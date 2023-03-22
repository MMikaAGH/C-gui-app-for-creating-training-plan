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
using ProjektZaliczeniowy;

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Plan plan = new Plan();
        public MainWindow()
        {

            InitializeComponent();
        }

        private void btnStworzPlan_Click(object sender, RoutedEventArgs e)
        {

            PlanWindow okno = new PlanWindow(plan);
            okno.ShowDialog();
        }

        private void btnAtlas_Click(object sender, RoutedEventArgs e)
        {
            AtlasWindow okno = new AtlasWindow();
            okno.ShowDialog();
        }
    }
}
