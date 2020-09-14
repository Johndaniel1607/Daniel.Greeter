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
using System.Xml;

namespace Greeter
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

        private void btn_Click_me_Click(object sender, RoutedEventArgs e)
        {
            string fullname = txt_FirstName.Text + " " + txt_LastName.Text;

            MessageBox.Show("HELLO " + fullname + ", Good Morning!Your favorite color is " + cboColor.SelectedItem);
        }

        private void cboColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InitializeComponent();
            List<string> colors = new List<string>()
            {
                "White",
                "Green",
                "Red",
                "Black",
                "Blue",
            };

            cboColor.ItemsSource = colors;
        }
    }
}
