namespace SCAM_App
{
    partial class FormDepartamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepartamento));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnadirAcceso = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.tbLocalizar = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvDepartamento = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoAcceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamento)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btnAnadirAcceso);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.tbLocalizar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 74);
            this.panel1.TabIndex = 0;
            // 
            // btnAnadirAcceso
            // 
            this.btnAnadirAcceso.ActiveBorderThickness = 1;
            this.btnAnadirAcceso.ActiveCornerRadius = 20;
            this.btnAnadirAcceso.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAnadirAcceso.ActiveForecolor = System.Drawing.SystemColors.WindowFrame;
            this.btnAnadirAcceso.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAnadirAcceso.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAnadirAcceso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnadirAcceso.BackgroundImage")));
            this.btnAnadirAcceso.ButtonText = "Añadir Nuevo";
            this.btnAnadirAcceso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnadirAcceso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirAcceso.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAnadirAcceso.IdleBorderThickness = 1;
            this.btnAnadirAcceso.IdleCornerRadius = 30;
            this.btnAnadirAcceso.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnAnadirAcceso.IdleForecolor = System.Drawing.Color.Silver;
            this.btnAnadirAcceso.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAnadirAcceso.Location = new System.Drawing.Point(374, 23);
            this.btnAnadirAcceso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnadirAcceso.Name = "btnAnadirAcceso";
            this.btnAnadirAcceso.Size = new System.Drawing.Size(133, 38);
            this.btnAnadirAcceso.TabIndex = 7;
            this.btnAnadirAcceso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAnadirAcceso.Click += new System.EventHandler(this.btnAnadirAcceso_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(782, 14);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(36, 26);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 6;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // tbLocalizar
            // 
            this.tbLocalizar.BackColor = System.Drawing.Color.RoyalBlue;
            this.tbLocalizar.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbLocalizar.BorderColorIdle = System.Drawing.Color.LightGray;
            this.tbLocalizar.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbLocalizar.BorderThickness = 1;
            this.tbLocalizar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLocalizar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbLocalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbLocalizar.isPassword = false;
            this.tbLocalizar.Location = new System.Drawing.Point(40, 29);
            this.tbLocalizar.Margin = new System.Windows.Forms.Padding(4);
            this.tbLocalizar.Name = "tbLocalizar";
            this.tbLocalizar.Size = new System.Drawing.Size(230, 25);
            this.tbLocalizar.TabIndex = 5;
            this.tbLocalizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dgvDepartamento
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDepartamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepartamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvDepartamento.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDepartamento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepartamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.departamento,
            this.codigoAcceso,
            this.edit,
            this.borrar});
            this.dgvDepartamento.DoubleBuffered = true;
            this.dgvDepartamento.EnableHeadersVisualStyles = false;
            this.dgvDepartamento.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvDepartamento.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.dgvDepartamento.HeaderForeColor = System.Drawing.Color.Silver;
            this.dgvDepartamento.Location = new System.Drawing.Point(8, 80);
            this.dgvDepartamento.Name = "dgvDepartamento";
            this.dgvDepartamento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDepartamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartamento.Size = new System.Drawing.Size(818, 339);
            this.dgvDepartamento.TabIndex = 2;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Cödigo";
            this.codigo.Name = "codigo";
            this.codigo.Width = 75;
            // 
            // departamento
            // 
            this.departamento.HeaderText = "Departamento";
            this.departamento.Name = "departamento";
            this.departamento.Width = 120;
            // 
            // codigoAcceso
            // 
            this.codigoAcceso.HeaderText = "Nível de Acceso";
            this.codigoAcceso.Name = "codigoAcceso";
            this.codigoAcceso.Width = 119;
            // 
            // edit
            // 
            this.edit.HeaderText = "Editar";
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.edit.Name = "edit";
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.edit.Width = 65;
            // 
            // borrar
            // 
            this.borrar.HeaderText = "Borrar";
            this.borrar.Image = ((System.Drawing.Image)(resources.GetObject("borrar.Image")));
            this.borrar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.borrar.Name = "borrar";
            this.borrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.borrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.borrar.Width = 66;
            // 
            // FormDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 431);
            this.Controls.Add(this.dgvDepartamento);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDepartamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormDepartamento";
            this.Load += new System.EventHandler(this.FormDepartamento_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAnadirAcceso;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbLocalizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoAcceso;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn borrar;
    }
}