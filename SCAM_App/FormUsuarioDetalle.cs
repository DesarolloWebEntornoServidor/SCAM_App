using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            
        }

        private void FormUsuarioDetalle_Load(object sender, EventArgs e)
        {
             tbIdUsuario.Enabled = false; // el campo Id aparezca desabilitado

            cargaComboEmpleado();

           if(esNuevo == false)
            {
                tbIdUsuario.Text = usu.IdUsuario.ToString();

                tbNombre.Text = usu.Nombre;
                tbAlias.Text = usu.Alias;
                tbLogin.Text = usu.Login;
                tbPassword.Text = Util.Desencriptar(usu.Password);

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
            this.Hide();

            FormUsuarios fa = new FormUsuarios();
            fa.Width = 579;
            fa.Height = 435;
            fa.Location = new Point(280, 160);
            fa.ShowDialog();
        }

        private void btnAnadirEmpleado_Click(object sender, EventArgs e) // añadir Usuario //
        {
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
                usuAd.IdUsuario = Convert.ToInt32( tbIdUsuario.Text);
                resultado = UsuarioDAO.ModificarUsuario(usuAd);
            }

            if (resultado > 0) // se inserta bien el usuario
            {
                int idEmp = cbEmpleado.SelectedIndex;

                if (usuAd.Acceso > 0 && idEmp > 0) // verifica si el usuario esta activo u el empleado ha sido seleccionado
                {
                    Usuario usus = UsuarioDAO.ObtenerUsuario(usuAd.Login); // busca el codigo del usuario

                    int retorno = EmpleadoDAO.VincularUsuario(idEmp, usus); // vincula el usuario en el empleado ///

                }

                MessageBox.Show("Usuario Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                FormUsuarios fa = new FormUsuarios();
                fa.Width = 579;
                fa.Height = 435;
                fa.Location = new Point(280, 160);
                fa.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se pudo guardar el Usuario", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    // Llamamos al Formulario de Ayuda
                    //
                    Help.FormHelpCodigoAcceso frm = new Help.FormHelpCodigoAcceso();
                    frm.ShowDialog();
                    frm.Dispose();
                    break;
                case Keys.Escape:
                    this.Hide();
                    FormUsuarios fa = new FormUsuarios();
                    fa.Width = 579;
                    fa.Height = 435;
                    fa.Location = new Point(280, 160);
                    fa.ShowDialog();
                    break;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
