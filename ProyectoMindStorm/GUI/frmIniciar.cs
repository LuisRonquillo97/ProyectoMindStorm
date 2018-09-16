using System;
using System.Windows.Forms;
using ThinkGearNET;
using System.Threading;
using ZedGraph;
using System.Drawing;

namespace ProyectoMindStorm.GUI
{
    public partial class frmIniciar : Form
    {
        //private Movimientos lego = new Movimientos();
        private ThinkGearWrapper _thinkGearWrapper = new ThinkGearWrapper();
        public PointPairList list = new PointPairList();
        public PointPairList list2 = new PointPairList();
        public bool abrir = false;
        int blink = 0, lastConcentracion = 0, lastMeditacion = 0, tiempo = 0;
        bool meditacion = false, concentracion = false, lanzado = false, lanzado2 = false, calibrado = false;


        int AVGmeditacion = 0, AVGConcentracion = 0, iteracionM = 0, iteracionC = 0;
        int[] meditacionArray = new int[10], concentracionArray = new int[10];

        public frmIniciar()
        {
            InitializeComponent();
        }

        private void frmIniciar_Load(object sender, EventArgs e)
        {
            CreateGraph(zg1);
        }
        private void CreateGraph(ZedGraphControl zgc)
        {
            GraphPane myPane = zgc.GraphPane;
            // Set the titles and axis labels
            myPane.Title.Text = "Concentración y relajación";
            myPane.XAxis.Title.Text = "Tiempo";
            myPane.YAxis.Title.Text = "Intensidad";

            // Make up some data points from the Sine function
            
            

            // Generate a blue curve with circle symbols, and "My Curve 2" in the legend
            LineItem myCurve = myPane.AddCurve("Concentración", list, Color.Red,
                                    SymbolType.Circle);
            LineItem myCurve2 = myPane.AddCurve("Meditación", list2, Color.Blue,
                                    SymbolType.Square);
            // Fill the area under the curve with a white-red gradient at 45 degrees

            // Make the symbols opaque by filling them with white
            myCurve.Symbol.Fill = new Fill(Color.White);

            // Fill the axis background with a color gradient
            myPane.Chart.Fill = new Fill(Color.White, Color.LightGoldenrodYellow, 45F);

            // Fill the pane background with a color gradient
            myPane.Fill = new Fill(Color.White, Color.FromArgb(220, 220, 255), 45F);

            // Calculate the Axis Scale Ranges
            zgc.AxisChange();
        }
        private void UpdateGraph(ZedGraphControl zgc, float attention, float meditation)
        {
            double y = Convert.ToDouble(attention);
            list.Add(tiempo, y);

            double y2 = Convert.ToDouble(meditation);
            list2.Add(tiempo, y2);
            
            if (tiempo % 10 == 0)
            {
                zgc.AxisChange();
                zgc.Invalidate();
                if (tiempo > 3000)
                {
                    tiempo = 0;
                    list.Clear();
                    list2.Clear();
                }
            }
            tiempo++;
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            _thinkGearWrapper = new ThinkGearWrapper();
            //if (lego.establecerConexion() == "La conexión fue exitosa")
            //{
                // setup the event
                string comPortName = "\\\\.\\COM3";

                //connect to the device on the specified COM port at 57600 baud
                if (!_thinkGearWrapper.Connect(comPortName, 57600, true))
                {
                    MessageBox.Show("No se pudo conectar al neurosky.");
                }
                else
                {
                    _thinkGearWrapper.ThinkGearChanged += _thinkGearWrapper_ThinkGearChanged;
                    _thinkGearWrapper.EnableBlinkDetection(true);
                    lblStatus.Text = "Conectado";
                }
            //}
        }

        private void btndetener_Click(object sender, EventArgs e)
        {
            _thinkGearWrapper.Disconnect();
            limpiarValores();
        }

        private void limpiarValores()//método que limpia los campos del formulario al parar la demo.
        {
            tiempo = 0;
            list.Clear();
            list2.Clear();
            lblStatus.Text = "Desconectado";
            lblIntensity.Text = "N/A";
            lblConcentration.Text = "Valor concentración: N/A";
            lblRelaxation.Text = "Valor relajación: N/A";
            lblPacketsRead.Text = "Paquetes leídos: N/A";
            lblDeltaValue.Text = "Value";
            lblThetaValue.Text = "Value";
            lblLowAlphaValue.Text = "Value";
            lblHighAlphaValue.Text = "Value";
            lblLowBetaValue.Text = "Value";
            lblHighBetaValue.Text = "Value";
            lblLowGammaValue.Text = "Value";
            lblHighGammaValue.Text = "Value";
            lblIntensity.Text = "Value";
            lblBlink.Text = "Valor parpadeo: N/A";
            iteracionM = 0;
            iteracionC = 0;
            for (int i = 0; i < 9; i++)
            {
                concentracionArray[i] = 0;
                meditacionArray[i] = 0;
                AVGConcentracion = 0;
                AVGmeditacion = 0;
            }

        }

        void _thinkGearWrapper_ThinkGearChanged(object sender, ThinkGearChangedEventArgs e)
        {
            // update the textbox and sleep for a tiny bit
            BeginInvoke(new MethodInvoker(delegate
            {
                if (meditacion)
                {

                    if (iteracionM <= meditacionArray.Length - 1)
                    {
                        if (e.ThinkGearState.Meditation != lastMeditacion)
                        {
                            lastMeditacion = Convert.ToInt32(e.ThinkGearState.Meditation);
                            meditacionArray[iteracionM] = Convert.ToInt32(e.ThinkGearState.Meditation);
                            iteracionM++;
                        }
                    }
                    else
                    {
                        meditacion = false;
                        int suma = 0;
                        for (int l = 0; l < meditacionArray.Length - 1; l++)
                        {
                            suma = suma + meditacionArray[l];
                        }
                        AVGmeditacion = suma / meditacionArray.Length;
                        lblAVGmeditacion.Text = "promedio meditación:" + AVGmeditacion.ToString();
                        if (!lanzado)
                        {
                            lanzado = true;
                            var fase2 = MessageBox.Show("Se tomarán tus valores de concentración, para comenzar pulse OK.", "Calibración fase 2", MessageBoxButtons.OK);
                            if (fase2 == DialogResult.OK)
                            {
                                concentracion = true;
                            }
                        }
                    }

                }
                if (concentracion)
                {
                    if (iteracionC <= concentracionArray.Length - 1)
                    {
                        if (e.ThinkGearState.Attention != lastConcentracion)
                        {
                            lastConcentracion = Convert.ToInt32(e.ThinkGearState.Attention);
                            concentracionArray[iteracionC] = Convert.ToInt32(e.ThinkGearState.Attention);
                            iteracionC++;
                        }

                    }
                    else
                    {
                        concentracion = false;
                        int suma = 0;
                        for (int k = 0; k < concentracionArray.Length - 1; k++)
                        {
                            suma = suma + concentracionArray[k];
                        }
                        AVGConcentracion = suma / concentracionArray.Length;
                        lblAVGmeditacion.Text = "promedio meditación:" + AVGmeditacion.ToString();
                        if (!lanzado2)
                        {
                            lanzado2 = true;
                            var fase2 = MessageBox.Show("Calibración completa", "Tu calibración se ha completado", MessageBoxButtons.OK);
                            calibrado = true;
                        }
                        lblAVGConcentracion.Text = "promedio concentracion:" + AVGConcentracion.ToString();
                    }
                }
                PBConcentration.Value = Convert.ToInt32(e.ThinkGearState.Attention);
                PBRelaxation.Value = Convert.ToInt32(e.ThinkGearState.Meditation);
                lblConcentration.Text = "Valor concentración: " + e.ThinkGearState.Attention.ToString();
                lblRelaxation.Text = "Valor meditación: " + e.ThinkGearState.Meditation.ToString();
                lblPacketsRead.Text = "Paquetes leídos: " + e.ThinkGearState.PacketsRead.ToString();
                lblDeltaValue.Text = e.ThinkGearState.Delta.ToString();
                lblThetaValue.Text = e.ThinkGearState.Theta.ToString();
                lblLowAlphaValue.Text = e.ThinkGearState.Alpha1.ToString();
                lblHighAlphaValue.Text = e.ThinkGearState.Alpha2.ToString();
                lblLowBetaValue.Text = e.ThinkGearState.Beta1.ToString();
                lblHighBetaValue.Text = e.ThinkGearState.Beta2.ToString();
                lblLowGammaValue.Text = e.ThinkGearState.Gamma1.ToString();
                lblHighGammaValue.Text = e.ThinkGearState.Gamma2.ToString();
                lblIntensity.Text = e.ThinkGearState.Raw.ToString();
                lblBlink.Text = "Valor parpadeo: " + e.ThinkGearState.BlinkStrength.ToString();
                UpdateGraph(zg1, e.ThinkGearState.Attention, e.ThinkGearState.Meditation);
                if (e.ThinkGearState.Meditation != 0)
                {
                    //btnCalibrar.Visible = true;
                }
                if (e.ThinkGearState.BlinkStrength > 120)
                {
                    //PBEye.Image = Properties.Resources.open_eye;
                }
                else
                {
                    //PBEye.Image = Properties.Resources.closed_eye;
                }
                if (e.ThinkGearState.Attention >= AVGConcentracion && e.ThinkGearState.Meditation >= AVGmeditacion && calibrado)
                {

                }
                else
                {
                    /*if (e.ThinkGearState.Attention >= AVGConcentracion && calibrado)
                    {
                        lego.moverDerecha();
                    }
                    if (e.ThinkGearState.Meditation >= AVGmeditacion && calibrado)
                    {
                        lego.moverIzquierda();
                    }*/
                }
                if (e.ThinkGearState.BlinkStrength > 120 && e.ThinkGearState.BlinkStrength != blink)
                {
                    /*blink = Convert.ToInt32(e.ThinkGearState.BlinkStrength);
                    lego.abrirPinza();*/
                }
                else
                {
                    blink = Convert.ToInt32(e.ThinkGearState.BlinkStrength);
                }
            }));
            Thread.Sleep(10);
        }
    }
}
