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
using System.Windows.Shapes;
using ProjektZaliczeniowy;

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy PlanWindow.xaml
    /// </summary>
    public partial class PlanWindow : Window
    {
        Plan plan = new Plan();
        public PlanWindow(Plan pl)
        {
            plan = pl;
            InitializeComponent();
            if (plan.DzienPlanu == DzienTyg.Poniedzialek)
                comboBox.Text = "Poniedziałek";
            else if (plan.DzienPlanu == DzienTyg.Wtorek)
                comboBox.Text = "Wtorek";
            else if (plan.DzienPlanu == DzienTyg.Sroda)
                comboBox.Text = "Środa";
            else if (plan.DzienPlanu == DzienTyg.Czwartek)
                comboBox.Text = "Czwartek";
            else if (plan.DzienPlanu == DzienTyg.Piatek)
                comboBox.Text = "Piątek";
            else if (plan.DzienPlanu == DzienTyg.Sobota)
                comboBox.Text = "Sobota";
            else
                comboBox.Text = "Niedziela";


        }

        private void btnDodajCw_Click(object sender, RoutedEventArgs e)
        {
            SzczegolyCwiczenia cwiczenie = new SzczegolyCwiczenia();
            DodajCwDoPlanuWindow window = new DodajCwDoPlanuWindow(cwiczenie);
            window.ShowDialog();
            plan.Umiesc(cwiczenie);
            lstPlan.ItemsSource = new ObservableCollection<SzczegolyCwiczenia>(plan.PlanCwiczen);
        }
        private void MenuZapisz_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string filename = dlg.FileName;
                if (comboBox.Text == "Poniedziałek")
                    plan.DzienPlanu = DzienTyg.Poniedzialek;
                else if (comboBox.Text == "Wtorek")
                    plan.DzienPlanu = DzienTyg.Wtorek;
                else if (comboBox.Text == "Środa")
                    plan.DzienPlanu = DzienTyg.Sroda;
                else if (comboBox.Text == "Czwartek")
                    plan.DzienPlanu = DzienTyg.Czwartek;
                else if (comboBox.Text == "Piątek")
                    plan.DzienPlanu = DzienTyg.Piatek;
                else if (comboBox.Text == "Sobota")
                    plan.DzienPlanu = DzienTyg.Sobota;
                else
                    plan.DzienPlanu = DzienTyg.Niedziela;

                Plan.ZapiszXML(filename, plan);
            }
        }



    }
}
