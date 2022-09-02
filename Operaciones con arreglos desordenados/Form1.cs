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
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();
        }

        private void Ejercicio1_Click(object sender, EventArgs e)
        {
            Ejercicio1 form1 = new Ejercicio1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ejercicio2 form2 = new Ejercicio2();
            form2.Show();
        }
    }
}
