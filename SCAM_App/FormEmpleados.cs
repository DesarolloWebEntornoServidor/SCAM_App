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
using BarcodeLib;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing.Imaging;

namespace SCAM_App
{
    public partial class FormEmpleados : Form
    {
        MySqlCommand cmd = new MySqlCommand();

        List<Empleado> listaEmpleados;
        private int v;

        public FormEmpleados()
        {
            InitializeComponent();

            dgvEmpleados.AllowUserToAddRows = false;

            panelTarjeta.Visible = false;

            btnCerrarTarjeta.Visible = false;
            btnPrinter.Visible = false;

            panelLista.Visible = false;

            btnCerraLista.Visible = false;
            btnPrinterLista.Visible = false;

        }

        public FormEmpleados(int v)
        {
            this.v = v;

            InitializeComponent();

            if (v == 2)
            {
                Modificar(FormLogin.usuId);

            }
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
        private void CargaDGV(List<Empleado> listaEmpleados)
        {
            dgvEmpleados.Rows.Clear();

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
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();

            FormEmpDetalles fa = new FormEmpDetalles();
            fa.Width = 800;
            fa.Height = 450;
            fa.Location = new Point(280, 160);
            fa.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Empleado> localizados = EmpleadoDAO.Localizar(textBox1.Text);

           // localizados = DepartamentoDAO.Localizar(textBox1.Text);

            CargaDGV(localizados);
        }

        private void dgvEmpleados_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvEmpleados.Columns[e.ColumnIndex].Name == "borrar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // diseña el boton de deletar //
                DataGridViewButtonCell celBoton = this.dgvEmpleados.Rows[e.RowIndex].Cells["borrar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"..\..\..\..\img\edit_delete.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvEmpleados.Rows[e.RowIndex].Height = icoAtomico.Height + 3;
                this.dgvEmpleados.Columns[e.ColumnIndex].Width = icoAtomico.Width + 7;

                e.Handled = true;
            }

            if (e.ColumnIndex >= 0 && this.dgvEmpleados.Columns[e.ColumnIndex].Name == "modificar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // diseña el boton de modificar //
                DataGridViewButtonCell celBoton1 = this.dgvEmpleados.Rows[e.RowIndex].Cells["modificar"] as DataGridViewButtonCell;
                Icon icoAtomico1 = new Icon(Environment.CurrentDirectory + @"..\..\..\..\img\modificar.ico");
                e.Graphics.DrawIcon(icoAtomico1, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvEmpleados.Rows[e.RowIndex].Height = icoAtomico1.Height + 3;
                this.dgvEmpleados.Columns[e.ColumnIndex].Width = icoAtomico1.Width + 7;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgvEmpleados.Columns[e.ColumnIndex].Name == "tarjeta" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // diseña el boton de modificar //
                DataGridViewButtonCell celBoton1 = this.dgvEmpleados.Rows[e.RowIndex].Cells["tarjeta"] as DataGridViewButtonCell;
                Icon icoAtomico1 = new Icon(Environment.CurrentDirectory + @"..\..\..\..\img\credit-card.ico");
                e.Graphics.DrawIcon(icoAtomico1, e.CellBounds.Left + 10, e.CellBounds.Top + 3);

                this.dgvEmpleados.Rows[e.RowIndex].Height = icoAtomico1.Height + 3;
                this.dgvEmpleados.Columns[e.ColumnIndex].Width = icoAtomico1.Width + 20;

                e.Handled = true;
            }
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int colum = e.ColumnIndex;
            int fila = e.RowIndex;

            if (colum < 0)
                return;

            if (dgvEmpleados.Columns[colum].HeaderText == "Borra")// <-- he pulsado el botón Borrar
            {
                int id = Convert.ToInt32(dgvEmpleados.Rows[fila].Cells[0].Value);

                if (DialogResult.No == MessageBox.Show("¿está seguro de eliminar al Empleado\n" + dgvEmpleados.Rows[fila].Cells[1].Value + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    return;

                int retorno = EmpleadoDAO.BorarRegistro(id);

                if (retorno > 0)
                    MessageBox.Show("Empleado Borrado con Exito !!!");
                else
                    MessageBox.Show("Error !!! Existe Usuario Vinculado a ese Empleado !!!");

                dgvEmpleados.Rows.Clear();
                CargaDGV();
            }
            else if (dgvEmpleados.Columns[colum].HeaderText == "Edita")// <-- he pulsado el botón Modificar
            {
                colum = e.ColumnIndex;
                fila = e.RowIndex;

                int id = Convert.ToInt32(dgvEmpleados.Rows[fila].Cells[0].Value);


                if (colum < 0)
                    return;

                Empleado emp = EmpleadoDAO.ObtenerEmpleado(id);

                this.Close();
                this.Dispose();
                FormEmpDetalles fa = new FormEmpDetalles(emp);

                fa.Width = 800;
                fa.Height = 450;
                fa.Location = new Point(280, 160);
                fa.ShowDialog();
                fa.Dispose();
            }
            else if (dgvEmpleados.Columns[colum].HeaderText == "Genera")// <-- he pulsado el botón Modificar
            {
                colum = e.ColumnIndex;
                fila = e.RowIndex;

                int id = Convert.ToInt32(dgvEmpleados.Rows[fila].Cells[0].Value);

                if (colum < 0)
                    return;

                Empleado emp = EmpleadoDAO.ObtenerEmpleado(id);

                lbNombre.Text = emp.Nombre + " " + emp.Apellidos;

                lbFuncion.Text = emp.Funcion;

                lbDepartamento.Text = DepartamentoDAO.ObtenerDepartamento(emp.IdDepartamento).Descripcion;

                // Busca imagen en la carpeta por la ruta y mostra en la ficha del empleado
                if (emp.Foto == "")
                {
                    MessageBox.Show("el archivo de foto esta vazio !!!!!");
                }
                else
                {
                    System.Drawing.Image image = System.Drawing.Image.FromFile(emp.Foto.Replace("--", "\\"));

                    var ms1 = new MemoryStream();

                    image.Save(ms1, ImageFormat.Png);

                    var ima = ms1.ToArray();

                    MemoryStream imagenMemory = new MemoryStream(ima);

                    pictFotoTarjeta.Image = System.Drawing.Image.FromStream(ms1);
                    pictFotoTarjeta.SizeMode = PictureBoxSizeMode.StretchImage;

                    ms1.Dispose();
                }

                panelTarjetaTransition.ShowSync(panelTarjeta);

                panelTarjeta.Visible = true;

                btnCerrarTarjeta.Visible = true;
                btnPrinter.Visible = true;
                try
                {
                    BarcodeLib.Barcode codigo = new BarcodeLib.Barcode();


                    string nombreCodBarras = emp.Nombre;

                    if(nombreCodBarras.Length > 15)
                        nombreCodBarras = emp.Nombre.Substring(0,15);

                    codigo.IncludeLabel = true;
                    panelResultado.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE128, nombreCodBarras, Color.Black, Color.White, 400, 100);
                }
                catch (Exception)
                {

                    throw;
                }

            }
            else
                return; // <-- No he pulsado ninguno de los botones que me iteresan
        }

        private void Modificar(int idUsu)
        {
            Empleado emp = EmpleadoDAO.BuscarEmpleadoVinculado(idUsu);

            this.Close();
            this.Dispose();

            FormEmpDetalles fa = new FormEmpDetalles(emp);

            fa.Width = 800;
            fa.Height = 450;
            fa.Location = new Point(280, 160);
            fa.ShowDialog();
            fa.Dispose();

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

        private void btnCerrarTarjeta_Click(object sender, EventArgs e)  //  Gebera las TArjeta del Empleado
        {
            panelTarjeta.Visible = false;

            btnCerrarTarjeta.Visible = false;
            btnPrinter.Visible = false;


        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            exportaraexcel(dgvEmpleados);
        }

        public void exportaraexcel(DataGridView tabla) // Exporta DatagridView para Excel  //
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);

            int indiceColumna = 0;
            foreach (DataGridViewColumn col in tabla.Columns) //Columnas
            {
                indiceColumna++;

                if (col.Name != "borrar" && col.Name != "modificar" && col.Name != "tarjeta")
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
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(@"..\..\..\ArchivosPDF\empleados.pdf", FileMode.Create));
                doc.Open();

                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"..\..\..\img\logo.png");
                logo.ScalePercent(25f);

                doc.Add(logo);

                doc.Add(new Phrase("Sistema de Controle de Accesos"));
                doc.Add(new Paragraph(""));
                doc.Add(new Paragraph(""));
                doc.Add(new Paragraph("                                         Lista de Empleados"));
                doc.Add(new Paragraph(""));
                doc.Add(new Paragraph(""));

                PdfPTable tabla = new PdfPTable(dgvEmpleados.Columns.Count-3);

                tabla.HorizontalAlignment = 1; // central

                for (int j = 0; j < dgvEmpleados.Columns.Count-3; j++)
                {
                    tabla.AddCell(new Phrase(dgvEmpleados.Columns[j].HeaderText));
                }

                tabla.HeaderRows = 1;


                for (int i = 0; i < dgvEmpleados.Rows.Count-3; i++)
                {
                    for (int h = 0; h < dgvEmpleados.Columns.Count-3; h++)
                    {
                        if (dgvEmpleados[h, i].Value != null)
                        {
                            tabla.AddCell(new Phrase(dgvEmpleados[h, i].Value.ToString()));
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

        private void btnPrinter_Click(object sender, EventArgs e)
        {

        }

        private void btnCerraLista_Click(object sender, EventArgs e)
        {
            panelLista.Visible = false;

            btnCerraLista.Visible = false;
            btnPrinterLista.Visible = false;
        }

        private void btnPrinterEmpLista_Click(object sender, EventArgs e)
        {
            string resultado = "";
            int contador = 0;

            resultado += "\t\t" + "Lista de Empleados" + "\r\n" + "\r\n";

            for (int i = 0; i < listaEmpleados.Count; i++)
            {
                resultado += "\t" + (listaEmpleados[i].Nombre + " " + listaEmpleados[i].Apellidos).PadRight(50, ' ') + "\tNacimiento: " +  listaEmpleados[i].FechaNacto.ToShortDateString() + "\t" + listaEmpleados[i].Dni.PadRight(12, ' ') + "\t" + listaEmpleados[i].Funcion.PadRight(30, ' ') + "\r\n";
                resultado += "\tTeléfono: " + listaEmpleados[i].Telefono.PadRight(11, ' ') + "Correo: " + listaEmpleados[i].Email.PadRight(30, ' ') + "\tEntrada: " + listaEmpleados[i].FechaEntrada.ToShortDateString() +"\tSalario: " + "\t" + listaEmpleados[i].Salario.ToString("N2") + "\r\n";
                resultado += "_______________________________________________________________________________________________________" + "\r\n";
                tbLista.Text = resultado;

                contador++;
            }

            resultado += "\r\n\t" + "Existen " + contador + " Empleados Activos " + "\r\n";
            tbLista.Text = resultado;

            panelLista.Invalidate();

            panelListaTrans.ShowSync(panelLista);

            panelLista.Visible = true;

            btnCerraLista.Visible = true;
            btnPrinterLista.Visible = true;
        }
    }
}
