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

namespace listadoboz
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


        private void SzinKeveres()
        {
            rctTeglalap.Fill = new SolidColorBrush(
                Color.FromRgb(
                    Convert.ToByte(sliPiros.Value), Convert.ToByte(sliZold.Value), Convert.ToByte(sliKek.Value)));
        }
        private void sliRGB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            SzinKeveres();
        }

        private void btnRogzit_Click(object sender, RoutedEventArgs e)
        {
            string text = $"{(byte)sliPiros.Value};{(byte)sliZold.Value};{(byte)sliKek.Value}";
            bool isAdded = false;

            foreach (var item in lbSzinek.Items)
            {
                if ((string)item == text)
                {
                    isAdded = true;
                    break;
                }
            }

            if (!isAdded)
            {
                lbSzinek.Items.Add(text);
            }
            else
            {
                MessageBox.Show("Az érték már szerepel a listában.");
            }
        }


        private void btnTorol_Click(object sender, RoutedEventArgs e)
        {
            
        }


        private void btnUrit_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
