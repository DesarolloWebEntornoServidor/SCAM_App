using System;
using Datos_Negocios;
using System.Windows.Forms;
using System.Drawing;
using WindowsFormsControlLibrary1;

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
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            if(FormLogin.usuNivelAcceso == 0)
            {
                MessageBox.Show("Usuario no está Activado Aún, Contacte el Administrador");
                this.Close();
                FormLogin fl = new FormLogin();
                fl.Show();
            }



        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin fl = new FormLogin();
            fl.Show();
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
                LogoTransition.HideSync(logo);
                sideMenu.Visible = false;
                sideMenu.Width = 50;
                PanelAnimator.ShowSync(sideMenu);
                btnMenuBarra.Visible = true;
                logoMini.Visible = true;
            }
        }

        private void btnAccesos_Click(object sender, EventArgs e)
        {
            LogoTransition.HideSync(logo);
            sideMenu.Visible = false;
            sideMenu.Width = 50;
            PanelAnimator.ShowSync(sideMenu);
            btnMenuBarra.Visible = true;
            logoMini.Visible = true;


            FormAccesos fa = new FormAccesos();
            //  fa.StartPosition = FormStartPosition.CenterScreen;

            fa.Width = 579;
            fa.Height = 435;
            fa.Location = new Point(280, 160);
            fa.ShowDialog();



        }

        private void btnDepart_Click(object sender, EventArgs e)
        {
            LogoTransition.HideSync(logo);
            sideMenu.Visible = false;
            sideMenu.Width = 50;
            PanelAnimator.ShowSync(sideMenu);
            btnMenuBarra.Visible = true;
            logoMini.Visible = true;


            FormDepartamento fd = new FormDepartamento();
            //  fa.StartPosition = FormStartPosition.CenterScreen;

            fd.Width = 579;
            fd.Height = 435;
            fd.Location = new Point(280, 160);
            fd.ShowDialog();

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            LogoTransition.HideSync(logo);
            sideMenu.Visible = false;
            sideMenu.Width = 50;
            PanelAnimator.ShowSync(sideMenu);
            btnMenuBarra.Visible = true;
            logoMini.Visible = true;


            FormEmpleados fe = new FormEmpleados();
            //  fa.StartPosition = FormStartPosition.CenterScreen;

            fe.Width = 860;
            fe.Height = 450;
            fe.Location = new Point(280, 160);
            fe.ShowDialog();
        }

        private void btnGenerarAcceso_Click(object sender, EventArgs e)
        {
            LogoTransition.HideSync(logo);
            sideMenu.Visible = false;
            sideMenu.Width = 50;
            PanelAnimator.ShowSync(sideMenu);
            btnMenuBarra.Visible = true;
            logoMini.Visible = true;

            FormAccesosEmpleados fae = new FormAccesosEmpleados();

            fae.Width = 579; 
            fae.Height = 435;
            fae.Location = new Point(280, 160);
            fae.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            LogoTransition.HideSync(logo);
            sideMenu.Visible = false;
            sideMenu.Width = 50;
            PanelAnimator.ShowSync(sideMenu);
            btnMenuBarra.Visible = true;
            logoMini.Visible = true;

          //  this.Close();

            FormUsuarios fa = new FormUsuarios();
            fa.Width = 579;
            fa.Height = 435;
            fa.Location = new Point(280, 160);
            fa.ShowDialog();
        }
    }
}
