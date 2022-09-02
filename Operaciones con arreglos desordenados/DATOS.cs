using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones_con_arreglos_desordenados
{
    static internal class DATOS
    {
        public static string[] Carnet =
        {
            "2019-0025U",
            "2019-0001U",
            "2018-0142U",
            "2018-0790i",
            "2017-1208U",
            "2019-0301U",
            "2018-0157U",
            "2003-18372"
        };
        public static string[] Nombres =
        {
            "Cerna Barahona Jhon Kelvin",
            "Emes Barahona Alberto Antonio",
            "Flores Munguia Axl Fernando",
            "Flores Romero Javier Abraham",
            "Gonzalez Rodriguez Geremias Josue",
            "Gonzalez Sandino Lester Abraham",
            "Guerrero Lopez Jose Dolores",
            "Guevara Jimenez Francisco Jose"
        };
        public static int Tam = 8;
        public static double[] IP = {0,0,0,0,0,0,0,0};
        public static double[] IIP = { 0, 0, 0, 0, 0, 0, 0, 0 };
        public static double[] SIST = { 0, 0, 0, 0, 0, 0, 0, 0 };
        public static double[] PROY = { 0, 0, 0, 0, 0, 0, 0, 0 };
        public static double[] NF = { 0, 0, 0, 0, 0, 0, 0, 0 };

        public static void getNF()
        {
            for(int a= 0; a<Tam; a++)
            {
                NF[a] = (IP[a] + IIP[a] + SIST[a] + PROY[a])/4;
            }
        }
        public static double getProm()
        {
            double suma = 0;
           foreach(double B in NF)
            {
                suma += B;
            }
            return suma / Tam;
        }
        public static int getStudent()
        {
            double mejor = 0;
            foreach(double B in NF)
            {
                if(mejor < B) { mejor = B; }
            }
            return Convert.ToInt32(mejor);
        }
        public static string getNombre(double b)
        {
            int index;
            index = Array.IndexOf(NF, b );
            return Carnet[index] + " - " + Nombres[index];
        }
        public static void agregarEstudiante(string a, string b)
        {
            try
            {
                Tam++;
                Array.Resize(ref Carnet, Tam);
                Array.Resize(ref Nombres, Tam);
                Array.Resize(ref IP, Tam);
                Array.Resize(ref IIP, Tam);
                Array.Resize(ref SIST, Tam);
                Array.Resize(ref PROY, Tam);
                Array.Resize(ref NF, Tam);

                Carnet[Tam - 1] = a;
                Nombres[Tam - 1] = b;
                IP[Tam - 1] = 0;
                IIP[Tam - 1] = 0;
                SIST[Tam - 1] = 0;
                PROY[Tam - 1] = 0;
                NF[Tam - 1] = 0;
            }
            catch(Exception e)
            {
                MessageBox.Show("No se pudo agregar el estudiante", e.Message);
            }
            
        }
        public static void agregarNota(string a, double fp, double sp , double sis, double pr)
        {
            int index;
            try
            {
                index = Array.IndexOf(Carnet, a);
                if((fp > 0 && fp < 100) && (sp > 0 && sp < 100) && (sis > 0 && sis < 100) && (pr > 0 && pr < 100))
                {
                    IP[index] = fp;
                    IIP[index] = sp;
                    SIST[index] = sis;
                    PROY[index] = pr;
                    getNF();
                }else { MessageBox.Show("Ingrese valores validos, las notas no pueden ser menor a 0 y mayor a 100"); }

            }catch(Exception e) { MessageBox.Show("Error al agregar la nota", e.Message); }
        }
        public static void eliminarEstudiante(string a)
        {
            int index;
            try
            {
                index = Array.IndexOf(Carnet, a);
                if (index < 0) { MessageBox.Show("Estudiante no encontrado"); return; }
                for (int i = index; i < Tam - 1; i++) {
                    Carnet[i] = Carnet[i + 1];
                    Nombres[i] = Nombres[i + 1];
                    IP[i] = IP[i+1];
                    IIP[i] = IIP[i+1];
                    SIST[i] = SIST[i + 1];
                    PROY[i] = PROY[i + 1];
                    NF[i] = NF[i + 1];
                }
                Tam--;
                Array.Resize(ref Carnet, Tam);
                Array.Resize(ref Nombres, Tam);
                Array.Resize(ref IP, Tam);
                Array.Resize(ref IIP, Tam);
                Array.Resize(ref SIST, Tam);
                Array.Resize(ref PROY, Tam);
                Array.Resize(ref NF, Tam);
                MessageBox.Show("Estudiante eliminado con exito", "Success");
                
            }
            catch(Exception e) 
            {
                MessageBox.Show("No se encontro el estudiante", e.Message);
            }
            
        }
    }
}
