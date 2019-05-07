using System;
using System.Threading;
using System.Windows.Forms;
using ThinkGearNET;
using ProyectoMindStorm.MindStorm;
namespace ProyectoMindStorm.GUI
{
    public partial class MainForm : Form
    {
        private Movimientos lego = new Movimientos();
        private ThinkGearWrapper _thinkGearWrapper = new ThinkGearWrapper();
        public bool abrir = false;
        int blink=0, lastConcentracion=0,lastMeditacion=0;
        bool meditacion = false, concentracion = false, lanzado = false, lanzado2 = false,calibrado=false;
        int AVGmeditacion=0, AVGConcentracion=0,iteracionM=0,iteracionC=0;
        int[] meditacionArray=new int[10], concentracionArray=new int[10];
        public MainForm()
        {
            InitializeComponent();
        }
        void _thinkGearWrapper_ThinkGearChanged(object sender, ThinkGearChangedEventArgs e)
        {
            // update the textbox and sleep for a tiny bit
            BeginInvoke(new MethodInvoker(delegate
            {
                if (meditacion)
                {
                    
                    if (iteracionM <= meditacionArray.Length-1)
                    {
                        if(e.ThinkGearState.Meditation != lastMeditacion)
                        {
                            lastMeditacion = Convert.ToInt32(e.ThinkGearState.Meditation);
                            meditacionArray[iteracionM] = Convert.ToInt32(e.ThinkGearState.Meditation);
                            iteracionM++;
                        }
                    }else
                    {
                        meditacion = false;
                        int suma = 0;
                        for(int l=0; l < meditacionArray.Length-1; l++)
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
                    if (iteracionC <= concentracionArray.Length-1 )
                    {
                        if(e.ThinkGearState.Attention != lastConcentracion)
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
                        for (int k = 0; k < concentracionArray.Length-1; k++)
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
                lblConcentration.Text = "Valor concentración: " + e.ThinkGearState.Attention;
                lblRelaxation.Text = "Valor meditación: " + e.ThinkGearState.Meditation;
                lblPacketsRead.Text = "Paquetes leídos: " + e.ThinkGearState.PacketsRead;
                PBConcentration.Value = Convert.ToInt32(e.ThinkGearState.Attention);
                lblConcentration.Text = "Valor concentración: " + e.ThinkGearState.Attention;
                PBRelaxation.Value = Convert.ToInt32(e.ThinkGearState.Meditation);
                lblRelaxation.Text = "Valor relajación: " + e.ThinkGearState.Meditation;
                lblDeltaValue.Text = e.ThinkGearState.Delta.ToString();
                lblThetaValue.Text = e.ThinkGearState.Theta.ToString();
                lblLowAlphaValue.Text = e.ThinkGearState.Alpha1.ToString();
                lblHighAlphaValue.Text = e.ThinkGearState.Alpha2.ToString();
                lblLowBetaValue.Text = e.ThinkGearState.Beta1.ToString();
                lblHighBetaValue.Text = e.ThinkGearState.Beta2.ToString();
                lblLowGammaValue.Text = e.ThinkGearState.Gamma1.ToString();
                lblHighGammaValue.Text = e.ThinkGearState.Gamma2.ToString();
                lblIntensity.Text = e.ThinkGearState.Raw.ToString();
                lblBlink.Text = "Valor parpadeo: "+ e.ThinkGearState.BlinkStrength.ToString();
                if (e.ThinkGearState.Meditation != 0)
                {
                    btnCalibrar.Visible = true;
                }
                if (e.ThinkGearState.BlinkStrength > 120)
                {
                    PBEye.Image = ProyectoMindStorm.Properties.Resources.open_eye;
                }else
                {
                    PBEye.Image = ProyectoMindStorm.Properties.Resources.closed_eye;
                }
                if(e.ThinkGearState.Attention>=AVGConcentracion && e.ThinkGearState.Meditation >= AVGmeditacion && calibrado)
                {

                }else
                {
                    if (e.ThinkGearState.Attention >= AVGConcentracion && calibrado)
                    {
                        lego.moverDerecha();
                    }
                    if (e.ThinkGearState.Meditation >=AVGmeditacion && calibrado)
                    {
                        lego.moverIzquierda();
                    }
                }
                if (e.ThinkGearState.BlinkStrength > 120 && e.ThinkGearState.BlinkStrength!=blink )
                {
                    blink = Convert.ToInt32(e.ThinkGearState.BlinkStrength);
                    lego.abrirPinza();
                }else
                {
                    blink = Convert.ToInt32(e.ThinkGearState.BlinkStrength);
                }
            }));
            Thread.Sleep(10);
        }

        private void btnStartDemo_Click(object sender, EventArgs e)//acción al pulsar el botón de iniciar demo
        {
            _thinkGearWrapper = new ThinkGearWrapper();
            if (lego.establecerConexion()== "La conexión fue exitosa")
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
                }
            }
        }

        private void btnCalibrar_Click(object sender, EventArgs e)
        {
            iteracionM = 0;
            iteracionC = 0;
            meditacion = false;
            concentracion = false;
            calibrado = false;
            lanzado = false;
            lanzado2 = false;
            AVGConcentracion = 0;
            AVGmeditacion = 0;
            var fase1=MessageBox.Show("Se tomarán tus valores de meditación, para comenzar pulse OK.", "Calibración fase 1", MessageBoxButtons.OK);
            if (fase1 == DialogResult.OK)
            {
                meditacion = true;
            }
        }

        private void btnStopDemo_Click(object sender, EventArgs e)//método que para la demo, detiene el timer y desconecta al neurosky
        {
            _thinkGearWrapper.Disconnect();
            limpiarValores();
            //lego.cerrarConexion();
        }
        private void limpiarValores()//método que limpia los campos del formulario al parar la demo.
        {
            lblStatus.Text = "Desconectado";
            lblIntensity.Text = "N/A";
            lblConcentration.Text = "Valor concentración: N/A";
            lblRelaxation.Text = "Valor relajación: N/A";
            lblPacketsRead.Text = "Paquetes leídos: N/A";
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

        private void simuladorToolStripMenuItem_Click(object sender, EventArgs e)//botón para el menú lego
        {
            LegoForm lego = new LegoForm();
            lego.Show();
        }
    }
}
