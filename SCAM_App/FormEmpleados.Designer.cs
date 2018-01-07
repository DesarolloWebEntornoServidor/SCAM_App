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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpleados));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnExcel = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPdf = new Bunifu.Framework.UI.BunifuImageButton();
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
            this.panelLista = new System.Windows.Forms.Panel();
            this.btnCerraLista = new Bunifu.Framework.UI.BunifuImageButton();
            this.tbLista = new System.Windows.Forms.TextBox();
            this.btnPrinterLista = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPrinterEmpLista = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelListaTrans = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInserir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.panelTarjeta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictFotoTarjeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrinter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarTarjeta)).BeginInit();
            this.panelLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerraLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrinterLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrinterEmpLista)).BeginInit();
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
            this.bunifuGradientPanel1.Controls.Add(this.btnPrinterEmpLista);
            this.bunifuGradientPanel1.Controls.Add(this.btnExcel);
            this.bunifuGradientPanel1.Controls.Add(this.btnPdf);
            this.bunifuGradientPanel1.Controls.Add(this.textBox1);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.btnInserir);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.panelListaTrans.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
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
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelListaTrans.SetDecoration(this.btnExcel, BunifuAnimatorNS.DecorationType.None);
            this.panelTarjetaTransition.SetDecoration(this.btnExcel, BunifuAnimatorNS.DecorationType.None);
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageActive = null;
            this.btnExcel.Location = new System.Drawing.Point(476, 10);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(45, 51);
            this.btnExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExcel.TabIndex = 24;
            this.btnExcel.TabStop = false;
            this.btnExcel.Zoom = 10;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelListaTrans.SetDecoration(this.btnPdf, BunifuAnimatorNS.DecorationType.None);
            this.panelTarjetaTransition.SetDecoration(this.btnPdf, BunifuAnimatorNS.DecorationType.None);
            this.btnPdf.Image = ((System.Drawing.Image)(resources.GetObject("btnPdf.Image")));
            this.btnPdf.ImageActive = null;
            this.btnPdf.Location = new System.Drawing.Point(536, 10);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(45, 51);
            this.btnPdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPdf.TabIndex = 23;
            this.btnPdf.TabStop = false;
            this.btnPdf.Zoom = 10;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // textBox1
            // 
            this.panelTarjetaTransition.SetDecoration(this.textBox1, BunifuAnimatorNS.DecorationType.None);
            this.panelListaTrans.SetDecoration(this.textBox1, BunifuAnimatorNS.DecorationType.None);
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
            this.panelListaTrans.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
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
            this.panelListaTrans.SetDecoration(this.btnInserir, BunifuAnimatorNS.DecorationType.None);
            this.panelTarjetaTransition.SetDecoration(this.btnInserir, BunifuAnimatorNS.DecorationType.None);
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageActive = null;
            this.btnInserir.Location = new System.Drawing.Point(277, 9);
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
            this.panelListaTrans.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
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
            this.panelListaTrans.SetDecoration(this.dgvEmpleados, BunifuAnimatorNS.DecorationType.None);
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
            this.panelListaTrans.SetDecoration(this.panelTarjeta, BunifuAnimatorNS.DecorationType.None);
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
            this.panelListaTrans.SetDecoration(this.lbFuncion, BunifuAnimatorNS.DecorationType.None);
            this.lbFuncion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFuncion.Location = new System.Drawing.Point(23, 116);
            this.lbFuncion.Name = "lbFuncion";
            this.lbFuncion.Size = new System.Drawing.Size(135, 16);
            this.lbFuncion.TabIndex = 7;
            this.lbFuncion.Text = "labelDepartamento";
            // 
            // panelResultado
            // 
            this.panelListaTrans.SetDecoration(this.panelResultado, BunifuAnimatorNS.DecorationType.None);
            this.panelTarjetaTransition.SetDecoration(this.panelResultado, BunifuAnimatorNS.DecorationType.None);
            this.panelResultado.Location = new System.Drawing.Point(19, 158);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(400, 100);
            this.panelResultado.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.panelTarjetaTransition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.panelListaTrans.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
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
            this.panelListaTrans.SetDecoration(this.lbDepartamento, BunifuAnimatorNS.DecorationType.None);
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
            this.panelListaTrans.SetDecoration(this.lbNombre, BunifuAnimatorNS.DecorationType.None);
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
            this.panelListaTrans.SetDecoration(this.pictFotoTarjeta, BunifuAnimatorNS.DecorationType.None);
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
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.panelTarjetaTransition.DefaultAnimation = animation2;
            // 
            // btnPrinter
            // 
            this.btnPrinter.BackColor = System.Drawing.Color.GhostWhite;
            this.panelListaTrans.SetDecoration(this.btnPrinter, BunifuAnimatorNS.DecorationType.None);
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
            this.btnPrinter.Click += new System.EventHandler(this.btnPrinter_Click);
            // 
            // btnCerrarTarjeta
            // 
            this.btnCerrarTarjeta.BackColor = System.Drawing.Color.GhostWhite;
            this.panelListaTrans.SetDecoration(this.btnCerrarTarjeta, BunifuAnimatorNS.DecorationType.None);
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
            // panelLista
            // 
            this.panelLista.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelLista.Controls.Add(this.btnCerraLista);
            this.panelLista.Controls.Add(this.tbLista);
            this.panelLista.Controls.Add(this.btnPrinterLista);
            this.panelListaTrans.SetDecoration(this.panelLista, BunifuAnimatorNS.DecorationType.None);
            this.panelTarjetaTransition.SetDecoration(this.panelLista, BunifuAnimatorNS.DecorationType.None);
            this.panelLista.Location = new System.Drawing.Point(83, 111);
            this.panelLista.Name = "panelLista";
            this.panelLista.Size = new System.Drawing.Size(676, 236);
            this.panelLista.TabIndex = 7;
            // 
            // btnCerraLista
            // 
            this.btnCerraLista.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelListaTrans.SetDecoration(this.btnCerraLista, BunifuAnimatorNS.DecorationType.None);
            this.panelTarjetaTransition.SetDecoration(this.btnCerraLista, BunifuAnimatorNS.DecorationType.None);
            this.btnCerraLista.Image = ((System.Drawing.Image)(resources.GetObject("btnCerraLista.Image")));
            this.btnCerraLista.ImageActive = null;
            this.btnCerraLista.Location = new System.Drawing.Point(242, 202);
            this.btnCerraLista.Name = "btnCerraLista";
            this.btnCerraLista.Size = new System.Drawing.Size(34, 23);
            this.btnCerraLista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerraLista.TabIndex = 8;
            this.btnCerraLista.TabStop = false;
            this.btnCerraLista.Zoom = 10;
            this.btnCerraLista.Click += new System.EventHandler(this.btnCerraLista_Click);
            // 
            // tbLista
            // 
            this.tbLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panelTarjetaTransition.SetDecoration(this.tbLista, BunifuAnimatorNS.DecorationType.None);
            this.panelListaTrans.SetDecoration(this.tbLista, BunifuAnimatorNS.DecorationType.None);
            this.tbLista.Location = new System.Drawing.Point(14, 12);
            this.tbLista.Multiline = true;
            this.tbLista.Name = "tbLista";
            this.tbLista.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLista.Size = new System.Drawing.Size(646, 184);
            this.tbLista.TabIndex = 3;
            // 
            // btnPrinterLista
            // 
            this.btnPrinterLista.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelListaTrans.SetDecoration(this.btnPrinterLista, BunifuAnimatorNS.DecorationType.None);
            this.panelTarjetaTransition.SetDecoration(this.btnPrinterLista, BunifuAnimatorNS.DecorationType.None);
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
            // btnPrinterEmpLista
            // 
            this.btnPrinterEmpLista.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelListaTrans.SetDecoration(this.btnPrinterEmpLista, BunifuAnimatorNS.DecorationType.None);
            this.panelTarjetaTransition.SetDecoration(this.btnPrinterEmpLista, BunifuAnimatorNS.DecorationType.None);
            this.btnPrinterEmpLista.Image = ((System.Drawing.Image)(resources.GetObject("btnPrinterEmpLista.Image")));
            this.btnPrinterEmpLista.ImageActive = null;
            this.btnPrinterEmpLista.Location = new System.Drawing.Point(413, 10);
            this.btnPrinterEmpLista.Name = "btnPrinterEmpLista";
            this.btnPrinterEmpLista.Size = new System.Drawing.Size(45, 51);
            this.btnPrinterEmpLista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPrinterEmpLista.TabIndex = 25;
            this.btnPrinterEmpLista.TabStop = false;
            this.btnPrinterEmpLista.Zoom = 10;
            this.btnPrinterEmpLista.Click += new System.EventHandler(this.btnPrinterEmpLista_Click);
            // 
            // panelListaTrans
            // 
            this.panelListaTrans.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.panelListaTrans.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
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
            this.panelListaTrans.DefaultAnimation = animation1;
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 458);
            this.Controls.Add(this.panelLista);
            this.Controls.Add(this.btnCerrarTarjeta);
            this.Controls.Add(this.btnPrinter);
            this.Controls.Add(this.panelTarjeta);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.dgvEmpleados);
            this.panelTarjetaTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.panelListaTrans.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormEmpleados";
            this.Load += new System.EventHandler(this.FormEmpleados_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPdf)).EndInit();
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
            this.panelLista.ResumeLayout(false);
            this.panelLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerraLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrinterLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrinterEmpLista)).EndInit();
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
        private Bunifu.Framework.UI.BunifuImageButton btnExcel;
        private Bunifu.Framework.UI.BunifuImageButton btnPdf;
        private System.Windows.Forms.Panel panelLista;
        private Bunifu.Framework.UI.BunifuImageButton btnCerraLista;
        private System.Windows.Forms.TextBox tbLista;
        private Bunifu.Framework.UI.BunifuImageButton btnPrinterLista;
        private Bunifu.Framework.UI.BunifuImageButton btnPrinterEmpLista;
        private BunifuAnimatorNS.BunifuTransition panelListaTrans;
    }
}