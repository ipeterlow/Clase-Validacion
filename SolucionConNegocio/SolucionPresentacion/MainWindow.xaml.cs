using System;
using System.Collections.Generic;
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
using SolucionNegocio;

namespace SolucionPresentacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                long rut = long.Parse(txtRut.Text);
                DateTime fechaNacimiento = dpFechaNacimiento.SelectedDate.Value;
                string dv = txtDigitoVerificador.Text;

                Persona p = new Persona(nombre, rut, dv, fechaNacimiento);
                MessageBox.Show("se ha ingresado una persona");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
