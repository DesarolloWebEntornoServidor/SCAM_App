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

            dgvAccesos.AllowUserToAddRows = false;

            dgvAccesos.Columns["Codigo"].Visible = false;
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

        public void CargaDGV(List<CodigoAcceso> listaCodigos)
        {
            dgvAccesos.Rows.Clear();

            int n = 0;
            for (int i = 0; i < listaCodigos.Count; i++)
            {
                n = dgvAccesos.Rows.Add();
                dgvAccesos.Rows[n].Cells[0].Value = listaCodigos[i].IdCodigoAcceso;
                dgvAccesos.Rows[n].Cells[1].Value = listaCodigos[i].DescripcionAcceso;

            }
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();

            FormAccesoDetalles fa = new FormAccesoDetalles();
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
                    this.Dispose();


                    break;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<CodigoAcceso> localizados = new List<CodigoAcceso>();

            localizados = CodigoAccesoDAO.Localizar(textBox1.Text);

            CargaDGV(localizados);
        }

        private void dgvAccesos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvAccesos.Columns[e.ColumnIndex].Name == "borrar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // diseña el boton de deletar //
                DataGridViewButtonCell celBoton = this.dgvAccesos.Rows[e.RowIndex].Cells["borrar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"..\..\..\..\img\edit_delete.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvAccesos.Rows[e.RowIndex].Height = icoAtomico.Height + 3;
                this.dgvAccesos.Columns[e.ColumnIndex].Width = icoAtomico.Width + 7;

                e.Handled = true;
            }

            if (e.ColumnIndex >= 0 && this.dgvAccesos.Columns[e.ColumnIndex].Name == "modificar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // diseña el boton de modificar //
                DataGridViewButtonCell celBoton1 = this.dgvAccesos.Rows[e.RowIndex].Cells["modificar"] as DataGridViewButtonCell;
                Icon icoAtomico1 = new Icon(Environment.CurrentDirectory + @"..\..\..\..\img\modificar.ico");
                e.Graphics.DrawIcon(icoAtomico1, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvAccesos.Rows[e.RowIndex].Height = icoAtomico1.Height + 3;
                this.dgvAccesos.Columns[e.ColumnIndex].Width = icoAtomico1.Width + 7;

                e.Handled = true;
            }
        } 

        private void dgvAccesos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int colum = e.ColumnIndex;
            int fila = e.RowIndex;

            if (colum < 0)
                return;

            if (dgvAccesos.Columns[colum].HeaderText == "Borra")// <-- he pulsado el botón Borrar
            {
                int id = Convert.ToInt32(dgvAccesos.Rows[fila].Cells[0].Value); 

                if (DialogResult.No == MessageBox.Show("¿está seguro de eliminar el Código\n" + dgvAccesos.Rows[fila].Cells[1].Value + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    return;

                int retorno = CodigoAccesoDAO.BorarRegistro(id);

                if (retorno > 0)
                    MessageBox.Show("Código de Acceso Borrado con Exito !!!");
                else
                    MessageBox.Show("Error !!! Existe Código está Vinculado a un Departamento !!!");

                dgvAccesos.Rows.Clear();
                CargaDGV();
            }
            else if (dgvAccesos.Columns[colum].HeaderText == "Edita")// <-- he pulsado el botón Borrar
            {
                colum = e.ColumnIndex;
                fila = e.RowIndex;

                int id = Convert.ToInt32(dgvAccesos.Rows[fila].Cells[0].Value);

                CodigoAcceso cod = CodigoAccesoDAO.ObtenerCodigoAcceso(id);

                if (colum < 0)
                    return;

                this.Close();
                FormAccesoDetalles fa = new FormAccesoDetalles(cod);

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
