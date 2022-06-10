using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using View.Screen;

namespace View
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        //Mover Formulario Principal Barra Superior
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        // Addicionar un Form a un Panel
        public void InsertFormInPanel(object Formhijo, Control contenedor)
        {
            if (contenedor.Controls.Count > 0)
                contenedor.Controls.RemoveAt(0);
            Form insert = (Form)Formhijo;
            insert.TopLevel = false;
            insert.Dock = DockStyle.Fill;
            contenedor.Controls.Add(insert);
            contenedor.Tag = insert;
            insert.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            InsertFormInPanel(new FrmAdd(),pnFormContainer);
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            InsertFormInPanel(new FrmList(), pnFormContainer);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
         InsertFormInPanel(new FrmEdit(), pnFormContainer);
        }
         private void pictureBox1_Click(object sender, EventArgs e)
        {
            InsertFormInPanel(new FrmDev(), pnFormContainer);
        }

        private void tmDate_Tick(object sender, EventArgs e)
        {
            var dateNow = DateTime.Now;
            string fecha = DateTime.Now.ToString("ddddd dd MMMM");
            string hora = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = "Fecha:  "+fecha;
            lblHour.Text = "Hora:  "+hora;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            InsertFormInPanel(new FrmDev(), pnFormContainer);
        }
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            InsertFormInPanel(new FrmDev(), pnFormContainer);
        }
    }
}
