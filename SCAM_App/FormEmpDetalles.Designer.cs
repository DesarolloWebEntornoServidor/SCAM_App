namespace SCAM_App
{
    partial class FormEmpDetalles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpDetalles));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolver = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnAnadirEmpleado = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tbIdEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictBoxFoto = new System.Windows.Forms.PictureBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.fechaNacimiento = new Bunifu.Framework.UI.BunifuDatepicker();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.tbFuncion = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.radioHombre = new System.Windows.Forms.RadioButton();
            this.radioMujer = new System.Windows.Forms.RadioButton();
            this.chkActivo = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label13 = new System.Windows.Forms.Label();
            this.fechaEntrada = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btnCargaImagen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxFoto)).BeginInit();
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
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 50);
            this.panel1.TabIndex = 1;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.ImageActive = null;
            this.btnVolver.Location = new System.Drawing.Point(694, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(41, 39);
            this.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVolver.TabIndex = 7;
            this.btnVolver.TabStop = false;
            this.btnVolver.Zoom = 10;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 8);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(168, 21);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "Datos del Empleado";
            // 
            // btnAnadirEmpleado
            // 
            this.btnAnadirEmpleado.ActiveBorderThickness = 1;
            this.btnAnadirEmpleado.ActiveCornerRadius = 20;
            this.btnAnadirEmpleado.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAnadirEmpleado.ActiveForecolor = System.Drawing.SystemColors.WindowFrame;
            this.btnAnadirEmpleado.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAnadirEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.btnAnadirEmpleado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnadirEmpleado.BackgroundImage")));
            this.btnAnadirEmpleado.ButtonText = "Guardar Empleado";
            this.btnAnadirEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnadirEmpleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirEmpleado.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAnadirEmpleado.IdleBorderThickness = 1;
            this.btnAnadirEmpleado.IdleCornerRadius = 30;
            this.btnAnadirEmpleado.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnAnadirEmpleado.IdleForecolor = System.Drawing.Color.Silver;
            this.btnAnadirEmpleado.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAnadirEmpleado.Location = new System.Drawing.Point(354, 395);
            this.btnAnadirEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnadirEmpleado.Name = "btnAnadirEmpleado";
            this.btnAnadirEmpleado.Size = new System.Drawing.Size(151, 42);
            this.btnAnadirEmpleado.TabIndex = 15;
            this.btnAnadirEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAnadirEmpleado.Click += new System.EventHandler(this.btnAnadirEmpleado_Click);
            // 
            // tbIdEmpleado
            // 
            this.tbIdEmpleado.Location = new System.Drawing.Point(165, 69);
            this.tbIdEmpleado.Name = "tbIdEmpleado";
            this.tbIdEmpleado.Size = new System.Drawing.Size(67, 20);
            this.tbIdEmpleado.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Código";
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(598, 235);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(167, 21);
            this.cbDepartamento.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(664, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Departamento";
            // 
            // cbUsuario
            // 
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(612, 287);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(153, 21);
            this.cbUsuario.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(638, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Usuario Vinculado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // lbApellidos
            // 
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellidos.Location = new System.Drawing.Point(89, 126);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(70, 16);
            this.lbApellidos.TabIndex = 23;
            this.lbApellidos.Text = "Apellidos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(165, 98);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(270, 20);
            this.tbNombre.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(97, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Teléfono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(101, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Función";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(128, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "DNI";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "Fecha de Entrada";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(105, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "Salário";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(121, 350);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 16);
            this.label12.TabIndex = 32;
            this.label12.Text = "Sexo";
            // 
            // pictBoxFoto
            // 
            this.pictBoxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictBoxFoto.Location = new System.Drawing.Point(665, 58);
            this.pictBoxFoto.Name = "pictBoxFoto";
            this.pictBoxFoto.Size = new System.Drawing.Size(100, 111);
            this.pictBoxFoto.TabIndex = 33;
            this.pictBoxFoto.TabStop = false;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(165, 126);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(270, 20);
            this.tbApellidos.TabIndex = 34;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fechaNacimiento.BackColor = System.Drawing.Color.SeaGreen;
            this.fechaNacimiento.BorderRadius = 0;
            this.fechaNacimiento.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.fechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaNacimiento.FormatCustom = "yyyy/MM/dd";
            this.fechaNacimiento.Location = new System.Drawing.Point(165, 152);
            this.fechaNacimiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.Size = new System.Drawing.Size(157, 20);
            this.fechaNacimiento.TabIndex = 35;
            this.fechaNacimiento.Value = new System.DateTime(2017, 12, 27, 9, 42, 10, 429);
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(165, 181);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(132, 20);
            this.tbDni.TabIndex = 37;
            // 
            // tbFuncion
            // 
            this.tbFuncion.Location = new System.Drawing.Point(165, 209);
            this.tbFuncion.Name = "tbFuncion";
            this.tbFuncion.Size = new System.Drawing.Size(230, 20);
            this.tbFuncion.TabIndex = 38;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(165, 235);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(132, 20);
            this.tbTelefono.TabIndex = 39;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(165, 265);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(270, 20);
            this.tbEmail.TabIndex = 40;
            // 
            // tbSalario
            // 
            this.tbSalario.Location = new System.Drawing.Point(165, 320);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(132, 20);
            this.tbSalario.TabIndex = 41;
            this.tbSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radioHombre
            // 
            this.radioHombre.AutoSize = true;
            this.radioHombre.Location = new System.Drawing.Point(165, 350);
            this.radioHombre.Name = "radioHombre";
            this.radioHombre.Size = new System.Drawing.Size(62, 17);
            this.radioHombre.TabIndex = 42;
            this.radioHombre.TabStop = true;
            this.radioHombre.Text = "Hombre";
            this.radioHombre.UseVisualStyleBackColor = true;
            // 
            // radioMujer
            // 
            this.radioMujer.AutoSize = true;
            this.radioMujer.Location = new System.Drawing.Point(233, 350);
            this.radioMujer.Name = "radioMujer";
            this.radioMujer.Size = new System.Drawing.Size(51, 17);
            this.radioMujer.TabIndex = 44;
            this.radioMujer.TabStop = true;
            this.radioMujer.Text = "Mujer";
            this.radioMujer.UseVisualStyleBackColor = true;
            // 
            // chkActivo
            // 
            this.chkActivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkActivo.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkActivo.Checked = true;
            this.chkActivo.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkActivo.ForeColor = System.Drawing.Color.White;
            this.chkActivo.Location = new System.Drawing.Point(667, 326);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(20, 20);
            this.chkActivo.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(689, 327);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 16);
            this.label13.TabIndex = 46;
            this.label13.Text = "Activo";
            // 
            // fechaEntrada
            // 
            this.fechaEntrada.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fechaEntrada.BackColor = System.Drawing.Color.SeaGreen;
            this.fechaEntrada.BorderRadius = 0;
            this.fechaEntrada.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaEntrada.ForeColor = System.Drawing.Color.White;
            this.fechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaEntrada.FormatCustom = null;
            this.fechaEntrada.Location = new System.Drawing.Point(165, 292);
            this.fechaEntrada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fechaEntrada.Name = "fechaEntrada";
            this.fechaEntrada.Size = new System.Drawing.Size(157, 20);
            this.fechaEntrada.TabIndex = 47;
            this.fechaEntrada.Value = new System.DateTime(2017, 12, 27, 9, 42, 10, 429);
            // 
            // btnCargaImagen
            // 
            this.btnCargaImagen.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCargaImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCargaImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCargaImagen.BorderRadius = 0;
            this.btnCargaImagen.ButtonText = "Cargar Imagen";
            this.btnCargaImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargaImagen.DisabledColor = System.Drawing.Color.Gray;
            this.btnCargaImagen.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCargaImagen.Iconimage = null;
            this.btnCargaImagen.Iconimage_right = null;
            this.btnCargaImagen.Iconimage_right_Selected = null;
            this.btnCargaImagen.Iconimage_Selected = null;
            this.btnCargaImagen.IconMarginLeft = 0;
            this.btnCargaImagen.IconMarginRight = 0;
            this.btnCargaImagen.IconRightVisible = true;
            this.btnCargaImagen.IconRightZoom = 0D;
            this.btnCargaImagen.IconVisible = true;
            this.btnCargaImagen.IconZoom = 90D;
            this.btnCargaImagen.IsTab = false;
            this.btnCargaImagen.Location = new System.Drawing.Point(665, 174);
            this.btnCargaImagen.Name = "btnCargaImagen";
            this.btnCargaImagen.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCargaImagen.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCargaImagen.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCargaImagen.selected = false;
            this.btnCargaImagen.Size = new System.Drawing.Size(100, 19);
            this.btnCargaImagen.TabIndex = 48;
            this.btnCargaImagen.Text = "Cargar Imagen";
            this.btnCargaImagen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCargaImagen.Textcolor = System.Drawing.Color.White;
            this.btnCargaImagen.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaImagen.Click += new System.EventHandler(this.btnCargaImagen_Click);
            // 
            // FormEmpDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCargaImagen);
            this.Controls.Add(this.fechaEntrada);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.radioMujer);
            this.Controls.Add(this.radioHombre);
            this.Controls.Add(this.tbSalario);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbFuncion);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.fechaNacimiento);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.pictBoxFoto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbApellidos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDepartamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIdEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnadirEmpleado);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmpDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormEmpDetalles";
            this.Load += new System.EventHandler(this.FormEmpDetalles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAnadirEmpleado;
        private System.Windows.Forms.TextBox tbIdEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.PictureBox pictBoxFoto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuCheckbox chkActivo;
        private System.Windows.Forms.RadioButton radioMujer;
        private System.Windows.Forms.RadioButton radioHombre;
        private System.Windows.Forms.TextBox tbSalario;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbFuncion;
        private System.Windows.Forms.TextBox tbDni;
        private Bunifu.Framework.UI.BunifuDatepicker fechaNacimiento;
        private System.Windows.Forms.TextBox tbApellidos;
        private Bunifu.Framework.UI.BunifuImageButton btnVolver;
        private Bunifu.Framework.UI.BunifuDatepicker fechaEntrada;
        private Bunifu.Framework.UI.BunifuFlatButton btnCargaImagen;
    }
}