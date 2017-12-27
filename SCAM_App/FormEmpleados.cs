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
    public partial class FormEmpleados : Form
    {
        MySqlCommand cmd = new MySqlCommand();

        List<Empleado> listaEmpleados;
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            CargaDGV();

        }

        private void CargaDGV()
        {
            listaEmpleados = EmpleadoDAO.ListarEmpleados();


            int n = 0;
            for (int i = 0; i < listaEmpleados.Count; i++)
            {
                n = dgvEmpleados.Rows.Add();
                dgvEmpleados.Rows[n].Cells[0].Value = listaEmpleados[i].IdEmpleado;
                dgvEmpleados.Rows[n].Cells[1].Value = listaEmpleados[i].Nombre;
                dgvEmpleados.Rows[n].Cells[2].Value = listaEmpleados[i].Apellidos;
                dgvEmpleados.Rows[n].Cells[3].Value = listaEmpleados[i].Dni;
                dgvEmpleados.Rows[n].Cells[4].Value = listaEmpleados[i].Funcion;
                dgvEmpleados.Rows[n].Cells[5].Value = listaEmpleados[i].Telefono;
                dgvEmpleados.Rows[n].Cells[6].Value = listaEmpleados[i].Email;
                dgvEmpleados.Rows[n].Cells[7].Value = DepartamentoDAO.ObtenerDepartamento(listaEmpleados[i].IdDepartamento).Descripcion;



            }
        }

        private void btnAnadirEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
            FormEmpDetalles fed = new FormEmpDetalles();
            fed.ShowDialog();
        }
    }
}
