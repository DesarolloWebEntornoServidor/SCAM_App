using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatosNegocios;

namespace SCAM_App
{
    public partial class FormAccesoDetalles : Form
    {
        private CodigoAcceso cod;
        bool esNuevo = true;
        bool hayError = false;

        public FormAccesoDetalles()
        {
            InitializeComponent();
        }

        public FormAccesoDetalles(CodigoAcceso cod)
        {
            InitializeComponent();

            this.cod = cod;
            esNuevo = false;

            txtCodigoAceso.Enabled = false;
        }

        private void FormAccesoDetalles_Load(object sender, EventArgs e)
        {
            txtIdCodigo.Enabled = false;
            chkBoxParaTodos.Checked = false;

            if (esNuevo == false)
            {
                txtIdCodigo.Text = cod.IdCodigoAcceso.ToString();
                txtCodigoAceso.Text = cod.CodigoDeAcceso;
                txtDescripcion.Text = cod.DescripcionAcceso;

                chkBoxParaTodos.Checked = (cod.PTodos == 1);

            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();


            FormAccesos fa = new FormAccesos();
            fa.Width = 579;
            fa.Height = 435;
            fa.Location = new Point(280, 160);
            fa.ShowDialog();
        }
        private void btnAnadirAcceso_Click(object sender, EventArgs e)
        {
            hayError = HayErrorEnFormulario();

            if (hayError)
            {
                MessageBox.Show("Existe Error en el Formulario, Presione F1 si necesitas Ayuda !!!");
                return;
            }

            CodigoAcceso cod = new CodigoAcceso();

            cod.CodigoDeAcceso = txtCodigoAceso.Text.Trim();
            cod.DescripcionAcceso = txtDescripcion.Text.Trim();
            cod.PTodos = 0;

            if (chkBoxParaTodos.Checked)
                cod.PTodos = 1;

            int resultado = 0;
            if (esNuevo)
            {
                resultado = CodigoAccesoDAO.Insertar(cod); // recibe el resultado positivo al insertar
            }
            else
            {
                cod.IdCodigoAcceso = Convert.ToInt32(txtIdCodigo.Text);

                resultado = CodigoAccesoDAO.ModificarCodigoAcceso(cod);
            }


            if (resultado > 0)
            {
                MessageBox.Show("Código de Acceso Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                this.Dispose();


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

        private bool HayErrorEnFormulario()
        {
            hayError = false;

            string pathString = @"[A-Z]{1}[a-zA-ZàáâäãåąčćęèéêëėįìíîïłńòóôöõøùúûüųūÿýżźñçčšžÀÁÂÄÃÅĄĆČĖĘÈÉÊËÌÍÎÏĮŁŃÒÓÔÖÕØÙÚÛÜŲŪŸÝŻŹÑßÇŒÆČŠŽ∂ð,.'-]{2,29}";
            string pathCodigo = @"[a-zA-Z]";

            if (!Regex.IsMatch(txtDescripcion.Text, pathString) || txtDescripcion.Text.Trim().Length > 30)
            {
                errorProvider1.SetError(txtDescripcion, "Error en el Formato en la Descripción del Código de Acceso ");

                hayError = true;
            }
            else
                errorProvider1.SetError(txtDescripcion, "");

            if (!Regex.IsMatch(txtCodigoAceso.Text, pathCodigo) || txtCodigoAceso.Text.Trim().Length > 30)
            {
                errorProvider1.SetError(txtCodigoAceso, "Error, el Código no Puede Empezar por Número ");

                hayError = true;
            }
            else
                errorProvider1.SetError(txtCodigoAceso, "");

            List<CodigoAcceso> yaExiste = CodigoAccesoDAO.YaExiste(Util.Encriptar(txtCodigoAceso.Text), txtDescripcion.Text); // Verifica si el Codigo ya existe   //
            if (yaExiste.Count > 0 && txtIdCodigo.Text == "")
                txtIdCodigo.Text = "0";

            if (yaExiste.Count > 0 && yaExiste[0].IdCodigoAcceso != Convert.ToInt32(txtIdCodigo.Text))
            {
                MessageBox.Show("Error, Esta Descripción de Codigo de Acceso ya Está Registrada !!!");
                hayError = true;
            }





            return hayError;
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


    }
}
