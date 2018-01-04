using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using DatosNegocios;
using System.Text.RegularExpressions;

namespace SCAM_App
{
    public partial class FormLogin : Form
    {
        public static string usuNombre;
        public static int usuNivelAcceso, usuId;
        bool hayError = false;
        bool usuExiste = false;

        public FormLogin()
        {
            InitializeComponent();

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            slideB.Focus();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if(slideB.Left == 494)
            {
                slideA.Visible = false;
                slideA.Left = 494;

                slideB.Visible = false;
                slideB.Left = 53;
                slideB.Visible = true;

                bunifuSeparator1.Left = bunifuThinButton22.Left;
                bunifuSeparator1.Width = bunifuThinButton22.Width;

                tbUsuario.Focus();

            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (slideA.Left == 494)
            {
                slideB.Visible = false;
                slideB.Left = 494;

                slideA.Visible = false;
                slideA.Left = 53;
                slideA.Visible = true;

                bunifuSeparator1.Left = bunifuThinButton21.Left;
                bunifuSeparator1.Width = bunifuThinButton21.Width;

            }

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {

            int vera = usuNivelAcceso;

            try
            {
                

                usuExiste = UsuarioDAO.verificaUsuario(tbUsuario.Text, tbPass.Text);

                if (usuExiste)
                {

                    Usuario usuExporta = UsuarioDAO.ObtenerUsuario(tbUsuario.Text);

                    usuNombre = usuExporta.Login;

                    usuNivelAcceso = usuExporta.Acceso;

                    usuId = usuExporta.IdUsuario;

                    if(usuNivelAcceso == 0)
                    {
                        MessageBox.Show("Usuario no está Activado Aún, Contacte el Administrador");
                        return;
                    }
                    this.Hide();

                    FormInicio fi = new FormInicio();
                    fi.StartPosition = FormStartPosition.CenterScreen;
                    fi.ShowDialog();
                }
                else
                {
                    MessageBox.Show("El Usuario o Contraseña Incorrectos");
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show("Imposible Verificar los Datos Introduzidos, Contacte el Administrador");
               // MessageBox.Show( ex.Message);
            }

            Conexion.CerrarConexion();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            hayError = HayErrorEnFormulario();

            if (hayError)
            {
                MessageBox.Show("Existe Error en el Formulario, Presione F1 si necesitas Ayuda !!!");
                return;
            }

            Usuario usuAd = new Usuario();

            usuAd.Nombre = tbNombre.Text.Trim();
            usuAd.Alias = tbAlias.Text.Trim();
            usuAd.Login = tbUsuarioReg.Text.Trim();
            usuAd.Password = tbPassReg.Text.Trim();

            int resultado = UsuarioDAO.Insertar(usuAd);

            if (resultado > 0)
            {
                MessageBox.Show("Usuario Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar el Usuario", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();

            Application.Exit();

        }

        private bool HayErrorEnFormulario()
        {
            hayError = false;
            string pathString = @"[A-Z]{1}[a-zA-ZàáâäãåąčćęèéêëėįìíîïłńòóôöõøùúûüųūÿýżźñçčšžÀÁÂÄÃÅĄĆČĖĘÈÉÊËÌÍÎÏĮŁŃÒÓÔÖÕØÙÚÛÜŲŪŸÝŻŹÑßÇŒÆČŠŽ∂ð,.'-]{2,49}";
            string pathAlias = @"[A-Z]{4}";
            string patherlogin = @"[a-zA-ZàáâäãåąčćęèéêëėįìíîïłńòóôöõøùúûüųūÿýżźñçčšžÀÁÂÄÃÅĄĆČĖĘÈÉÊËÌÍÎÏĮŁŃÒÓÔÖÕØÙÚÛÜŲŪŸÝŻŹÑßÇŒÆČŠŽ∂ð,.'-]";
            string patherPass = @"[a-zA-Z0-9àáâäãåąčćęèéêëėįìíîïłńòóôöõøùúûüųūÿýżźñçčšžÀÁÂÄÃÅĄĆČĖĘÈÉÊËÌÍÎÏĮŁŃÒÓÔÖÕØÙÚÛÜŲŪŸÝŻŹÑßÇŒÆČŠŽ∂ð,.'-]{";

            if (!Regex.IsMatch(tbNombre.Text, pathString) || tbNombre.Text.Trim().Length > 50)
            {
                errorProvider1.SetError(tbNombre, "Error en el Formato del Nombre ");

                hayError = true;
            }
            else
                errorProvider1.SetError(tbNombre, "");

            if (!Regex.IsMatch(tbAlias.Text, pathAlias) || tbAlias.Text.Trim().Length > 4)
            {
                errorProvider1.SetError(tbAlias, "Error en el Formato del Alias ");

                hayError = true;
            }
            else
                errorProvider1.SetError(tbAlias, "");

            if (!Regex.IsMatch(tbUsuarioReg.Text, patherlogin) || tbUsuarioReg.Text.Trim().Length > 10)
            {
                errorProvider1.SetError(tbUsuarioReg, "Error en el Formato del Login ");

                hayError = true;
            }
            else
                errorProvider1.SetError(tbUsuarioReg, "");

            if (!Regex.IsMatch(tbPassReg.Text, patherPass) || tbPassReg.Text.Trim().Length > 45)
            {
                errorProvider1.SetError(tbPassReg, "Error en el Formato de la Password ");

                hayError = true;
            }
            else
                errorProvider1.SetError(tbPassReg, "");

            return hayError;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    // Llamamos al Formulario de Ayuda
                    //
                    Help.FormHelpUsuarios frm = new Help.FormHelpUsuarios(1);
                    frm.ShowDialog();
                    frm.Dispose();
                    break;
                case Keys.Escape:

                    this.Close();
                    this.Dispose();

                    break;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
