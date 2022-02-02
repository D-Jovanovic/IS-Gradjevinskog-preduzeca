using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
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
using ISGradnja.Class;
using ISGradnja.Validators;

namespace ISGradnja.Windows
{
    /// <summary>
    /// Interaction logic for Profil.xaml
    /// </summary>
    public partial class Profil : Window
    {
        public Profil()
        {
            InitializeComponent();
            txtRola.Text = Global.ulogovanKorisnik;
            LoadUser();
            AddHotKeys();
        }

        private void AddHotKeys()
        {
            RoutedCommand edit = new RoutedCommand();
            edit.InputGestures.Add(new KeyGesture(Key.Enter));
            CommandBindings.Add(new CommandBinding(edit, btnEdit_Click));

            RoutedCommand close = new RoutedCommand();
            close.InputGestures.Add(new KeyGesture(Key.Escape));
            CommandBindings.Add(new CommandBinding(close, btnClose_Click));
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "0pHs3ssNHB03TpXjDtNqD7pEWzqIG3TYcGfLhBW6",
            BasePath = "https://filmovil-damjan2021-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private void LoadUser()
        {
            try
            {
                
                client = new FireSharp.FirebaseClient(ifc);

                FirebaseResponse res = client.Get(@"Users/" + Global.ulogovanKorisnikUsername);
                User ResUser = res.ResultAs<User>();// database result

                txtUsername.Text = ResUser.Username;
                txtEmail.Text = ResUser.Email;
                txtFullName.Text = ResUser.FullName;
                txtPassword.Text = ResUser.Password;
                txtPhoneNumber.Text = ResUser.PhoneNumber;
               
                
            }

            catch (Exception er)
            {
                MessageBox.Show("Nema interneta ili je problem u konekciji!" + er.Message, "Login - Greška", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);

                User user = new User()
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    Email = txtEmail.Text,
                    FullName = txtFullName.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Role = Global.ulogovanKorisnik
                };

                //Validacija blok
                var userValidator = new UserValidator();
                var result = userValidator.Validate(user);
                if (!result.IsValid)
                {
                    foreach (var faliure in result.Errors)
                    {
                        MessageBox.Show(faliure.ErrorMessage, "Profil", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    SetResponse set = client.Set(@"Users/" + txtUsername.Text, user);

                    MessageBox.Show("Korisnik je uspešno editovan!", "Profil", MessageBoxButton.OK, MessageBoxImage.Information);
                }

            }

            catch (Exception er)
            {
                MessageBox.Show("Nema interneta ili je problem u konekciji!" + er.Message, "Login - Greška", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
