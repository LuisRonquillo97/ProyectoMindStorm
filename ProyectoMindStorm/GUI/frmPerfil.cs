using Newtonsoft.Json;
using ProyectoMindStorm.MindWave.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMindStorm.GUI
{
    public partial class frmPerfil : Form
    {
        List<ComboBox> toolParameterComboBoxes = null;
        public frmPerfil()
        {
            InitializeComponent();
            oPreferencias = new Preferencias();
            if (cmbMov1.Text == "" || cmbMov2.Text == "" || cmbMov3.Text == "" || cmbMov3.Text == "")
            {
                btnGuardarConfig.Enabled = false;
            }
           
        }
        Preferencias oPreferencias;
        private void cmbMov1_SelectedValueChanged(object sender, EventArgs e)
        {
           
            switch (cmbMov1.SelectedItem.ToString().Trim()) {
                case "Arriba":
                    Arriba1.Visible = true;
                    abajo1.Visible = false;
                    derecha1.Visible = false;
                    izquierda1.Visible = false;
                    sin1.Visible = false;
                    break;
                case "Abajo":
                    Arriba1.Visible = false;
                    abajo1.Visible = true;
                    derecha1.Visible = false;
                    izquierda1.Visible = false;
                    sin1.Visible = false;
                    break;
                case "Derecha":
                    Arriba1.Visible = false;
                    abajo1.Visible = false;
                    derecha1.Visible = true;
                    izquierda1.Visible = false;
                    sin1.Visible = false;
                    break;
                case "Izquierda":
                    Arriba1.Visible = false;
                    abajo1.Visible = false;
                    derecha1.Visible = false;
                    izquierda1.Visible = true;
                    sin1.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {

            
            switch (cmbMov2.SelectedItem.ToString().Trim())
            {
                case "Arriba":
                    arriba2.Visible = true;
                    abajo2.Visible = false;
                    derecha2.Visible = false;
                    izquierda2.Visible = false;
                    sin2.Visible = false;
                    break;
                case "Abajo":
                    arriba2.Visible = false;
                    abajo2.Visible = true;
                    derecha2.Visible = false;
                    izquierda2.Visible = false;
                    sin2.Visible = false;
                    break;
                case "Derecha":
                    arriba2.Visible = false;
                    abajo2.Visible = false;
                    derecha2.Visible = true;
                    izquierda2.Visible = false;
                    sin2.Visible = false;
                    break;
                case "Izquierda":
                    arriba2.Visible = false;
                    abajo2.Visible = false;
                    derecha2.Visible = false;
                    izquierda2.Visible = true;
                    sin2.Visible = false;
                    break;
                default:
                    break;
            }

        }

        private void cmbMov3_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cmbMov3.SelectedItem.ToString().Trim())
            {
                case "Arriba":
                    arriba3.Visible = true;
                    abajo3.Visible = false;
                    derecha3.Visible = false;
                    izquierda3.Visible = false;
                    sin3.Visible = false;
                    break;
                case "Abajo":
                    arriba3.Visible = false;
                    abajo3.Visible = true;
                    derecha3.Visible = false;
                    izquierda3.Visible = false;
                    sin3.Visible = false;
                    break;
                case "Derecha":
                    arriba3.Visible = false;
                    abajo3.Visible = false;
                    derecha3.Visible = true;
                    izquierda3.Visible = false;
                    sin3.Visible = false;
                    break;
                case "Izquierda":
                    arriba3.Visible = false;
                    abajo3.Visible = false;
                    derecha3.Visible = false;
                    izquierda3.Visible = true;
                    sin3.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void cmbMov4_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cmbMov4.SelectedItem.ToString().Trim())
            {
                case "Arriba":
                    arriba4.Visible = true;
                    abajo4.Visible = false;
                    derecha4.Visible = false;
                    izquierda4.Visible = false;
                    sin4.Visible = false;
                    break;
                case "Abajo":
                    arriba4.Visible = false;
                    abajo4.Visible = true;
                    derecha4.Visible = false;
                    izquierda4.Visible = false;
                    sin4.Visible = false;
                    break;
                case "Derecha":
                    arriba4.Visible = false;
                    abajo4.Visible = false;
                    derecha4.Visible = true;
                    izquierda4.Visible = false;
                    sin4.Visible = false;
                    break;
                case "Izquierda":
                    arriba4.Visible = false;
                    abajo4.Visible = false;
                    derecha4.Visible = false;
                    izquierda4.Visible = true;
                    sin4.Visible = false;
                    break;
                default:
                    break;
            }

        }

        private void cmbMov1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox thisCB = sender as ComboBox;
            if (thisCB.Text != "")
            {
                foreach (ComboBox cb in toolParameterComboBoxes)
                {
                    if (thisCB.Name != cb.Name && thisCB.Text == cb.Text && thisCB.Text != "" && cb.Text != "")
                    {
                        Arriba1.Visible = false;
                        abajo1.Visible = false;
                        derecha1.Visible = false;
                        izquierda1.Visible = false;
                        sin1.Visible = true;
                        MessageBox.Show("No puedes seleccionar el mismo movimiento" + "\r\n" + "\r\n"
                                     + "La opcion ya ha sido seleccionada en: " + cb.Name.Replace("comboBox", ""), "Error");
                        thisCB.SelectedIndex = 0;
                        break;
                    }
                }

                if (cmbMov1.Text != "" && cmbMov2.Text != "" && cmbMov3.Text != "" && cmbMov4.Text != "")
                {
                    btnGuardarConfig.Enabled = true;
                }
                else
                {
                    btnGuardarConfig.Enabled = false;
                }
            }
        }

        private void cmbMov2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox thisCB = sender as ComboBox;
            if (thisCB.Text != "")
            {
                foreach (ComboBox cb in toolParameterComboBoxes)
                {
                    if (thisCB.Name != cb.Name && thisCB.Text == cb.Text && thisCB.Text != "" && cb.Text != "")
                    {
                        arriba2.Visible = false;
                        abajo2.Visible = false;
                        derecha2.Visible = false;
                        izquierda2.Visible = false;
                        sin2.Visible = true;
                        MessageBox.Show("No puedes seleccionar el mismo movimiento." + "\r\n" + "\r\n"
                                     + "La opcion ya ha sido seleccionada en:  " + cb.Name.Replace("comboBox", ""), "Error");
                        thisCB.SelectedIndex = 0;
                        break;
                    }
                }

                if (cmbMov1.Text != "" && cmbMov2.Text != "" && cmbMov3.Text != "" && cmbMov4.Text != "")
                {
                    btnGuardarConfig.Enabled = true;
                }
                else
                {
                    btnGuardarConfig.Enabled = false;
                }
            }
        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            toolParameterComboBoxes = new List<ComboBox>();
            toolParameterComboBoxes.Add(cmbMov1);
            toolParameterComboBoxes.Add(cmbMov2);
            toolParameterComboBoxes.Add(cmbMov3);
            toolParameterComboBoxes.Add(cmbMov4);
        }

        private void cmbMov3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox thisCB = sender as ComboBox;
            if (thisCB.Text != "")
            {
                foreach (ComboBox cb in toolParameterComboBoxes)
                {
                    if (thisCB.Name != cb.Name && thisCB.Text == cb.Text && thisCB.Text != "" && cb.Text != "")
                    {
                        arriba3.Visible = false;
                        abajo3.Visible = false;
                        derecha3.Visible = false;
                        izquierda3.Visible = false;
                        sin3.Visible = true;
                        MessageBox.Show("No puedes seleccionar el mismo movimiento." + "\r\n" + "\r\n"
                                     + "La opcion ya ha sido seleccionada en:  " + cb.Name.Replace("comboBox", ""), "Error");
                        thisCB.SelectedIndex = 0;
                        break;
                    }
                }
                if (cmbMov1.Text != "" && cmbMov2.Text != "" && cmbMov3.Text != "" && cmbMov4.Text != "")
                {
                    btnGuardarConfig.Enabled = true;
                }
                else
                {
                    btnGuardarConfig.Enabled = false;
                }
            }
        }

        private void cmbMov4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox thisCB = sender as ComboBox;
            if (thisCB.Text != "")
            {
                foreach (ComboBox cb in toolParameterComboBoxes)
                {
                    if (thisCB.Name != cb.Name && thisCB.Text == cb.Text && thisCB.Text != "" && cb.Text != "")
                    {
                        arriba4.Visible = false;
                        abajo4.Visible = false;
                        derecha4.Visible = false;
                        izquierda4.Visible = false;
                        sin4.Visible = true;
                        MessageBox.Show("No puedes seleccionar el mismo movimiento." + "\r\n" + "\r\n"
                                     + "La opcion ya ha sido seleccionada en:  " + cb.Name.Replace("comboBox", ""), "Error");
                        thisCB.SelectedIndex = 0;
                        break;
                    }
                }

                if (cmbMov1.Text != "" && cmbMov2.Text != "" && cmbMov3.Text != "" && cmbMov4.Text != "")
                {
                    btnGuardarConfig.Enabled = true;
                }
                else
                {
                    btnGuardarConfig.Enabled = false;
                }
            }
        }

        private void btnGuardarConfig_Click(object sender, EventArgs e)
        {
            ConfiguracionBO config = new ConfiguracionBO();
            config.movimiento1 = cmbMov1.Text;
            config.movimiento2 = cmbMov2.Text;
            config.movimiento3 = cmbMov3.Text;
            config.movimiento4 = cmbMov4.Text;
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;
            using (StreamWriter sw = new StreamWriter(@"C:\Users\pc\Documents\Visual Studio 2015\Projects\ProyectoMindStorm\json.txt"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, config);
                MessageBox.Show("Configuración Guardada con Exito.", "Configuración");
            }
        }

    }
}
