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
using System.IO;
using System.Drawing.Imaging;

namespace SCAM_App
{
    public partial class FormEmpleados : Form
    {
        MySqlCommand cmd = new MySqlCommand();

        List<Empleado> listaEmpleados;

        public FormEmpleados()
        {
            InitializeComponent();

            dgvEmpleados.AllowUserToAddRows = false;

            panelTarjeta.Visible = false;

            btnCerrarTarjeta.Visible = false;
            btnPrinter.Visible = false;

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
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.Close();
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
                this.dgvEmpleados.Columns[e.ColumnIndex].Width = icoAtomico.Width + 3;

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
                this.dgvEmpleados.Columns[e.ColumnIndex].Width = icoAtomico1.Width + 3;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgvEmpleados.Columns[e.ColumnIndex].Name == "tarjeta" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // diseña el boton de modificar //
                DataGridViewButtonCell celBoton1 = this.dgvEmpleados.Rows[e.RowIndex].Cells["tarjeta"] as DataGridViewButtonCell;
                Icon icoAtomico1 = new Icon(Environment.CurrentDirectory + @"..\..\..\..\img\credit-card.ico");
                e.Graphics.DrawIcon(icoAtomico1, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvEmpleados.Rows[e.RowIndex].Height = icoAtomico1.Height + 3;
                this.dgvEmpleados.Columns[e.ColumnIndex].Width = icoAtomico1.Width + 3;

                e.Handled = true;
            }
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int colum = e.ColumnIndex;
            int fila = e.RowIndex;

            if (colum < 0)
                return;

            if (dgvEmpleados.Columns[colum].HeaderText == "Borrar")// <-- he pulsado el botón Borrar
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
            else if (dgvEmpleados.Columns[colum].HeaderText == "Modificar")// <-- he pulsado el botón Modificar
            {
                colum = e.ColumnIndex;
                fila = e.RowIndex;

                int id = Convert.ToInt32(dgvEmpleados.Rows[fila].Cells[0].Value);


                if (colum < 0)
                    return;

                Empleado emp = EmpleadoDAO.ObtenerEmpleado(id);

                this.Close();
                FormEmpDetalles fa = new FormEmpDetalles(emp);

                fa.Width = 800;
                fa.Height = 450;
                fa.Location = new Point(280, 160);
                fa.ShowDialog();
                fa.Dispose();
            }
            else if (dgvEmpleados.Columns[colum].HeaderText == "Tarjeta")// <-- he pulsado el botón Modificar
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
                    Image image = Image.FromFile(emp.Foto.Replace("--", "\\"));

                    var ms1 = new MemoryStream();

                    image.Save(ms1, ImageFormat.Png);

                    var ima = ms1.ToArray();

                    MemoryStream imagenMemory = new MemoryStream(ima);

                    pictFotoTarjeta.Image = Image.FromStream(ms1);
                    pictFotoTarjeta.SizeMode = PictureBoxSizeMode.StretchImage;

                    ms1.Dispose();
                }

                panelTarjetaTransition.ShowSync(panelTarjeta);

                panelTarjeta.Visible = true;

                btnCerrarTarjeta.Visible = true;
                btnPrinter.Visible = true;

                BarcodeLib.Barcode codigo = new BarcodeLib.Barcode();

                codigo.IncludeLabel = true;
                panelResultado.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE128, emp.Nombre + " " + emp.Apellidos, Color.Black, Color.White, 400, 100);
            }
            else
                return; // <-- No he pulsado ninguno de los botones que me iteresan
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

                    //FormEmpleados fa = new FormEmpleados();
                    //fa.Width = 860;
                    //fa.Height = 450;
                    //fa.Location = new Point(280, 160);
                    //fa.ShowDialog();
                    break;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnCerrarTarjeta_Click(object sender, EventArgs e)
        {
            panelTarjeta.Visible = false;

            btnCerrarTarjeta.Visible = false;
            btnPrinter.Visible = false;


        }
    }
}
