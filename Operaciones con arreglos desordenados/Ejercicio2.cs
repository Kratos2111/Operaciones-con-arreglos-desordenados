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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            DataEjercicio1.Rows.Clear();
            for (int i = 0; i < DatosEmpleados.Tam; i++)
            {
                DataEjercicio1.Rows.Add(DatosEmpleados.cedula[i], DatosEmpleados.Nombres[i], DatosEmpleados.Apellidos[i], DatosEmpleados.Salario[i], DatosEmpleados.hijos[i]);
            }
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {

        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            editarSalario form = new editarSalario();
            form.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            DatosEmpleados.AumentodeSalario();
        }

        private void Ejercicio2_Activated(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEmpleados form = new AgregarEmpleados();
            form.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar form = new Eliminar();
            form.Show();
        }
    }
}
