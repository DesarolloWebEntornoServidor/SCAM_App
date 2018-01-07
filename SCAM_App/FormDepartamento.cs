using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
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

            dgvDepartamento.Columns["Codigo"].Visible = false;

            panelLista.Visible = false;

            btnCerrarDepto.Visible = false;
            btnPrinterLista.Visible = false;

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
            LlamaDetalles();
        }

        private void LlamaDetalles()
        {
            this.Close();
            this.Dispose();

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
                    this.Dispose();


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
                this.dgvDepartamento.Columns[e.ColumnIndex].Width = icoAtomico.Width + 7;

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
                this.dgvDepartamento.Columns[e.ColumnIndex].Width = icoAtomico1.Width + 7;

                e.Handled = true;
            }
        }

        private void dgvDepartamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int colum = e.ColumnIndex;
            int fila = e.RowIndex;

            if (colum < 0)
                return;

            if (dgvDepartamento.Columns[colum].HeaderText == "Borra")// <-- he pulsado el botón Borrar
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
            else if (dgvDepartamento.Columns[colum].HeaderText == "Edita")// <-- he pulsado el botón Modificar
            {
                colum = e.ColumnIndex;
                fila = e.RowIndex;

                int id = Convert.ToInt32(dgvDepartamento.Rows[fila].Cells[0].Value);

                Departamento dep = DepartamentoDAO.ObtenerDepartamento(id);

                if (colum < 0)
                    return;

                this.Close();
                this.Dispose();

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

        private void btnExcel_Click(object sender, EventArgs e)
        {
            exportaraexcel(dgvDepartamento);
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
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(@"..\..\..\ArchivosPDF\departamentos.pdf", FileMode.Create));
                doc.Open();

                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"..\..\..\img\logo.png");
                logo.ScalePercent(25f);

                doc.Add(logo);

                doc.Add(new Phrase("Sistema de Controle de Accesos"));
                doc.Add(new Paragraph(""));
                doc.Add(new Paragraph(""));
                doc.Add(new Paragraph("                                         Lista de Departamentos"));
                doc.Add(new Paragraph(""));
                doc.Add(new Paragraph(""));

                PdfPTable tabla = new PdfPTable(dgvDepartamento.Columns.Count-2);

                tabla.HorizontalAlignment = 1; // central

                for (int j = 0; j < dgvDepartamento.Columns.Count-2; j++)
                {
                         tabla.AddCell(new Phrase(dgvDepartamento.Columns[j].HeaderText));
                }

                tabla.HeaderRows = 1;


                for (int i = 0; i < dgvDepartamento.Rows.Count-2; i++)
                {
                    for (int h = 0; h < dgvDepartamento.Columns.Count-2; h++)
                    {
                        if (dgvDepartamento[h, i].Value != null)
                        {
                            tabla.AddCell(new Phrase(dgvDepartamento[h, i].Value.ToString()));
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

        private void btnCerrarDepto_Click(object sender, EventArgs e)
        {
            panelLista.Visible = false;

            btnCerrarDepto.Visible = false;
            btnPrinterLista.Visible = false;
        }

        private void btnPrinterDepLista_Click(object sender, EventArgs e)
        {
            string resultado = "";
            int contador = 0;

            resultado += "\t\t" + "Lista de Departamentos" + "\r\n" + "\r\n";

            for (int i = 0; i < listaDeps.Count; i++)
            {
                resultado += "\t" + listaDeps[i].Descripcion + "\r\n";
                tbLista.Text = resultado;

                contador++;
            }

            resultado += "\r\n\t" + "Existen " + contador + " Departamentos Registrados " + "\r\n";
            tbLista.Text = resultado;

            panelLista.Invalidate();

            panelListaTrans.ShowSync(panelLista);

            panelLista.Visible = true;

            btnCerrarDepto.Visible = true;
            btnPrinterLista.Visible = true;
        }
    }
}
