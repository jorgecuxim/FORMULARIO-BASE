using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DORMULARIOBASE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            labelSaludo.Text = "BUENAS TARDES";
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            labelCargo.Text = "INGENIERO";
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            labelNombre.Text = "JORGE ANTONIO";
        }

        private void btnApellido_Click(object sender, EventArgs e)
        {
            labelPaterno.Text = "CUXIM";
        }

        private void btnApellido2_Click(object sender, EventArgs e)
        {
            labelMaterno.Text = "EUAN";
        }
    }
}
