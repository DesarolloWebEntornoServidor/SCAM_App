using MySql.Data.MySqlClient;
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
    public partial class FormDepartamento : Form
    {
        MySqlCommand cmd = new MySqlCommand();

        List<Departamento> listaDeps;
        public FormDepartamento()
        {
            InitializeComponent();
        }

        private void FormDepartamento_Load(object sender, EventArgs e)
        {
            CargaDGV();
        }
        public void CargaDGV()
        {
            listaDeps = DepartamentoDAO.ListarDepartamentos();

            int n = 0;
            for (int i = 0; i < listaDeps.Count; i++)
            {
                n = dgvDepartamento.Rows.Add();
                dgvDepartamento.Rows[n].Cells[0].Value = listaDeps[i].IdDepartamento;
                dgvDepartamento.Rows[n].Cells[1].Value = listaDeps[i].Descripcion;
                dgvDepartamento.Rows[n].Cells[2].Value = CodigoAccesoDAO.ObtenerCodigoAcceso(listaDeps[i].IdCodigoAcceso).DescripcionAcceso;

            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnadirAcceso_Click(object sender, EventArgs e)
        {
            this.Close();
            FormDeptoDetalles fdd = new FormDeptoDetalles();
            fdd.ShowDialog();
        }
    }
}
