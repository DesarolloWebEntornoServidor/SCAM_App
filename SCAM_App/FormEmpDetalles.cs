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
using System.Text.RegularExpressions;

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
        bool hayError = false; 

        string nombreRuta = "";
        string nombreImagen = "";

        public string NombreRuta { get => nombreRuta; set => nombreRuta = value; }

        public FormEmpDetalles()
        {
            InitializeComponent();
        }

        public FormEmpDetalles(Empleado emp)
        {
            InitializeComponent();

            this.emp = emp;
            esNuevo = false;

            if (FormLogin.usuNivelAcceso == 2)
            {
                fechaEntrada.Enabled = false;
                cbDepartamento.Enabled = false;
                cbUsuario.Enabled = false;

                chkActivo.Enabled = false;
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Volver();
        }

        private void Volver()
        {
            if (FormLogin.usuNivelAcceso == 2)
            {
                this.Close();
                this.Dispose();
                FormInicio fa1 = new FormInicio();

                fa1.StartPosition = FormStartPosition.CenterScreen;
                fa1.ShowDialog();
                fa1.Dispose();
            }
            else
            {
                this.Close();
                this.Dispose();

                FormEmpleados fa = new FormEmpleados();
                fa.Width = 880;
                fa.Height = 450;
                fa.Location = new Point(265, 160);
                fa.ShowDialog();
            }
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
                fechaNacimiento.Value = emp.FechaNacto;

                tbDni.Text = emp.Dni;
                tbFuncion.Text = emp.Funcion;
                tbTelefono.Text = emp.Telefono;
                tbEmail.Text = emp.Email;

                fechaEntrada.Value = emp.FechaEntrada;

                tbSalario.Text = emp.Salario.ToString("N2");

                NombreRuta = emp.Foto.Replace("--", "\\"); // cambio las -- por barras para guardar en la variable la ruta existente en la base  //

                // Busca imagen en la carpeta por la ruta y mostra en la ficha del empleado
                if (emp.Foto == "")
                {
                    MessageBox.Show("el archivo de foto esta vazio !!!!!");
                }
                else
                {
                    Image image = Image.FromFile(emp.Foto.Replace("--", "\\"));

                    var ms1 = new MemoryStream();

                    image.Save(ms1, ImageFormat.Png);

                    var ima = ms1.ToArray();

                    MemoryStream imagenMemory = new MemoryStream(ima);

                    pictBoxFoto.Image = Image.FromStream(ms1);
                    pictBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;

                    ms1.Dispose();
                }

                depV = DepartamentoDAO.ObtenerDepartamento(emp.IdDepartamento); // Solicita el Departamento que esta vinculado ese Empleado ///
                usuV = UsuarioDAO.ObtenerUsuario(emp.IdUsuario); // Solicita el Departamento que esta vinculado ese Empleado ///

                if (depV.IdDepartamento > 0)
                    cbDepartamento.SelectedValue = depV.IdDepartamento; // utiliza el departametno que ya exste en la base
                else
                    cbDepartamento.Text = "Seleccione un Departamento";

                if (usuV.IdUsuario > 0)
                    cbUsuario.SelectedValue = usuV.IdUsuario;  // utiliza el usuario que ya existe en la base
                else
                    cbUsuario.Text = "Seleccione un Usuario";

                if (emp.Sexo == "H")  // activa el radio check, con el sexo que ya existe en la base
                    radioHombre.Checked = true;
                else if (emp.Sexo == "M")
                    radioMujer.Checked = true;

                if (emp.Activo == 1) // activa el check box si ya esta activado en la base
                    chkActivo.Checked = true;
                else
                    chkActivo.Checked = false;
            }
        }

        private void cargaCombos() // varga los comboos de Departamento e Usuario para el empleado //
        {
            listaDeparts = DepartamentoDAO.ListarDepartamentos();

            listaDeparts.Insert(0, new Departamento(0, 0, "Seleccione un Departamento"));

            cbDepartamento.DataSource = listaDeparts;
            cbDepartamento.DisplayMember = "descripcion";
            cbDepartamento.ValueMember = "IdDepartamento";

            listaUsuarios = UsuarioDAO.ListarUsuarios();

            listaUsuarios.Insert(0, new Usuario("Seleccione un Usuario"));

            cbUsuario.DataSource = listaUsuarios;
            cbUsuario.DisplayMember = "login";
            cbUsuario.ValueMember = "idUsuario";

        }

        private void btnAnadirEmpleado_Click(object sender, EventArgs e)
        {
            hayError = HayErrorEnFormulario();

            if (hayError)
            {
                MessageBox.Show("Existe Error en el Formulario, Presione F1 si necesitas Ayuda !!!");
                return;
            }

            Empleado emp = new Empleado();  // coge los datos del formulario y mete en el Objeto Empleado

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

            // guardo la imagen en la carpeta y en el atributo Foto
            if(NombreRuta != "")
            {
                Image image = Image.FromFile(NombreRuta);

                MemoryStream ms1 = new MemoryStream();

                image.Save(ms1, ImageFormat.Png);

                byte[] ima = ms1.ToArray();

                emp.Foto = nombreRuta.Replace("\\", "--"); // cambio las barras por -- para guardar en la base de datos  //
            }
                


            int resultado = 0;
            if (esNuevo)
                resultado = EmpleadoDAO.Insertar(emp); // recibe el resultado positivo al insertar
            else
            {
                emp.IdEmpleado = Convert.ToInt32(tbIdEmpleado.Text);

                emp.Foto = NombreRuta.Replace("\\", "--");

                resultado = EmpleadoDAO.ModificarEmpleado(emp);
            }

            if (resultado > 0)
            {

                if(emp.Activo == 0)  // si el empleado ha sido desactivado, deberá automaticamente desactivar el Usuario a él correspondiente  //
                {
                    Usuario usu = UsuarioDAO.ObtenerUsuario(emp.IdUsuario);

                    usu.Acceso = 0;

                    UsuarioDAO.ModificarUsuario(usu);
                }


                MessageBox.Show("Empleado Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Volver();
            }
            else
            {
                MessageBox.Show("No se pudo guardar el Empleado", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCargaImagen_Click(object sender, EventArgs e)
        {         
            OpenFileDialog abrir = new OpenFileDialog(); // inicia a carga del imagen del empleado
            abrir.Filter = "*.jpg;*.png|*.jpg;*.png";
            abrir.RestoreDirectory = true;
            string nuevaRuta = "";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                pictBoxFoto.Image = Image.FromFile(abrir.FileName);
                pictBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;

                nuevaRuta = Path.Combine(@"..\..\..\FotosEmpleados", Path.GetFileName(abrir.FileName));
                try   // para que no de error al aparecer una foto igual a una existente en la carpeta
                {
                    File.Copy(abrir.FileName, nuevaRuta);
                }
                catch (IOException)
                {
                    MessageBox.Show("Ya existe una Foto con ese nombre !!!");
                }
            }
            else
            {
                pictBoxFoto.Image = null;
            }

            nombreRuta = nuevaRuta;
            nombreImagen = abrir.SafeFileName;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    // Llamamos al Formulario de Ayuda
                    //
                    Help.FormHelpEmpleado frm = new Help.FormHelpEmpleado();
                    frm.ShowDialog();
                    frm.Dispose();
                    break;
                case Keys.Escape:
                    Volver();

                    break;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private bool HayErrorEnFormulario()
        {
            hayError = false;
            string pathString = @"[A-Z]{1}[a-zA-ZàáâäãåąčćęèéêëėįìíîïłńòóôöõøùúûüųūÿýżźñçčšžÀÁÂÄÃÅĄĆČĖĘÈÉÊËÌÍÎÏĮŁŃÒÓÔÖÕØÙÚÛÜŲŪŸÝŻŹÑßÇŒÆČŠŽ∂ð,.'-]{2,29}";
            string paternTelefono = @"[0-9]{9}$";
            string pathernDni = @"^(([A-Z]\d{8})|(\d{8}-[A-Z]))$";
            string patherMail = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            string pathernSalario = @"[^\\d,\\d]";

            if (!Regex.IsMatch(tbNombre.Text, pathString) || tbNombre.Text.Trim().Length > 30)
            {
                errorProvider1.SetError(tbNombre, "Error en el Formato del Nombre ");

                hayError = true;
            }
            else
                errorProvider1.SetError(tbNombre, "");

            if (!Regex.IsMatch(tbApellidos.Text, pathString) || tbApellidos.Text.Trim().Length > 40)
            {
                errorProvider1.SetError(tbApellidos, "Error en el Formato del Apellido ");

                hayError = true;
            }
            else
                errorProvider1.SetError(tbApellidos, "");

            if (!Regex.IsMatch(tbDni.Text, pathernDni))
            {
                errorProvider1.SetError(tbDni, "Error en el Formato del DNI ");

                hayError = true;
            }
            else
                errorProvider1.SetError(tbDni, "");

            if (!Regex.IsMatch(tbFuncion.Text, pathString))
            {
                errorProvider1.SetError(tbFuncion, "Error en el Formato de la Función ");

                hayError = true;
            }
            else
                errorProvider1.SetError(tbFuncion, "");

            if (!Regex.IsMatch(tbTelefono.Text, paternTelefono) || tbTelefono.Text.Trim().Length > 9)
            {
                errorProvider1.SetError(tbTelefono, "Error en el Formato de telefono ");
                hayError = true;
            }
            else
                errorProvider1.SetError(tbTelefono, "");

            if (!Regex.IsMatch(tbEmail.Text, patherMail))
            {
                errorProvider1.SetError(tbEmail, "Error en el Formato del Correo ");

                hayError = true;
            }
            else
                errorProvider1.SetError(tbEmail, "");

            if (!Regex.IsMatch(tbSalario.Text, pathernSalario))
            {
                tbSalario.Text = tbSalario.Text.Replace(".", ",");
                errorProvider1.SetError(tbSalario, "Tienes que Informar el Salário");
                hayError = true;
            }
            else
                errorProvider1.SetError(tbSalario, "");

            if (cbDepartamento.Text == "Seleccione un Departamento")
            {
                errorProvider1.SetError(cbDepartamento, "Error, Tienes que seleccionar algun Departamento ");
                hayError = true;

            }
            else
                errorProvider1.SetError(cbDepartamento, "");

            if (radioHombre.Checked == false && radioMujer.Checked == false)
            {
                errorProvider1.SetError(radioMujer, "Error, Tienes que seleccionar algun Sexo ");
                hayError = true;

            }
            else
                errorProvider1.SetError(radioMujer, "");

            if (cbUsuario.Text == "Seleccione un Usuario")
            {
                errorProvider1.SetError(cbUsuario, "Error, Tienes que seleccionar un Usuario ");
                hayError = true;

            }
            else
                errorProvider1.SetError(cbUsuario, "");

            Empleado UsuExiste = EmpleadoDAO.BuscarEmpleadoVinculado(Convert.ToInt32(cbUsuario.SelectedValue));
            if (UsuExiste != null)
            {
                errorProvider1.SetError(cbUsuario, "Error, No puedes Vincular el mismo Usuario a dos Empleados ");
                hayError = true;

            }
            else
                errorProvider1.SetError(cbUsuario, "");

            return hayError;
        }
    }
}
