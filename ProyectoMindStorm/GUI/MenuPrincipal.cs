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
using System.Runtime.InteropServices;
using ThinkGearNET;

namespace ProyectoMindStorm.GUI
{
    public partial class MenuPrincipal : Form
    {
        Preferencias oPreferencias;
        private ThinkGearWrapper _thinkGearWrapper = new ThinkGearWrapper();

        public MenuPrincipal()
        {
            InitializeComponent();
            oPreferencias = new Preferencias();
            oPreferencias.Lienzo = content;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void bIniciar_Click(object sender, EventArgs e)
        {
            picbarraIniciar.Visible = true;
            picbarraPerfil.Visible = false;
            frmIniciar frm = new frmIniciar();
            oPreferencias.cambiarVentana(frm);
        }

        private void bConfig_Click(object sender, EventArgs e)
        {
            picbarraIniciar.Visible = false;
            frmConfig frm = new frmConfig();
            oPreferencias.cambiarVentana(frm);
        }

        private void bPerfil_Click(object sender, EventArgs e)
        {
            picbarraIniciar.Visible = false;
            frmPerfil frm = new frmPerfil();
            oPreferencias.cambiarVentana(frm);
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void MenuPrincipal_Load_1(object sender, EventArgs e)
        {
            frmBienvenida frm = new frmBienvenida();
            oPreferencias.cambiarVentana(frm);
        }

        private void bPerfil_Click_1(object sender, EventArgs e)
        {
            _thinkGearWrapper.Disconnect();
            picbarraIniciar.Visible = false;
            picbarraPerfil.Visible = true;
            frmPerfil frm = new frmPerfil();
            oPreferencias.cambiarVentana(frm);
        }
    }

}
