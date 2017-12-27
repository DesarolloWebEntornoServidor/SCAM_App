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
        public FormDeptoDetalles()
        {
            InitializeComponent();
        }

        private void FormDeptoDetalles_Load(object sender, EventArgs e)
        {
            txtIdDepto.Enabled = false;

            cargaCombo();
        }

        private void cargaCombo()
        {
            List<CodigoAcceso> listaCodigos = CodigoAccesoDAO.ListarCodigosAcceso();

            listaCodigos.Insert(0, new CodigoAcceso(0, "Mensagen", "Seleccione el Nivel de Acceso")); 


            cbCodigosAcceso.DataSource = listaCodigos;
            cbCodigosAcceso.DisplayMember = "descripcionAcceso";
            cbCodigosAcceso.ValueMember = "IdCodigoAcceso";
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormDepartamento fa = new FormDepartamento();
            fa.Width = 860;
            fa.Height = 450;
            fa.Location = new Point(280, 160);
            fa.ShowDialog();
        }

        private void btnAnadirAcceso_Click(object sender, EventArgs e)
        {
            Departamento dep = new Departamento();

            dep.Descripcion = txtDescripcion.Text.Trim();
            dep.IdCodigoAcceso = cbCodigosAcceso.SelectedIndex;

            int resultado = DepartamentoDAO.Insertar(dep);

            if (resultado > 0)
            {
                MessageBox.Show("Departamento Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescripcion.Text = "";
                txtDescripcion.Focus();
            }
            else
            {
                MessageBox.Show("No se pudo guardar el Departamento", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

     
    }
}
