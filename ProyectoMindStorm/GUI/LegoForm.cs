using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoMindStorm.MindStorm;


namespace ProyectoMindStorm.GUI
{
    public partial class LegoForm : Form
    {

        Movimientos oMovimientos = new Movimientos();
        public LegoForm()
        {
            InitializeComponent();
            oMovimientos.establecerConexion();
            
        }

        private void btnArriba_Click(object sender, EventArgs e)
        {
            oMovimientos.moverArriba();
        }

        private void LegoForm_Load(object sender, EventArgs e)
        {
            
           
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            oMovimientos.establecerConexion();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAbajo_Click(object sender, EventArgs e)
        {

            oMovimientos.moverAbajo();
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            oMovimientos.moverIzquierda();
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            oMovimientos.moverDerecha();

        }

        private void LegoForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void LegoForm_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyValue == Convert.ToChar('\r'))
            //{
            //    //Codigo a ejecutar cuando se pulsa enter
            //    MessageBox.Show("ARRIBA");
            //}
            //else if (e.KeyValue == (char)Keys.Down)
            //{
            //    //Codigo a ejecutar cuando se pulsa Escape
            //    MessageBox.Show("ABAJO");
            //}
            //else if (e.KeyValue == (char)Keys.Left)
            //{
            //    //Codigo a ejecutar cuando se pulsa F1
            //    MessageBox.Show("Izquiera");
            //}
            //else if (e.KeyValue == (char)Keys.Right)
            //{
            //    //Codigo a ejecutar cuando se pulsa Suprimir
            //    MessageBox.Show("derecha");
            //}
        }

        private void LegoForm_KeyUp(object sender, KeyEventArgs e)
        {
            /*switch (e.KeyValue)
            {
               case (char)Keys.Up:
                    //_brick.DirectCommand.StepMotorAtPowerAsync(OutputPort.B, -35, 800, true);
                    MessageBox.Show("arriba");
                    break;
                case (char)Keys.Down:
                    _brick.DirectCommand.StepMotorAtPowerAsync(OutputPort.B, 35, 800, true);
                    break;
                case (char)Keys.Left:
                    _brick.DirectCommand.TurnMotorAtPowerForTimeAsync(OutputPort.C, 50, 1500, true);
                    break;
                case (char)Keys.Right:
                    _brick.DirectCommand.TurnMotorAtPowerForTimeAsync(OutputPort.C, -50, 1500, true);
                    break;*/
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            
        }
 
        private void btnGarra_Click(object sender, EventArgs e)
        {
            oMovimientos.abrirPinza();
        }
    }
}
