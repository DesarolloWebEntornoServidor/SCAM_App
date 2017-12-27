namespace SCAM_App
{
    partial class FormAccesoEmpDetalles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccesoEmpDetalles));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdDepto = new System.Windows.Forms.TextBox();
            this.btnAnadirAcceso = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cbEmpleado = new System.Windows.Forms.ComboBox();
            this.chkListCodiAcceso = new System.Windows.Forms.CheckedListBox();
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
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
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 50);
            this.panel1.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(16, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(276, 20);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "Asignar Acceso a los  Departamentos";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(480, 4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(42, 41);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 7;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nivel de Acceso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Empleado";
            // 
            // txtIdDepto
            // 
            this.bunifuTransition1.SetDecoration(this.txtIdDepto, BunifuAnimatorNS.DecorationType.None);
            this.txtIdDepto.Location = new System.Drawing.Point(214, 75);
            this.txtIdDepto.Name = "txtIdDepto";
            this.txtIdDepto.Size = new System.Drawing.Size(67, 20);
            this.txtIdDepto.TabIndex = 19;
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
            this.bunifuTransition1.SetDecoration(this.btnAnadirAcceso, BunifuAnimatorNS.DecorationType.None);
            this.btnAnadirAcceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirAcceso.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAnadirAcceso.IdleBorderThickness = 1;
            this.btnAnadirAcceso.IdleCornerRadius = 30;
            this.btnAnadirAcceso.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnAnadirAcceso.IdleForecolor = System.Drawing.Color.Silver;
            this.btnAnadirAcceso.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAnadirAcceso.Location = new System.Drawing.Point(189, 293);
            this.btnAnadirAcceso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnadirAcceso.Name = "btnAnadirAcceso";
            this.btnAnadirAcceso.Size = new System.Drawing.Size(151, 42);
            this.btnAnadirAcceso.TabIndex = 21;
            this.btnAnadirAcceso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAnadirAcceso.Click += new System.EventHandler(this.btnAnadirAcceso_Click);
            // 
            // cbEmpleado
            // 
            this.bunifuTransition1.SetDecoration(this.cbEmpleado, BunifuAnimatorNS.DecorationType.None);
            this.cbEmpleado.FormattingEnabled = true;
            this.cbEmpleado.Location = new System.Drawing.Point(214, 118);
            this.cbEmpleado.Name = "cbEmpleado";
            this.cbEmpleado.Size = new System.Drawing.Size(220, 21);
            this.cbEmpleado.TabIndex = 23;
            this.cbEmpleado.SelectedIndexChanged += new System.EventHandler(this.cbEmpleado_SelectedIndexChanged);
            // 
            // chkListCodiAcceso
            // 
            this.chkListCodiAcceso.CheckOnClick = true;
            this.bunifuTransition1.SetDecoration(this.chkListCodiAcceso, BunifuAnimatorNS.DecorationType.None);
            this.chkListCodiAcceso.FormattingEnabled = true;
            this.chkListCodiAcceso.Location = new System.Drawing.Point(214, 166);
            this.chkListCodiAcceso.Name = "chkListCodiAcceso";
            this.chkListCodiAcceso.Size = new System.Drawing.Size(220, 109);
            this.chkListCodiAcceso.TabIndex = 24;
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 20;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // FormAccesoEmpDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 363);
            this.Controls.Add(this.chkListCodiAcceso);
            this.Controls.Add(this.cbEmpleado);
            this.Controls.Add(this.btnAnadirAcceso);
            this.Controls.Add(this.txtIdDepto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAccesoEmpDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormAccesoEmpDetalles";
            this.Load += new System.EventHandler(this.FormAccesoEmpDetalles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.ComboBox cbEmpleado;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAnadirAcceso;
        private System.Windows.Forms.TextBox txtIdDepto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chkListCodiAcceso;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
    }
}