using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;




namespace miAlegreInfancia
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        guardarCuaderno almacenarCuaderno = new guardarCuaderno(3);
        guardarTarea guardar = new guardarTarea(3);
        guardarSeguimiento almacenarSeguimiento = new guardarSeguimiento(3);
        guardarExamenes almacenarExamenes = new guardarExamenes(3);
        guardarActitudinal almacenarActitudinal = new guardarActitudinal(3);
        int a = 0;
        int e = 0;
        int t = 0;
        int s = 0;
        int c = 0;
        int objetosTarea = 0;
        int objetosSeguimiento = 0;
        int objetosExamen = 0;
        int objetosActitudinal = 0;
        int objetosCuaderno = 0;
        private string aulaSeleccionada;
        private bool valoresGuardados = false;

        public MainWindow()
        {
            InitializeComponent();

            ComboBoxItem selecciona = new ComboBoxItem();
            selecciona.Content = "Selecciona un Aula";
            combobox.Items.Add(selecciona);
            combobox.SelectedIndex = 0;

            ComboBoxItem aula1 = new ComboBoxItem();
            aula1.Content = "Aula Primero A";
            combobox.Items.Add(aula1);

            ComboBoxItem aula2 = new ComboBoxItem();
            aula2.Content = "Aula Primero B";
            combobox.Items.Add(aula2);




        }

        private void boton_reiniciar(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);

        }
        private void combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!valoresGuardados)
            {
                ComboBoxItem selectedItem = combobox.SelectedItem as ComboBoxItem;

                if (selectedItem != null)
                {
                    aulaSeleccionada = selectedItem.Content.ToString();
                }
            }
        }
        public bool verificarSecciones()
        {
            return listaTarea.Items.Count > 0 && listaSeguimiento.Items.Count > 0 && listaActitudinal.Items.Count > 0 && listaCuaderno.Items.Count > 0 && lista_examenes.Items.Count > 0;

        }
        private void guardarArchivo(object sender, RoutedEventArgs e)
        {
            if (aulaSeleccionada == "Aula Primero A")
            {
                
                string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                
                string rutaArchivo = System.IO.Path.Combine(escritorio, "información_AulaPrimeroA.txt");

                
                string contenidoAnterior = "";
                if (File.Exists(rutaArchivo))
                {
                    contenidoAnterior = File.ReadAllText(rutaArchivo);
                }

                
                string informacion = contenidoAnterior +
                    "=== SECCIÓN TAREA ===" + Environment.NewLine;
                foreach (string item in listaTarea.Items)
                {
                    informacion += item + Environment.NewLine;
                }

                informacion += "=== SECCIÓN ACTITUDINAL ===" + Environment.NewLine;
                foreach (string item in listaActitudinal.Items)
                {
                    informacion += item + Environment.NewLine;
                }

                informacion += "=== SECCIÓN CUADERNO ===" + Environment.NewLine;
                foreach (string item in listaCuaderno.Items)
                {
                    informacion += item + Environment.NewLine;
                }

                informacion += "=== SECCIÓN EXÁMENES ===" + Environment.NewLine;
                foreach (string item in lista_examenes.Items)
                {
                    informacion += item + Environment.NewLine;
                }

                informacion += "=== SECCIÓN SEGUIMIENTO ===" + Environment.NewLine;
                foreach (string item in listaSeguimiento.Items)
                {
                    informacion += item + Environment.NewLine;
                }

                try
                {
                    
                    File.WriteAllText(rutaArchivo, informacion);
                    MessageBox.Show("La información se ha guardado correctamente en tu Escritorio/Desktop.\n" +
                        "Nombre del archivo: información_AulaPrimeroA.txt");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la información: " + ex.Message);
                }
            }
            else if (aulaSeleccionada == "Aula Primero B")
            {
                
                string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                
                string rutaArchivo = System.IO.Path.Combine(escritorio, "información_AulaPrimeroB.txt");

                
                string contenidoAnterior = "";
                if (File.Exists(rutaArchivo))
                {
                    contenidoAnterior = File.ReadAllText(rutaArchivo);
                }

                
                string informacion = contenidoAnterior +
                    "=== SECCIÓN TAREA ===" + Environment.NewLine;
                foreach (string item in listaTarea.Items)
                {
                    informacion += item + Environment.NewLine;
                }

                informacion += "=== SECCIÓN ACTITUDINAL ===" + Environment.NewLine;
                foreach (string item in listaActitudinal.Items)
                {
                    informacion += item + Environment.NewLine;
                }

                informacion += "=== SECCIÓN CUADERNO ===" + Environment.NewLine;
                foreach (string item in listaCuaderno.Items)
                {
                    informacion += item + Environment.NewLine;
                }

                informacion += "=== SECCIÓN EXÁMENES ===" + Environment.NewLine;
                foreach (string item in lista_examenes.Items)
                {
                    informacion += item + Environment.NewLine;
                }

                informacion += "=== SECCIÓN SEGUIMIENTO ===" + Environment.NewLine;
                foreach (string item in listaSeguimiento.Items)
                {
                    informacion += item + Environment.NewLine;
                }

                try
                {

                    File.WriteAllText(rutaArchivo, informacion);
                    MessageBox.Show("La información se ha guardado correctamente en tu Escritorio/Desktop.\n" +
                        "Nombre del archivo: información_AulaPrimeroB.txt");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la información: " + ex.Message);
                }
            }

        }
        public void Boton_Actitudinal(object sender, RoutedEventArgs ds)
        {
            if (string.IsNullOrEmpty(aulaSeleccionada) || combobox.Text == "Selecciona un Aula")
            {
                MessageBox.Show("Selecciona primero un Aula en la pestaña Principal");
                return;
            }

            if (objetosActitudinal < 3)
            {
                try
                {
                    string nombre = nombre_actitudinal.Text;
                    double nota1 = Convert.ToDouble(nota1_actitudinal.Text);
                    double nota2 = Convert.ToDouble(nota2_actitudinal.Text);
                    double nota3 = Convert.ToDouble(nota3_actitudinal.Text);
                    double nota4 = Convert.ToDouble(nota4_actitudinal.Text);

                    if (nota1 > 5 || nota2 > 5 || nota3 > 5 || nota4 > 5)

                    {
                        MessageBox.Show("Has escrito una nota mayor a 5. \nRecuerda escribir notas decimales con comas y no puntos.");
                    }
                    else
                    {
                        Actitudinal actitudinal = new Actitudinal();
                        actitudinal.setNombre(nombre);
                        actitudinal.setNota1(nota1);
                        actitudinal.setNota2(nota2);
                        actitudinal.setNota3(nota3);
                        actitudinal.setNota4(nota4);

                        c1_actitudinal.Text = Convert.ToString(actitudinal.hallarPrimerCorte());
                        c2_actitudinal.Text = Convert.ToString(actitudinal.hallarSegundoCorte());
                        label_actitudinal.Content = Convert.ToString(actitudinal.sumaTotal());

                        List<string> listaActitudinalCompleta = new List<string>();

                        if (aulaSeleccionada == "Aula Primero A")
                        {
                            listaActitudinalCompleta.Add("INFORMACIÓN PARA AULA PRIMERO A");
                            almacenarActitudinal.setNotas(a, actitudinal);
                            listaActitudinalCompleta.AddRange(almacenarActitudinal.mostrarNotasAulaPrimeroA());
                            listaActitudinal.ItemsSource = listaActitudinalCompleta;
                        }
                        else if (aulaSeleccionada == "Aula Primero B")
                        {
                            listaActitudinalCompleta.Add("INFORMACIÓN PARA AULA PRIMERO B");
                            almacenarActitudinal.setNotas(a, actitudinal);
                            listaActitudinalCompleta.AddRange(almacenarActitudinal.mostrarNotasAulaPrimeroB());
                            listaActitudinal.ItemsSource = listaActitudinalCompleta;
                        }

                        a++;
                        objetosActitudinal++;
                        nota1_actitudinal.Clear();
                        nota2_actitudinal.Clear();
                        nota3_actitudinal.Clear();
                        nota4_actitudinal.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No has llenado todos los campos");
                }
            }
            else
            {
                MessageBox.Show("No puedes agregar más periodos.\nPeriodos agregados: " + objetosActitudinal);
            }

            if (verificarSecciones())
            {
                btn_archivo.IsEnabled = true;
            }
            else
            {
                btn_archivo.IsEnabled = false;
            }

            combobox.IsEnabled = false;
        }
        private void Boton_Tarea(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(aulaSeleccionada) || combobox.Text == "Selecciona un Aula")
            {
                MessageBox.Show("Selecciona primero un Aula en la pestaña Principal");
                return;
            }

            if (objetosTarea < 3)
            {
                try
                {
                    string nombre = txtNombre.Text;
                    double nota1 = Convert.ToDouble(n1_tarea.Text);
                    double nota2 = Convert.ToDouble(n2_tarea.Text);
                    double nota3 = Convert.ToDouble(n3_tarea.Text);
                    double nota4 = Convert.ToDouble(n4_tarea.Text);
                    double nota5 = Convert.ToDouble(n5_tarea.Text);
                    double nota6 = Convert.ToDouble(n6_tarea.Text);
                    double nota7 = Convert.ToDouble(n7_tarea.Text);
                    double nota8 = Convert.ToDouble(n8_tarea.Text);

                    if (nota1 > 5 || nota2 > 5 || nota3 > 5 || nota4 > 5 || nota5 > 5 || nota6 > 5 || nota7 > 5 || nota8 > 5)
                    {
                        MessageBox.Show("Has escrito una nota mayor a 5. \nRecuerda escribir notas decimales con comas y no puntos.");
                    }
                    else
                    {
                        Tarea tarea = new Tarea();
                        tarea.setNombre(nombre);
                        tarea.setNota1(nota1);
                        tarea.setNota2(nota2);
                        tarea.setNota3(nota3);
                        tarea.setNota4(nota4);
                        tarea.setNota5(nota5);
                        tarea.setNota6(nota6);
                        tarea.setNota7(nota7);
                        tarea.setNota8(nota8);

                        corte1_tarea.Text = Convert.ToString(tarea.hallarPrimerCorte());
                        corte2_tarea.Text = Convert.ToString(tarea.hallarSegundoCorte());
                        labelTarea.Content = Convert.ToString(tarea.sumaTotal());

                        List<string> listaTareaCompleta = new List<string>();

                        if (aulaSeleccionada == "Aula Primero A")
                        {
                            listaTareaCompleta.Add("INFORMACIÓN PARA AULA PRIMERO A");
                            guardar.setNotas(objetosTarea, tarea);
                            listaTareaCompleta.AddRange(guardar.mostrarNotasAulaPrimeroA());
                            listaTarea.ItemsSource = listaTareaCompleta;
                        }
                        else if (aulaSeleccionada == "Aula Primero B")
                        {
                            listaTareaCompleta.Add("INFORMACIÓN PARA AULA PRIMERO B");
                            guardar.setNotas(objetosTarea, tarea);
                            listaTareaCompleta.AddRange(guardar.mostrarNotasAulaPrimeroB());
                            listaTarea.ItemsSource = listaTareaCompleta;
                        }

                        objetosTarea++;

                        n1_tarea.Clear();
                        n2_tarea.Clear();
                        n3_tarea.Clear();
                        n4_tarea.Clear();
                        n5_tarea.Clear();
                        n6_tarea.Clear();
                        n7_tarea.Clear();
                        n8_tarea.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No has llenado todos los campos");
                }
            }
            else
            {
                MessageBox.Show("No puedes agregar más periodos.\nPeriodos agregados: " + objetosTarea);
            }

            if (verificarSecciones())
            {
                btn_archivo.IsEnabled = true;
            }
            else
            {
                btn_archivo.IsEnabled = false;
            }

            combobox.IsEnabled = false;
        }
        private void Boton_Seguimiento(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(aulaSeleccionada) || combobox.Text == "Selecciona un Aula")
            {
                MessageBox.Show("Selecciona primero un Aula en la pestaña Principal");
                return;
            }

            if (objetosSeguimiento < 3)
            {
                try
                {
                    string nombre = nombre_seguimiento.Text;
                    double nota1 = Convert.ToDouble(nota1_seguimiento.Text);
                    double nota2 = Convert.ToDouble(nota2_seguimiento.Text);
                    double nota3 = Convert.ToDouble(nota3_seguimiento.Text);
                    double nota4 = Convert.ToDouble(nota4_seguimiento.Text);
                    double nota5 = Convert.ToDouble(nota5_seguimiento.Text);
                    double nota6 = Convert.ToDouble(nota6_seguimiento.Text);
                    double nota7 = Convert.ToDouble(nota7_seguimiento.Text);
                    double nota8 = Convert.ToDouble(nota8_seguimiento.Text);

                    if (nota1 > 5 || nota2 > 5 || nota3 > 5 || nota4 > 5 || nota5 > 5 || nota6 > 5 || nota7 > 5 || nota8 > 5)
                    {
                        MessageBox.Show("Has escrito una nota mayor a 5. \nRecuerda escribir notas decimales con comas y no puntos.");
                    }
                    else
                    {
                        Seguimiento seguimiento = new Seguimiento();
                        seguimiento.setNombre(nombre);
                        seguimiento.setNota1(nota1);
                        seguimiento.setNota2(nota2);
                        seguimiento.setNota3(nota3);
                        seguimiento.setNota4(nota4);
                        seguimiento.setNota5(nota5);
                        seguimiento.setNota6(nota6);
                        seguimiento.setNota7(nota7);
                        seguimiento.setNota8(nota8);

                        c1_seguimiento.Text = Convert.ToString(seguimiento.hallarPrimerCorte());
                        c2_seguimiento.Text = Convert.ToString(seguimiento.hallarSegundoCorte());
                        label_seguimiento.Content = Convert.ToString(seguimiento.sumaTotal());

                        List<string> listaSeguimientoCompleta = new List<string>();

                        if (aulaSeleccionada == "Aula Primero A")
                        {
                            listaSeguimientoCompleta.Add("INFORMACIÓN PARA AULA PRIMERO A");
                            almacenarSeguimiento.setNotas(objetosSeguimiento, seguimiento);
                            listaSeguimientoCompleta.AddRange(almacenarSeguimiento.mostrarNotasAulaPrimeroA());
                            listaSeguimiento.ItemsSource = listaSeguimientoCompleta;
                        }
                        else if (aulaSeleccionada == "Aula Primero B")
                        {
                            listaSeguimientoCompleta.Add("INFORMACIÓN PARA AULA PRIMERO B");
                            almacenarSeguimiento.setNotas(objetosSeguimiento, seguimiento);
                            listaSeguimientoCompleta.AddRange(almacenarSeguimiento.mostrarNotasAulaPrimeroB());
                            listaSeguimiento.ItemsSource = listaSeguimientoCompleta;
                        }

                        objetosSeguimiento++;

                        nota1_seguimiento.Clear();
                        nota2_seguimiento.Clear();
                        nota3_seguimiento.Clear();
                        nota4_seguimiento.Clear();
                        nota5_seguimiento.Clear();
                        nota6_seguimiento.Clear();
                        nota7_seguimiento.Clear();
                        nota8_seguimiento.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No has llenado todos los campos");
                }
            }
            else
            {
                MessageBox.Show("No puedes agregar más periodos.\nPeriodos agregados: " + objetosSeguimiento);
            }

            if (verificarSecciones())
            {
                btn_archivo.IsEnabled = true;
            }
            else
            {
                btn_archivo.IsEnabled = false;
            }

            combobox.IsEnabled = false;
        }

        public void Boton_Cuaderno(object sender, RoutedEventArgs asd)
        {

            if (string.IsNullOrEmpty(aulaSeleccionada) || combobox.Text == "Selecciona un Aula")
            {
                MessageBox.Show("Selecciona primero un Aula en la pestaña Principal");
                return;
            }
            if (objetosCuaderno < 3)
            {
                try
                {
                    string nombre = nombre_cuaderno.Text;
                    double nota1 = Convert.ToDouble(nota1_cuaderno.Text);
                    double nota2 = Convert.ToDouble(nota2_cuaderno.Text);

                    if (nota1 > 5 || nota2 > 5)
                    {
                        MessageBox.Show("Has escrito una nota mayor a 5. \nRecuerda escribir notas decimales con comas y no puntos.");
                    }
                    else
                    {
                        Cuaderno cuaderno = new Cuaderno();
                        cuaderno.setNombre(nombre);
                        cuaderno.setNota1(nota1);
                        cuaderno.setNota2(nota2);

                        c1_cuaderno.Text = Convert.ToString(cuaderno.hallarPrimerCorte());
                        c2_cuaderno.Text = Convert.ToString(cuaderno.hallarSegundoCorte());
                        label_cuaderno.Content = Convert.ToString(cuaderno.sumaTotal());

                        List<string> listaCuadernoCompleta = new List<string>();

                        if (aulaSeleccionada == "Aula Primero A")
                        {
                            listaCuadernoCompleta.Add("INFORMACIÓN PARA AULA PRIMERO A");
                            almacenarCuaderno.setNotas(objetosCuaderno, cuaderno);
                            listaCuadernoCompleta.AddRange(almacenarCuaderno.mostrarNotasAulaPrimeroA());
                            listaCuaderno.ItemsSource = listaCuadernoCompleta;
                        }
                        else if (aulaSeleccionada == "Aula Primero B")
                        {
                            listaCuadernoCompleta.Add("INFORMACIÓN PARA AULA PRIMERO B");
                            almacenarCuaderno.setNotas(objetosCuaderno, cuaderno);
                            listaCuadernoCompleta.AddRange(almacenarCuaderno.mostrarNotasAulaPrimeroB());
                            listaCuaderno.ItemsSource = listaCuadernoCompleta;
                        }

                        objetosCuaderno++;

                        nota1_cuaderno.Clear();
                        nota2_cuaderno.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No has llenado todos los campos");
                }
            }
            else
            {
                MessageBox.Show("No puedes agregar mas periodos.\nPeriodos agregados: " + objetosCuaderno);
            }

            if (verificarSecciones())
            {
                btn_archivo.IsEnabled = true;
            }
            else
            {
                btn_archivo.IsEnabled = false;
            }

            combobox.IsEnabled = false;
        }
        private void Boton_Examenes(object sender, RoutedEventArgs xd)
        {
            if (string.IsNullOrEmpty(aulaSeleccionada) || combobox.Text == "Selecciona un Aula")
            {
                MessageBox.Show("Selecciona primero un Aula en la pestaña Principal");
                return;
            }
            if (objetosExamen < 3)
            {
                bool flag = false;
                try
                {
                    string text = nombre_examenes.Text;
                    double num = Convert.ToDouble(nota1_examenes.Text);
                    double num2 = Convert.ToDouble(nota2_examenes.Text);
                    if (num > 5.0 || num2 > 5.0)
                    {
                        MessageBox.Show("Has escrito una nota mayor a 5. \nRecuerda escribir notas decimales con comas y no puntos.");
                    }
                    else
                    {
                        Examenes examenes = new Examenes();
                        examenes.setNombre(text);
                        examenes.setNota1(num);
                        examenes.setNota2(num2);
                        c1_examenes.Text = Convert.ToString(examenes.hallarPrimerCorte());
                        c2_examenes.Text = Convert.ToString(examenes.hallarSegundoCorte());
                        label_examenes.Content = Convert.ToString(examenes.sumaTotal());
                        List<string> list = new List<string>();
                        if (aulaSeleccionada == "Aula Primero A")
                        {
                            list.Add("INFORMACIÓN PARA AULA PRIMERO A");
                            almacenarExamenes.setNotas(e, examenes);
                            list.AddRange(almacenarExamenes.mostrarNotasAulaPrimeroA());
                            lista_examenes.ItemsSource = list;
                        }
                        else if (aulaSeleccionada == "Aula Primero B")
                        {
                            list.Add("INFORMACIÓN PARA AULA PRIMERO B");
                            almacenarExamenes.setNotas(e, examenes);
                            list.AddRange(almacenarExamenes.mostrarNotasAulaPrimeroB());
                            lista_examenes.ItemsSource = list;
                        }
                        e++;
                        objetosExamen++;
                        nota1_examenes.Clear();
                        nota2_examenes.Clear();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No has llenado todos los campos");
                }
            }
            else
            {
                MessageBox.Show("No puedes agregar mas periodos.\nPeriodos agregados: " + objetosExamen);
            }
            if (verificarSecciones())
            {
                btn_archivo.IsEnabled = true;
            }
            else
            {
                btn_archivo.IsEnabled = false;
            }
            valoresGuardados = true;
            combobox.IsEnabled = false;
        }



    }


}
