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

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertToCelsius(object sender, RoutedEventArgs e)
        {
            string fString = textBox.Text;
            var fDouble = double.Parse(fString);
            var cDouble = 5 * (fDouble - 32) / 9;
            string cString = cDouble.ToString();
            textBox.Text = cString;

        }

        private void ConvertToFahrenheit(object sender, RoutedEventArgs e)
        {
            String cstring = textBox.Text;
            var cDouble = double.Parse(cstring);
            var fDouble = (cDouble * 9 / 5) + 32;
            string fString = fDouble.ToString();
            textBox.Text = fString;

        }
    }
}
