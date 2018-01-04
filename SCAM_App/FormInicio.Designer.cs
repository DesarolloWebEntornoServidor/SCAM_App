using Datos_Negocios;
namespace SCAM_App
{
    partial class FormInicio
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sideMenu = new System.Windows.Forms.Panel();
            this.btnGenerarAcceso = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenuBarra = new Bunifu.Framework.UI.BunifuImageButton();
            this.logoMini = new System.Windows.Forms.PictureBox();
            this.btnEmpleados = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDepart = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAccesos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUsuarios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.LogoTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.sideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuBarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // sideMenu
            // 
            this.sideMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sideMenu.Controls.Add(this.btnGenerarAcceso);
            this.sideMenu.Controls.Add(this.btnMenuBarra);
            this.sideMenu.Controls.Add(this.logoMini);
            this.sideMenu.Controls.Add(this.btnEmpleados);
            this.sideMenu.Controls.Add(this.btnDepart);
            this.sideMenu.Controls.Add(this.btnAccesos);
            this.sideMenu.Controls.Add(this.btnUsuarios);
            this.sideMenu.Controls.Add(this.btnMenu);
            this.sideMenu.Controls.Add(this.logo);
            this.PanelAnimator.SetDecoration(this.sideMenu, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.sideMenu, BunifuAnimatorNS.DecorationType.None);
            this.sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenu.Location = new System.Drawing.Point(0, 50);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(191, 449);
            this.sideMenu.TabIndex = 0;
            // 
            // btnGenerarAcceso
            // 
            this.btnGenerarAcceso.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnGenerarAcceso.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGenerarAcceso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerarAcceso.BorderRadius = 0;
            this.btnGenerarAcceso.ButtonText = "   Generar Acceso";
            this.btnGenerarAcceso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnGenerarAcceso, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnGenerarAcceso, BunifuAnimatorNS.DecorationType.None);
            this.btnGenerarAcceso.DisabledColor = System.Drawing.Color.Gray;
            this.btnGenerarAcceso.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGenerarAcceso.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGenerarAcceso.Iconimage")));
            this.btnGenerarAcceso.Iconimage_right = null;
            this.btnGenerarAcceso.Iconimage_right_Selected = null;
            this.btnGenerarAcceso.Iconimage_Selected = null;
            this.btnGenerarAcceso.IconMarginLeft = 0;
            this.btnGenerarAcceso.IconMarginRight = 0;
            this.btnGenerarAcceso.IconRightVisible = true;
            this.btnGenerarAcceso.IconRightZoom = 0D;
            this.btnGenerarAcceso.IconVisible = true;
            this.btnGenerarAcceso.IconZoom = 70D;
            this.btnGenerarAcceso.IsTab = true;
            this.btnGenerarAcceso.Location = new System.Drawing.Point(0, 313);
            this.btnGenerarAcceso.Name = "btnGenerarAcceso";
            this.btnGenerarAcceso.Normalcolor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGenerarAcceso.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGenerarAcceso.OnHoverTextColor = System.Drawing.Color.RoyalBlue;
            this.btnGenerarAcceso.selected = false;
            this.btnGenerarAcceso.Size = new System.Drawing.Size(190, 37);
            this.btnGenerarAcceso.TabIndex = 9;
            this.btnGenerarAcceso.Text = "   Generar Acceso";
            this.btnGenerarAcceso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarAcceso.Textcolor = System.Drawing.Color.Silver;
            this.btnGenerarAcceso.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarAcceso.Click += new System.EventHandler(this.btnGenerarAcceso_Click);
            // 
            // btnMenuBarra
            // 
            this.btnMenuBarra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelAnimator.SetDecoration(this.btnMenuBarra, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnMenuBarra, BunifuAnimatorNS.DecorationType.None);
            this.btnMenuBarra.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuBarra.Image")));
            this.btnMenuBarra.ImageActive = null;
            this.btnMenuBarra.Location = new System.Drawing.Point(12, 10);
            this.btnMenuBarra.Name = "btnMenuBarra";
            this.btnMenuBarra.Size = new System.Drawing.Size(20, 20);
            this.btnMenuBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenuBarra.TabIndex = 8;
            this.btnMenuBarra.TabStop = false;
            this.btnMenuBarra.Visible = false;
            this.btnMenuBarra.Zoom = 10;
            this.btnMenuBarra.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // logoMini
            // 
            this.LogoTransition.SetDecoration(this.logoMini, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.logoMini, BunifuAnimatorNS.DecorationType.None);
            this.logoMini.Image = ((System.Drawing.Image)(resources.GetObject("logoMini.Image")));
            this.logoMini.Location = new System.Drawing.Point(-2, 36);
            this.logoMini.Name = "logoMini";
            this.logoMini.Size = new System.Drawing.Size(51, 37);
            this.logoMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoMini.TabIndex = 7;
            this.logoMini.TabStop = false;
            this.logoMini.Visible = false;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnEmpleados.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmpleados.BorderRadius = 0;
            this.btnEmpleados.ButtonText = "        Empleados";
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnEmpleados, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnEmpleados, BunifuAnimatorNS.DecorationType.None);
            this.btnEmpleados.DisabledColor = System.Drawing.Color.Gray;
            this.btnEmpleados.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmpleados.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Iconimage")));
            this.btnEmpleados.Iconimage_right = null;
            this.btnEmpleados.Iconimage_right_Selected = null;
            this.btnEmpleados.Iconimage_Selected = null;
            this.btnEmpleados.IconMarginLeft = 0;
            this.btnEmpleados.IconMarginRight = 0;
            this.btnEmpleados.IconRightVisible = true;
            this.btnEmpleados.IconRightZoom = 0D;
            this.btnEmpleados.IconVisible = true;
            this.btnEmpleados.IconZoom = 70D;
            this.btnEmpleados.IsTab = true;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 230);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Normalcolor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEmpleados.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEmpleados.OnHoverTextColor = System.Drawing.Color.RoyalBlue;
            this.btnEmpleados.selected = false;
            this.btnEmpleados.Size = new System.Drawing.Size(190, 37);
            this.btnEmpleados.TabIndex = 6;
            this.btnEmpleados.Text = "        Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Textcolor = System.Drawing.Color.Silver;
            this.btnEmpleados.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnDepart
            // 
            this.btnDepart.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnDepart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDepart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDepart.BorderRadius = 0;
            this.btnDepart.ButtonText = "     Departamento";
            this.btnDepart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnDepart, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnDepart, BunifuAnimatorNS.DecorationType.None);
            this.btnDepart.DisabledColor = System.Drawing.Color.Gray;
            this.btnDepart.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDepart.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDepart.Iconimage")));
            this.btnDepart.Iconimage_right = null;
            this.btnDepart.Iconimage_right_Selected = null;
            this.btnDepart.Iconimage_Selected = null;
            this.btnDepart.IconMarginLeft = 0;
            this.btnDepart.IconMarginRight = 0;
            this.btnDepart.IconRightVisible = true;
            this.btnDepart.IconRightZoom = 0D;
            this.btnDepart.IconVisible = true;
            this.btnDepart.IconZoom = 70D;
            this.btnDepart.IsTab = true;
            this.btnDepart.Location = new System.Drawing.Point(0, 187);
            this.btnDepart.Name = "btnDepart";
            this.btnDepart.Normalcolor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDepart.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDepart.OnHoverTextColor = System.Drawing.Color.RoyalBlue;
            this.btnDepart.selected = false;
            this.btnDepart.Size = new System.Drawing.Size(190, 37);
            this.btnDepart.TabIndex = 5;
            this.btnDepart.Text = "     Departamento";
            this.btnDepart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDepart.Textcolor = System.Drawing.Color.Silver;
            this.btnDepart.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepart.Click += new System.EventHandler(this.btnDepart_Click);
            // 
            // btnAccesos
            // 
            this.btnAccesos.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnAccesos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAccesos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccesos.BorderRadius = 0;
            this.btnAccesos.ButtonText = "        Accesos";
            this.btnAccesos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnAccesos, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnAccesos, BunifuAnimatorNS.DecorationType.None);
            this.btnAccesos.DisabledColor = System.Drawing.Color.Gray;
            this.btnAccesos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAccesos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAccesos.Iconimage")));
            this.btnAccesos.Iconimage_right = null;
            this.btnAccesos.Iconimage_right_Selected = null;
            this.btnAccesos.Iconimage_Selected = null;
            this.btnAccesos.IconMarginLeft = 0;
            this.btnAccesos.IconMarginRight = 0;
            this.btnAccesos.IconRightVisible = true;
            this.btnAccesos.IconRightZoom = 0D;
            this.btnAccesos.IconVisible = true;
            this.btnAccesos.IconZoom = 70D;
            this.btnAccesos.IsTab = true;
            this.btnAccesos.Location = new System.Drawing.Point(0, 149);
            this.btnAccesos.Name = "btnAccesos";
            this.btnAccesos.Normalcolor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAccesos.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAccesos.OnHoverTextColor = System.Drawing.Color.RoyalBlue;
            this.btnAccesos.selected = false;
            this.btnAccesos.Size = new System.Drawing.Size(190, 37);
            this.btnAccesos.TabIndex = 4;
            this.btnAccesos.Text = "        Accesos";
            this.btnAccesos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccesos.Textcolor = System.Drawing.Color.Silver;
            this.btnAccesos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccesos.Click += new System.EventHandler(this.btnAccesos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnUsuarios.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuarios.BorderRadius = 0;
            this.btnUsuarios.ButtonText = "        Usuarios";
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnUsuarios, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnUsuarios, BunifuAnimatorNS.DecorationType.None);
            this.btnUsuarios.DisabledColor = System.Drawing.Color.Gray;
            this.btnUsuarios.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUsuarios.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Iconimage")));
            this.btnUsuarios.Iconimage_right = null;
            this.btnUsuarios.Iconimage_right_Selected = null;
            this.btnUsuarios.Iconimage_Selected = null;
            this.btnUsuarios.IconMarginLeft = 0;
            this.btnUsuarios.IconMarginRight = 0;
            this.btnUsuarios.IconRightVisible = true;
            this.btnUsuarios.IconRightZoom = 0D;
            this.btnUsuarios.IconVisible = true;
            this.btnUsuarios.IconZoom = 70D;
            this.btnUsuarios.IsTab = true;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 111);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Normalcolor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUsuarios.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUsuarios.OnHoverTextColor = System.Drawing.Color.RoyalBlue;
            this.btnUsuarios.selected = true;
            this.btnUsuarios.Size = new System.Drawing.Size(190, 37);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "        Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Textcolor = System.Drawing.Color.Silver;
            this.btnUsuarios.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelAnimator.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(165, 6);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(20, 20);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 2;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // logo
            // 
            this.LogoTransition.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(9, 6);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(176, 87);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.header.Controls.Add(this.bunifuImageButton2);
            this.header.Controls.Add(this.bunifuCustomLabel1);
            this.PanelAnimator.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(940, 50);
            this.header.TabIndex = 1;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PanelAnimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(878, 6);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(47, 39);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 4;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 20;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.LogoTransition.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(34, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(232, 20);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Sistema de Controle de Acceso";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel2
            // 
            this.PanelAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(191, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 449);
            this.panel2.TabIndex = 2;
            // 
            // LogoTransition
            // 
            this.LogoTransition.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.LogoTransition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0.5F;
            animation2.RotateLimit = 0.2F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.LogoTransition.DefaultAnimation = animation2;
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.PanelAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 20;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation1;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(940, 499);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sideMenu);
            this.Controls.Add(this.header);
            this.LogoTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInicio";
            this.Text = "FormInicio";
            this.sideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuBarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel sideMenu;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuFlatButton btnUsuarios;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmpleados;
        private Bunifu.Framework.UI.BunifuFlatButton btnDepart;
        private Bunifu.Framework.UI.BunifuFlatButton btnAccesos;
        private System.Windows.Forms.PictureBox logoMini;
        private System.Windows.Forms.Panel panel2;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator;
        private BunifuAnimatorNS.BunifuTransition LogoTransition;
        private Bunifu.Framework.UI.BunifuImageButton btnMenuBarra;
        private Bunifu.Framework.UI.BunifuFlatButton btnGenerarAcceso;
    }
}