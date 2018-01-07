namespace SCAM_App
{
    partial class FormAccesosEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccesosEmpleados));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcel = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPdf = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnInserir = new Bunifu.Framework.UI.BunifuImageButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.dgvAccesoEmpleado = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoAcceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.panelLista = new System.Windows.Forms.Panel();
            this.btnCerrarCod = new Bunifu.Framework.UI.BunifuImageButton();
            this.tbLista = new System.Windows.Forms.TextBox();
            this.btnPrinterLista = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPrinterCodLista = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelListaTrans = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInserir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccesoEmpleado)).BeginInit();
            this.panelLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarCod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrinterLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrinterCodLista)).BeginInit();
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
            this.panel1.Controls.Add(this.btnExcel);
            this.panel1.Controls.Add(this.btnPdf);
            this.panel1.Controls.Add(this.btnInserir);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panelListaTrans.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 74);
            this.panel1.TabIndex = 0;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelListaTrans.SetDecoration(this.btnExcel, BunifuAnimatorNS.DecorationType.None);
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageActive = null;
            this.btnExcel.Location = new System.Drawing.Point(412, 12);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(45, 51);
            this.btnExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExcel.TabIndex = 26;
            this.btnExcel.TabStop = false;
            this.btnExcel.Zoom = 10;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelListaTrans.SetDecoration(this.btnPdf, BunifuAnimatorNS.DecorationType.None);
            this.btnPdf.Image = ((System.Drawing.Image)(resources.GetObject("btnPdf.Image")));
            this.btnPdf.ImageActive = null;
            this.btnPdf.Location = new System.Drawing.Point(349, 12);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(45, 51);
            this.btnPdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPdf.TabIndex = 25;
            this.btnPdf.TabStop = false;
            this.btnPdf.Zoom = 10;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelListaTrans.SetDecoration(this.btnInserir, BunifuAnimatorNS.DecorationType.None);
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageActive = null;
            this.btnInserir.Location = new System.Drawing.Point(217, 6);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(53, 56);
            this.btnInserir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInserir.TabIndex = 13;
            this.btnInserir.TabStop = false;
            this.btnInserir.Zoom = 10;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // textBox1
            // 
            this.panelListaTrans.SetDecoration(this.textBox1, BunifuAnimatorNS.DecorationType.None);
            this.textBox1.Location = new System.Drawing.Point(12, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelListaTrans.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(160, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelListaTrans.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(477, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(55, 42);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 11;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // dgvAccesoEmpleado
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAccesoEmpleado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccesoEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAccesoEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvAccesoEmpleado.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvAccesoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAccesoEmpleado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccesoEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAccesoEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.empleado,
            this.codigoAcceso,
            this.borrar});
            this.panelListaTrans.SetDecoration(this.dgvAccesoEmpleado, BunifuAnimatorNS.DecorationType.None);
            this.dgvAccesoEmpleado.DoubleBuffered = true;
            this.dgvAccesoEmpleado.EnableHeadersVisualStyles = false;
            this.dgvAccesoEmpleado.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvAccesoEmpleado.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.dgvAccesoEmpleado.HeaderForeColor = System.Drawing.Color.Silver;
            this.dgvAccesoEmpleado.Location = new System.Drawing.Point(0, 74);
            this.dgvAccesoEmpleado.MultiSelect = false;
            this.dgvAccesoEmpleado.Name = "dgvAccesoEmpleado";
            this.dgvAccesoEmpleado.ReadOnly = true;
            this.dgvAccesoEmpleado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAccesoEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccesoEmpleado.Size = new System.Drawing.Size(567, 355);
            this.dgvAccesoEmpleado.TabIndex = 8;
            this.dgvAccesoEmpleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccesoEmpleado_CellClick);
            this.dgvAccesoEmpleado.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvAccesoEmpleado_CellPainting_1);
            // 
            // codigo
            // 
            this.codigo.FillWeight = 50F;
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 69;
            // 
            // empleado
            // 
            this.empleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.empleado.HeaderText = "Empleado";
            this.empleado.Name = "empleado";
            this.empleado.ReadOnly = true;
            this.empleado.Width = 87;
            // 
            // codigoAcceso
            // 
            this.codigoAcceso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.codigoAcceso.HeaderText = "Nivel de Acceso";
            this.codigoAcceso.Name = "codigoAcceso";
            this.codigoAcceso.ReadOnly = true;
            this.codigoAcceso.Width = 116;
            // 
            // borrar
            // 
            this.borrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.borrar.FillWeight = 50F;
            this.borrar.HeaderText = "Borra";
            this.borrar.Name = "borrar";
            this.borrar.ReadOnly = true;
            this.borrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.borrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.borrar.Text = "";
            this.borrar.Width = 53;
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 20;
            // 
            // panelLista
            // 
            this.panelLista.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelLista.Controls.Add(this.btnCerrarCod);
            this.panelLista.Controls.Add(this.tbLista);
            this.panelLista.Controls.Add(this.btnPrinterLista);
            this.panelListaTrans.SetDecoration(this.panelLista, BunifuAnimatorNS.DecorationType.None);
            this.panelLista.Location = new System.Drawing.Point(100, 105);
            this.panelLista.Name = "panelLista";
            this.panelLista.Size = new System.Drawing.Size(379, 236);
            this.panelLista.TabIndex = 30;
            // 
            // btnCerrarCod
            // 
            this.btnCerrarCod.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelListaTrans.SetDecoration(this.btnCerrarCod, BunifuAnimatorNS.DecorationType.None);
            this.btnCerrarCod.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarCod.Image")));
            this.btnCerrarCod.ImageActive = null;
            this.btnCerrarCod.Location = new System.Drawing.Point(242, 202);
            this.btnCerrarCod.Name = "btnCerrarCod";
            this.btnCerrarCod.Size = new System.Drawing.Size(34, 23);
            this.btnCerrarCod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarCod.TabIndex = 8;
            this.btnCerrarCod.TabStop = false;
            this.btnCerrarCod.Zoom = 10;
            this.btnCerrarCod.Click += new System.EventHandler(this.btnCerrarCod_Click);
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
            // btnPrinterCodLista
            // 
            this.btnPrinterCodLista.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelListaTrans.SetDecoration(this.btnPrinterCodLista, BunifuAnimatorNS.DecorationType.None);
            this.btnPrinterCodLista.Image = ((System.Drawing.Image)(resources.GetObject("btnPrinterCodLista.Image")));
            this.btnPrinterCodLista.ImageActive = null;
            this.btnPrinterCodLista.Location = new System.Drawing.Point(289, 11);
            this.btnPrinterCodLista.Name = "btnPrinterCodLista";
            this.btnPrinterCodLista.Size = new System.Drawing.Size(45, 51);
            this.btnPrinterCodLista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPrinterCodLista.TabIndex = 31;
            this.btnPrinterCodLista.TabStop = false;
            this.btnPrinterCodLista.Zoom = 10;
            this.btnPrinterCodLista.Click += new System.EventHandler(this.btnPrinterCodLista_Click);
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
            // FormAccesosEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 435);
            this.Controls.Add(this.panelLista);
            this.Controls.Add(this.btnPrinterCodLista);
            this.Controls.Add(this.dgvAccesoEmpleado);
            this.Controls.Add(this.panel1);
            this.panelListaTrans.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAccesosEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormAccesosEmpleados";
            this.Load += new System.EventHandler(this.FormAccesosEmpleados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInserir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccesoEmpleado)).EndInit();
            this.panelLista.ResumeLayout(false);
            this.panelLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarCod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrinterLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrinterCodLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvAccesoEmpleado;
        private System.Windows.Forms.TextBox textBox1;
        private Bunifu.Framework.UI.BunifuImageButton btnInserir;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoAcceso;
        private System.Windows.Forms.DataGridViewButtonColumn borrar;
        private Bunifu.Framework.UI.BunifuImageButton btnExcel;
        private Bunifu.Framework.UI.BunifuImageButton btnPdf;
        private System.Windows.Forms.Panel panelLista;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrarCod;
        private System.Windows.Forms.TextBox tbLista;
        private Bunifu.Framework.UI.BunifuImageButton btnPrinterLista;
        private Bunifu.Framework.UI.BunifuImageButton btnPrinterCodLista;
        private BunifuAnimatorNS.BunifuTransition panelListaTrans;
    }
}