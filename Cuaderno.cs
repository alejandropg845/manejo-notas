using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miAlegreInfancia
{
    internal class Cuaderno
    {
        private string nombre;
        private double nota1;
        private double nota2;


        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nom)
        {
            nombre = nom;
        }
        public void setNota1(double n)
        {
            nota1 = n;
        }

        public void setNota2(double h) { nota2 = h; }

        public double getNota1() { return nota1; }
        public double getNota2() { return nota2; }

        public double hallarPrimerCorte()
        {
            return (nota1 * 0.5);

        }

        public double hallarSegundoCorte()
        {
            return (nota2 * 0.5);
        }

        public double sumaTotal()
        {
            return hallarPrimerCorte() + hallarSegundoCorte();
        }


    }

    class guardarCuaderno
    {
        Cuaderno[] arregloCuadernos;

        public guardarCuaderno(int tamaño)
        {
            arregloCuadernos = new Cuaderno[tamaño];
        }

        public void setNotas(int pos, Cuaderno examen)
        {
            arregloCuadernos[pos] = examen;
        }

        public List<string> mostrarNotasAulaPrimeroA()
        {
            int periodo = 0;

            List<string> listaNotas = new List<string>();

            for (int i = 0; i < 3; i++)
            {

                Cuaderno cuaderno = arregloCuadernos[i];
                if (cuaderno != null)
                {

                    periodo++;
                    string informacion =
                        "-----NOTA PERIODO " + periodo +
                    "-----" + "\nNOMBRE:\t\t " + cuaderno.getNombre() + "\nNOTA CORTE UNO:\t " + cuaderno.hallarPrimerCorte() +
                    "\nNOTA CORTE DOS:\t " + cuaderno.hallarSegundoCorte() + "\n\nNOTA FINAL:\t\t " + cuaderno.sumaTotal() +
                    "\n_________________________________________________";

                    listaNotas.Add(informacion);

                }



            }
            return listaNotas;
        }

        public List<string> mostrarNotasAulaPrimeroB()
        {
            int periodo = 0;

            List<string> listaNotas = new List<string>();

            for (int i = 0; i < 3; i++)
            {

                Cuaderno cuaderno = arregloCuadernos[i];
                if (cuaderno != null)
                {

                    periodo++;
                    string informacion =
                        "-----NOTA PERIODO " + periodo +
                    "-----" + "\nNOMBRE:\t\t " + cuaderno.getNombre() + "\nNOTA CORTE UNO:\t " + cuaderno.hallarPrimerCorte() +
                    "\nNOTA CORTE DOS:\t " + cuaderno.hallarSegundoCorte() + "\n\nNOTA FINAL:\t\t " + cuaderno.sumaTotal() +
                    "\n_________________________________________________";

                    listaNotas.Add(informacion);

                }



            }
            return listaNotas;
        }
    }
}
