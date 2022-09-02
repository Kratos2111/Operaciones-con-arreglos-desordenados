using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones_con_arreglos_desordenados
{
    static internal class DatosEmpleados
    {
        public static string[] cedula;
        public static string[] Nombres;
        public static string[] Apellidos;
        public static int[] hijos;
        public static double[] Salario;
        public static int Tam;

        public static void eliminarEmpleado(string a)
        {
            int index;
            try
            {
                index = Array.IndexOf(cedula, a);
                if (index < 0) { MessageBox.Show("Empleado no encontrado"); return; }
                for (int i = index; i < Tam - 1; i++)
                {
                    cedula[i] = cedula[i + 1];
                    Nombres[i] = Nombres[i + 1];
                    Apellidos[i] = Apellidos[i + 1];
                    hijos[i] = hijos[i + 1];
                    Salario[i] = Salario[i + 1];
                }
                Tam--;
                Array.Resize(ref cedula, Tam);
                Array.Resize(ref Nombres, Tam);
                Array.Resize(ref Apellidos, Tam);
                Array.Resize(ref hijos, Tam);
                Array.Resize(ref Salario, Tam);
               
                MessageBox.Show("Empleado eliminado con exito", "Success");

            }
            catch (Exception e)
            {
                MessageBox.Show("No se encontro el empleado", e.Message);
            }

        }
        public static double Cal()
        {
            double total = 0;
            foreach (double a in Salario)
            {
                total += a;
            }
            return total / Tam;
        }
        public static void agregarEmpleado(string a, string b, string c, double sal, int x)
        {
            try
            {
                Tam++;
                Array.Resize(ref cedula, Tam);
                Array.Resize(ref Nombres, Tam);
                Array.Resize(ref Apellidos, Tam);
                Array.Resize(ref Salario, Tam);
                Array.Resize(ref hijos, Tam);

                cedula[Tam - 1] = a;
                Nombres[Tam - 1] = b;
                Apellidos[Tam - 1] = c;
                Salario[Tam - 1] = sal;
                hijos[Tam - 1] = x;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo agregar el estudiante", e.Message);
            }

        }
        public static void AumentodeSalario()
        {
            double sal;
            double prom = Cal();
            foreach(double a in Salario)
            {
                if(a < prom)
                {
                    sal = Salario[Array.IndexOf(Salario, a)];
                    sal += sal * 0.1;
                }
            }
        }

        public static void agregarSalario(string a, double Sal)
        {
            int index;
            try
            {
                index = Array.IndexOf(cedula, a);
                if (Sal > 0)
                {
                    Salario[index] = Sal;
                }
                else { MessageBox.Show("Ingrese valores validos, las notas no pueden ser menor a 0"); }

            }
            catch (Exception e) { MessageBox.Show("Error al agregar la nota", e.Message); }
        }
    }
}
