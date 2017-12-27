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
    public partial class FormAccesoDetalles : Form
    {
        public FormAccesoDetalles()
        {
            InitializeComponent();
        }
        private void FormAccesoDetalles_Load(object sender, EventArgs e)
        {
            txtIdCodigo.Enabled = false;
            chkBoxParaTodos.Checked = false;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormAccesos fa = new FormAccesos();
            fa.Width = 860;
            fa.Height = 450;
            fa.Location = new Point(280, 160);
            fa.ShowDialog();
        }

        private void btnAnadirAcceso_Click(object sender, EventArgs e)
        {

             CodigoAcceso cod = new CodigoAcceso();

            cod.CodigoDeAcceso = txtCodigoAceso.Text.Trim();
            cod.DescripcionAcceso = txtDescripcion.Text.Trim();
            cod.PTodos = 0;

            if (chkBoxParaTodos.Checked)
                cod.PTodos = 1;

            int resultado = CodigoAccesoDAO.Insertar(cod);

            if (resultado > 0)
            {
                MessageBox.Show("Código de Acceso Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigoAceso.Text = "";
                txtDescripcion.Text = "";
                txtCodigoAceso.Focus();
            }
            else
            {
                MessageBox.Show("No se pudo guardar el Código de Acceso", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


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

                    FormAccesos fa = new FormAccesos();
                    fa.Width = 860;
                    fa.Height = 450;
                    fa.Location = new Point(280, 160);
                    fa.ShowDialog();
                    break;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


    }
}
