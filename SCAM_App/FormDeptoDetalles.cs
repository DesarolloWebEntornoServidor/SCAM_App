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
    public partial class FormDeptoDetalles : Form
    {
        private Departamento dep;
        private CodigoAcceso codV = null;
        List<CodigoAcceso> listaCodigos;
        bool esNuevo = true;

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
                listaCodigos.Insert(0, new CodigoAcceso(0, "Mensagen", "Seleccione el Nivel de Acceso")); 


            cbCodigosAcceso.DataSource = listaCodigos;
            cbCodigosAcceso.DisplayMember = "descripcionAcceso";
            cbCodigosAcceso.ValueMember = "IdCodigoAcceso";
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormDepartamento fa = new FormDepartamento();
            fa.Width = 579;
            fa.Height = 435;
            fa.Location = new Point(280, 160);
            fa.ShowDialog();
        }

        private void btnAnadirAcceso_Click(object sender, EventArgs e)
        {
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

                this.Hide();

                FormDepartamento fa = new FormDepartamento();
                fa.Width = 579;
                fa.Height = 435;
                fa.Location = new Point(280, 160);
                fa.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se pudo guardar el Departamento", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
                    this.Hide();
                    FormDepartamento fa = new FormDepartamento();
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
