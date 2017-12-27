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
using MySql.Data.MySqlClient;

namespace SCAM_App
{
    public partial class FormAccesos : Form
    {
        MySqlCommand cmd = new MySqlCommand();

        List<CodigoAcceso> listaCodigos;


        public FormAccesos()
        {
            InitializeComponent();
        }

        private void FormAccesos_Load(object sender, EventArgs e)
        {
            CargaDGV();

        }
        public void CargaDGV()
        {
            listaCodigos = CodigoAccesoDAO.ListarCodigosAcceso();

            int n = 0;
            for (int i = 0; i < listaCodigos.Count; i++)
            {
                n = dgvAccesos.Rows.Add();
                dgvAccesos.Rows[n].Cells[0].Value = listaCodigos[i].IdCodigoAcceso;
                dgvAccesos.Rows[n].Cells[1].Value = listaCodigos[i].DescripcionAcceso;

            }
        }

        void adicionarItem(int codigo, string descripcion)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void tbLocalizar_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAnadirAcceso_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAccesoDetalles fad = new FormAccesoDetalles();
            fad.ShowDialog();
        }
    }
}
