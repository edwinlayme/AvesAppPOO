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
    public partial class FrmEdit : Form
    {
        AveController<Ave> mylista = new AveController<Ave>("ave.json");
        public FrmEdit()
        {
            InitializeComponent();
            mylista.Cargar();
            mostrarLista(mylista.lista);
            cmbCode.SelectedIndex = 0;
        }
        public void mostrarLista(List<Ave> listaDataGrid)
        {
            cmbCode.Items.Clear();
            foreach (Ave item in listaDataGrid)
            {
                cmbCode.Items.Add(item.codigo);
            }
        }

        private void cmbCode_SelectedIndexChanged(object sender, EventArgs e)
        {

            int indice = cmbCode.SelectedIndex;
            //Cargar Datos seleccionando Codigo
            Ave busca = mylista.Buscar(x => x.codigo.ToString() == cmbCode.Items[indice].ToString())[0];
            txtName.Texts = busca.nombre.ToString();
            txtEdad.Texts = busca.edad.ToString();
            txtPeso.Texts = busca.peso.ToString();
            cmbGroup.Text = busca.grupo.ToString();
            cmbSpecies.Text = busca.especie.ToString();
            cmbFamily.Text = busca.familia.ToString();
            lblSetCode.Text = cmbCode.Text;
            lblSetName.Text = txtName.Texts;
            lblSetEdad.Text = txtEdad.Texts;
            lblSetPeso.Text = txtPeso.Texts;
            lblSetGrupo.Text = cmbGroup.Text;
            lblSetEspecie.Text = cmbSpecies.Text;
            lblSetFamilia.Text = cmbFamily.Text;

        }
        private void btnUpdate_Click(object sender, EventArgs e)
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

                if (txtName.Texts != "" || txtPeso.Texts != "" || txtEdad.Texts != "")
                {
                    Ave nuevo = new Ave(int.Parse(cmbCode.Text),
                                        txtName.Texts, int.Parse(txtEdad.Texts),
                                        double.Parse(txtPeso.Texts), grupo, esp, familia);
                    mylista.Actualizar(x => x.codigo == int.Parse(cmbCode.Text), nuevo);
                    MessageBox.Show("DATOS ACTUALIZADOS EXITOSAMENTE¡", "Cuadro de Dialogo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("REVISA TUS DATOS¡ LLena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("REVISA TUS DATOS¡ LLena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo...", "Cuadro de Dialogo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
