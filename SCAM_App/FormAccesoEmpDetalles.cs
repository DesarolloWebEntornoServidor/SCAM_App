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
    public partial class FormAccesoEmpDetalles : Form
    {
        

        public FormAccesoEmpDetalles()
        {
            InitializeComponent();
        }
        private void FormAccesoEmpDetalles_Load(object sender, EventArgs e)
        {
            txtIdDepto.Enabled = false;

            cargaComboEmpleado();
        }

        private void cargaComboEmpleado()
        {
            List<Empleado> listaEmps = EmpleadoDAO.ListarEmpleados(); // Genera una lista para mostrar en el comboBox de empleados

            listaEmps.Insert(0, new Empleado(0, "Seleccione el Empleado"));

            cbEmpleado.DataSource = listaEmps;
            cbEmpleado.DisplayMember = "Nombre";
            cbEmpleado.ValueMember = "IdEmpleado";
        }

        private void rellenaChkListBox(int id) // Metodo para Rellenar el Check List Box // 
        {
            List<CodigoAcceso> listaCodigos = CodigoAccesoDAO.ListarCodigosAcceso(); // Carga una lista con todos os codigos de accesos existentes

            chkListCodiAcceso.Items.Clear();

            for (int i = 0; i < listaCodigos.Count; i++)
            {
                chkListCodiAcceso.Items.Add(listaCodigos[i].DescripcionAcceso); // carga el checkList con la lista de codigos
            }

            List<int> listaAccesos = AccesoEmpleadoDAO.ObtenerAccesosdelEmpleado(id); // crea una lista con los accesos que el empleado ya tiene

            string compara = "";
            string comparaCom = "";
            for (int j = 0; j < listaAccesos.Count; j++)
            {
                 compara = CodigoAccesoDAO.ObtenerCodigoAcceso(listaAccesos[j]).DescripcionAcceso; // verifica se ese codigo esta dentre los codigos que tiene el empleado
                for (int i = 0; i < chkListCodiAcceso.Items.Count; i++)
                {
                    comparaCom = chkListCodiAcceso.Items[i].ToString();

                    if(comparaCom.Equals(compara))
                    {
                        chkListCodiAcceso.SetItemChecked(i, true); // si lo tiene , marca como checkeado

                    }
                }

            }

        }

        private void btnAnadirAcceso_Click(object sender, EventArgs e)
        {
            List<AccesoEmpleados> ace = new List<AccesoEmpleados>();

            AccesoEmpleados a1 = new AccesoEmpleados();

            List<string> nombreCodigosChecados = new List<string>();

            foreach (string items in chkListCodiAcceso.CheckedItems)
            {
                nombreCodigosChecados.Add(items);
            }

            int idEmp = Convert.ToInt32(cbEmpleado.SelectedValue);        

            int resultado = AccesoEmpleadoDAO.InsertarGrupoAccesos(idEmp, nombreCodigosChecados);

            if (resultado > 0)
            {
                MessageBox.Show("Acceso Asignado con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();

                FormAccesosEmpleados fa = new FormAccesosEmpleados();
                fa.Width = 579;
                fa.Height = 435;
                fa.Location = new Point(280, 160);
                fa.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se pudo Asignar el Acceso", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormAccesosEmpleados fa = new FormAccesosEmpleados();
            fa.Width = 579;
            fa.Height = 435;
            fa.Location = new Point(280, 160);
            fa.ShowDialog();
        }

        private void cbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int identificaEmp = cbEmpleado.SelectedIndex;

            if(identificaEmp > 0)
               rellenaChkListBox(identificaEmp);


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
                    FormAccesosEmpleados fa = new FormAccesosEmpleados();
                    fa.Width = 579;
                    fa.Height = 435;
                    fa.Location = new Point(280, 160);
                    fa.ShowDialog();

                    break;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }

}
