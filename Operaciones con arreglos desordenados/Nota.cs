using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones_con_arreglos_desordenados
{
    public partial class Nota : Form
    {
        public Nota()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DATOS.agregarNota(txtCarnet.Text, double.Parse(txtIp.Text), double.Parse(txtIIp.Text), double.Parse(txtSis.Text), double.Parse(txtPro.Text));
            this.Hide();
        }
    }
}
