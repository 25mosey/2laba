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

namespace Books2
{
    public enum Theme
    {
        Economic, Economic1, Economic2, Economic3, Math , Math1, Math2, Math3, Historia, Historia1 , Historia2, Historia3, Russian, Russian1, Russian2, Russian3
    }
    public partial class MainWindow : Window
    {
        Themes facultet = new Themes();
        public MainWindow()
        {
            InitializeComponent();

        }  

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            Catalog.Text = "Format: Test, theme." + '\n';
            for (int i = 0; i < 6; i++)
            {
                Catalog.Text += facultet.Name_Students[i] + ", " + facultet.Theme_str[i] + ", " + facultet.Theme_str1[i] + ", " + facultet.Theme_str2[i] + ", " + facultet.Theme_str3[i] + "." + '\n';
            }
        }

    }
}
