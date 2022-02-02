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
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using ISGradnja.Class;

namespace ISGradnja.Windows
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            AddHotKeys();
        }

        private void AddHotKeys()
        {
            RoutedCommand login = new RoutedCommand();
            login.InputGestures.Add(new KeyGesture(Key.Enter));
            CommandBindings.Add(new CommandBinding(login, btnLogin_Click));
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "0pHs3ssNHB03TpXjDtNqD7pEWzqIG3TYcGfLhBW6",
            BasePath = "https://filmovil-damjan2021-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text) && string.IsNullOrWhiteSpace(txtPassword.Password))
                {
                    MessageBox.Show("Popunite sva polja", "Login - Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                client = new FireSharp.FirebaseClient(ifc);

                FirebaseResponse res = client.Get(@"Users/" + txtUsername.Text);
                User ResUser = res.ResultAs<User>();// database result

                User CurUser = new User() // USER GIVEN INFO
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Password
                };

                if (User.IsEqual(ResUser, CurUser))
                {
                    GlavniProzor glavniProzor = new GlavniProzor();
                    glavniProzor.Show();
                    Global.ulogovanKorisnik = ResUser.Role;
                    Global.ulogovanKorisnikUsername = txtUsername.Text;
                    Close();
                }

                else
                {
                    User.ShowError();
                }
            }

            catch (Exception er)
            {
                MessageBox.Show("Korisnički username i password se ne poklapaju!" + er.Message, "Login - Greška", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            /*
            if (txtUsername.Text == "admin" && txtPassword.Password == "admin")
            {
                GlavniProzor glavniProzor = new GlavniProzor();
                glavniProzor.Show();
                Global.ulogovanKorisnik = txtUsername.Text;
                Close();
            } else
            {
                MessageBox.Show("Uneti podaci nisu ispravni!", "Login - IS Gradjevina", MessageBoxButton.OK, MessageBoxImage.Error);
            } */
        }
    }
}
