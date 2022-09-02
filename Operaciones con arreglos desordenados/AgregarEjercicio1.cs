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
    public partial class AgregarEjercicio1 : Form
    {
        public AgregarEjercicio1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DATOS.agregarEstudiante(txtCarnet.Text, txtNombre.Text);
            this.Hide();
            Ejercicio1 form = new Ejercicio1();
            form.loadData();
        }
    }
}
