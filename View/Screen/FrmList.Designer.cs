namespace View.Screen
{
    partial class FrmList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbFamily = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbSpecies = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnSearch = new View.Controls.MyButton();
            this.txtSearchName = new View.Controls.MyTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdate = new View.Controls.MyButton();
            this.txtResult = new View.Controls.MyTextBox();
            this.btnEliminar = new View.Controls.MyButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Famil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Espcies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearchName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(710, 64);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.cmbFamily);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.cmbSpecies);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(333, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(375, 60);
            this.panel4.TabIndex = 17;
            // 
            // cmbFamily
            // 
            this.cmbFamily.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFamily.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbFamily.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbFamily.FormattingEnabled = true;
            this.cmbFamily.Items.AddRange(new object[] {
            "Struthioniforme",
            "Tinamiforme",
            "Podicipediforme",
            "Ciconiforme",
            "Phoenicopteriforme",
            "Falconiforme"});
            this.cmbFamily.Location = new System.Drawing.Point(215, 25);
            this.cmbFamily.Name = "cmbFamily";
            this.cmbFamily.Size = new System.Drawing.Size(138, 28);
            this.cmbFamily.TabIndex = 16;
            this.cmbFamily.SelectedIndexChanged += new System.EventHandler(this.cmbFamily_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(219, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 20);
            this.label16.TabIndex = 15;
            this.label16.Text = "FAMILIA:";
            // 
            // cmbSpecies
            // 
            this.cmbSpecies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpecies.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSpecies.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbSpecies.FormattingEnabled = true;
            this.cmbSpecies.Items.AddRange(new object[] {
            "Rapaz",
            "Pajaro",
            "Corredor",
            "Zancuda",
            "Gallinacea",
            "Anseriforme",
            "Esfenisciforme"});
            this.cmbSpecies.Location = new System.Drawing.Point(24, 25);
            this.cmbSpecies.Name = "cmbSpecies";
            this.cmbSpecies.Size = new System.Drawing.Size(138, 28);
            this.cmbSpecies.TabIndex = 14;
            this.cmbSpecies.SelectedIndexChanged += new System.EventHandler(this.cmbSpecies_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cambria", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(24, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 20);
            this.label17.TabIndex = 13;
            this.label17.Text = "ESPECIE:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.BorderRadius = 20;
            this.btnSearch.BorderSize = 2;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(193, 12);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 40);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Buscar...";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchName
            // 
            this.txtSearchName.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearchName.BorderColor = System.Drawing.SystemColors.Highlight;
            this.txtSearchName.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtSearchName.BorderRadius = 14;
            this.txtSearchName.BorderSize = 2;
            this.txtSearchName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchName.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearchName.Location = new System.Drawing.Point(9, 17);
            this.txtSearchName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchName.Multiline = false;
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Padding = new System.Windows.Forms.Padding(7);
            this.txtSearchName.PasswordChar = false;
            this.txtSearchName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearchName.PlaceholderText = "Ingrese Nombre";
            this.txtSearchName.Size = new System.Drawing.Size(178, 32);
            this.txtSearchName.TabIndex = 0;
            this.txtSearchName.Texts = "";
            this.txtSearchName.UnderlinedStyle = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.txtResult);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(533, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 292);
            this.panel2.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnUpdate.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.btnUpdate.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.BorderRadius = 20;
            this.btnUpdate.BorderSize = 2;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(22, 10);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 64);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Editar Nombre";
            this.btnUpdate.TextColor = System.Drawing.SystemColors.HighlightText;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtResult.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtResult.BorderFocusColor = System.Drawing.Color.Silver;
            this.txtResult.BorderRadius = 5;
            this.txtResult.BorderSize = 1;
            this.txtResult.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResult.ForeColor = System.Drawing.Color.DimGray;
            this.txtResult.Location = new System.Drawing.Point(15, 151);
            this.txtResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Padding = new System.Windows.Forms.Padding(7);
            this.txtResult.PasswordChar = false;
            this.txtResult.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtResult.PlaceholderText = "";
            this.txtResult.Size = new System.Drawing.Size(145, 128);
            this.txtResult.TabIndex = 16;
            this.txtResult.Texts = "";
            this.txtResult.UnderlinedStyle = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(92)))), ((int)(((byte)(63)))));
            this.btnEliminar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(92)))), ((int)(((byte)(63)))));
            this.btnEliminar.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.BorderRadius = 22;
            this.btnEliminar.BorderSize = 2;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(15, 85);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(148, 45);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextColor = System.Drawing.SystemColors.HighlightText;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvLista);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 64);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(4);
            this.panel3.Size = new System.Drawing.Size(533, 292);
            this.panel3.TabIndex = 2;
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Nomb,
            this.Famil,
            this.Espcies,
            this.Group});
            this.dgvLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLista.Location = new System.Drawing.Point(4, 4);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowTemplate.Height = 25;
            this.dgvLista.Size = new System.Drawing.Size(525, 284);
            this.dgvLista.TabIndex = 1;
            // 
            // Code
            // 
            this.Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Code.HeaderText = "Código";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Code.Width = 71;
            // 
            // Nomb
            // 
            this.Nomb.HeaderText = "Nombre";
            this.Nomb.Name = "Nomb";
            this.Nomb.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Famil
            // 
            this.Famil.HeaderText = "Familia";
            this.Famil.Name = "Famil";
            this.Famil.ReadOnly = true;
            // 
            // Espcies
            // 
            this.Espcies.HeaderText = "Especie";
            this.Espcies.Name = "Espcies";
            this.Espcies.ReadOnly = true;
            // 
            // Group
            // 
            this.Group.HeaderText = "Grupo";
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            // 
            // FrmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 356);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmList";
            this.Text = "Formulario List";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvLista;
        private Controls.MyButton btnEliminar;
        private Controls.MyTextBox txtSearchName;
        private Controls.MyButton btnSearch;
        private Controls.MyTextBox txtResult;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbSpecies;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbFamily;
        private System.Windows.Forms.Label label16;
        private Controls.MyButton btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Famil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Espcies;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
    }
}