namespace SCAM_App
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lbMensaje = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLoginL = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnRegistrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.slideA = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbPassReg = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbUsuarioReg = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbAlias = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbNombre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.slideB = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tbPass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbUsuario = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.slideA.SuspendLayout();
            this.slideB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lbMensaje, BunifuAnimatorNS.DecorationType.None);
            this.lbMensaje.Location = new System.Drawing.Point(152, 25);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(0, 13);
            this.lbMensaje.TabIndex = 5;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 1;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SlateGray;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SlateGray;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.SteelBlue;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Registrar";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuThinButton21, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 1;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.SteelBlue;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.bunifuThinButton21.Location = new System.Drawing.Point(105, 40);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(132, 53);
            this.bunifuThinButton21.TabIndex = 7;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // btnLoginL
            // 
            this.btnLoginL.ActiveBorderThickness = 1;
            this.btnLoginL.ActiveCornerRadius = 1;
            this.btnLoginL.ActiveFillColor = System.Drawing.Color.SlateGray;
            this.btnLoginL.ActiveForecolor = System.Drawing.Color.White;
            this.btnLoginL.ActiveLineColor = System.Drawing.Color.SlateGray;
            this.btnLoginL.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLoginL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoginL.BackgroundImage")));
            this.btnLoginL.ButtonText = "Login";
            this.btnLoginL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnLoginL, BunifuAnimatorNS.DecorationType.None);
            this.btnLoginL.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginL.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLoginL.IdleBorderThickness = 1;
            this.btnLoginL.IdleCornerRadius = 1;
            this.btnLoginL.IdleFillColor = System.Drawing.Color.SteelBlue;
            this.btnLoginL.IdleForecolor = System.Drawing.Color.White;
            this.btnLoginL.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnLoginL.Location = new System.Drawing.Point(238, 40);
            this.btnLoginL.Margin = new System.Windows.Forms.Padding(5);
            this.btnLoginL.Name = "btnLoginL";
            this.btnLoginL.Size = new System.Drawing.Size(132, 53);
            this.btnLoginL.TabIndex = 8;
            this.btnLoginL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLoginL.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.ActiveBorderThickness = 1;
            this.btnRegistrar.ActiveCornerRadius = 1;
            this.btnRegistrar.ActiveFillColor = System.Drawing.Color.Green;
            this.btnRegistrar.ActiveForecolor = System.Drawing.Color.White;
            this.btnRegistrar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnRegistrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRegistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.BackgroundImage")));
            this.btnRegistrar.ButtonText = "Registrar";
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnRegistrar, BunifuAnimatorNS.DecorationType.None);
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnRegistrar.IdleBorderThickness = 1;
            this.btnRegistrar.IdleCornerRadius = 1;
            this.btnRegistrar.IdleFillColor = System.Drawing.Color.Green;
            this.btnRegistrar.IdleForecolor = System.Drawing.Color.Silver;
            this.btnRegistrar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnRegistrar.Location = new System.Drawing.Point(35, 307);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(329, 53);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // slideA
            // 
            this.slideA.Controls.Add(this.bunifuCustomLabel5);
            this.slideA.Controls.Add(this.btnRegistrar);
            this.slideA.Controls.Add(this.tbPassReg);
            this.slideA.Controls.Add(this.bunifuCustomLabel4);
            this.slideA.Controls.Add(this.tbUsuarioReg);
            this.slideA.Controls.Add(this.bunifuCustomLabel3);
            this.slideA.Controls.Add(this.tbAlias);
            this.slideA.Controls.Add(this.bunifuCustomLabel2);
            this.slideA.Controls.Add(this.tbNombre);
            this.slideA.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuTransition1.SetDecoration(this.slideA, BunifuAnimatorNS.DecorationType.None);
            this.slideA.Location = new System.Drawing.Point(36, 101);
            this.slideA.Name = "slideA";
            this.slideA.Size = new System.Drawing.Size(401, 388);
            this.slideA.TabIndex = 10;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(25, 193);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(69, 17);
            this.bunifuCustomLabel5.TabIndex = 8;
            this.bunifuCustomLabel5.Text = "Password";
            // 
            // tbPassReg
            // 
            this.tbPassReg.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbPassReg.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPassReg.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.tbPassReg.BorderThickness = 2;
            this.tbPassReg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.tbPassReg, BunifuAnimatorNS.DecorationType.None);
            this.tbPassReg.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbPassReg.ForeColor = System.Drawing.Color.Silver;
            this.tbPassReg.isPassword = true;
            this.tbPassReg.Location = new System.Drawing.Point(17, 214);
            this.tbPassReg.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassReg.Name = "tbPassReg";
            this.tbPassReg.Size = new System.Drawing.Size(366, 35);
            this.tbPassReg.TabIndex = 7;
            this.tbPassReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(25, 123);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(54, 17);
            this.bunifuCustomLabel4.TabIndex = 6;
            this.bunifuCustomLabel4.Text = "Usuario";
            // 
            // tbUsuarioReg
            // 
            this.tbUsuarioReg.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbUsuarioReg.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUsuarioReg.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.tbUsuarioReg.BorderThickness = 2;
            this.tbUsuarioReg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.tbUsuarioReg, BunifuAnimatorNS.DecorationType.None);
            this.tbUsuarioReg.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbUsuarioReg.ForeColor = System.Drawing.Color.Silver;
            this.tbUsuarioReg.isPassword = false;
            this.tbUsuarioReg.Location = new System.Drawing.Point(17, 144);
            this.tbUsuarioReg.Margin = new System.Windows.Forms.Padding(4);
            this.tbUsuarioReg.Name = "tbUsuarioReg";
            this.tbUsuarioReg.Size = new System.Drawing.Size(366, 35);
            this.tbUsuarioReg.TabIndex = 5;
            this.tbUsuarioReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(203, 52);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(37, 17);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Alias";
            // 
            // tbAlias
            // 
            this.tbAlias.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbAlias.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbAlias.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.tbAlias.BorderThickness = 2;
            this.tbAlias.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.tbAlias, BunifuAnimatorNS.DecorationType.None);
            this.tbAlias.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbAlias.ForeColor = System.Drawing.Color.Silver;
            this.tbAlias.isPassword = false;
            this.tbAlias.Location = new System.Drawing.Point(202, 73);
            this.tbAlias.Margin = new System.Windows.Forms.Padding(4);
            this.tbAlias.Name = "tbAlias";
            this.tbAlias.Size = new System.Drawing.Size(181, 35);
            this.tbAlias.TabIndex = 3;
            this.tbAlias.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(25, 52);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(61, 17);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbNombre.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNombre.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.tbNombre.BorderThickness = 2;
            this.tbNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.tbNombre, BunifuAnimatorNS.DecorationType.None);
            this.tbNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbNombre.ForeColor = System.Drawing.Color.Silver;
            this.tbNombre.isPassword = false;
            this.tbNombre.Location = new System.Drawing.Point(17, 73);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(172, 35);
            this.tbNombre.TabIndex = 1;
            this.tbNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(64, 11);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(263, 22);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Darse de Alta como Usuario";
            // 
            // slideB
            // 
            this.slideB.Controls.Add(this.bunifuCustomLabel6);
            this.slideB.Controls.Add(this.btnLogin);
            this.slideB.Controls.Add(this.tbPass);
            this.slideB.Controls.Add(this.bunifuCustomLabel7);
            this.slideB.Controls.Add(this.tbUsuario);
            this.slideB.Controls.Add(this.bunifuCustomLabel10);
            this.bunifuTransition1.SetDecoration(this.slideB, BunifuAnimatorNS.DecorationType.None);
            this.slideB.Location = new System.Drawing.Point(494, 101);
            this.slideB.Name = "slideB";
            this.slideB.Size = new System.Drawing.Size(401, 388);
            this.slideB.TabIndex = 11;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(25, 171);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(69, 17);
            this.bunifuCustomLabel6.TabIndex = 8;
            this.bunifuCustomLabel6.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 1;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.Green;
            this.btnLogin.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnLogin, BunifuAnimatorNS.DecorationType.None);
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 1;
            this.btnLogin.IdleFillColor = System.Drawing.Color.Green;
            this.btnLogin.IdleForecolor = System.Drawing.Color.Silver;
            this.btnLogin.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.Location = new System.Drawing.Point(35, 298);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(329, 53);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbPass
            // 
            this.tbPass.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbPass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPass.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.tbPass.BorderThickness = 2;
            this.tbPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.tbPass, BunifuAnimatorNS.DecorationType.None);
            this.tbPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbPass.ForeColor = System.Drawing.Color.Silver;
            this.tbPass.isPassword = true;
            this.tbPass.Location = new System.Drawing.Point(17, 192);
            this.tbPass.Margin = new System.Windows.Forms.Padding(4);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(366, 35);
            this.tbPass.TabIndex = 7;
            this.tbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(25, 101);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(54, 17);
            this.bunifuCustomLabel7.TabIndex = 6;
            this.bunifuCustomLabel7.Text = "Usuario";
            // 
            // tbUsuario
            // 
            this.tbUsuario.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbUsuario.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUsuario.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.tbUsuario.BorderThickness = 2;
            this.tbUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.tbUsuario, BunifuAnimatorNS.DecorationType.None);
            this.tbUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbUsuario.ForeColor = System.Drawing.Color.Silver;
            this.tbUsuario.isPassword = false;
            this.tbUsuario.Location = new System.Drawing.Point(17, 122);
            this.tbUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(366, 35);
            this.tbUsuario.TabIndex = 5;
            this.tbUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel10, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(151, 9);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(77, 30);
            this.bunifuCustomLabel10.TabIndex = 0;
            this.bunifuCustomLabel10.Text = "Login";
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
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
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuSeparator1.LineThickness = 5;
            this.bunifuSeparator1.Location = new System.Drawing.Point(106, 92);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(120, 5);
            this.bunifuSeparator1.TabIndex = 12;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.SteelBlue;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(407, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(39, 34);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 13;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(33, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Presione F1 para Ayuda";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(469, 530);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.slideB);
            this.Controls.Add(this.slideA);
            this.Controls.Add(this.btnLoginL);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.lbMensaje);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.slideA.ResumeLayout(false);
            this.slideA.PerformLayout();
            this.slideB.ResumeLayout(false);
            this.slideB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbMensaje;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Panel slideA;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbNombre;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegistrar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLoginL;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbPassReg;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbUsuarioReg;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbAlias;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Panel slideB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbPass;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbUsuario;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

