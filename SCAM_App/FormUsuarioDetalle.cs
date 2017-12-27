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
        public FormUsuarioDetalle()
        {
            InitializeComponent();

            tbPassword.UseSystemPasswordChar = true;

        }
        private void FormUsuarioDetalle_Load(object sender, EventArgs e)
        {
            tbIdUsuario.Enabled = false;


            cargaComboEmpleado();
        }

        private void cargaComboEmpleado()
        {
            List<Empleado> listaEmps = EmpleadoDAO.ListarEmpleados(); // Genera una lista para mostrar en el comboBox de empleados

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

        private void btnAnadirEmpleado_Click(object sender, EventArgs e)
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

            int idEmp = cbEmpleado.SelectedIndex;


            if (usuAd.Acceso > 0 && idEmp > 0)
            {

                EmpleadoDAO.VincularUsuario(idEmp);

            }

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

                    break;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
