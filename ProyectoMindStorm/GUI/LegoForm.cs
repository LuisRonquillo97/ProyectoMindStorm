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
        public LegoForm()
        {
            InitializeComponent();
        }

        public async Task Test()
        {
            _brick = new Brick(new UsbCommunication());
            //_brick = new Brick(new BluetoothCommunication("COM5"));
            //_brick = new Brick(new NetworkCommunication("192.168.2.237"));

            _brick.BrickChanged += _brick_BrickChanged;


            MessageBox.Show("Conectando");
            await _brick.ConnectAsync();

            MessageBox.Show("conectando con el motor");
            await _brick.DirectCommand.TurnMotorAtSpeedForTimeAsync(OutputPort.B, -30, 1000, false);
        }

        public void _brick_BrickChanged(object sender, BrickChangedEventArgs e)
        {
            MessageBox.Show(""+ e.Ports[InputPort.B].SIValue);
        }

        private void btnArriba_Click(object sender, EventArgs e)
        {
            Task t = Test();
            t.Wait();
            
        }

        private void LegoForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
