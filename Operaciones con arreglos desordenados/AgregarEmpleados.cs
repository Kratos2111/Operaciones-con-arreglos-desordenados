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
    public partial class AgregarEmpleados : Form
    {
        public AgregarEmpleados()
        {
            InitializeComponent();
        }

        private void AgregarEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatosEmpleados.agregarEmpleado(txtCarnet.Text, txtIp.Text, txtIIp.Text, double.Parse(txtSis.Text), int.Parse(txtPro.Text));
            this.Hide();
        }
    }
}
