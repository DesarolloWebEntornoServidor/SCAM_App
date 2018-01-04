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
    public partial class FormDeptoDetalles : Form
    {
        private Departamento dep;
        private CodigoAcceso codV = null;
        List<CodigoAcceso> listaCodigos;
        bool esNuevo = true;
        bool hayError = false;

        public FormDeptoDetalles()
        {
            InitializeComponent();
        }

        public FormDeptoDetalles(Departamento dep)
        {
            InitializeComponent();

            this.dep = dep;
            esNuevo = false;
        }

        private void FormDeptoDetalles_Load(object sender, EventArgs e)
        {
            txtIdDepto.Enabled = false;

            cargaCombo();

            if (esNuevo == false)
            {
                txtIdDepto.Text = dep.IdDepartamento.ToString();

                txtDescripcion.Text = dep.Descripcion;

                codV = CodigoAccesoDAO.ObtenerCodigoAcceso(dep.IdCodigoAcceso); // Solicita el empleado que esta vinculado a ese usuario ///

                if (codV.IdCodigoAcceso > 0)
                    cbCodigosAcceso.SelectedValue = codV.IdCodigoAcceso;
                else
                    cbCodigosAcceso.Text = "Seleccione un Nivel de Acceso";
            }
        }

        private void cargaCombo()
        {
            listaCodigos = CodigoAccesoDAO.ListarCodigosAcceso();
            if(esNuevo)
                listaCodigos.Insert(0, new CodigoAcceso(0, "Mensagen", "Seleccione un Nivel de Acceso")); 


            cbCodigosAcceso.DataSource = listaCodigos;
            cbCodigosAcceso.DisplayMember = "descripcionAcceso";
            cbCodigosAcceso.ValueMember = "IdCodigoAcceso";
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Volver();
        }

        private void btnAnadirAcceso_Click(object sender, EventArgs e)
        {
            hayError = HayErrorEnFormulario();

            if (hayError)
            {
                MessageBox.Show("Existe Error en el Formulario, Presione F1 si necesitas Ayuda !!!");
                return;
            }

            Departamento dep = new Departamento();

            dep.Descripcion = txtDescripcion.Text.Trim();
            dep.IdCodigoAcceso = Convert.ToInt32( cbCodigosAcceso.SelectedValue);

            int resultado = 0;
            if (esNuevo)
                resultado = DepartamentoDAO.Insertar(dep); // recibe el resultado positivo al insertar
            else
            {
                int idCod = cbCodigosAcceso.SelectedIndex;
                dep.IdDepartamento = Convert.ToInt32(txtIdDepto.Text);
                resultado = DepartamentoDAO.ModificarDepartamento(dep);
            }

            if (resultado > 0)
            {
                MessageBox.Show("Departamento Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Volver();

            }
            else
            {
                MessageBox.Show("No se pudo guardar el Departamento", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Volver()
        {
            this.Close();
            this.Dispose();

            FormDepartamento fa = new FormDepartamento();
            fa.Width = 579;
            fa.Height = 435;
            fa.Location = new Point(280, 160);
            fa.ShowDialog();
        }

        private bool HayErrorEnFormulario()
        {
            hayError = false;
            string pathString = @"[A-Z]{1}[a-zA-ZàáâäãåąčćęèéêëėįìíîïłńòóôöõøùúûüųūÿýżźñçčšžÀÁÂÄÃÅĄĆČĖĘÈÉÊËÌÍÎÏĮŁŃÒÓÔÖÕØÙÚÛÜŲŪŸÝŻŹÑßÇŒÆČŠŽ∂ð,.'-]{2,44}";

            if (!Regex.IsMatch(txtDescripcion.Text, pathString) || txtDescripcion.Text.Trim().Length > 45)
            {
                errorProvider1.SetError(txtDescripcion, "Error en el Formato del Nombre del Departamento ");

                hayError = true;
            }
            else
                errorProvider1.SetError(txtDescripcion, "");

            if (cbCodigosAcceso.Text == "Seleccione un Nivel de Acceso")
            {
                errorProvider1.SetError(cbCodigosAcceso, "Error, Tieenes que seleccionar algun Codigo de Acceso ");
                hayError = true;

            }
            else
                errorProvider1.SetError(cbCodigosAcceso, "");


            return hayError;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    // Llamamos al Formulario de Ayuda
                    //
                    Help.FormHelpDepartamento frm = new Help.FormHelpDepartamento();
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
