using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace miAlegreInfancia
{
    internal class Examenes
    {
        private string nombre;

        private double nota1;

        private double nota2;

        public double hallarPrimerCorte()
        {
            return nota1 * 0.15;
        }

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

        public double hallarSegundoCorte()
        {
            return nota2 * 0.15;
        }

        public double sumaTotal()
        {
            return hallarPrimerCorte() + hallarSegundoCorte();
        }
    }



    class guardarExamenes
    {
        private Examenes[] arregloExamenes;

        public guardarExamenes(int tamaño)
        {
            arregloExamenes = new Examenes[tamaño];
        }

        public void setNotas(int pos, Examenes examen)
        {
            arregloExamenes[pos] = examen;
        }

        public List<string> mostrarNotasAulaPrimeroA()
        {
            int periodo = 0;
            List<string> list = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                Examenes examenes = arregloExamenes[i];
                if (examenes != null)
                {
                    periodo++;
                    string informacion = "-----NOTA PERIODO " + periodo + "-----\n\nNOMBRE:\t\t " + examenes.getNombre() + "\nNOTA PRIMER CORTE:\t " + examenes.hallarPrimerCorte() + "\nNOTA SEGUNDO CORTE:\t " + examenes.hallarSegundoCorte() + "\n\nNOTA FINAL:\t\t " + examenes.sumaTotal() + "\n_________________________________________________";
                    list.Add(informacion);
                }
            }
            return list;
        }

        public List<string> mostrarNotasAulaPrimeroB()
        {
            int periodo = 0;
            List<string> listaNotas = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                Examenes examenes = arregloExamenes[i];
                if (examenes != null)
                {
                    periodo++;
                    string informacion = "\n-----NOTA PERIODO " + periodo + "-----\n\nNOMBRE:\t\t " + examenes.getNombre() + "\nNOTA PRIMER CORTE:\t " + examenes.hallarPrimerCorte() + "\nNOTA SEGUNDO CORTE:\t " + examenes.hallarSegundoCorte() + "\n\nNOTA FINAL:\t\t " + examenes.sumaTotal() + "\n_________________________________________________";
                    listaNotas.Add(informacion);
                }
            }
            return listaNotas;
        }
    }



}
