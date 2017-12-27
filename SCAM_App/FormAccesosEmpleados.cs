﻿using System;
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

            if (dgvAccesoEmpleado.Columns[colum].HeaderText == "Borrar")// <-- he pulsado el botón Borrar
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
                this.dgvAccesoEmpleado.Columns[e.ColumnIndex].Width = icoAtomico.Width + 3;

                e.Handled = true;
            }

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    this.Hide();

                    break;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}