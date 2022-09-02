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
    public partial class InfoEjercicio1 : Form
    {
        public InfoEjercicio1()
        {
            InitializeComponent();
        }

        private void InfoEjercicio1_Load(object sender, EventArgs e)
        {
            txtMejor.Text = DATOS.getNombre(DATOS.getStudent()).ToString();
            txtNota.Text = DATOS.getStudent().ToString();
            txtProm.Text = DATOS.getProm().ToString();
        }
    }
}
