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
    /// Interaction logic for MagacinDodaj.xaml
    /// </summary>
    public partial class MagacinDodaj : Window
    {
        public MagacinDodaj()
        {
            InitializeComponent();
            AddHotKeys();
        }


        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void AddHotKeys()
        {
            RoutedCommand dodaj = new RoutedCommand();
            dodaj.InputGestures.Add(new KeyGesture(Key.Enter));
            CommandBindings.Add(new CommandBinding(dodaj, btnAdd_Click));

            RoutedCommand close = new RoutedCommand();
            close.InputGestures.Add(new KeyGesture(Key.Escape));
            CommandBindings.Add(new CommandBinding(close, btnClose_Click));
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Class.Magacin magacin = new Class.Magacin()
                {
                    Naziv = txtName.Text,
                    MernaJedinica = cmbMernaJedinica.Text,
                    Kolicina =  int.Parse(txtKolicina.Text),
                    Dostupno = int.Parse(txtKolicina.Text)
                };

                //Validacija blok
                var magacinValidator = new MagacinValidator();
                var result = magacinValidator.Validate(magacin);
                if (!result.IsValid)
                {
                    foreach (var faliure in result.Errors)
                    {
                        MessageBox.Show(faliure.ErrorMessage, "Dodavanje u magacin", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    if (SqlDataAcces.AddMagacin(magacin))
                    {
                        MessageBox.Show("Nova stavka je uspešno dodata!", "Dodavanje u magacin - Uspešno!", MessageBoxButton.OK, MessageBoxImage.Information);
                        ResetFields();

                    }
                    else
                    {
                        MessageBox.Show("Desila se greška!", "Dodavanje u magacin - Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }

            }

            catch (Exception er)
            {
                MessageBox.Show("Desila se greška!" + er.Message, "Dodavanje radnika - Greška", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ResetFields()
        {
            txtName.Text = null;
            txtKolicina.Text = null;
            cmbMernaJedinica.Text = null;
        }
    }
}
    