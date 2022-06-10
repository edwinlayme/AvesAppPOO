namespace View
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pnTop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new View.Controls.MyButton();
            this.btnExit = new View.Controls.MyButton();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.pnFormContainer = new System.Windows.Forms.Panel();
            this.pnBottomBar = new System.Windows.Forms.Panel();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnNavBar = new System.Windows.Forms.Panel();
            this.btnNew = new View.Controls.MyButton();
            this.btnList = new View.Controls.MyButton();
            this.btnEdit = new View.Controls.MyButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSettings = new View.Controls.MyButton();
            this.tmDate = new System.Windows.Forms.Timer(this.components);
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnContainer.SuspendLayout();
            this.pnBottom.SuspendLayout();
            this.pnBottomBar.SuspendLayout();
            this.pnNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnTop.Controls.Add(this.pictureBox2);
            this.pnTop.Controls.Add(this.btnMinimizar);
            this.pnTop.Controls.Add(this.btnExit);
            this.pnTop.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnTop.MaximumSize = new System.Drawing.Size(0, 40);
            this.pnTop.MinimumSize = new System.Drawing.Size(0, 40);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(720, 40);
            this.pnTop.TabIndex = 1;
            this.pnTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTop_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(225, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(324, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnMinimizar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnMinimizar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(218)))), ((int)(((byte)(232)))));
            this.btnMinimizar.BorderRadius = 16;
            this.btnMinimizar.BorderSize = 2;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(218)))), ((int)(((byte)(232)))));
            this.btnMinimizar.Location = new System.Drawing.Point(645, 4);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 32);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.Text = "__";
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnMinimizar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(218)))), ((int)(((byte)(232)))));
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnExit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnExit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(218)))), ((int)(((byte)(232)))));
            this.btnExit.BorderRadius = 16;
            this.btnExit.BorderSize = 2;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(218)))), ((int)(((byte)(232)))));
            this.btnExit.Location = new System.Drawing.Point(680, 4);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = " X";
            this.btnExit.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(218)))), ((int)(((byte)(232)))));
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnContainer
            // 
            this.pnContainer.Controls.Add(this.pnBottom);
            this.pnContainer.Controls.Add(this.pnNavBar);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 40);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(720, 500);
            this.pnContainer.TabIndex = 2;
            // 
            // pnBottom
            // 
            this.pnBottom.Controls.Add(this.pnFormContainer);
            this.pnBottom.Controls.Add(this.pnBottomBar);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBottom.Location = new System.Drawing.Point(0, 110);
            this.pnBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(720, 390);
            this.pnBottom.TabIndex = 2;
            // 
            // pnFormContainer
            // 
            this.pnFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFormContainer.Location = new System.Drawing.Point(0, 0);
            this.pnFormContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnFormContainer.Name = "pnFormContainer";
            this.pnFormContainer.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.pnFormContainer.Size = new System.Drawing.Size(720, 360);
            this.pnFormContainer.TabIndex = 1;
            // 
            // pnBottomBar
            // 
            this.pnBottomBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(212)))), ((int)(((byte)(227)))));
            this.pnBottomBar.Controls.Add(this.lblHour);
            this.pnBottomBar.Controls.Add(this.lblDate);
            this.pnBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottomBar.Location = new System.Drawing.Point(0, 360);
            this.pnBottomBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnBottomBar.Name = "pnBottomBar";
            this.pnBottomBar.Size = new System.Drawing.Size(720, 30);
            this.pnBottomBar.TabIndex = 0;
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.ForeColor = System.Drawing.Color.DarkRed;
            this.lblHour.Location = new System.Drawing.Point(633, 8);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(33, 15);
            this.lblHour.TabIndex = 1;
            this.lblHour.Text = "Hora";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(9, 6);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(43, 16);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Fecha";
            // 
            // pnNavBar
            // 
            this.pnNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(212)))), ((int)(((byte)(227)))));
            this.pnNavBar.Controls.Add(this.btnNew);
            this.pnNavBar.Controls.Add(this.btnList);
            this.pnNavBar.Controls.Add(this.btnEdit);
            this.pnNavBar.Controls.Add(this.pictureBox1);
            this.pnNavBar.Controls.Add(this.btnSettings);
            this.pnNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnNavBar.Location = new System.Drawing.Point(0, 0);
            this.pnNavBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnNavBar.Name = "pnNavBar";
            this.pnNavBar.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pnNavBar.Size = new System.Drawing.Size(720, 110);
            this.pnNavBar.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(173)))), ((int)(((byte)(250)))));
            this.btnNew.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(173)))), ((int)(((byte)(250)))));
            this.btnNew.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.btnNew.BorderRadius = 8;
            this.btnNew.BorderSize = 3;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.Location = new System.Drawing.Point(154, 4);
            this.btnNew.Margin = new System.Windows.Forms.Padding(0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(140, 102);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "Nuevo";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNew.TextColor = System.Drawing.Color.White;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(173)))), ((int)(((byte)(250)))));
            this.btnList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(173)))), ((int)(((byte)(250)))));
            this.btnList.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.btnList.BorderRadius = 8;
            this.btnList.BorderSize = 3;
            this.btnList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnList.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.Image = ((System.Drawing.Image)(resources.GetObject("btnList.Image")));
            this.btnList.Location = new System.Drawing.Point(294, 4);
            this.btnList.Margin = new System.Windows.Forms.Padding(0);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(140, 102);
            this.btnList.TabIndex = 5;
            this.btnList.Text = "Lista";
            this.btnList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnList.TextColor = System.Drawing.Color.White;
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(173)))), ((int)(((byte)(250)))));
            this.btnEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(173)))), ((int)(((byte)(250)))));
            this.btnEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.btnEdit.BorderRadius = 8;
            this.btnEdit.BorderSize = 3;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(434, 4);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 102);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edición";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(173)))), ((int)(((byte)(250)))));
            this.btnSettings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(173)))), ((int)(((byte)(250)))));
            this.btnSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.btnSettings.BorderRadius = 8;
            this.btnSettings.BorderSize = 3;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(574, 4);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(140, 102);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Configuración";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSettings.TextColor = System.Drawing.Color.White;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // tmDate
            // 
            this.tmDate.Enabled = true;
            this.tmDate.Tick += new System.EventHandler(this.tmDate_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(720, 540);
            this.Controls.Add(this.pnContainer);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(720, 540);
            this.MinimumSize = new System.Drawing.Size(720, 540);
            this.Name = "FrmPrincipal";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APLICACION AVES";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.pnTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnContainer.ResumeLayout(false);
            this.pnBottom.ResumeLayout(false);
            this.pnBottomBar.ResumeLayout(false);
            this.pnBottomBar.PerformLayout();
            this.pnNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnTop;
        public System.Windows.Forms.Panel pnContainer;
        public Controls.MyButton btnExit;
        public Controls.MyButton btnMinimizar;
        public System.Windows.Forms.Panel pnNavBar;
        public System.Windows.Forms.PictureBox pictureBox1;
        public Controls.MyButton btnNew;
        public Controls.MyButton btnList;
        public Controls.MyButton btnEdit;
        public System.Windows.Forms.Panel pnBottom;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Panel pnBottomBar;
        public System.Windows.Forms.Panel pnFormContainer;
        public System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Label lblHour;
        public System.Windows.Forms.Timer tmDate;
        public Controls.MyButton btnSettings;
    }
}