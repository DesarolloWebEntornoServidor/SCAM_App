namespace SCAM_App
{
    partial class FormEmpleados
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpleados));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInserir = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.dgvEmpleados = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ttelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tarjeta = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelTarjeta = new System.Windows.Forms.Panel();
            this.lbFuncion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbDepartamento = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbNombre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictFotoTarjeta = new System.Windows.Forms.PictureBox();
            this.panelTarjetaTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.btnPrinter = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCerrarTarjeta = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInserir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.panelTarjeta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictFotoTarjeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrinter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarTarjeta)).BeginInit();
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
            this.bunifuGradientPanel1.Controls.Add(this.textBox1);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.btnInserir);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.panelTarjetaTransition.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(930, 70);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.panelTarjetaTransition.SetDecoration(this.textBox1, BunifuAnimatorNS.DecorationType.None);
            this.textBox1.Location = new System.Drawing.Point(25, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelTarjetaTransition.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(173, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelTarjetaTransition.SetDecoration(this.btnInserir, BunifuAnimatorNS.DecorationType.None);
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageActive = null;
            this.btnInserir.Location = new System.Drawing.Point(358, 9);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(53, 56);
            this.btnInserir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInserir.TabIndex = 20;
            this.btnInserir.TabStop = false;
            this.btnInserir.Zoom = 10;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelTarjetaTransition.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(713, 10);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(46, 47);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // dgvEmpleados
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvEmpleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpleados.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.apellidos,
            this.dni,
            this.funcion,
            this.Ttelefono,
            this.email,
            this.departamento,
            this.borrar,
            this.modificar,
            this.tarjeta});
            this.panelTarjetaTransition.SetDecoration(this.dgvEmpleados, BunifuAnimatorNS.DecorationType.None);
            this.dgvEmpleados.DoubleBuffered = true;
            this.dgvEmpleados.EnableHeadersVisualStyles = false;
            this.dgvEmpleados.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvEmpleados.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.dgvEmpleados.HeaderForeColor = System.Drawing.Color.Silver;
            this.dgvEmpleados.Location = new System.Drawing.Point(0, 71);
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(930, 383);
            this.dgvEmpleados.TabIndex = 3;
            this.dgvEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellClick);
            this.dgvEmpleados.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvEmpleados_CellPainting);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Cödigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Visible = false;
            this.codigo.Width = 75;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 106;
            // 
            // apellidos
            // 
            this.apellidos.HeaderText = "Apellidos";
            this.apellidos.Name = "apellidos";
            this.apellidos.ReadOnly = true;
            this.apellidos.Width = 106;
            // 
            // dni
            // 
            this.dni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            this.dni.Width = 70;
            // 
            // funcion
            // 
            this.funcion.HeaderText = "Función";
            this.funcion.Name = "funcion";
            this.funcion.ReadOnly = true;
            this.funcion.Width = 106;
            // 
            // Ttelefono
            // 
            this.Ttelefono.HeaderText = "Teléfono";
            this.Ttelefono.Name = "Ttelefono";
            this.Ttelefono.ReadOnly = true;
            this.Ttelefono.Width = 105;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 106;
            // 
            // departamento
            // 
            this.departamento.HeaderText = "Departamento";
            this.departamento.Name = "departamento";
            this.departamento.ReadOnly = true;
            this.departamento.Width = 106;
            // 
            // borrar
            // 
            this.borrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.borrar.HeaderText = "Borra";
            this.borrar.Name = "borrar";
            this.borrar.ReadOnly = true;
            this.borrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.borrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.borrar.Width = 56;
            // 
            // modificar
            // 
            this.modificar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.modificar.HeaderText = "Edita";
            this.modificar.Name = "modificar";
            this.modificar.ReadOnly = true;
            this.modificar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.modificar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.modificar.Width = 63;
            // 
            // tarjeta
            // 
            this.tarjeta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tarjeta.HeaderText = "Genera";
            this.tarjeta.Name = "tarjeta";
            this.tarjeta.ReadOnly = true;
            this.tarjeta.Width = 65;
            // 
            // panelTarjeta
            // 
            this.panelTarjeta.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panelTarjeta.Controls.Add(this.lbFuncion);
            this.panelTarjeta.Controls.Add(this.panelResultado);
            this.panelTarjeta.Controls.Add(this.pictureBox2);
            this.panelTarjeta.Controls.Add(this.lbDepartamento);
            this.panelTarjeta.Controls.Add(this.lbNombre);
            this.panelTarjeta.Controls.Add(this.pictFotoTarjeta);
            this.panelTarjetaTransition.SetDecoration(this.panelTarjeta, BunifuAnimatorNS.DecorationType.None);
            this.panelTarjeta.Location = new System.Drawing.Point(229, 119);
            this.panelTarjeta.Name = "panelTarjeta";
            this.panelTarjeta.Size = new System.Drawing.Size(438, 265);
            this.panelTarjeta.TabIndex = 4;
            // 
            // lbFuncion
            // 
            this.lbFuncion.AutoSize = true;
            this.panelTarjetaTransition.SetDecoration(this.lbFuncion, BunifuAnimatorNS.DecorationType.None);
            this.lbFuncion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFuncion.Location = new System.Drawing.Point(23, 116);
            this.lbFuncion.Name = "lbFuncion";
            this.lbFuncion.Size = new System.Drawing.Size(135, 16);
            this.lbFuncion.TabIndex = 7;
            this.lbFuncion.Text = "labelDepartamento";
            // 
            // panelResultado
            // 
            this.panelTarjetaTransition.SetDecoration(this.panelResultado, BunifuAnimatorNS.DecorationType.None);
            this.panelResultado.Location = new System.Drawing.Point(19, 158);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(400, 100);
            this.panelResultado.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.panelTarjetaTransition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // lbDepartamento
            // 
            this.lbDepartamento.AutoSize = true;
            this.panelTarjetaTransition.SetDecoration(this.lbDepartamento, BunifuAnimatorNS.DecorationType.None);
            this.lbDepartamento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartamento.Location = new System.Drawing.Point(23, 133);
            this.lbDepartamento.Name = "lbDepartamento";
            this.lbDepartamento.Size = new System.Drawing.Size(135, 16);
            this.lbDepartamento.TabIndex = 3;
            this.lbDepartamento.Text = "labelDepartamento";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.panelTarjetaTransition.SetDecoration(this.lbNombre, BunifuAnimatorNS.DecorationType.None);
            this.lbNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbNombre.Location = new System.Drawing.Point(23, 95);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(113, 19);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "labelNombre";
            // 
            // pictFotoTarjeta
            // 
            this.panelTarjetaTransition.SetDecoration(this.pictFotoTarjeta, BunifuAnimatorNS.DecorationType.None);
            this.pictFotoTarjeta.Location = new System.Drawing.Point(317, 23);
            this.pictFotoTarjeta.Name = "pictFotoTarjeta";
            this.pictFotoTarjeta.Size = new System.Drawing.Size(100, 122);
            this.pictFotoTarjeta.TabIndex = 0;
            this.pictFotoTarjeta.TabStop = false;
            // 
            // panelTarjetaTransition
            // 
            this.panelTarjetaTransition.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.panelTarjetaTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.panelTarjetaTransition.DefaultAnimation = animation1;
            // 
            // btnPrinter
            // 
            this.btnPrinter.BackColor = System.Drawing.Color.GhostWhite;
            this.panelTarjetaTransition.SetDecoration(this.btnPrinter, BunifuAnimatorNS.DecorationType.None);
            this.btnPrinter.Enabled = false;
            this.btnPrinter.Image = ((System.Drawing.Image)(resources.GetObject("btnPrinter.Image")));
            this.btnPrinter.ImageActive = null;
            this.btnPrinter.Location = new System.Drawing.Point(382, 391);
            this.btnPrinter.Name = "btnPrinter";
            this.btnPrinter.Size = new System.Drawing.Size(48, 41);
            this.btnPrinter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPrinter.TabIndex = 5;
            this.btnPrinter.TabStop = false;
            this.btnPrinter.Zoom = 10;
            // 
            // btnCerrarTarjeta
            // 
            this.btnCerrarTarjeta.BackColor = System.Drawing.Color.GhostWhite;
            this.panelTarjetaTransition.SetDecoration(this.btnCerrarTarjeta, BunifuAnimatorNS.DecorationType.None);
            this.btnCerrarTarjeta.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarTarjeta.Image")));
            this.btnCerrarTarjeta.ImageActive = null;
            this.btnCerrarTarjeta.Location = new System.Drawing.Point(447, 391);
            this.btnCerrarTarjeta.Name = "btnCerrarTarjeta";
            this.btnCerrarTarjeta.Size = new System.Drawing.Size(48, 41);
            this.btnCerrarTarjeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarTarjeta.TabIndex = 6;
            this.btnCerrarTarjeta.TabStop = false;
            this.btnCerrarTarjeta.Zoom = 10;
            this.btnCerrarTarjeta.Click += new System.EventHandler(this.btnCerrarTarjeta_Click);
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 458);
            this.Controls.Add(this.btnCerrarTarjeta);
            this.Controls.Add(this.btnPrinter);
            this.Controls.Add(this.panelTarjeta);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.dgvEmpleados);
            this.panelTarjetaTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormEmpleados";
            this.Load += new System.EventHandler(this.FormEmpleados_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInserir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.panelTarjeta.ResumeLayout(false);
            this.panelTarjeta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictFotoTarjeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrinter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarTarjeta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvEmpleados;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton btnInserir;
        private System.Windows.Forms.Panel panelTarjeta;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel lbDepartamento;
        private Bunifu.Framework.UI.BunifuCustomLabel lbNombre;
        private System.Windows.Forms.PictureBox pictFotoTarjeta;
        private BunifuAnimatorNS.BunifuTransition panelTarjetaTransition;
        private Bunifu.Framework.UI.BunifuCustomLabel lbFuncion;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrarTarjeta;
        private Bunifu.Framework.UI.BunifuImageButton btnPrinter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ttelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamento;
        private System.Windows.Forms.DataGridViewButtonColumn borrar;
        private System.Windows.Forms.DataGridViewButtonColumn modificar;
        private System.Windows.Forms.DataGridViewButtonColumn tarjeta;
    }
}