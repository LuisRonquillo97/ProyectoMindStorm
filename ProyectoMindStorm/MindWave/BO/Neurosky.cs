using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMindStorm.MindWave.BO
{
    class Neurosky
    {
        NativeThinkgear thinkgear = new NativeThinkgear();
        string comPortName = "\\\\.\\COM4";
        int errCodeLog = 0;
        int errCodeDatalog= 0;
        int errCodeConectar= 0;
        int connectionID = 0;
        int paquetes = 0;
        public String GenerarNuevaConexion()
        {
            connectionID = NativeThinkgear.TG_GetNewConnectionId();
            //Establece conexión, si la conexión es correcta retorna un número positivo;
            if (connectionID < 0)
            {
                if (connectionID != 0)
                {
                    return "ERROR: ya hay una conexión actual con el neurosky, ciérrela e intente de nuevo.";
                }
                else
                {
                    return "ERROR: No se pudo crear una conexión correcta.\nID de conexión: " + connectionID;
                }

            }else
            {
                return "OK";
            }
            
        }
        public String Log()
        {
            errCodeLog = NativeThinkgear.TG_SetStreamLog(connectionID, "streamLog.txt");
            if (errCodeLog < 0)
            {
                return "ERROR:el método TG_SetStreamLog() regresó: " + errCodeLog.ToString();
            }else
            {
                return "OK";
            }
        }
        public String DataLog()
        {
            /* Set/open data (ThinkGear values) log file for connection */
            errCodeDatalog = NativeThinkgear.TG_SetDataLog(connectionID, "dataLog.txt");
            if (errCodeDatalog < 0)
            {
                return "ERROR: TG_SetDataLog() returned: " + errCodeDatalog.ToString();
                
            }else
            {
                return "OK";
            }
        }
        public String Conectar()
        {
            string generarconexion = GenerarNuevaConexion();
            string generarlog = Log();
            string generarDatalog = DataLog();
            if (generarconexion == "OK")
            {
                if (generarlog == "OK")
                {
                    if (generarDatalog == "OK")
                    {
                        errCodeConectar = NativeThinkgear.TG_Connect(connectionID,
                          comPortName,
                          NativeThinkgear.Baudrate.TG_BAUD_57600,
                          NativeThinkgear.SerialDataFormat.TG_STREAM_PACKETS);
                        if (errCodeConectar < 0)
                        {
                            return "ERROR: el método TG_Connect() retornó: " + errCodeConectar.ToString();
                        }
                        else
                        {
                            return "OK";
                        }
                    }
                    else
                    {
                        return generarDatalog;
                    }
                }else
                {
                    return generarlog;
                }
            }else
            {
                return generarconexion;
            }
            
        }
        public int LeerPaquetes()
        {
            paquetes= NativeThinkgear.TG_ReadPackets(connectionID, 1000);
            return paquetes;
        }
        public int ObtenerConcentración()
        {
            LeerPaquetes();
            
            /* si TG_ReadPackets() logro leer paquetes con datos*/
            if (paquetes > 1)
            {

                /* si el valor de concentración se ha actualizado mediante TG_ReadPackets() */
                if ((int)NativeThinkgear.TG_GetValueStatus(connectionID, NativeThinkgear.DataType.TG_DATA_ATTENTION) != 0)
                {
                    /* Validaciones de mínimo y máximo establecido, si es mayor a 100... */
                    if ((int)NativeThinkgear.TG_GetValue(connectionID, NativeThinkgear.DataType.TG_DATA_ATTENTION) > 100)
                    {
                        return 100;
                    }
                    else
                    {   //Si es menor a 0...
                        if ((int)NativeThinkgear.TG_GetValue(connectionID, NativeThinkgear.DataType.TG_DATA_ATTENTION) < 0)
                        {
                            return 0;
                        }
                        //si es un número menor a 100 pero mayor que 0, entonces manda el valor exacto obtenido del neurosky
                        else
                        {
                            return (int)NativeThinkgear.TG_GetValue(connectionID, NativeThinkgear.DataType.TG_DATA_ATTENTION);
                        }
                    }
                }
                else
                {
                    return (int)NativeThinkgear.TG_GetValue(connectionID, NativeThinkgear.DataType.TG_DATA_ATTENTION);
                }/* cierra el if de "si el valor de concentración se actualizó"... */

            }
            else
            {
                return (int)NativeThinkgear.TG_GetValue(connectionID, NativeThinkgear.DataType.TG_DATA_ATTENTION);
            } /* cierra el if de "si se ha leído un paquete"... */
        }
        public int ObtenerRelajación()
        {
            LeerPaquetes();

            /* si TG_ReadPackets() logro leer paquetes con datos*/
            if (paquetes > 1)
            {

                /* si el valor de concentración se ha actualizado mediante TG_ReadPackets() */
                if ((int)NativeThinkgear.TG_GetValueStatus(connectionID, NativeThinkgear.DataType.TG_DATA_MEDITATION) != 0)
                {
                    /* Validaciones de mínimo y máximo establecido, si es mayor a 100... */
                    if ((int)NativeThinkgear.TG_GetValue(connectionID, NativeThinkgear.DataType.TG_DATA_MEDITATION) > 100)
                    {
                        return 100;
                    }
                    else
                    {   //Si es menor a 0...
                        if ((int)NativeThinkgear.TG_GetValue(connectionID, NativeThinkgear.DataType.TG_DATA_MEDITATION) < 0)
                        {
                            return 0;
                        }
                        //si es un número menor a 100 pero mayor que 0, entonces manda el valor exacto obtenido del neurosky
                        else
                        {
                            return (int)NativeThinkgear.TG_GetValue(connectionID, NativeThinkgear.DataType.TG_DATA_MEDITATION);
                        }
                    }
                }
                else
                {
                    return (int)NativeThinkgear.TG_GetValue(connectionID, NativeThinkgear.DataType.TG_DATA_MEDITATION);
                }/* cierra el if de "si el valor de concentración se actualizó"... */

            }
            else
            {
                return (int)NativeThinkgear.TG_GetValue(connectionID, NativeThinkgear.DataType.TG_DATA_MEDITATION);
            } /* cierra el if de "si se ha leído un paquete"... */
        }
        public int ObtenerDelta()
        {
            LeerPaquetes();

            /* si TG_ReadPackets() logro leer paquetes con datos*/
            if (paquetes > 1)
            {

                /* si el valor de concentración se ha actualizado mediante TG_ReadPackets() */
                if ((int)NativeThinkgear.TG_GetValueStatus(connectionID, NativeThinkgear.DataType.TG_DATA_DELTA) != 0)
                {

                    return (int)NativeThinkgear.TG_GetValue(connectionID, NativeThinkgear.DataType.TG_DATA_DELTA);    
                }
                else
                {
                    return (int)NativeThinkgear.TG_GetValue(connectionID, NativeThinkgear.DataType.TG_DATA_DELTA);
                }/* cierra el if de "si el valor de concentración se actualizó"... */

            }
            else
            {
                return (int)NativeThinkgear.TG_GetValue(connectionID, NativeThinkgear.DataType.TG_DATA_DELTA);
            } /* cierra el if de "si se ha leído un paquete"... */
        }
        public int ObtenerTheta()
        {
            LeerPaquetes();

            /* si TG_ReadPackets() logro leer paquetes con datos*/
            if (paquetes > 1)
            {

                /* si el valor de concentración se ha actualizado mediante TG_ReadPackets() */
                if ((int)NativeThinkgear.TG_GetValueStatus(connectionID, NativeThinkgear.DataType.TG_DATA_THETA) != 0)
                {

                    return (int)NativeThinkgear.TG_GetValue(connectionID, NativeThinkgear.DataType.TG_DATA_THETA);
                }
                else
                {
                    return (int)NativeThinkgear.TG_GetValue(connectionID, NativeThinkgear.DataType.TG_DATA_THETA);
                }/* cierra el if de "si el valor de concentración se actualizó"... */

            }
            else
            {
                return (int)NativeThinkgear.TG_GetValue(connectionID, NativeThinkgear.DataType.TG_DATA_THETA);
            } /* cierra el if de "si se ha leído un paquete"... */
        }
        public int ObtenerAlfaBaja()
        {
            LeerPaquetes();

            /* si TG_ReadPackets() logro leer paquetes con datos*/
            if (paquetes > 1)
            {
                return (int)NativeThinkgear.TG_GetValue(connectionID, NativeThinkgear.DataType.TG_DATA_ALPHA1);
            }
            else
            {
                return (int)NativeThinkgear.TG_GetValue(connectionID, NativeThinkgear.DataType.TG_DATA_ALPHA1);
            } /* cierra el if de "si se ha leído un paquete"... */
        }
        public int ObtenerAlfaAlta()
        {
            LeerPaquetes();

            /* si TG_ReadPackets() logro leer paquetes con datos*/
            if (paquetes > 1)
            {
                return (int)NativeThinkgear.TG_GetValue(connectionID, NativeThinkgear.DataType.TG_DATA_ALPHA2);
            }
            else
            {
                return (int)NativeThinkgear.TG_GetValue(connectionID, NativeThinkgear.DataType.TG_DATA_ALPHA2);
            } /* cierra el if de "si se ha leído un paquete"... */
        }
        public int ObtenerBetaBaja()
        {
            LeerPaquetes();

            /* si TG_ReadPackets() logro leer paquetes con datos*/
            if (paquetes > 1)
            {
                return (int)NativeThinkgear.TG_GetValue(connectionID, NativeThinkgear.DataType.TG_DATA_BETA1);
            }
            else
            {
                return (int)NativeThinkgear.TG_GetValue(connectionID, NativeThinkgear.DataType.TG_DATA_BETA1);
            } /* cierra el if de "si se ha leído un paquete"... */
        }
        public int ObtenerBetaAlta()
        {
            LeerPaquetes();

            /* si TG_ReadPackets() logro leer paquetes con datos*/
            if (paquetes > 1)
            {
                return (int)NativeThinkgear.TG_GetValue(connectionID, NativeThinkgear.DataType.TG_DATA_BETA2);
            }
            else
            {
                return (int)NativeThinkgear.TG_GetValue(connectionID, NativeThinkgear.DataType.TG_DATA_BETA2);
            } /* cierra el if de "si se ha leído un paquete"... */
        }
        public int ObtenergGammaBaja()
        {
            LeerPaquetes();

            /* si TG_ReadPackets() logro leer paquetes con datos*/
            if (paquetes > 1)
            {
                return (int)NativeThinkgear.TG_GetValue(connectionID, NativeThinkgear.DataType.TG_DATA_GAMMA1);
            }
            else
            {
                return (int)NativeThinkgear.TG_GetValue(connectionID, NativeThinkgear.DataType.TG_DATA_GAMMA1);
            } /* cierra el if de "si se ha leído un paquete"... */
        }
        public int ObtenerGammaAlta()
        {
            LeerPaquetes();

            /* si TG_ReadPackets() logro leer paquetes con datos*/
            if (paquetes > 1)
            {
                return (int)NativeThinkgear.TG_GetValue(connectionID, NativeThinkgear.DataType.TG_DATA_GAMMA2);
            }
            else
            {
                return (int)NativeThinkgear.TG_GetValue(connectionID, NativeThinkgear.DataType.TG_DATA_GAMMA2);
            } /* cierra el if de "si se ha leído un paquete"... */
        }
        public int ObtenerIntensidad()
        {
            LeerPaquetes();

            /* si TG_ReadPackets() logro leer paquetes con datos*/
            if (paquetes > 1)
            {
                return (int)NativeThinkgear.TG_GetValue(connectionID, NativeThinkgear.DataType.TG_DATA_RAW);
            }
            else
            {
                return (int)NativeThinkgear.TG_GetValue(connectionID, NativeThinkgear.DataType.TG_DATA_RAW);
            } /* cierra el if de "si se ha leído un paquete"... */
        }
        public String Desconectar()
        {
            /* Libera la conexión */
            NativeThinkgear.TG_FreeConnection(connectionID);
            return "el programa se ha desconectado del neurosky mindwave.";
        }
    }

}
