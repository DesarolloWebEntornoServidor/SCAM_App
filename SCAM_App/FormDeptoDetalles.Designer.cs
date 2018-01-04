namespace SCAM_App
{
    partial class FormDeptoDetalles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeptoDetalles));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAnadirAcceso = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtIdDepto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCodigosAcceso = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 50);
            this.panel1.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(16, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(207, 21);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "Datos del Departamento";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(491, 6);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 5;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
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
            this.btnAnadirAcceso.ButtonText = "Guardar Departamento";
            this.btnAnadirAcceso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnadirAcceso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirAcceso.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAnadirAcceso.IdleBorderThickness = 1;
            this.btnAnadirAcceso.IdleCornerRadius = 30;
            this.btnAnadirAcceso.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnAnadirAcceso.IdleForecolor = System.Drawing.Color.Silver;
            this.btnAnadirAcceso.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAnadirAcceso.Location = new System.Drawing.Point(176, 303);
            this.btnAnadirAcceso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnadirAcceso.Name = "btnAnadirAcceso";
            this.btnAnadirAcceso.Size = new System.Drawing.Size(203, 42);
            this.btnAnadirAcceso.TabIndex = 14;
            this.btnAnadirAcceso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAnadirAcceso.Click += new System.EventHandler(this.btnAnadirAcceso_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(245, 140);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(220, 20);
            this.txtDescripcion.TabIndex = 13;
            // 
            // txtIdDepto
            // 
            this.txtIdDepto.Location = new System.Drawing.Point(245, 98);
            this.txtIdDepto.Name = "txtIdDepto";
            this.txtIdDepto.Size = new System.Drawing.Size(67, 20);
            this.txtIdDepto.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Código de Acceso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Código";
            // 
            // cbCodigosAcceso
            // 
            this.cbCodigosAcceso.FormattingEnabled = true;
            this.cbCodigosAcceso.Location = new System.Drawing.Point(245, 187);
            this.cbCodigosAcceso.Name = "cbCodigosAcceso";
            this.cbCodigosAcceso.Size = new System.Drawing.Size(220, 21);
            this.cbCodigosAcceso.TabIndex = 15;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormDeptoDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 453);
            this.Controls.Add(this.cbCodigosAcceso);
            this.Controls.Add(this.btnAnadirAcceso);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtIdDepto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDeptoDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormDeptoDetalles";
            this.Load += new System.EventHandler(this.FormDeptoDetalles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAnadirAcceso;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtIdDepto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCodigosAcceso;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}