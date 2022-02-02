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
    /// Interaction logic for RadnikEdit.xaml
    /// </summary>
    public partial class RadnikEdit : Window
    {
        public RadnikEdit()
        {
            InitializeComponent();
            AddHotKeys();
            LoadDelatnosti();
            LoadGradilista();
            LoadData();

            
        }

        private void LoadData()
        {

            Radnik radnik = SqlDataAcces.GetRadnik(Global.idRadnikEdit);

            txtFullName.Text = radnik.ImePrezime;
            txtAddres.Text = radnik.Adresa;
            txtPhoneNumber.Text = radnik.BrojTelefona;
            txtJMBG.Text = radnik.JMBG;
            
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
            CommandBindings.Add(new CommandBinding(dodaj, btnEdit_Click));

            RoutedCommand close = new RoutedCommand();
            close.InputGestures.Add(new KeyGesture(Key.Escape));
            CommandBindings.Add(new CommandBinding(close, btnClose_Click));
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
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
                        MessageBox.Show(faliure.ErrorMessage, "Editovanje radnika", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                        if (SqlDataAcces.UpdataRadnik(radnik, Global.idRadnikEdit))
                        {
                            MessageBox.Show("Radnik je uspešno editovan!", "Editovanje radnika - Uspešno!", MessageBoxButton.OK, MessageBoxImage.Information);
                            Close();

                        }
                        else
                        {
                            MessageBox.Show("Desila se greška!", "Editovanje radnika - Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                

            }

            catch (Exception er)
            {
                MessageBox.Show("Desila se greška!" + er.Message, "Dodavanje radnika - Greška", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
