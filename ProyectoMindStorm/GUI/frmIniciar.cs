using System;
using System.Windows.Forms;
using ThinkGearNET;
using System.Threading;
using ZedGraph;
using System.Drawing;
using ProyectoMindStorm.MindStorm;
using System.Linq;

namespace ProyectoMindStorm.GUI
{
    public partial class frmIniciar : Form
    {
        private Movimientos lego = new Movimientos();
        private ThinkGearWrapper _thinkGearWrapper = new ThinkGearWrapper();
        public PointPairList list = new PointPairList();
        public PointPairList list2 = new PointPairList();
        public bool abrir = false, legoUse=false;
        int blink = 0, tiempo = 0, modo=-1, AVGconcentracion = 70;
        int sum = 0, divisible=0;

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
            if (attention > 0)
            {
                divisible++;
                sum = sum + Convert.ToInt32(attention);
                AVGconcentracion = sum / divisible;
            }
            
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            _thinkGearWrapper = new ThinkGearWrapper();
            if (lego.establecerConexion() == "La conexión fue exitosa")
            {
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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (legoUse)
            {
                legoUse = false;
                lblActivacionLego.Text = "Lego desactivado";
            }
            else
            {
                legoUse = true;
                lblActivacionLego.Text = "Lego activado";
            }
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
            lblAVGConcentracion.Text = "Promedio concentración: ";

        }

        void _thinkGearWrapper_ThinkGearChanged(object sender, ThinkGearChangedEventArgs e)
        {
            // update the textbox and sleep for a tiny bit
            BeginInvoke(new MethodInvoker(delegate
            {
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
                lblAVGConcentracion.Text = "Promedio concentración: " + AVGconcentracion;
                UpdateGraph(zg1, e.ThinkGearState.Attention, e.ThinkGearState.Meditation);
                
                if (e.ThinkGearState.BlinkStrength > 120 && e.ThinkGearState.BlinkStrength != blink)
                {
                    blink = Convert.ToInt32(e.ThinkGearState.BlinkStrength);
                    if (modo == 3)
                    {
                        modo = 0;
                    }
                    else
                    {
                        modo++;
                    }
                }
                else
                {
                    if(e.ThinkGearState.BlinkStrength != blink)
                    {
                        if (legoUse)
                        {
                            lego.abrirPinza();
                        }
                    }
                    blink = Convert.ToInt32(e.ThinkGearState.BlinkStrength);
                    
                    
                }
                if (e.ThinkGearState.Attention >= 70 && e.ThinkGearState.Meditation >= 70)
                {

                }
                else
                {
                    
                }
                switch (modo)
                {
                    case 0:
                        lblMode.Text = "Mover derecha";
                        if (e.ThinkGearState.Attention >= 70)
                        {
                            if (legoUse)
                            {
                                lego.moverDerecha();
                            }
                            
                        }
                        break;
                    case 1:
                        lblMode.Text = "Mover izquierda";
                        if (e.ThinkGearState.Attention >= AVGconcentracion)
                        {
                            if (legoUse)
                            {
                                lego.moverIzquierda();
                            }
                            
                        }
                        break;
                    case 2:
                        lblMode.Text = "Mover arriba";
                        if (e.ThinkGearState.Attention >= AVGconcentracion)
                        {
                            if (legoUse)
                            {
                                lego.moverArriba();
                            }
                            
                        }
                        break;
                    case 3:
                        lblMode.Text = "Mover abajo";
                        if (e.ThinkGearState.Attention >= AVGconcentracion)
                        {
                            if (legoUse)
                            {
                                lego.moverAbajo();
                            }
                            
                        }
                        break;
                }
            }));
            Thread.Sleep(10);
        }
    }
}
