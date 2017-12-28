namespace SCAM_App
{
    partial class FormAccesoDetalles
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccesoDetalles));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdCodigo = new System.Windows.Forms.TextBox();
            this.txtCodigoAceso = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAnadirAcceso = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.chkBoxParaTodos = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
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
            this.PanelAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 50);
            this.panel1.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.PanelAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(30, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(210, 20);
            this.bunifuCustomLabel1.TabIndex = 4;
            this.bunifuCustomLabel1.Text = "Datos del Código de Acceso";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.PanelAnimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(469, 5);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.PanelAnimator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.PanelAnimator.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código de Acceso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.PanelAnimator.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripción";
            // 
            // txtIdCodigo
            // 
            this.PanelAnimator.SetDecoration(this.txtIdCodigo, BunifuAnimatorNS.DecorationType.None);
            this.txtIdCodigo.Location = new System.Drawing.Point(228, 81);
            this.txtIdCodigo.Name = "txtIdCodigo";
            this.txtIdCodigo.Size = new System.Drawing.Size(67, 20);
            this.txtIdCodigo.TabIndex = 4;
            // 
            // txtCodigoAceso
            // 
            this.PanelAnimator.SetDecoration(this.txtCodigoAceso, BunifuAnimatorNS.DecorationType.None);
            this.txtCodigoAceso.Location = new System.Drawing.Point(228, 120);
            this.txtCodigoAceso.Name = "txtCodigoAceso";
            this.txtCodigoAceso.Size = new System.Drawing.Size(220, 20);
            this.txtCodigoAceso.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            this.PanelAnimator.SetDecoration(this.txtDescripcion, BunifuAnimatorNS.DecorationType.None);
            this.txtDescripcion.Location = new System.Drawing.Point(228, 166);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(220, 20);
            this.txtDescripcion.TabIndex = 6;
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
            this.btnAnadirAcceso.ButtonText = "Guardar Código";
            this.btnAnadirAcceso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnAnadirAcceso, BunifuAnimatorNS.DecorationType.None);
            this.btnAnadirAcceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirAcceso.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAnadirAcceso.IdleBorderThickness = 1;
            this.btnAnadirAcceso.IdleCornerRadius = 30;
            this.btnAnadirAcceso.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnAnadirAcceso.IdleForecolor = System.Drawing.Color.Silver;
            this.btnAnadirAcceso.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAnadirAcceso.Location = new System.Drawing.Point(209, 308);
            this.btnAnadirAcceso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnadirAcceso.Name = "btnAnadirAcceso";
            this.btnAnadirAcceso.Size = new System.Drawing.Size(151, 42);
            this.btnAnadirAcceso.TabIndex = 7;
            this.btnAnadirAcceso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAnadirAcceso.Click += new System.EventHandler(this.btnAnadirAcceso_Click);
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.PanelAnimator.Cursor = null;
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
            this.PanelAnimator.DefaultAnimation = animation1;
            // 
            // chkBoxParaTodos
            // 
            this.chkBoxParaTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkBoxParaTodos.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkBoxParaTodos.Checked = true;
            this.chkBoxParaTodos.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.PanelAnimator.SetDecoration(this.chkBoxParaTodos, BunifuAnimatorNS.DecorationType.None);
            this.chkBoxParaTodos.ForeColor = System.Drawing.Color.White;
            this.chkBoxParaTodos.Location = new System.Drawing.Point(228, 225);
            this.chkBoxParaTodos.Name = "chkBoxParaTodos";
            this.chkBoxParaTodos.Size = new System.Drawing.Size(20, 20);
            this.chkBoxParaTodos.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.PanelAnimator.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Comun a Todos los Empleados";
            // 
            // FormAccesoDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 442);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkBoxParaTodos);
            this.Controls.Add(this.btnAnadirAcceso);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigoAceso);
            this.Controls.Add(this.txtIdCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAccesoDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormAccesoDetalles";
            this.Load += new System.EventHandler(this.FormAccesoDetalles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigoAceso;
        private System.Windows.Forms.TextBox txtIdCodigo;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAnadirAcceso;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuCheckbox chkBoxParaTodos;
    }
}