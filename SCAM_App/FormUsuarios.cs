using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DatosNegocios;

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
                fa.Location = new Point(280, 160);
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
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"..\..\..\..\img\edit_delete.ico");
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
                Icon icoAtomico1 = new Icon(Environment.CurrentDirectory + @"..\..\..\..\img\modificar.ico");
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

        private void btnPdf_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            //Util.ExportarDataGridViewExcel(listaUsuarios);
        }

        //private void ExportarDataGridViewExcel()
        //{
        //    SaveFileDialog fichero = new SaveFileDialog();
        //    fichero.Filter = "Excel (*.xls)|*.xls";
        //    if (fichero.ShowDialog() == DialogResult.OK)
        //    {
        //        Microsoft.Office.Interop.Excel.Application aplicacion;
        //        Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
        //        Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
        //        aplicacion = new Microsoft.Office.Interop.Excel.Application();
        //        libros_trabajo = aplicacion.Workbooks.Add();
        //        hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
        //        //Recorremos el DataGridView rellenando la hoja de trabajo
        //        for (int i = 0; i < dgvUsuarios.Rows.Count - 1; i++)
        //        {
        //            for (int j = 0; j < dgvUsuarios.Columns.Count; j++)
        //            {
        //                hoja_trabajo.Cells[i + 1, j + 1] = dgvUsuarios.Rows[i].Cells[j].Value.ToString();
        //            }
        //        }
        //        libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
        //        libros_trabajo.Close(true);
        //        aplicacion.Quit();
        //    }
        //}

            private void Modificar(int idUsu)
            {
                Usuario usu = UsuarioDAO.ObtenerUsuario(idUsu);

               
                //// modificar usuario ////////////////////////////
                this.Close();
                this.Dispose();

                FormUsuarioDetalle fa = new FormUsuarioDetalle(usu);

                fa.Width = 579;
                fa.Height = 435;
                fa.Location = new Point(280, 160);
                fa.ShowDialog();

        }




    }
}
