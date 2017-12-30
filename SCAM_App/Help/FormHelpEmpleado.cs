using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCAM_App.Help
{
    public partial class FormHelpEmpleado : Form
    {
        public FormHelpEmpleado()
        {
            InitializeComponent();
        }

        private void FormHelpEmpleado_Load(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    this.Hide();

                    //FormEmpleados fa = new FormEmpleados();
                    //fa.Width = 860;
                    //fa.Height = 450;
                    //fa.Location = new Point(280, 160);
                    //fa.ShowDialog();
                    break;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
