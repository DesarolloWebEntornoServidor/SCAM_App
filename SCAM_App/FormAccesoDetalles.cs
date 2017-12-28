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
        private CodigoAcceso cod;
        bool esNuevo = true;

        public FormAccesoDetalles()
        {
            InitializeComponent();
        }

        public FormAccesoDetalles(CodigoAcceso cod)
        {
            InitializeComponent();

            this.cod = cod;
            esNuevo = false;
        }

        private void FormAccesoDetalles_Load(object sender, EventArgs e)
        {
            txtIdCodigo.Enabled = false;
            chkBoxParaTodos.Checked = false;

            if (esNuevo == false)
            {
                txtIdCodigo.Text = cod.IdCodigoAcceso.ToString();
                txtCodigoAceso.Text = Util.Desencriptar(cod.CodigoDeAcceso);
                txtDescripcion.Text = cod.DescripcionAcceso;

                chkBoxParaTodos.Checked = (cod.PTodos == 1);

            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormAccesos fa = new FormAccesos();
            fa.Width = 579;
            fa.Height = 435;
            fa.Location = new Point(280, 160);
            fa.ShowDialog();
        }
        private void btnAnadirAcceso_Click(object sender, EventArgs e)
        {

             CodigoAcceso cod = new CodigoAcceso();

            cod.IdCodigoAcceso = Convert.ToInt32(txtIdCodigo.Text);
            cod.CodigoDeAcceso = txtCodigoAceso.Text.Trim();
            cod.DescripcionAcceso = txtDescripcion.Text.Trim();
            cod.PTodos = 0;

            if (chkBoxParaTodos.Checked)
                cod.PTodos = 1;

            int resultado = 0;
            if (esNuevo)
                resultado = CodigoAccesoDAO.Insertar(cod); // recibe el resultado positivo al insertar
            else
            {
                resultado = CodigoAccesoDAO.ModificarCodigoAcceso(cod);
            }


            if (resultado > 0)
            {
                MessageBox.Show("Código de Acceso Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                FormAccesos fa = new FormAccesos();
                fa.Width = 579;
                fa.Height = 435;
                fa.Location = new Point(280, 160);
                fa.ShowDialog();
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

                    break;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


    }
}
