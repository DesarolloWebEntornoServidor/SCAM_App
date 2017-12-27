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
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();

            dgvUsuarios.AllowUserToAddRows = false;

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
            List<Usuario> listaUsuarios = UsuarioDAO.ListarUsuarios();

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

            if (dgvUsuarios.Columns[colum].HeaderText == "Borrar")// <-- he pulsado el botón Borrar
            {
                int valor = Convert.ToInt32(dgvUsuarios.Rows[fila].Cells[0].Value);

                if (DialogResult.No == MessageBox.Show("¿está seguro de eliminar a\n" + dgvUsuarios.Rows[fila].Cells[1].Value + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    return;

                UsuarioDAO.BorarRegistro(valor);

                MessageBox.Show("Acceso Borrado con Exito !!!");

                dgvUsuarios.Rows.Clear();
                CargaDGV();
            }
            else if (dgvUsuarios.Columns[colum].HeaderText == "Modificar")// <-- he pulsado el botón Borrar
            {
                //// modificar usuario ////////////////////////////
                this.Close();
                FormUsuarioDetalle fa = new FormUsuarioDetalle();
                fa.Width = 579;
                fa.Height = 435;
                fa.Location = new Point(280, 160);
                fa.ShowDialog();
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
                this.dgvUsuarios.Columns[e.ColumnIndex].Width = icoAtomico.Width + 3;

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
                this.dgvUsuarios.Columns[e.ColumnIndex].Width = icoAtomico1.Width + 3;

                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Usuario> localizados = new List<Usuario>();

            localizados = UsuarioDAO.Localizar(textBox1.Text);

            CargaDGV(localizados);
        }

  
    }
}
