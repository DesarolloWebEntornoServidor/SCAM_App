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

            dgvDepartamento.AllowUserToAddRows = false;

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

        private void CargaDGV(List<Departamento> listaDeps) // carga el data grid por el localizador
        {
            dgvDepartamento.Rows.Clear();

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

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.Close();
            FormDeptoDetalles fa = new FormDeptoDetalles();

            fa.Width = 579;
            fa.Height = 435;
            fa.Location = new Point(280, 160);
            fa.ShowDialog();
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
                    this.Close();

                    break;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Departamento> localizados = new List<Departamento>();

            localizados = DepartamentoDAO.Localizar(textBox1.Text);

            CargaDGV(localizados);
        }

        private void dgvDepartamento_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvDepartamento.Columns[e.ColumnIndex].Name == "borrar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // diseña el boton de deletar //
                DataGridViewButtonCell celBoton = this.dgvDepartamento.Rows[e.RowIndex].Cells["borrar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"..\..\..\..\img\edit_delete.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvDepartamento.Rows[e.RowIndex].Height = icoAtomico.Height + 3;
                this.dgvDepartamento.Columns[e.ColumnIndex].Width = icoAtomico.Width + 3;

                e.Handled = true;
            }

            if (e.ColumnIndex >= 0 && this.dgvDepartamento.Columns[e.ColumnIndex].Name == "modificar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // diseña el boton de modificar //
                DataGridViewButtonCell celBoton1 = this.dgvDepartamento.Rows[e.RowIndex].Cells["modificar"] as DataGridViewButtonCell;
                Icon icoAtomico1 = new Icon(Environment.CurrentDirectory + @"..\..\..\..\img\modificar.ico");
                e.Graphics.DrawIcon(icoAtomico1, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvDepartamento.Rows[e.RowIndex].Height = icoAtomico1.Height + 3;
                this.dgvDepartamento.Columns[e.ColumnIndex].Width = icoAtomico1.Width + 3;

                e.Handled = true;
            }
        }

        private void dgvDepartamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int colum = e.ColumnIndex;
            int fila = e.RowIndex;

            if (colum < 0)
                return;

            if (dgvDepartamento.Columns[colum].HeaderText == "Borrar")// <-- he pulsado el botón Borrar
            {
                int id = Convert.ToInt32(dgvDepartamento.Rows[fila].Cells[0].Value);

                if (DialogResult.No == MessageBox.Show("¿está seguro de eliminar al Departamento de\n" + dgvDepartamento.Rows[fila].Cells[1].Value + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    return;

                int retorno = DepartamentoDAO.BorarRegistro(id);

                if(retorno > 0)
                    MessageBox.Show("Departamento Borrado con Exito !!!");
                else
                    MessageBox.Show("Error !!! Existe Empleado Vinculado a ese Departamento !!!");


                dgvDepartamento.Rows.Clear();
                CargaDGV();
            }
            else if (dgvDepartamento.Columns[colum].HeaderText == "Modificar")// <-- he pulsado el botón Modificar
            {
                colum = e.ColumnIndex;
                fila = e.RowIndex;

                int id = Convert.ToInt32(dgvDepartamento.Rows[fila].Cells[0].Value);

                Departamento dep = DepartamentoDAO.ObtenerDepartamento(id);

                if (colum < 0)
                    return;

                this.Close();
                FormDeptoDetalles fa = new FormDeptoDetalles(dep);

                fa.Width = 579;
                fa.Height = 435;
                fa.Location = new Point(280, 160);
                fa.ShowDialog();
                fa.Dispose();
            }
            else
                return; // <-- No he pulsado ninguno de los botones que me iteresan
        }
    }
}
