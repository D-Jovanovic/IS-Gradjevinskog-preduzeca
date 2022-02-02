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
using System.Windows.Shapes;
using System.Data;
using System.Data.SQLite;
using ISGradnja.Class;
using ISGradnja.Validators;

namespace ISGradnja.Windows
{
    /// <summary>
    /// Interaction logic for MagacinRaspodela.xaml
    /// </summary>
    public partial class MagacinRaspodela : Window
    {
        int dostupno;
        Class.Magacin magacinAfter;
        public MagacinRaspodela()
        {
            InitializeComponent();
            AddHotKeys();
            LoadGradilista();
            LoadData();
        }

        private void LoadData()
        {
            Class.Magacin magacin = SqlDataAcces.GetMagacin(Global.idMagacinEdit);
            magacinAfter = magacin;

            txtNaziv.Text = magacin.Naziv;
            txtDostupno.Text = "Dostupno: " + magacin.Dostupno.ToString();
            dostupno = magacin.Dostupno;
        }

        private void LoadGradilista()
        {
            List<Class.Projekti> listaGradilista = new List<Class.Projekti>();
            listaGradilista = SqlDataAcces.GetAllProjketi();


            foreach (var del in listaGradilista)
            {
                cmbGradiliste.Items.Add(del.Naziv);
            }
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void AddHotKeys()
        {
            RoutedCommand dodaj = new RoutedCommand();
            dodaj.InputGestures.Add(new KeyGesture(Key.Enter));
            CommandBindings.Add(new CommandBinding(dodaj, btnRaspodela_Click));

            RoutedCommand close = new RoutedCommand();
            close.InputGestures.Add(new KeyGesture(Key.Escape));
            CommandBindings.Add(new CommandBinding(close, btnClose_Click));
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void btnRaspodela_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Class.MagacinRaspodela magacin = new Class.MagacinRaspodela()
                {
                    Naziv = txtNaziv.Text,
                    Gradiliste = cmbGradiliste.Text,
                    Kolicina = int.Parse(txtKolicina.Text)
                };

                //Validacija blok
                if(dostupno >= int.Parse(txtKolicina.Text))
                {
                    if (SqlDataAcces.AddMagacinRaspodela(magacin))
                    {
                        MessageBox.Show("Stavka je uspešno raspodeljena!", "Raspodela u magacinu - Uspešno!", MessageBoxButton.OK, MessageBoxImage.Information);

                        magacinAfter.Dostupno = dostupno - int.Parse(txtKolicina.Text);
                        SqlDataAcces.UpdataMagacin(magacinAfter, Global.idMagacinEdit);

                    }
                    else
                    {
                        MessageBox.Show("Desila se greška!", "Raspodela u magacinu - Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                } else
                {
                    MessageBox.Show("Nije dostupno toliko stavki!", "Raspodela u magacinu - Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                    
                }

            

            catch (Exception er)
            {
                MessageBox.Show("Desila se greška!" + er.Message, "Raspodela u magacinu - Greška", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
