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
    /// Interaction logic for MagacinEdit.xaml
    /// </summary>
    public partial class MagacinEdit : Window
    {
        Class.Magacin magacinBefore;
        public MagacinEdit()
        {
            InitializeComponent();
            AddHotKeys();
            LoadData();
        }


        private void LoadData()
        {
            Class.Magacin magacin = SqlDataAcces.GetMagacin(Global.idMagacinEdit);
            magacinBefore = magacin;

            txtName.Text = magacin.Naziv;
            txtKolicina.Text = magacin.Kolicina.ToString();
            cmbMernaJedinica.Text = magacin.MernaJedinica;
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
                if(int.Parse(txtKolicina.Text) < (magacinBefore.Kolicina - magacinBefore.Dostupno))
                {
                    MessageBox.Show("Desila se greška! Ne mozete smanjiti broj stavki jer su rasporedjene!", "Editovanje magacina - Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                if (magacinBefore.Dostupno == magacinBefore.Kolicina)
                {
                    Class.Magacin magacin = new Class.Magacin()
                    {
                        Naziv = txtName.Text,
                        MernaJedinica = cmbMernaJedinica.Text,
                        Kolicina = int.Parse(txtKolicina.Text),
                        Dostupno = int.Parse(txtKolicina.Text)
                    };

                    //Validacija blok
                    var magacinValidator = new MagacinValidator();
                    var result = magacinValidator.Validate(magacin);
                    if (!result.IsValid)
                    {
                        foreach (var faliure in result.Errors)
                        {
                            MessageBox.Show(faliure.ErrorMessage, "Editovanje magacina", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    else
                    {
                        if (SqlDataAcces.UpdataMagacin(magacin, Global.idMagacinEdit))
                        {
                            MessageBox.Show("Stavka u magacinu je uspešno editovana!", "Editovanje magacina - Uspešno!", MessageBoxButton.OK, MessageBoxImage.Information);
                            Close();

                        }
                        else
                        {
                            MessageBox.Show("Desila se greška!", "Editovanje magacina - Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }


            }
                else
                {
                    Class.Magacin magacin = new Class.Magacin()
                    {
                        Naziv = txtName.Text,
                        MernaJedinica = cmbMernaJedinica.Text,
                        Kolicina = int.Parse(txtKolicina.Text),
                        Dostupno = (int.Parse(txtKolicina.Text) - magacinBefore.Kolicina) + magacinBefore.Dostupno
                    };

                    //Validacija blok
                    var magacinValidator = new MagacinValidator();
                    var result = magacinValidator.Validate(magacin);
                    if (!result.IsValid)
                    {
                        foreach (var faliure in result.Errors)
                        {
                            MessageBox.Show(faliure.ErrorMessage, "Editovanje magacina", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    else
                    {
                        if (SqlDataAcces.UpdataMagacin(magacin, Global.idMagacinEdit))
                        {
                            MessageBox.Show("Stavka u magacinu je uspešno editovana!", "Editovanje magacina - Uspešno!", MessageBoxButton.OK, MessageBoxImage.Information);
                            Close();

                        }
                        else
                        {
                            MessageBox.Show("Desila se greška!", "Editovanje magacina - Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }


                
            }
            }




            catch (Exception er)
            {
                MessageBox.Show("Desila se greška!" + er.Message, "Editovanje magacina - Greška", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

