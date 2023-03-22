using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ProjektZaliczeniowy;
using MessageBox = System.Windows.MessageBox;

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy DodajCwDoPlanuWindow.xaml
    /// </summary>
    public partial class DodajCwDoPlanuWindow : Window
    {
        SzczegolyCwiczenia cwiczenie;
        public DodajCwDoPlanuWindow()
        {
            InitializeComponent();
        }
        public DodajCwDoPlanuWindow(SzczegolyCwiczenia cw) : this()
        {
            cwiczenie = cw;
            txtNazwa.Text = cwiczenie.Nazwa;
            if (cwiczenie.Kategoria == KatergoraCw.Klatka_Piersiowa)
                comboBox.Text = "Klatka Piersiowa";
            else if (cwiczenie.Kategoria == KatergoraCw.Plecy)
                comboBox.Text = "Plecy";
            else if (cwiczenie.Kategoria == KatergoraCw.Barki)
                comboBox.Text = "Barki";
            else if (cwiczenie.Kategoria == KatergoraCw.Biceps)
                comboBox.Text = "Biceps";
            else if (cwiczenie.Kategoria == KatergoraCw.Przedramie)
                comboBox.Text = "Przedrammie";
            else if (cwiczenie.Kategoria == KatergoraCw.Uda_i_posladki)
                comboBox.Text = "Uda i posladki";
            else if (cwiczenie.Kategoria == KatergoraCw.Lydka)
                comboBox.Text = "Lydka";
            else if (cwiczenie.Kategoria == KatergoraCw.Brzuch)
                comboBox.Text = "Brzuch";
            else if (cwiczenie.Kategoria == KatergoraCw.Cale_cialo)
                comboBox.Text = "Cale cialo";
            else
                comboBox.Text = "Triceps";
            txtPowtorzenia.Text = cwiczenie.Powtorzenia;
            txtSerie.Text = cwiczenie.Serie;

        }

        private void btnDodajCw_Click(object sender, RoutedEventArgs e)
        {
            if (txtNazwa.Text == "" || txtPowtorzenia.Text == "" || txtSerie.Text == "")
                MessageBox.Show("Prosze uzupelnić dane", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                if (comboBox.Text == "Klatka piersiowa")
                    cwiczenie.Kategoria = KatergoraCw.Klatka_Piersiowa;
                else if (comboBox.Text == "Plecy")
                    cwiczenie.Kategoria = KatergoraCw.Plecy;
                else if (comboBox.Text == "Brzuch")
                    cwiczenie.Kategoria = KatergoraCw.Brzuch;
                else if (comboBox.Text == "Lydka")
                    cwiczenie.Kategoria = KatergoraCw.Lydka;
                else if (comboBox.Text == "Uda i posladki")
                    cwiczenie.Kategoria = KatergoraCw.Uda_i_posladki;
                else if (comboBox.Text == "Biceps")
                    cwiczenie.Kategoria = KatergoraCw.Biceps;
                else if (comboBox.Text == "Triceps")
                    cwiczenie.Kategoria = KatergoraCw.Triceps;
                else if (comboBox.Text == "Barki")
                    cwiczenie.Kategoria = KatergoraCw.Barki;
                else if (comboBox.Text == "Przedramie")
                    cwiczenie.Kategoria = KatergoraCw.Przedramie;
                else
                    cwiczenie.Kategoria = KatergoraCw.Cale_cialo;

                cwiczenie.Nazwa = txtNazwa.Text;
                cwiczenie.Powtorzenia = txtPowtorzenia.Text;
                cwiczenie.Serie = txtSerie.Text;
                DialogResult = true;
            }
        }
    }

}

