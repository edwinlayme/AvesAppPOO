using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View.Screen
{
    public partial class FrmAdd : Form
    {
        AveController<Ave> lista = new AveController<Ave>("ave.json");
        public FrmAdd()
        {
            InitializeComponent();

            cmbGroup.SelectedIndex = 0;
            cmbFamily.SelectedIndex = 0;
            cmbSpecies.SelectedIndex = 0;
            lista.Cargar();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
           int cod = new Random().Next(100000, 999999);
           txtCodigo.Texts = cod.ToString();
        }

        private void txtCodigo__TextChanged(object sender, EventArgs e)
        {
            lblSetCode.Text = txtCodigo.Texts;
        }

        private void txtName__TextChanged(object sender, EventArgs e)
        {
            lblSetName.Text = txtName.Texts;
        }

        private void txtEdad__TextChanged(object sender, EventArgs e)
        {
            lblSetEdad.Text = txtEdad.Texts;
        }

        private void txtPeso__TextChanged(object sender, EventArgs e)
        {
            lblSetPeso.Text = txtPeso.Texts;
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSetGroup.Text = cmbGroup.Text;
        }

        private void cmbFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSetFamily.Text = cmbFamily.Text;
        }

        private void cmbSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSetEspecie.Text = cmbSpecies.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        //Seleccionar Grupo 
            string groupselect = cmbGroup.Text;
            Grupo grupo;
            switch (groupselect)
            {
                case "Aves":
                    grupo = Grupo.Aves;
                break;
                case "Peces":
                    grupo = Grupo.Peces;
                break;
                case "Anfibios":
                    grupo = Grupo.Anfibios;
                    break;
                case "Reptiles":
                    grupo = Grupo.Reptiles;
                    break;
                case "Mamíferos":
                    grupo = Grupo.Mamíferos;
                    break;
                default:
                    grupo = Grupo.Aves;
                    break;
            }
            //Seleccionar Familia
            string familyselect = cmbFamily.Text;
            tipoFamilia familia;
            switch (familyselect)
            {
                case "Struthioniforme":
                    familia = tipoFamilia.Struthioniforme;
                    break;
                case "Tinamiforme":
                    familia = tipoFamilia.Tinamiforme;
                    break;
                case "Podicipediforme":
                    familia = tipoFamilia.Podicipediforme;
                    break;
                case "Ciconiforme":
                    familia = tipoFamilia.Ciconiforme;
                    break;
                case "Phoenicopteriforme":
                    familia = tipoFamilia.Phoenicopteriforme;
                    break;
                case "Falconiforme":
                    familia = tipoFamilia.Falconiforme;
                    break;
                default:
                    familia = tipoFamilia.Struthioniforme;
                    break;
            }
            //Seleccionar Especie
            string especisSelect = cmbSpecies.Text;
            tipoEspecie esp;
            switch (especisSelect)
            {
                case "Rapaz":
                    esp = tipoEspecie.Rapaz;
                    break;
                case "Pajaro":
                    esp = tipoEspecie.Pajaro;
                    break;
                case "Corredor":
                    esp = tipoEspecie.Corredor;
                    break;
                case "Zancuda":
                    esp = tipoEspecie.Zancuda;
                    break;
                case "Gallinacea":
                    esp = tipoEspecie.Gallinacea;
                    break;
                case "Anseriforme":
                    esp = tipoEspecie.Anseriforme;
                    break;
                case "Esfenisciforme":
                    esp = tipoEspecie.Esfenisciforme;
                    break;
                default:
                    esp = tipoEspecie.Pajaro;
                    break;
            }

            try
            {
                Ave nuevo = new Ave(int.Parse(txtCodigo.Texts),
                    txtName.Texts, int.Parse(txtEdad.Texts),
                    double.Parse(txtPeso.Texts), grupo, esp, familia);
                if (txtCodigo.Texts != "" || txtName.Texts != "" || txtEdad.Texts != "")
                {
                    lista.Adicionar(nuevo);
                    MessageBox.Show("DATOS ALMACENADOS EXITOSAMENTE¡", "Cuadro de Dialogo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("REVISA TUS DATOS¡ LLena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch(Exception)
            {
                MessageBox.Show("REVISA TUS DATOS¡ LLena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
