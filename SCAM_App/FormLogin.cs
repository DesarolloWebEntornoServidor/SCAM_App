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

namespace SCAM_App
{
    public partial class FormLogin : Form
    {
        public static string usuNombre;
        public static int usuNivelAcceso;

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
                // slideA.Refresh();

                bunifuSeparator1.Left = bunifuThinButton21.Left;
                bunifuSeparator1.Width = bunifuThinButton21.Width;

            }

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {

                bool usuExiste = UsuarioDAO.verificaUsuario(tbUsuario.Text, tbPass.Text);

                if (usuExiste)
                {
                    //lbMensaje.Text = "Benvenido " + tbUsuario.Text;

                    usuNombre = tbUsuario.Text;

                    usuNivelAcceso = UsuarioDAO.ObtenerUsuario(tbUsuario.Text).Acceso;

                    if(usuNivelAcceso == 0)
                    {
                        MessageBox.Show("Usuario no está Activado Aún, Contacte el Administrador");
                        return;
                    }

                    FormInicio fi = new FormInicio();
                    fi.StartPosition = FormStartPosition.CenterScreen;
                    fi.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El Usuario o Contraseña NO existe");
                }
            }
            catch (Exception ex)
            {
                lbMensaje.Text = "Error " + ex;
            }

            Conexion.CerrarConexion();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
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

            
        }
    }
}
