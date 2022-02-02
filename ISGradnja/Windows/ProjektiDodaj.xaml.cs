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
using System.Diagnostics;
using Microsoft.Win32;

namespace ISGradnja.Windows
{
    /// <summary>
    /// Interaction logic for ProjektiDodaj.xaml
    /// </summary>
    public partial class ProjektiDodaj : Window
    {
        string doc1 = "";
        string doc2 = "";
        string doc3 = "";
        public ProjektiDodaj()
        {
            InitializeComponent();
            AddHotKeys();
            LoadTip();
        }

        private void LoadTip()
        {
            List<Class.TipObjekta> listaGradilista = new List<Class.TipObjekta>();
            listaGradilista = SqlDataAcces.GetAllTipObjekta();


            foreach (var del in listaGradilista)
            {
                cmbTip.Items.Add(del.Naziv);
            }
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void AddHotKeys()
        {

            RoutedCommand close = new RoutedCommand();
            close.InputGestures.Add(new KeyGesture(Key.Escape));
            CommandBindings.Add(new CommandBinding(close, btnClose_Click));
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnDoc1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var fileContent = string.Empty;
                var filePath = string.Empty;


                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Filter = "Word files (*.docx)|*.docx|Pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";

                openFileDialog.ShowDialog();
                //Get the path of specified file
                filePath = openFileDialog.FileName;
                string sourceFile = filePath;

                var onlyFileName = System.IO.Path.GetFileName(openFileDialog.FileName);

                string destinationFile = AppDomain.CurrentDomain.BaseDirectory + "docs\\" + onlyFileName;

                System.IO.File.Copy(sourceFile, destinationFile, true);

                doc1 = onlyFileName;

                btnDoc1.Content = onlyFileName;


            }
            catch (Exception er)
            {
                MessageBox.Show("Desila se greska prilikom ucitavanja dokumenta" + er.Message, "Greska dodavanje dokumenta");
            }
        }

        private void btnDoc2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var fileContent = string.Empty;
                var filePath = string.Empty;


                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Filter = "Word files (*.docx)|*.docx|Pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";

                openFileDialog.ShowDialog();
                //Get the path of specified file
                filePath = openFileDialog.FileName;
                string sourceFile = filePath;

                var onlyFileName = System.IO.Path.GetFileName(openFileDialog.FileName);

                string destinationFile = AppDomain.CurrentDomain.BaseDirectory + "docs\\" + onlyFileName;

                System.IO.File.Copy(sourceFile, destinationFile, true);

                doc2 = onlyFileName;

                btnDoc2.Content = onlyFileName;


            }
            catch (Exception er)
            {
                MessageBox.Show("Desila se greska prilikom ucitavanja dokumenta" + er.Message, "Greska dodavanje dokumenta");
            }
        }

        private void btnDoc3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var fileContent = string.Empty;
                var filePath = string.Empty;


                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Filter = "Word files (*.docx)|*.docx|Pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";

                openFileDialog.ShowDialog();
                //Get the path of specified file
                filePath = openFileDialog.FileName;
                string sourceFile = filePath;

                var onlyFileName = System.IO.Path.GetFileName(openFileDialog.FileName);

                string destinationFile = AppDomain.CurrentDomain.BaseDirectory + "docs\\" + onlyFileName;

                System.IO.File.Copy(sourceFile, destinationFile, true);

                doc3 = onlyFileName;

                btnDoc3.Content = onlyFileName;


            }
            catch (Exception er)
            {
                MessageBox.Show("Desila se greska prilikom ucitavanja dokumenta" + er.Message, "Greska dodavanje dokumenta");
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Class.Projekti projekti = new Class.Projekti()
                {
                    Naziv = txtNaziv.Text,
                    Investitor = txtInvestitor.Text,
                    Adresa = txtAdresa.Text,
                    Tip = cmbTip.Text,
                    Spratnost = txtSpratnost.Text,
                    PocetakDatum = dpPocetak.Text,
                    RokDatum = dpRok.Text,
                    Dokument1 = doc1,
                    Dokument2 = doc2,
                    Dokument3 = doc3
                    
                };

                //Validacija blok
                var projektiValidator = new ProjektiValidator();
                var result = projektiValidator.Validate(projekti);
                if (!result.IsValid)
                {
                    foreach (var faliure in result.Errors)
                    {
                        MessageBox.Show(faliure.ErrorMessage, "Dodavanje projekta", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                        if (SqlDataAcces.AddProjekat(projekti))
                        {
                            MessageBox.Show("Novi projekat je uspešno dodat!", "Dodavanje projekta - Uspešno!", MessageBoxButton.OK, MessageBoxImage.Information);
                            ResetFields();

                        }
                        else
                        {
                            MessageBox.Show("Desila se greška!", "Dodavanje projekta - Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                

            }

            catch (Exception er)
            {
                MessageBox.Show("Desila se greška!" + er.Message, "Dodavanje projekta - Greška", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void ResetFields()
        {
            txtNaziv.Text = null;
            txtInvestitor.Text = null;
            txtAdresa.Text = null;
            txtSpratnost.Text = null;
            cmbTip.Text = null;
            dpPocetak.Text = null;
            dpRok.Text = null;
        }
    }
}
