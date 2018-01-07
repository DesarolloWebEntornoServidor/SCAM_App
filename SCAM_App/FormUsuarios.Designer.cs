namespace SCAM_App
{
    partial class FormUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnPrinter = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPdf = new Bunifu.Framework.UI.BunifuImageButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInserir = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnVolver = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.dgvUsuarios = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tbLista = new System.Windows.Forms.TextBox();
            this.panelLista = new System.Windows.Forms.Panel();
            this.panelListaTrans = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.btnCerrarTarjeta = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPrinterLista = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrinter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInserir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.panelLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarTarjeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrinterLista)).BeginInit();
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
            this.bunifuGradientPanel1.Controls.Add(this.btnPrinter);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton2);
            this.bunifuGradientPanel1.Controls.Add(this.btnPdf);
            this.bunifuGradientPanel1.Controls.Add(this.textBox1);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.btnInserir);
            this.bunifuGradientPanel1.Controls.Add(this.btnVolver);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.panelListaTrans.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(771, 74);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // btnPrinter
            // 
            this.btnPrinter.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelListaTrans.SetDecoration(this.btnPrinter, BunifuAnimatorNS.DecorationType.None);
            this.btnPrinter.Image = ((System.Drawing.Image)(resources.GetObject("btnPrinter.Image")));
            this.btnPrinter.ImageActive = null;
            this.btnPrinter.Location = new System.Drawing.Point(308, 12);
            this.btnPrinter.Name = "btnPrinter";
            this.btnPrinter.Size = new System.Drawing.Size(45, 51);
            this.btnPrinter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPrinter.TabIndex = 19;
            this.btnPrinter.TabStop = false;
            this.btnPrinter.Zoom = 10;
            this.btnPrinter.Click += new System.EventHandler(this.btnPrinter_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelListaTrans.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(434, 12);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(45, 51);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 18;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelListaTrans.SetDecoration(this.btnPdf, BunifuAnimatorNS.DecorationType.None);
            this.btnPdf.Image = ((System.Drawing.Image)(resources.GetObject("btnPdf.Image")));
            this.btnPdf.ImageActive = null;
            this.btnPdf.Location = new System.Drawing.Point(371, 12);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(45, 51);
            this.btnPdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPdf.TabIndex = 17;
            this.btnPdf.TabStop = false;
            this.btnPdf.Zoom = 10;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // textBox1
            // 
            this.panelListaTrans.SetDecoration(this.textBox1, BunifuAnimatorNS.DecorationType.None);
            this.textBox1.Location = new System.Drawing.Point(22, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelListaTrans.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(170, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelListaTrans.SetDecoration(this.btnInserir, BunifuAnimatorNS.DecorationType.None);
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageActive = null;
            this.btnInserir.Location = new System.Drawing.Point(239, 7);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(53, 56);
            this.btnInserir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInserir.TabIndex = 14;
            this.btnInserir.TabStop = false;
            this.btnInserir.Zoom = 10;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelListaTrans.SetDecoration(this.btnVolver, BunifuAnimatorNS.DecorationType.None);
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.ImageActive = null;
            this.btnVolver.Location = new System.Drawing.Point(521, 19);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(44, 44);
            this.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVolver.TabIndex = 4;
            this.btnVolver.TabStop = false;
            this.btnVolver.Zoom = 10;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelListaTrans.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(786, 10);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(36, 26);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // dgvUsuarios
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.alias,
            this.login,
            this.acceso,
            this.borrar,
            this.modificar});
            this.panelListaTrans.SetDecoration(this.dgvUsuarios, BunifuAnimatorNS.DecorationType.None);
            this.dgvUsuarios.DoubleBuffered = true;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvUsuarios.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.dgvUsuarios.HeaderForeColor = System.Drawing.Color.Silver;
            this.dgvUsuarios.Location = new System.Drawing.Point(1, 74);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(719, 284);
            this.dgvUsuarios.TabIndex = 2;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            this.dgvUsuarios.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvUsuarios_CellPainting);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 75;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 79;
            // 
            // alias
            // 
            this.alias.HeaderText = "Alias";
            this.alias.Name = "alias";
            this.alias.ReadOnly = true;
            this.alias.Width = 59;
            // 
            // login
            // 
            this.login.HeaderText = "Login";
            this.login.Name = "login";
            this.login.ReadOnly = true;
            this.login.Width = 63;
            // 
            // acceso
            // 
            this.acceso.HeaderText = "Acceso";
            this.acceso.Name = "acceso";
            this.acceso.ReadOnly = true;
            this.acceso.Width = 77;
            // 
            // borrar
            // 
            this.borrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.borrar.HeaderText = "Borra";
            this.borrar.Name = "borrar";
            this.borrar.ReadOnly = true;
            this.borrar.Width = 53;
            // 
            // modificar
            // 
            this.modificar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.modificar.HeaderText = "Edita";
            this.modificar.Name = "modificar";
            this.modificar.ReadOnly = true;
            this.modificar.Width = 60;
            // 
            // tbLista
            // 
            this.tbLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panelListaTrans.SetDecoration(this.tbLista, BunifuAnimatorNS.DecorationType.None);
            this.tbLista.Location = new System.Drawing.Point(14, 12);
            this.tbLista.Multiline = true;
            this.tbLista.Name = "tbLista";
            this.tbLista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLista.Size = new System.Drawing.Size(345, 184);
            this.tbLista.TabIndex = 3;
            // 
            // panelLista
            // 
            this.panelLista.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelLista.Controls.Add(this.btnCerrarTarjeta);
            this.panelLista.Controls.Add(this.tbLista);
            this.panelLista.Controls.Add(this.btnPrinterLista);
            this.panelListaTrans.SetDecoration(this.panelLista, BunifuAnimatorNS.DecorationType.None);
            this.panelLista.Location = new System.Drawing.Point(37, 89);
            this.panelLista.Name = "panelLista";
            this.panelLista.Size = new System.Drawing.Size(379, 236);
            this.panelLista.TabIndex = 4;
            // 
            // panelListaTrans
            // 
            this.panelListaTrans.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.panelListaTrans.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 1F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 0F;
            this.panelListaTrans.DefaultAnimation = animation6;
            // 
            // btnCerrarTarjeta
            // 
            this.btnCerrarTarjeta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelListaTrans.SetDecoration(this.btnCerrarTarjeta, BunifuAnimatorNS.DecorationType.None);
            this.btnCerrarTarjeta.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarTarjeta.Image")));
            this.btnCerrarTarjeta.ImageActive = null;
            this.btnCerrarTarjeta.Location = new System.Drawing.Point(242, 202);
            this.btnCerrarTarjeta.Name = "btnCerrarTarjeta";
            this.btnCerrarTarjeta.Size = new System.Drawing.Size(34, 23);
            this.btnCerrarTarjeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarTarjeta.TabIndex = 8;
            this.btnCerrarTarjeta.TabStop = false;
            this.btnCerrarTarjeta.Zoom = 10;
            this.btnCerrarTarjeta.Click += new System.EventHandler(this.btnCerrarTarjeta_Click);
            // 
            // btnPrinterLista
            // 
            this.btnPrinterLista.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelListaTrans.SetDecoration(this.btnPrinterLista, BunifuAnimatorNS.DecorationType.None);
            this.btnPrinterLista.Enabled = false;
            this.btnPrinterLista.Image = ((System.Drawing.Image)(resources.GetObject("btnPrinterLista.Image")));
            this.btnPrinterLista.ImageActive = null;
            this.btnPrinterLista.Location = new System.Drawing.Point(202, 202);
            this.btnPrinterLista.Name = "btnPrinterLista";
            this.btnPrinterLista.Size = new System.Drawing.Size(34, 23);
            this.btnPrinterLista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPrinterLista.TabIndex = 7;
            this.btnPrinterLista.TabStop = false;
            this.btnPrinterLista.Zoom = 10;
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 392);
            this.Controls.Add(this.panelLista);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.panelListaTrans.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormUsuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrinter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInserir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.panelLista.ResumeLayout(false);
            this.panelLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarTarjeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrinterLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton btnVolver;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvUsuarios;
        private Bunifu.Framework.UI.BunifuImageButton btnInserir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn alias;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn acceso;
        private System.Windows.Forms.DataGridViewButtonColumn borrar;
        private System.Windows.Forms.DataGridViewButtonColumn modificar;
        private Bunifu.Framework.UI.BunifuImageButton btnPdf;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Panel panelLista;
        private System.Windows.Forms.TextBox tbLista;
        private Bunifu.Framework.UI.BunifuImageButton btnPrinter;
        private BunifuAnimatorNS.BunifuTransition panelListaTrans;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrarTarjeta;
        private Bunifu.Framework.UI.BunifuImageButton btnPrinterLista;
    }
}