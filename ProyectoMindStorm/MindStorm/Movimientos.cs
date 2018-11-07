using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LegoEv3Clases.UsbConexion; //Clase para la conexion USB
using LegoEv3Clases.Core; //Nucleo de la libreria

namespace ProyectoMindStorm.MindStorm
{
    class Movimientos
    {
        //Intancia del Brick lego
        int angulo = 0;
        public Brick _brick;
        public ColorSensorColor sensorcolor;

        //Variables para la garra
        bool contador = false;
        double mitad = 2;

        public Movimientos() {

        }

        //metodo para establecer la conexion con el lego
        public String establecerConexion() {
            _brick = new Brick(new UsbCommunication());
            //_brick = new Brick(new BluetoothCommunication("COM5"));
            //_brick = new Brick(new NetworkCommunication("192.168.2.237"));
            //_brick.BrickChanged += _brick_BrickChanged;
            if (_brick.ConnectAsync() != null){
                return "La conexión fue exitosa";
            }
            else{
               return "Verificar conexión";
            }
        }

        public void cerrarConexion() {
            _brick.Disconnect();
        }

        public void moverArriba() {
            _brick.DirectCommand.StepMotorAtPowerAsync(OutputPort.B, -20, 100, true);
        }

        public void moverAbajo(){
            _brick.DirectCommand.StepMotorAtPowerAsync(OutputPort.B, 10, 100, true);
        }

        public void moverIzquierda(){
            _brick.DirectCommand.TurnMotorAtPowerForTimeAsync(OutputPort.C, 10, 150, true);
            
        }

        public void moverDerecha(){
            _brick.DirectCommand.TurnMotorAtPowerForTimeAsync(OutputPort.C, -10, 150, true);
        }

        public void abrirPinza() {

            switch (contador)
            {
                case false:
                    _brick.DirectCommand.StepMotorAtPowerAsync(OutputPort.A, 80, 50, true);

                    break;
                case true:
                    _brick.DirectCommand.StepMotorAtPowerAsync(OutputPort.A, -55, 45, true);
                    break;
            }
            revertir();

        }

        public void revertir(){

            double valor = 0;
            valor = mitad % 2;
            if (valor == 0){
                contador = true;
                mitad++;
            }
            else{
                contador = false;
                mitad++;
            }

        }
    }
}
