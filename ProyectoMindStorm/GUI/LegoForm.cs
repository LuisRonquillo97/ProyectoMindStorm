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

            //_brick.BrickChanged += _brick_BrickChanged;

            await _brick.ConnectAsync();
           
            await _brick.DirectCommand.TurnMotorAtSpeedForTimeAsync(OutputPort.B, 50, 100, false);

            await _brick.DirectCommand.PlayToneAsync(0x50, 100, 1000);

            System.Console.WriteLine("Beeped...done!");
        }
        private void btnArriba_Click(object sender, EventArgs e)
        {

        }
    }
}
