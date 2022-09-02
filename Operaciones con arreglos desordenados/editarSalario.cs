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
    public partial class editarSalario : Form
    {
        public editarSalario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatosEmpleados.agregarSalario(txtCarnet.Text, double.Parse(txtNombre.Text));
            this.Hide();
        }
    }
}
