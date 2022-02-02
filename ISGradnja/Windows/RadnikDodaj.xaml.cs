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
    /// Interaction logic for RadnikDodaj.xaml
    /// </summary>
    public partial class RadnikDodaj : Window
    {
        public RadnikDodaj()
        {
            InitializeComponent();
            AddHotKeys();
            LoadDelatnosti();
            LoadGradilista();

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

        private void LoadDelatnosti()
        {

            List<Delatnosti> listaDelatnosti = new List<Delatnosti>();
            listaDelatnosti = SqlDataAcces.GetAllDelatnosti();


            foreach (var del in listaDelatnosti)
            {
                cmbDelatnost.Items.Add(del.Naziv);
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
                Radnik radnik = new Radnik()
                {
                    ImePrezime = txtFullName.Text,
                    Adresa = txtAddres.Text,
                    BrojTelefona = txtPhoneNumber.Text,
                    JMBG = txtJMBG.Text,
                    Delatnost = cmbDelatnost.Text,
                    Gradiliste = cmbGradiliste.Text
                };

                //Validacija blok
                var radnikValidator = new RadnikValidator();
                var result = radnikValidator.Validate(radnik);
                if (!result.IsValid)
                {
                    foreach (var faliure in result.Errors)
                    {
                        MessageBox.Show(faliure.ErrorMessage, "Dodavanje radnika", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                } else
                {
                    if (SqlDataAcces.CheckRadnikExist(radnik))
                    {
                        MessageBox.Show("Takav radnik već postoji u bazi!", "Dodavanje radnika - Greška", MessageBoxButton.OK, MessageBoxImage.Error);

                    }
                    else
                    {
                        if (SqlDataAcces.AddRadnik(radnik))
                        {
                            MessageBox.Show("Novi radnik je uspešno dodat!", "Dodavanje radnika - Uspešno!", MessageBoxButton.OK, MessageBoxImage.Information);
                            ResetFields();

                        }
                        else
                        {
                            MessageBox.Show("Desila se greška!", "Dodavanje radnika - Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
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
            txtFullName.Text = null;
            txtAddres.Text = null;
            txtPhoneNumber.Text = null;
            txtJMBG.Text = null;
            cmbDelatnost.Text = null;
            cmbGradiliste.Text = null;
        }
    }
}
