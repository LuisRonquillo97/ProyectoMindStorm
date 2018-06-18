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
        int blink=0;
        public MainForm()
        {
            InitializeComponent();
        }
        void _thinkGearWrapper_ThinkGearChanged(object sender, ThinkGearChangedEventArgs e)
        {
            // update the textbox and sleep for a tiny bit
            BeginInvoke(new MethodInvoker(delegate
            {
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
                if (e.ThinkGearState.BlinkStrength > 200)
                {
                    PBEye.Image = ProyectoMindStorm.Properties.Resources.open_eye;
                }else
                {
                    PBEye.Image = ProyectoMindStorm.Properties.Resources.closed_eye;
                }
                if (e.ThinkGearState.Attention>=90 && e.ThinkGearState.Meditation<=70)
                {
                    lego.moverDerecha();
                }
                if(e.ThinkGearState.Attention <= 70 && e.ThinkGearState.Meditation >= 90)
                {
                    lego.moverIzquierda();
                }
                if (e.ThinkGearState.BlinkStrength > 150 && e.ThinkGearState.BlinkStrength!=blink)
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
                _thinkGearWrapper.ThinkGearChanged += _thinkGearWrapper_ThinkGearChanged;
                string comPortName = "\\\\.\\COM4";

                // connect to the device on the specified COM port at 57600 baud
                if (!_thinkGearWrapper.Connect(comPortName, 57600, true))
                {
                    MessageBox.Show("No se pudo conectar al neurosky.");
                }
                else
                {
                    _thinkGearWrapper.EnableBlinkDetection(true);
                }
            }
           
                
            
        }

        private void btnStopDemo_Click(object sender, EventArgs e)//método que para la demo, detiene el timer y desconecta al neurosky
        {
            _thinkGearWrapper.Disconnect();
            limpiarValores();
        }
        private void limpiarValores()//método que limpia los campos del formulario al parar la demo.
        {
            lblStatus.Text = "Desconectado";
            lblIntensity.Text = "N/A";
            lblConcentration.Text = "Valor concentración: N/A";
            lblRelaxation.Text = "Valor relajación: N/A";
            lblPacketsRead.Text = "Paquetes leídos: N/A";
        }

        private void simuladorToolStripMenuItem_Click(object sender, EventArgs e)//botón para el menú lego
        {
            LegoForm lego = new LegoForm();
            lego.Show();
        }
    }
}
