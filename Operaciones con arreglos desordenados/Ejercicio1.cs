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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }
        private bool validar(double a)
        {
            if (a < 0 || a > 100) return false;
            return true;
        }
        public void loadData()
        {
            DataEjercicio1.Rows.Clear();
            for (int i = 0; i < DATOS.Tam; i++)
            {
                DataEjercicio1.Rows.Add(DATOS.Carnet[i], DATOS.Nombres[i], DATOS.IP[i], DATOS.IIP[i], DATOS.SIST[i], DATOS.PROY[i], DATOS.NF[i]);
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void DataEjercicio1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEjercicio1 form = new AgregarEjercicio1();
            form.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarEjercicio1 form = new eliminarEjercicio1();
            form.Show();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            Nota form = new Nota();
            form.Show();
        }

        private void Ejercicio1_Activated(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            InfoEjercicio1 form = new InfoEjercicio1();
            form.Show();
        }
    }
}
