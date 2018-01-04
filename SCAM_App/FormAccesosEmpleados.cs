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

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace SCAM_App
{
    public partial class FormAccesosEmpleados : Form
    {
        MySqlCommand cmd = new MySqlCommand();

        List<AccesoEmpleados> listaAccesos;
        public FormAccesosEmpleados()
        {
            InitializeComponent();
        }

        private void FormAccesosEmpleados_Load(object sender, EventArgs e)
        {
            CargaDGV();

            dgvAccesoEmpleado.AllowUserToAddRows = false;

            dgvAccesoEmpleado.Columns["Codigo"].Visible = false;
        }

        private void CargaDGV()
        {
            listaAccesos = AccesoEmpleadoDAO.ListarAccesosdeEmpleados();

            int n = 0;
            for (int i = 0; i < listaAccesos.Count; i++)
            {
                n = dgvAccesoEmpleado.Rows.Add();
                dgvAccesoEmpleado.Rows[n].Cells[0].Value = listaAccesos[i].IdAccesoEmpleado;
                dgvAccesoEmpleado.Rows[n].Cells[1].Value = EmpleadoDAO.ObtenerEmpleado(listaAccesos[i].IdEmpleado).Nombre;
                dgvAccesoEmpleado.Rows[n].Cells[2].Value = CodigoAccesoDAO.ObtenerCodigoAcceso(listaAccesos[i].IdCodAcceso).DescripcionAcceso;

            }
        }

        private void CargaDGV(List<AccesoEmpleados> listaAccesos)
        {
            dgvAccesoEmpleado.Rows.Clear();

            int n = 0;
            for (int i = 0; i < listaAccesos.Count; i++)
            {
                n = dgvAccesoEmpleado.Rows.Add();
                dgvAccesoEmpleado.Rows[n].Cells[0].Value = listaAccesos[i].IdAccesoEmpleado;
                dgvAccesoEmpleado.Rows[n].Cells[1].Value = EmpleadoDAO.ObtenerEmpleado(listaAccesos[i].IdEmpleado).Nombre;
                dgvAccesoEmpleado.Rows[n].Cells[2].Value = CodigoAccesoDAO.ObtenerCodigoAcceso(listaAccesos[i].IdCodAcceso).DescripcionAcceso;

            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAccesoEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int colum = e.ColumnIndex;
            int fila = e.RowIndex;

            if (colum < 0)
                return;

            if (dgvAccesoEmpleado.Columns[colum].HeaderText == "Borra")// <-- he pulsado el botón Borrar
            {
                int valor =Convert.ToInt32(dgvAccesoEmpleado.Rows[fila].Cells[0].Value);

                if (DialogResult.No == MessageBox.Show("¿está seguro de eliminar el acceso a\n" + dgvAccesoEmpleado.Rows[fila].Cells[2].Value + " para " + dgvAccesoEmpleado.Rows[fila].Cells[1].Value + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    return;

                AccesoEmpleadoDAO.BorarRegistro(valor);

                MessageBox.Show("Acceso Borrado con Exito !!!");

                dgvAccesoEmpleado.Rows.Clear();
                CargaDGV();
            }    
            else
                return; // <-- No he pulsado ninguno de los botones que me iteresan
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<AccesoEmpleados> localizados = new List<AccesoEmpleados>();

            localizados = AccesoEmpleadoDAO.Localizar(textBox1.Text);

            CargaDGV(localizados);
        }

        private void dgvAccesoEmpleado_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvAccesoEmpleado.Columns[e.ColumnIndex].Name == "borrar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // diseña el boton de deletar //
                DataGridViewButtonCell celBoton = this.dgvAccesoEmpleado.Rows[e.RowIndex].Cells["borrar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"..\..\..\..\img\edit_delete.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvAccesoEmpleado.Rows[e.RowIndex].Height = icoAtomico.Height + 3;
                this.dgvAccesoEmpleado.Columns[e.ColumnIndex].Width = icoAtomico.Width + 7;

                e.Handled = true;
            }

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();

            FormAccesoEmpDetalles fa = new FormAccesoEmpDetalles();
           // bunifuFormFadeTransition1.ShowAsyc( fa);
            
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

        private void btnExcel_Click(object sender, EventArgs e)
        {
            exportaraexcel(dgvAccesoEmpleado);
        }

        public void exportaraexcel(DataGridView tabla) // Exporta DatagridView para Excel  //
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);

            int indiceColumna = 0;
            foreach (DataGridViewColumn col in tabla.Columns) //Columnas
            {
                indiceColumna++;

                if (col.Name != "borrar" && col.Name != "modificar")
                    excel.Cells[1, indiceColumna] = col.Name;
            }

            int indiceFila = 0;
            foreach (DataGridViewRow row in tabla.Rows) //Filas
            {
                indiceFila++;
                indiceColumna = 0;
                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    indiceColumna++;
                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;
                }
            }
            excel.Visible = true;
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            try
            {

                Document doc = new Document(PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(@"..\..\..\ArchivosPDF\accesosAsignados.pdf", FileMode.Create));
                doc.Open();

                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"..\..\..\img\logo.png");
                logo.ScalePercent(25f);

                doc.Add(logo);

                doc.Add(new Phrase("Sistema de Controle de Accesos"));
                doc.Add(new Paragraph(""));
                doc.Add(new Paragraph(""));
                doc.Add(new Paragraph("                                         Lista de Acceso Asignados a Empleados"));
                doc.Add(new Paragraph(""));
                doc.Add(new Paragraph(""));

                PdfPTable tabla = new PdfPTable(dgvAccesoEmpleado.Columns.Count - 2);

                tabla.HorizontalAlignment = 1; // central

                for (int j = 0; j < dgvAccesoEmpleado.Columns.Count - 2; j++)
                {
                    tabla.AddCell(new Phrase(dgvAccesoEmpleado.Columns[j].HeaderText));
                }

                tabla.HeaderRows = 1;


                for (int i = 0; i < dgvAccesoEmpleado.Rows.Count - 2; i++)
                {
                    for (int h = 0; h < dgvAccesoEmpleado.Columns.Count - 2; h++)
                    {
                        if (dgvAccesoEmpleado[h, i].Value != null)
                        {
                            tabla.AddCell(new Phrase(dgvAccesoEmpleado[h, i].Value.ToString()));
                        }
                    }
                }

                doc.Add(tabla);
                doc.Close();

                MessageBox.Show("Archivo Generado con Exito");
            }
            catch (Exception)
            {

                MessageBox.Show("Error, El Archivo Actual está Abierto !!");
            }
        }
    }
}
