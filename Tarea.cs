using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace miAlegreInfancia
{
    internal class Tarea
    {
      
        private string nombre;
        private double nota1;
        private double nota2;
        private double nota3;
        private double nota4;
        private double nota5;
        private double nota6;
        private double nota7;
        private double nota8;


        public void setNombre(string n)
        {
            nombre = n;
        }

        public string getNombre()
        {
            return nombre;
        }
        public void setNota1(double n)
        {
            nota1 = n;
        }

        public void setNota2(double h) { nota2 = h; }

        public void setNota3(double x) { nota3 = x; }
        public void setNota4(double u) { nota4 = u; }
        public void setNota5(double y) { nota5 = y; }
        public void setNota6(double b) { nota6 = b; }
        public void setNota7(double a) { nota7 = a; }
        public void setNota8(double n) { nota8 = n; }
        public double getNota1() { return nota1; }
        public double getNota2() { return nota2; }
        public double getNota3() { return nota3; }
        public double getNota4() { return nota4; }
        public double getNota5() { return nota5; }
        public double getNota6() { return nota6; }
        public double getNota7() { return nota7; }
        public double getNota8() { return nota8; }

        public double hallarPrimerCorte()
        {
            return ((nota1 + nota2 + nota3 + nota4) / 4) * 0.1;

        }

        public double hallarSegundoCorte()
        {
            return ((nota5 + nota6 + nota7 + nota8) / 4) * 0.1;
        }

        public double sumaTotal()
        {
            return hallarPrimerCorte() + hallarSegundoCorte();
        }
    }

    class guardarTarea
    {
        Tarea[] arregloTarea;

        public guardarTarea(int tamaño)
        {
            arregloTarea = new Tarea[tamaño];
        }

        public void setNotas(int pos, Tarea examen)
        {
            arregloTarea[pos] = examen;
        }

        private bool tituloAgregado = false;
        public List<string> mostrarNotasAulaPrimeroA()
        {

            int periodo = 0;
            List<string> listaNotas = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                Tarea tarea = arregloTarea[i];



                if (tarea != null)
                {

                    periodo++;
                    string informacion =
                        "-----NOTA PERIODO " + periodo +
                        "-----" + "\n\nNOMBRE:\t\t " + tarea.getNombre() + "\nNOTA PRIMER CORTE:\t " + tarea.hallarPrimerCorte() +
                        "\nNOTA SEGUNDO CORTE:\t " + tarea.hallarSegundoCorte() + "\n\nNOTA FINAL:\t\t " + tarea.sumaTotal() + "\n_________________________________________________";

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
                Tarea tarea = arregloTarea[i];


                if (tarea != null)
                {

                    periodo++;
                    string informacion =
                        "-----NOTA PERIODO " + periodo +
                        "-----" + "\n\nNOMBRE:\t\t " + tarea.getNombre() + "\nNOTA PRIMER CORTE:\t " + tarea.hallarPrimerCorte() +
                        "\nNOTA SEGUNDO CORTE:\t " + tarea.hallarSegundoCorte() + "\n\nNOTA FINAL:\t\t " + tarea.sumaTotal() + "\n_________________________________________________";

                    listaNotas.Add(informacion);
                }
            }
            return listaNotas;
        }
    }

}





