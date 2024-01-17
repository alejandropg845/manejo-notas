using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miAlegreInfancia
{
    partial class Actitudinal
    {

        private string nombre;
        private double nota1;
        private double nota2;
        private double nota3;
        private double nota4;

        public void setNombre(string nom)
        {
            nombre = nom;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNota1(double n1)
        {
            nota1 = n1;
        }

        public double getNota1()
        {
            return nota1;

        }

        public void setNota2(double n2)
        {
            nota2 = n2;
        }

        public double getNota2()
        {
            return nota2;

        }



        public void setNota3(double n3)
        {
            nota3 = n3;
        }

        public double getNota3()
        {
            return nota3;

        }

        public void setNota4(double n4)
        {
            nota4 = n4;
        }

        public double getNota4()
        {
            return nota4;

        }


        public double hallarPrimerCorte()
        {
            return ((nota1 + nota2) / 2) * 0.05;

        }

        public double hallarSegundoCorte()
        {
            return ((nota3 + nota4) / 2) * 0.05;
        }


        public double sumaTotal()
        {
            return hallarPrimerCorte() + hallarSegundoCorte();
        }

    }

    class guardarActitudinal
    {
        Actitudinal[] arregloActitudinal;

        public guardarActitudinal(int tamaño)
        {
            arregloActitudinal = new Actitudinal[tamaño];
        }

        public void setNotas(int pos, Actitudinal actitudinal)
        {
            arregloActitudinal[pos] = actitudinal;
        }
        private bool tituloAgregado = false;
        public List<string> mostrarNotasAulaPrimeroA()
        {

            int periodo = 0;
            List<string> listaNotas = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                Actitudinal actitudinal = arregloActitudinal[i];

                if (actitudinal != null)
                {


                    periodo++;
                    string informacion =
                        "-----NOTA PERIODO " + periodo +
                        "-----" + "\nNOMBRE:\t\t " + actitudinal.getNombre() + "\nNOTA PRIMER CORTE:\t " + actitudinal.hallarPrimerCorte() +
                        "\nNOTA SEGUNDO CORTE:\t " + actitudinal.hallarSegundoCorte() + "\n\nNOTA FINAL:\t\t " + actitudinal.sumaTotal() + "\n_________________________________________________";

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
                Actitudinal actitudinal = arregloActitudinal[i];

                if (actitudinal != null)
                {

                    periodo++;
                    string informacion =
                        "-----NOTA PERIODO " + periodo +
                        "-----" + "\nNOMBRE:\t\t " + actitudinal.getNombre() + "\nNOTA PRIMER CORTE:\t " + actitudinal.hallarPrimerCorte() +
                        "\nNOTA SEGUNDO CORTE:\t " + actitudinal.hallarSegundoCorte() + "\n\nNOTA FINAL:\t\t " + actitudinal.sumaTotal() + "\n_________________________________________________";

                    listaNotas.Add(informacion);


                }

            }
            return listaNotas;

        }
    }
}
