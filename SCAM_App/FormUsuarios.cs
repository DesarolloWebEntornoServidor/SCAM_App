using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DatosNegocios;

using Microsoft.Office.Interop.Excel;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace SCAM_App
{
    public partial class FormUsuarios : Form
    {
        List<Usuario> listaUsuarios;
        private int v;

        public FormUsuarios()
        {
            InitializeComponent();

            dgvUsuarios.AllowUserToAddRows = false;

            dgvUsuarios.Columns["Codigo"].Visible = false;

            panelLista.Visible = false;

            btnCerrarTarjeta.Visible = false;
            btnPrinterLista.Visible = false;

        }

        public FormUsuarios(int v)
        {
            InitializeComponent();

            this.v = v;

            if(v == 2)
            {
                Modificar(FormLogin.usuId);

            }

        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            CargaDGV();
        }

        private void btnVolver_Click(object sender, EventArgs e) // boton de salida //////
        {
            this.Close();
        }
        public void CargaDGV() // carga el data grid cdo inicia la rutina
        {
            listaUsuarios = UsuarioDAO.ListarUsuarios();

            int n = 0;
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                n = dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[n].Cells[0].Value = listaUsuarios[i].IdUsuario;
                dgvUsuarios.Rows[n].Cells[1].Value = listaUsuarios[i].Nombre;
                dgvUsuarios.Rows[n].Cells[2].Value = listaUsuarios[i].Alias;
                dgvUsuarios.Rows[n].Cells[3].Value = listaUsuarios[i].Login;
                dgvUsuarios.Rows[n].Cells[4].Value = listaUsuarios[i].Acceso;

            }
        }

        private void CargaDGV(List<Usuario> listaUsuarios) // carga el data grid por el localizador
        {
            dgvUsuarios.Rows.Clear();

            int n = 0;
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                n = dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[n].Cells[0].Value = listaUsuarios[i].IdUsuario;
                dgvUsuarios.Rows[n].Cells[1].Value = listaUsuarios[i].Nombre;
                dgvUsuarios.Rows[n].Cells[2].Value = listaUsuarios[i].Alias;
                dgvUsuarios.Rows[n].Cells[3].Value = listaUsuarios[i].Login;
                dgvUsuarios.Rows[n].Cells[4].Value = listaUsuarios[i].Acceso;

            }
        }
        private void btnInserir_Click(object sender, EventArgs e) // boton inserir nuevo Usuario /////
        {
            this.Close();
            this.Dispose();

            FormUsuarioDetalle fa = new FormUsuarioDetalle();

            fa.Width = 579;
            fa.Height = 435;
            fa.Location = new System.Drawing.Point(280, 160);
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

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int colum = e.ColumnIndex;
            int fila = e.RowIndex;

            if (colum < 0)
                return;

            if (dgvUsuarios.Columns[colum].HeaderText == "Borra")// <-- he pulsado el botón Borrar
            {
                int valor = Convert.ToInt32(dgvUsuarios.Rows[fila].Cells[0].Value);

                if(valor == FormLogin.usuId)
                {
                    MessageBox.Show("No Puedes Borrar el Usuario que está Logado !!!");
                    return;
                }

                if (DialogResult.No == MessageBox.Show("¿está seguro de eliminar a\n" + dgvUsuarios.Rows[fila].Cells[1].Value + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    return;

                int retorno = UsuarioDAO.BorarRegistro(valor);

                if (retorno > 0)
                    MessageBox.Show("Usuario Borrado con Exito !!!");
                else
                    MessageBox.Show("Error !!! Este Usuario está Vinculado a un Empleado !!!");

                dgvUsuarios.Rows.Clear();
                CargaDGV();
            }
            else if (dgvUsuarios.Columns[colum].HeaderText == "Edita")// <-- he pulsado el botón Borrar
            {
                colum = e.ColumnIndex;
                fila = e.RowIndex;

                int idUsu = Convert.ToInt32(dgvUsuarios.Rows[fila].Cells[0].Value);

                Usuario usu = UsuarioDAO.ObtenerUsuario(idUsu);

                if (colum < 0)
                    return;
                //// modificar usuario ////////////////////////////
                this.Close();
                this.Dispose();

                FormUsuarioDetalle fa = new FormUsuarioDetalle(usu); 

                fa.Width = 579;
                fa.Height = 435;
                fa.Location = new System.Drawing.Point(280, 160);
                fa.ShowDialog();
                fa.Dispose();
            }
            else
                return; // <-- No he pulsado ninguno de los botones que me iteresan
        }

        private void dgvUsuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvUsuarios.Columns[e.ColumnIndex].Name == "borrar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // diseña el boton de deletar //
                DataGridViewButtonCell celBoton = this.dgvUsuarios.Rows[e.RowIndex].Cells["borrar"] as DataGridViewButtonCell;
                System.Drawing.Icon icoAtomico = new System.Drawing.Icon(Environment.CurrentDirectory + @"..\..\..\..\img\edit_delete.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvUsuarios.Rows[e.RowIndex].Height = icoAtomico.Height + 3;
                this.dgvUsuarios.Columns[e.ColumnIndex].Width = icoAtomico.Width + 7;

                e.Handled = true;
            }

            if (e.ColumnIndex >= 0 && this.dgvUsuarios.Columns[e.ColumnIndex].Name == "modificar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // diseña el boton de modificar //
                DataGridViewButtonCell celBoton1 = this.dgvUsuarios.Rows[e.RowIndex].Cells["modificar"] as DataGridViewButtonCell;
                System.Drawing.Icon icoAtomico1 = new System.Drawing.Icon(Environment.CurrentDirectory + @"..\..\..\..\img\modificar.ico");
                e.Graphics.DrawIcon(icoAtomico1, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvUsuarios.Rows[e.RowIndex].Height = icoAtomico1.Height + 3;
                this.dgvUsuarios.Columns[e.ColumnIndex].Width = icoAtomico1.Width + 7;

                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Usuario> localizados = new List<Usuario>();

            localizados = UsuarioDAO.Localizar(textBox1.Text);

            CargaDGV(localizados);
        }

        private void btnPdf_Click(object sender, EventArgs e) // Exportar del datagridviwe a PDF  //
        {
            try
            {

                Document doc = new Document(PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(@"..\..\..\ArchivosPDF\usuarios.pdf", FileMode.Create));
                doc.Open();

                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"..\..\..\img\logo.png");
                logo.ScalePercent(25f);

                doc.Add(logo);

                doc.Add(new Phrase("Sistema de Controle de Accesos"));
                doc.Add(new Paragraph(""));
                doc.Add(new Paragraph(""));
                doc.Add(new Paragraph("                                         Lista de Usuarios"));
                doc.Add(new Paragraph(""));
                doc.Add(new Paragraph(""));

                PdfPTable tabla = new PdfPTable(dgvUsuarios.Columns.Count-2);

                tabla.HorizontalAlignment = 1; // central

                for (int j = 0; j < dgvUsuarios.Columns.Count-2; j++)
                {
                    tabla.AddCell(new Phrase(dgvUsuarios.Columns[j].HeaderText));
                }

                tabla.HeaderRows = 1;


                for (int i = 0; i < dgvUsuarios.Rows.Count-2; i++)
                {
                    for (int h = 0; h < dgvUsuarios.Columns.Count-2; h++)
                    {
                        if(dgvUsuarios[h,i].Value != null)
                        {
                            tabla.AddCell(new Phrase(dgvUsuarios[h, i].Value.ToString()));
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

        //public override void VerifyRenderingInServerForm(Control control) { }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            exportaraexcel(dgvUsuarios);
        }

        public void exportaraexcel(DataGridView tabla) // Exporta DatagridView para Excel  //
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);

            int indiceColumna = 0;
            foreach (DataGridViewColumn col in tabla.Columns) //Columnas
            {
                indiceColumna++;

                if(col.Name != "borrar" && col.Name !="modificar")
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

        private void Modificar(int idUsu)
            {
                Usuario usu = UsuarioDAO.ObtenerUsuario(idUsu);

               
                //// modificar usuario ////////////////////////////
                this.Close();
                this.Dispose();

                FormUsuarioDetalle fa = new FormUsuarioDetalle(usu);

                fa.Width = 579;
                fa.Height = 435;
                fa.Location = new System.Drawing.Point(280, 160);
                fa.ShowDialog();

        }

        private void btnPrinter_Click(object sender, EventArgs e)
        {
            string resultado = "";
            int contador = 0;

            resultado += "\t\t" + "Lista de Usuarios" + "\r\n" + "\r\n";

            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                resultado += "\t" + listaUsuarios[i].Nombre.PadRight(30,' ') + listaUsuarios[i].Alias.PadRight(6, ' ') + listaUsuarios[i].Login.PadRight(10, ' ') + "\t" + listaUsuarios[i].Acceso.ToString("##") + "\r\n";
                tbLista.Text = resultado;

                contador++;
            }

            resultado += "\r\n\t" + "Existen " + contador + " Usuarios Registrados" + "\r\n";
            tbLista.Text = resultado;

            panelLista.Invalidate();

            panelListaTrans.ShowSync(panelLista);

            panelLista.Visible = true;

            btnCerrarTarjeta.Visible = true;
            btnPrinterLista.Visible = true;

        }

        private void btnCerrarTarjeta_Click(object sender, EventArgs e)
        {
            panelLista.Visible = false;

            btnCerrarTarjeta.Visible = false;
            btnPrinterLista.Visible = false;
        }
    }
    
}
