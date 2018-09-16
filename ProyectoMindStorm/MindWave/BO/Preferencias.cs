using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoMindStorm.MindWave.BO;

namespace ProyectoMindStorm.MindWave.BO
{
    class Preferencias
    {

        private Panel lienzo;

        public Preferencias()
        {

        }


        public void cambiarVentana(Form frm)
        {
            if (this.Lienzo.Controls.Count > 0)
                this.Lienzo.Controls.RemoveAt(0);
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.Lienzo.Controls.Add(frm);
            this.Lienzo.Tag = frm;
            frm.Show();
        }

        public Panel Lienzo
        {
            get { return lienzo; }
            set { lienzo = value; }
        }

    }
}
