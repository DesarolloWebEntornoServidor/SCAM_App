using System;
using Datos_Negocios;
using System.Windows.Forms;
using System.Drawing;
using WindowsFormsControlLibrary1;
using BarcodeLib;

namespace SCAM_App
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();

            if (FormLogin.usuNivelAcceso == 0)
            {
                MessageBox.Show("Usuario no está Activado Aún, Contacte el Administrador");
                return;
            }
            else if (FormLogin.usuNivelAcceso == 2)
            {
                btnAccesos.Enabled = false;
                btnDepart.Enabled = false;
                btnGenerarAcceso.Enabled = false;
            }
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            if(FormLogin.usuNivelAcceso == 0)
            {
                MessageBox.Show("Usuario no está Activado, Contacte el Administrador");
                this.Close();
                FormLogin fl = new FormLogin();
                fl.Show();
            }

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Volver();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(sideMenu.Width == 50)
            {
                sideMenu.Visible = false;
                sideMenu.Width = 190;
                PanelAnimator.ShowSync(sideMenu);
                LogoTransition.ShowSync(logo);
                btnMenuBarra.Visible = false;
                logoMini.Visible = false;
            }
            else
            {
                Transicion();
            }
        }

        private void btnAccesos_Click(object sender, EventArgs e)
        {
            Transicion();

            FormAccesos fa = new FormAccesos();
            //  fa.StartPosition = FormStartPosition.CenterScreen;

            fa.Width = 579;
            fa.Height = 435;
            fa.Location = new Point(280, 160);
            fa.ShowDialog();

        }

        private void btnDepart_Click(object sender, EventArgs e)
        {
            Transicion();

            FormDepartamento fd = new FormDepartamento();

            fd.Width = 579;
            fd.Height = 435;
            fd.Location = new Point(280, 160);
            fd.ShowDialog();

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Transicion();

            FormEmpleados fe;

            if (FormLogin.usuNivelAcceso == 2)
                fe = new FormEmpleados(2);
            else
                fe = new FormEmpleados();

            fe.Width = 880;
            fe.Height = 450;
            fe.Location = new Point(265, 160);
            fe.ShowDialog();
        }

        private void btnGenerarAcceso_Click(object sender, EventArgs e)
        {
            Transicion();

            FormAccesosEmpleados fae = new FormAccesosEmpleados();

            fae.Width = 579; 
            fae.Height = 435;
            fae.Location = new Point(280, 160);
            fae.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Transicion();

            FormUsuarios fa;

            if(FormLogin.usuNivelAcceso == 2)
                fa = new FormUsuarios(2);
            else
                fa = new FormUsuarios();

            fa.Width = 579;
            fa.Height = 435;
            fa.Location = new Point(280, 160);
            fa.ShowDialog();
        }

        private void btnGenerarTarjeta_Click(object sender, EventArgs e)
        {
            Transicion();

            FormEmpleados fe = new FormEmpleados();

            fe.Width = 860;
            fe.Height = 450;
            fe.Location = new Point(280, 160);
            fe.ShowDialog();
        }

        private void Transicion()
        {
            LogoTransition.HideSync(logo);
            sideMenu.Visible = false;
            sideMenu.Width = 50;
            PanelAnimator.ShowSync(sideMenu);
            btnMenuBarra.Visible = true;
            logoMini.Visible = true;
        }

        private void Volver()
        {
            this.Close();
            FormLogin fl = new FormLogin();
            fl.Show();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    // Llamamos al Formulario de Ayuda
                    //
                    Help.FormHelpInicio frm = new Help.FormHelpInicio();
                    frm.ShowDialog();
                    frm.Dispose();
                    break;
                case Keys.Escape:
                    Volver();

                    break;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
