using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatosNegocios;

namespace SCAM_App
{
    public partial class FormUsuarioDetalle : Form
    {
        private Usuario usu;
        private Empleado empV = null;
        List<Empleado> listaEmps;
        bool esNuevo = true;
        bool hayError = false;

        public FormUsuarioDetalle()
        {
            InitializeComponent();

            tbPassword.UseSystemPasswordChar = true; // indica que el campo password no aparezca los dartos cdo los introduzca

        }

        public FormUsuarioDetalle(Usuario usu)
        {
            InitializeComponent();

            this.usu = usu;
            esNuevo = false;

            if(FormLogin.usuNivelAcceso == 2)
            {
                radioZero.Enabled = false;
                radioUno.Enabled = false;
                radioDos.Enabled = false;

                cbEmpleado.Enabled = false;
            }

        }

        private void FormUsuarioDetalle_Load(object sender, EventArgs e)
        {
             tbIdUsuario.Enabled = false; // el campo Id aparezca desabilitado

            cargaComboEmpleado();

           if(esNuevo == false)
            {
                tbPassword.UseSystemPasswordChar = true;

                tbIdUsuario.Text = usu.IdUsuario.ToString();

                tbNombre.Text = usu.Nombre;
                tbAlias.Text = usu.Alias;
                tbLogin.Text = usu.Login;
                tbPassword.Text = usu.Password;

                if (usu.Acceso == 0)
                    radioZero.Checked = true;
                else if (usu.Acceso == 1)
                    radioUno.Checked = true;
                else
                    radioDos.Checked = true;

                empV = EmpleadoDAO.BuscarEmpleadoVinculado(usu.IdUsuario); // Solicita el empleado que esta vinculado a ese usuario ///

                if (empV.IdEmpleado > 0)
                    cbEmpleado.SelectedValue = empV.IdEmpleado;
                else
                    cbEmpleado.Text = "Seleccione un Empleado";
            }
         

        }

        private void cargaComboEmpleado()
        {
            listaEmps = EmpleadoDAO.ListarEmpleados(); // Genera una lista para mostrar en el comboBox de empleados

            if (esNuevo)
                listaEmps.Insert(0, new Empleado(0, "Seleccione el Empleado"));


            cbEmpleado.DataSource = listaEmps;
            cbEmpleado.DisplayMember = "Nombre";
            cbEmpleado.ValueMember = "IdEmpleado";

        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Volver();

        }

        private void btnAnadirEmpleado_Click(object sender, EventArgs e) // añadir Usuario //
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
            usuAd.Login = tbLogin.Text.Trim();
            usuAd.Password = tbPassword.Text.Trim();

            usuAd.Acceso = 0;

            if (radioUno.Checked)
                usuAd.Acceso = 1;
            else if (radioDos.Checked)
                usuAd.Acceso = 2;

            int resultado = 0;
            if (esNuevo)
                resultado = UsuarioDAO.Insertar(usuAd); // recibe el resultado positivo al insertar el usuario
            else
            {
                usuAd.IdUsuario = Convert.ToInt32(tbIdUsuario.Text);
                resultado = UsuarioDAO.ModificarUsuario(usuAd);
            }

            if (resultado > 0) // se inserta bien el usuario
            {
                int idEmp = cbEmpleado.SelectedIndex;

                if (usuAd.Acceso > 0 && idEmp > 0) // verifica si el usuario esta activo u el empleado ha sido seleccionado
                {
                    Usuario usus = UsuarioDAO.ObtenerUsuario(usuAd.Login); // busca el codigo del usuario

                    int retorno = EmpleadoDAO.VincularUsuario(Convert.ToInt32( cbEmpleado.SelectedValue), usus); // vincula el usuario en el empleado ///

                }

                MessageBox.Show("Usuario Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Volver();
            }
            else
            {
                MessageBox.Show("No se pudo guardar el Usuario", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Volver()
        {
            if(FormLogin.usuNivelAcceso == 2)
            {
                this.Close();
                this.Dispose();

                FormInicio fa1 = new FormInicio();

                fa1.StartPosition = FormStartPosition.CenterScreen;
                fa1.ShowDialog();
               // fa1.Dispose();
            }
            else
            {
                this.Close();
                this.Dispose();

                FormUsuarios fa = new FormUsuarios();
                fa.Width = 579;
                fa.Height = 435;
                fa.Location = new Point(280, 160);
                fa.ShowDialog();
            }


        }


        private bool HayErrorEnFormulario()
        {
            hayError = false;
            string pathString = @"[A-Z]{1}[a-zA-ZàáâäãåąčćęèéêëėįìíîïłńòóôöõøùúûüųūÿýżźñçčšžÀÁÂÄÃÅĄĆČĖĘÈÉÊËÌÍÎÏĮŁŃÒÓÔÖÕØÙÚÛÜŲŪŸÝŻŹÑßÇŒÆČŠŽ∂ð,.'-]{2,49}";
            string pathAlias = @"[A-Z]{4}";
            string patherlogin = @"[a-zA-ZàáâäãåąčćęèéêëėįìíîïłńòóôöõøùúûüųūÿýżźñçčšžÀÁÂÄÃÅĄĆČĖĘÈÉÊËÌÍÎÏĮŁŃÒÓÔÖÕØÙÚÛÜŲŪŸÝŻŹÑßÇŒÆČŠŽ∂ð,.'-]";
            string patherPass = @"[a-zA-Z0-9àáâäãåąčćęèéêëėįìíîïłńòóôöõøùúûüųūÿýżźñçčšžÀÁÂÄÃÅĄĆČĖĘÈÉÊËÌÍÎÏĮŁŃÒÓÔÖÕØÙÚÛÜŲŪŸÝŻŹÑßÇŒÆČŠŽ∂ð,.'-]{1,45}";

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

            if (!Regex.IsMatch(tbLogin.Text, patherlogin) || tbLogin.Text.Trim().Length > 10)
            {
                errorProvider1.SetError(tbLogin, "Error en el Formato del Login ");

                hayError = true;
            }
            else
                errorProvider1.SetError(tbLogin, "");

            if (tbPassword.Text.Trim().Length > 20)
            {
                errorProvider1.SetError(tbPassword, "Error en el Tamaño de la Password ");

                hayError = true;
            }
            else
                errorProvider1.SetError(tbPassword, "");

            if (radioZero.Checked == false && radioUno.Checked == false && radioDos.Checked == false)
            {
                errorProvider1.SetError(radioDos, "Error, Tienes que seleccionar algun Nivel de Acceso ");
                hayError = true;

            }
            else
                errorProvider1.SetError(radioDos, "");


            List<Usuario> yaExiste = UsuarioDAO.YaExiste(tbLogin.Text, tbAlias.Text); // Verifica si el Empleado o DNI ya exuste  //
            if (yaExiste.Count > 0 && tbIdUsuario.Text == "")
                tbIdUsuario.Text = "0";

            if (yaExiste.Count > 0 && yaExiste[0].IdUsuario != Convert.ToInt32(tbIdUsuario.Text))
            {
                    MessageBox.Show("El Alias u el Usuario ya Existen !!!");
                hayError = true;
            }


            return hayError;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    // Llamamos al Formulario de Ayuda
                    //
                    Help.FormHelpUsuarios frm = new Help.FormHelpUsuarios();
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
