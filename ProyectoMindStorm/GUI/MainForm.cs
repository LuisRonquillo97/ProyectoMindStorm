using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoMindStorm.MindWave.BO;

namespace ProyectoMindStorm.GUI
{
    public partial class MainForm : Form
    {
        Timer t = new Timer(); //inicializamos un timer
        Neurosky Nsky = new Neurosky(); //llamamos a los métodos del neurosky
        public MainForm()
        {
            InitializeComponent();
            lblVersion.Text = NativeThinkgear.TG_GetVersion().ToString();//muestra la versión del driver
            t.Interval = 100; // especifica el tiempo en milisegundos para el timer
            t.Tick += new EventHandler(timer_Tick); //establece el método del timer
        }

        private void btnStartDemo_Click(object sender, EventArgs e)//acción al pulsar el botón de iniciar demo
        {
            string conexion = Nsky.Conectar();//llamado al método de conexión del neurosky, recibimos el string que devuelve el método, debe devolver "OK"
            if (conexion == "OK")//si se realiza una conexión correctamente al neurosky...
            {
                lblStatus.Text = "Conectado";
                t.Start();//arrancamos el método del timer, aquí se llamarán a todas las lecturas del neurosky
            }
            else
            {
                //si ocurrió algún error, el método conectar devuelve el error, entonces, lo imprimimos con un MessageBox
                MessageBox.Show(conexion);
            }
        }
        void timer_Tick(object sender, EventArgs e)//método dónde se llaman las lecturas del neurosky
        {
            //Obtener datos de los métodos de neurosky
            int concentración = Nsky.ObtenerConcentración();
            int relajación = Nsky.ObtenerRelajación();
            int Delta = Nsky.ObtenerDelta();
            int theta = Nsky.ObtenerTheta();
            int alfaBaja = Nsky.ObtenerAlfaBaja();
            int alfaAlta = Nsky.ObtenerAlfaAlta();
            int betaBaja = Nsky.ObtenerBetaBaja();
            int betaAlta = Nsky.ObtenerBetaAlta();
            int gammaBaja = Nsky.ObtenergGammaBaja();
            int gammaAlta = Nsky.ObtenerGammaAlta();
            int raw = Nsky.ObtenerIntensidad();
            //Asigación de los valores obtenidos a los componentes del form
            lblPacketsRead.Text = "Paquetes leídos: " + Nsky.LeerPaquetes().ToString();
            PBConcentration.Value = concentración;
            lblConcentration.Text = "Valor concentración: " + concentración.ToString();
            PBRelaxation.Value = relajación;
            lblRelaxation.Text = "Valor relajación: " + relajación.ToString();
            lblDeltaValue.Text = Delta.ToString();
            lblThetaValue.Text = theta.ToString();
            lblLowAlphaValue.Text = alfaBaja.ToString();
            lblHighAlphaValue.Text = alfaAlta.ToString();
            lblLowBetaValue.Text = betaBaja.ToString();
            lblHighBetaValue.Text = betaAlta.ToString();
            lblLowGammaValue.Text = gammaBaja.ToString();
            lblHighGammaValue.Text = gammaAlta.ToString();
            lblIntensity.Text = raw.ToString();
        }

        private void btnStopDemo_Click(object sender, EventArgs e)//método que para la demo, detiene el timer y desconecta al neurosky
        {
            t.Stop();
            Nsky.Desconectar();
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
