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
    public partial class FrmList : Form
    {
        AveController<Ave> mylista = new AveController<Ave>("ave.json");

        public FrmList()
        {
            InitializeComponent();
            cmbFamily.SelectedIndex = 0;
            cmbSpecies.SelectedIndex = 0;
            mylista.Cargar();
            mostrarLista(mylista.lista);
        }
        public void mostrarLista(List<Ave> listaDataGrid)
        {
            dgvLista.Rows.Clear();
            foreach (Ave item in listaDataGrid)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = item.codigo });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = item.nombre });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = item.familia.ToString() });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = item.especie.ToString() });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = item.grupo.ToString() });
                dgvLista.Rows.Add(fila);
            }
        }

        private void cmbSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seleccionar = mylista.Buscar(x => x.especie.ToString() == cmbSpecies.Text);
            mostrarLista(seleccionar);
        }

        private void cmbFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seleccionar = mylista.Buscar(x => x.familia.ToString() == cmbFamily.Text);
            mostrarLista(seleccionar);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try { 
            if (txtSearchName.Texts != "") 
              { 
               var seleccionar = mylista.Buscar(x => x.nombre == txtSearchName.Texts);
               mostrarLista(seleccionar);
               int FilaActual = dgvLista.CurrentRow.Index;
               string codigo = dgvLista.Rows[FilaActual].Cells[0].Value.ToString();
               string nombre = dgvLista.Rows[FilaActual].Cells[1].Value.ToString();
               txtResult.Texts = "......SELECCION......\nCódigo: " + codigo + "\nNombre: "+nombre;
              }
              else
              {
                MessageBox.Show("Introduccir Nombre a Seleccionar...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
            }catch(Exception)
            {
                MessageBox.Show("Introduccir Nombre a Seleccionar...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            /*string msg = String.Format("Row: {0}, Column: {1}",
             dgvLista.CurrentCell.RowIndex,
             dgvLista.CurrentCell.ColumnIndex);
             MessageBox.Show(msg, "Celda Seleccionada");*/
            int FilaActual = dgvLista.CurrentRow.Index;
            string codigo = dgvLista.Rows[FilaActual].Cells[0].Value.ToString();
            string nombre = dgvLista.Rows[FilaActual].Cells[1].Value.ToString();
            txtResult.Texts = "......SELECCION......\nCódigo: " + codigo + "\nNombre: " + nombre;
            try
            {
                if (dgvLista.CurrentCell.ColumnIndex == 0)
                {
                    mylista.Eliminar(x=>x.codigo.ToString() == codigo);
                    MessageBox.Show("Código: " + codigo+ "\n\nNombre: " + nombre, "Eliminado Correctamente...");
                }
                else
                {
                    MessageBox.Show("Seleccionar Codigo a Eliminar...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccionar Codigo a Eliminar...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mostrarLista(mylista.lista);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int FilaActual = dgvLista.CurrentRow.Index;
            int codigo = int.Parse(dgvLista.Rows[FilaActual].Cells[0].Value.ToString());
            string nombre = dgvLista.Rows[FilaActual].Cells[1].Value.ToString();
            var seleccionar = mylista.Buscar(x => x.codigo == codigo)[0];
            try
            {

                if (nombre != "")
                {
                    Ave nuevo = new Ave(codigo,nombre,seleccionar.edad,seleccionar.peso,seleccionar.grupo,seleccionar.especie,seleccionar.familia);
                    mylista.Actualizar(x => x.codigo == codigo, nuevo);
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
            mostrarLista(mylista.lista);
        }
    }
}
