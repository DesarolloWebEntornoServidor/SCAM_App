namespace SCAM_App
{
    partial class FormAccesos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccesos));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnAnadirAcceso = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.tbLocalizar = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvAccesos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.codigosaccesoTableAdapter1 = new DatosNegocios.DataSetSCATableAdapters.codigosaccesoTableAdapter();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccesos)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnAnadirAcceso);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel1.Controls.Add(this.tbLocalizar);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(826, 74);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btnAnadirAcceso
            // 
            this.btnAnadirAcceso.ActiveBorderThickness = 1;
            this.btnAnadirAcceso.ActiveCornerRadius = 20;
            this.btnAnadirAcceso.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAnadirAcceso.ActiveForecolor = System.Drawing.SystemColors.WindowFrame;
            this.btnAnadirAcceso.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAnadirAcceso.BackColor = System.Drawing.SystemColors.Control;
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
            this.btnAnadirAcceso.Location = new System.Drawing.Point(378, 19);
            this.btnAnadirAcceso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnadirAcceso.Name = "btnAnadirAcceso";
            this.btnAnadirAcceso.Size = new System.Drawing.Size(133, 38);
            this.btnAnadirAcceso.TabIndex = 3;
            this.btnAnadirAcceso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAnadirAcceso.Click += new System.EventHandler(this.btnAnadirAcceso_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(786, 10);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(36, 26);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
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
            this.tbLocalizar.Location = new System.Drawing.Point(44, 25);
            this.tbLocalizar.Margin = new System.Windows.Forms.Padding(4);
            this.tbLocalizar.Name = "tbLocalizar";
            this.tbLocalizar.Size = new System.Drawing.Size(230, 25);
            this.tbLocalizar.TabIndex = 1;
            this.tbLocalizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbLocalizar.OnValueChanged += new System.EventHandler(this.tbLocalizar_OnValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvAccesos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAccesos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccesos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAccesos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvAccesos.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvAccesos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAccesos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccesos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAccesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion,
            this.edit,
            this.borrar});
            this.dgvAccesos.DoubleBuffered = true;
            this.dgvAccesos.EnableHeadersVisualStyles = false;
            this.dgvAccesos.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvAccesos.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.dgvAccesos.HeaderForeColor = System.Drawing.Color.Silver;
            this.dgvAccesos.Location = new System.Drawing.Point(12, 80);
            this.dgvAccesos.Name = "dgvAccesos";
            this.dgvAccesos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAccesos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccesos.Size = new System.Drawing.Size(802, 325);
            this.dgvAccesos.TabIndex = 1;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Cödigo";
            this.codigo.Name = "codigo";
            this.codigo.Width = 75;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 102;
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
            // codigosaccesoTableAdapter1
            // 
            this.codigosaccesoTableAdapter1.ClearBeforeFill = true;
            // 
            // FormAccesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 431);
            this.Controls.Add(this.dgvAccesos);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAccesos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormAccesos";
            this.Load += new System.EventHandler(this.FormAccesos_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccesos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvAccesos;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbLocalizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DatosNegocios.DataSetSCATableAdapters.codigosaccesoTableAdapter codigosaccesoTableAdapter1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAnadirAcceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn borrar;
    }
}