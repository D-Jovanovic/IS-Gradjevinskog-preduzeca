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

namespace ISGradnja.Windows
{
    /// <summary>
    /// Interaction logic for GlavniProzor.xaml
    /// </summary>
    public partial class GlavniProzor : Window
    {
        public GlavniProzor()
        {
            InitializeComponent();
            AddHotKeys();
        }

        private void AddHotKeys()
        {
            RoutedCommand projekti = new RoutedCommand();
            projekti.InputGestures.Add(new KeyGesture(Key.P,ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(projekti, ProjektiHandler));

            RoutedCommand magacin = new RoutedCommand();
            magacin.InputGestures.Add(new KeyGesture(Key.M, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(magacin, MagacinHandler));

            RoutedCommand radnici = new RoutedCommand();
            radnici.InputGestures.Add(new KeyGesture(Key.R, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(radnici, RadniciHandler));


            RoutedCommand profil = new RoutedCommand();
            profil.InputGestures.Add(new KeyGesture(Key.O, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(profil, btnProfil_Click));

            RoutedCommand admin = new RoutedCommand();
            admin.InputGestures.Add(new KeyGesture(Key.A, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(admin, btnAdminPanel_Click));

            RoutedCommand pomoc = new RoutedCommand();
            pomoc.InputGestures.Add(new KeyGesture(Key.F5));
            CommandBindings.Add(new CommandBinding(pomoc, btnPomoc_Click));

            RoutedCommand logout = new RoutedCommand();
            logout.InputGestures.Add(new KeyGesture(Key.F4, ModifierKeys.Alt));
            CommandBindings.Add(new CommandBinding(logout, BtnLogout));
        }

        private void ProjektiHandler(object sender, ExecutedRoutedEventArgs e)
        {
            naslovPorzora.Text = "IS Gradjevina - Projekti";
            ListViewMenu.SelectedItem = ItemProjekti;
            GridMain.Children.Clear();
            GridMain.Children.Add(new Windows.Projekti());
        }

        private void MagacinHandler(object sender, ExecutedRoutedEventArgs e)
        {
            if (Global.ulogovanKorisnik == "Gost")
            {
                MessageBox.Show("Ova opcija nije dostupna gostu!", "IS Gradjevina - Magacin", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                naslovPorzora.Text = "IS Gradjevina - Magacin";
                ListViewMenu.SelectedItem = ItemMagacin;
                GridMain.Children.Clear();
                GridMain.Children.Add(new Windows.Magacin());
            }
        }

        public void RadniciHandler(object sender, ExecutedRoutedEventArgs e)
        {
            if (Global.ulogovanKorisnik == "Gost")
            {
                MessageBox.Show("Ova opcija nije dostupna gostu!", "IS Gradjevina - Radnici", MessageBoxButton.OK, MessageBoxImage.Information);
            } else
            {
                naslovPorzora.Text = "IS Gradjevina - Radnici";
                ListViewMenu.SelectedItem = ItemRadnici;
                GridMain.Children.Clear();
                GridMain.Children.Add(new Windows.Radnici());
            }

        }

        private void BtnLogout(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemProjekti":
                    naslovPorzora.Text = "IS Gradjevina - Projekti";
                    usc = new Windows.Projekti();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemMagacin":
                    if(Global.ulogovanKorisnik == "Gost")
                    {
                        MessageBox.Show("Ova opcija nije dostupna gostu!", "IS Gradjevina - Magacin", MessageBoxButton.OK, MessageBoxImage.Information);
                        break;
                    }
                    naslovPorzora.Text = "IS Gradjevina - Magacin";
                    usc = new Windows.Magacin();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemRadnici":
                    if (Global.ulogovanKorisnik == "Gost")
                    {
                        MessageBox.Show("Ova opcija nije dostupna gostu!", "IS Gradjevina - Radnici", MessageBoxButton.OK, MessageBoxImage.Information);
                        break;
                    }
                    naslovPorzora.Text = "IS Gradjevina - Radnici";
                    usc = new Windows.Radnici();
                    GridMain.Children.Add(usc);
                    break;
                default:
                    break;

            }
        }

        private void btnPodesavanja_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("U ovom prozoru bice podesavanja aplikacije", "Podesavanja", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnProfil_Click(object sender, RoutedEventArgs e)
        {
            Windows.Profil profil = new Profil();
            profil.Show();
        }

        private void btnAdminPanel_Click(object sender, RoutedEventArgs e)
        {
            if(Global.ulogovanKorisnik == "Admin")
            {
                Windows.AdminPanel adminPanel = new AdminPanel();
                adminPanel.Show();
            } else
            {
                MessageBox.Show("Admin panel je dostupan samo adminu. Trenutno je ulogovan korisnik sa dozvolom:  " + Global.ulogovanKorisnik, "Admin panel", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            
        }

        private void btnPomoc_Click(object sender, RoutedEventArgs e)
        {   
            MessageBox.Show("Ovde ce biti linkovana pomoc", "Pomoc", MessageBoxButton.OK, MessageBoxImage.Information);
            
        }
    }
}
