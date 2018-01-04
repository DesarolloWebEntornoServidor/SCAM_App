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
    public partial class FormHelpUsuarios : Form
    {
        private int v;

        public FormHelpUsuarios()
        {
            InitializeComponent();
        }

        public FormHelpUsuarios(int v)
        {
            InitializeComponent();

            this.v = v;

            if (v == 1)
                groupBoxUsuario.Visible = false;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    this.Close();

                    break;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
