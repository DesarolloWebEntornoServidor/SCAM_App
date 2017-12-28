using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatosNegocios;
using System.IO;
using System.Drawing.Imaging;

namespace SCAM_App
{
    public partial class FormEmpDetalles : Form
    {
        private Empleado emp;

        private Departamento depV = null;
        List<Departamento> listaDeparts;

        private Usuario usuV = null;
        List<Usuario> listaUsuarios;
        bool esNuevo = true;

        public FormEmpDetalles()
        {
            InitializeComponent();
        }

        public FormEmpDetalles(Empleado emp)
        {
            InitializeComponent();

            this.emp = emp;
            esNuevo = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormEmpleados fa = new FormEmpleados();
            fa.Width = 860;
            fa.Height = 450;
            fa.Location = new Point(280, 160);
            fa.ShowDialog();
        }

        private void FormEmpDetalles_Load(object sender, EventArgs e)
        {
            tbIdEmpleado.Enabled = false;

            cargaCombos();

            if (esNuevo == false)
            {
                 tbIdEmpleado.Text = emp.IdEmpleado.ToString();
                 tbNombre.Text = emp.Nombre;
                 tbApellidos.Text = emp.Apellidos;
               // emp.FechaNacto = Convert.ToDateTime(fechaNacimiento.Value.Year + "/" + fechaNacimiento.Value.Month + "/" + fechaNacimiento.Value.Day);
               fechaNacimiento.Value = emp.FechaNacto;

                tbDni.Text = emp.Dni;
                tbFuncion.Text = emp.Funcion;
                tbTelefono.Text = emp.Telefono;
                tbEmail.Text = emp.Email;

                fechaEntrada.Value = emp.FechaEntrada;

                tbSalario.Text = emp.Salario.ToString("N2");

                depV = DepartamentoDAO.ObtenerDepartamento(emp.IdDepartamento); // Solicita el Departamento que esta vinculado ese Empleado ///
                usuV = UsuarioDAO.ObtenerUsuario(emp.IdUsuario); // Solicita el Departamento que esta vinculado ese Empleado ///

                if (depV.IdDepartamento > 0)
                    cbDepartamento.SelectedValue = depV.IdDepartamento;
                else
                    cbDepartamento.Text = "Seleccione un Departamento";

                if (usuV.IdUsuario > 0)
                    cbUsuario.SelectedValue = usuV.IdUsuario;
                else
                    cbUsuario.Text = "Seleccione un Usuario";

                if (emp.Sexo == "H")
                    radioHombre.Checked = true;
                else if (emp.Sexo == "M")
                    radioMujer.Checked = true;

                if (emp.Activo == 1)
                    chkActivo.Checked = true;
                else
                    chkActivo.Checked = false;
            }
        }

        private void cargaCombos()
        {
            listaDeparts = DepartamentoDAO.ListarDepartamentos();

            listaDeparts.Insert(0, new Departamento(0, 0, "Seleccione el Departamento"));

            cbDepartamento.DataSource = listaDeparts;
            cbDepartamento.DisplayMember = "descripcion";
            cbDepartamento.ValueMember = "IdDepartamento";

            listaUsuarios = UsuarioDAO.ListarUsuarios();

            listaUsuarios.Insert(0, new Usuario("Seleccione el Usuario"));

            cbUsuario.DataSource = listaUsuarios;
            cbUsuario.DisplayMember = "login";
            cbUsuario.ValueMember = "idUsuario";

        }

        private void btnAnadirEmpleado_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();

            emp.IdEmpleado = Convert.ToInt32(tbIdEmpleado.Text);
            emp.Nombre = tbNombre.Text.Trim();
            emp.Apellidos = tbApellidos.Text.Trim();

            emp.FechaNacto = fechaNacimiento.Value;

            emp.Dni = tbDni.Text;
            emp.Funcion = tbFuncion.Text.Trim();
            emp.Telefono = tbTelefono.Text;
            emp.Email = tbEmail.Text;

            emp.FechaEntrada = fechaEntrada.Value;

            emp.Salario = Convert.ToDouble(tbSalario.Text);

            if (radioHombre.Checked)
                emp.Sexo = "H";
            else if (radioMujer.Checked)
                emp.Sexo = "M";
            
            emp.IdDepartamento = Convert.ToInt32(cbDepartamento.SelectedValue);
            emp.IdUsuario = Convert.ToInt32(cbUsuario.SelectedValue);

            if (chkActivo.Checked)
                emp.Activo = 1;
            else
                emp.Activo = 0;


            //// Asignando el valor de la imagen

            //// Stream usado como buffer
            //MemoryStream ms = new System.IO.MemoryStream();
            //// Se guarda la imagen en el buffer
            //pictBoxFoto.Image.Save(ms, ImageFormat.Jpeg);
            //// Se extraen los bytes del buffer para asignarlos como valor para el 
            //// parámetro.
            //byte[] im = ms.GetBuffer();
            //// emp.Foto =  ms.GetBuffer();

            int resultado = 0;
            if (esNuevo)
                resultado = EmpleadoDAO.Insertar(emp); // recibe el resultado positivo al insertar
            else
            {
                resultado = EmpleadoDAO.ModificarEmpleado(emp);
            }

            if (resultado > 0)
            {
                MessageBox.Show("Empleado Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNombre.Text = "";
                tbNombre.Focus();
            }
            else
            {
                MessageBox.Show("No se pudo guardar el Empleado", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCargaImagen_Click(object sender, EventArgs e)
        {
            // Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                pictBoxFoto.Image = Image.FromFile(dialog.FileName);
            }
        }
    }
}
