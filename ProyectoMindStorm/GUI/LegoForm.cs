using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LegoEv3Clases.UsbConexion;
using LegoEv3Clases.Core;

namespace ProyectoMindStorm.GUI
{
    public partial class LegoForm : Form
    {
        public Brick _brick;
        public ColorSensorColor sensorcolor;
        int contador = 0;
        public LegoForm()
        {
            InitializeComponent();
            btnAbajo.Visible = false;
            btnArriba.Visible = false;
            btnIzquierda.Visible = false;
            btnDerecha.Visible = false;
            btnGarra.Visible = false;
            btnDesconectar.Visible = false;
            btnConectar.Visible = true;

        }
        public void Conexion()
        {
            _brick = new Brick(new UsbCommunication());
            //_brick = new Brick(new BluetoothCommunication("COM5"));
            //_brick = new Brick(new NetworkCommunication("192.168.2.237"));
            _brick.BrickChanged += _brick_BrickChanged;

            _brick.ConnectAsync();
            if (_brick.ConnectAsync() != null)
            {
                MessageBox.Show("La conexión fue exitosa");
                btnAbajo.Visible = true;
                btnArriba.Visible = true;
                btnIzquierda.Visible = true;
                btnDerecha.Visible = true;
                btnGarra.Visible = true;
                btnConectar.Visible = false;
                btnDesconectar.Visible = true;
            }
            else
            {
                MessageBox.Show("Verificar conexión");
            }
        }

        public void _brick_BrickChanged(object sender, BrickChangedEventArgs e)
        {
           
        }

        private void btnArriba_Click(object sender, EventArgs e)
        {
            _brick.DirectCommand.StepMotorAtPowerAsync(OutputPort.B, -35, 800, true);
            
            
        }

        private void LegoForm_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Conexion();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAbajo_Click(object sender, EventArgs e)
        {
            _brick.DirectCommand.StepMotorAtPowerAsync(OutputPort.B, 35, 800, true);
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            _brick.DirectCommand.TurnMotorAtPowerForTimeAsync(OutputPort.C, 50, 1500, true);
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            _brick.DirectCommand.TurnMotorAtPowerForTimeAsync(OutputPort.C, -50, 1500, true);
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
    }
}
