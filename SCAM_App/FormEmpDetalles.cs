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
        public FormEmpDetalles()
        {
            InitializeComponent();
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
        }

        private void cargaCombos()
        {
            List<Departamento> listaDeparts = DepartamentoDAO.ListarDepartamentos();

            listaDeparts.Insert(0, new Departamento(0, 0, "Seleccione el Departamento"));

            cbDepartamento.DataSource = listaDeparts;
            cbDepartamento.DisplayMember = "descripcion";
            cbDepartamento.ValueMember = "IdDepartamento";

            List<Usuario> listaUsuarios = UsuarioDAO.ListarUsuarios();

            listaUsuarios.Insert(0, new Usuario("Seleccione el Usuario"));

            cbUsuario.DataSource = listaUsuarios;
            cbUsuario.DisplayMember = "login";
            cbUsuario.ValueMember = "idUsuario";

        }

        private void btnAnadirEmpleado_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();

            emp.Nombre = tbNombre.Text.Trim();
            emp.Apellidos = tbApellidos.Text.Trim();
            emp.FechaNacto = Convert.ToDateTime(fechaNacimiento.Value.Year + "/" + fechaNacimiento.Value.Month + "/" + fechaNacimiento.Value.Day);


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
            
            emp.IdDepartamento = cbDepartamento.SelectedIndex;
            emp.IdUsuario = cbUsuario.SelectedIndex;

            if (chkActivo.Checked)
                emp.Activo = 1;
            else
                emp.Activo = 0;


            // Asignando el valor de la imagen

            // Stream usado como buffer
            MemoryStream ms = new System.IO.MemoryStream();
            // Se guarda la imagen en el buffer
            pictBoxFoto.Image.Save(ms, ImageFormat.Jpeg);
            // Se extraen los bytes del buffer para asignarlos como valor para el 
            // parámetro.
            byte[] im = ms.GetBuffer();
           // emp.Foto =  ms.GetBuffer();



            int resultado = EmpleadoDAO.Insertar(emp);

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
