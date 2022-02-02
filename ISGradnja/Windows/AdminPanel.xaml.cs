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
using ISGradnja.Validators;
using System.Data;

namespace ISGradnja.Windows
{
    /// <summary>
    /// Interaction logic for AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        public AdminPanel()
        {
            InitializeComponent();
            AddHotKeys();
            LoadDelatnostiTipObjekta();
        }

        private void LoadDelatnostiTipObjekta()
        {

            try
            {
                DataSet DS = SqlDataAcces.GetAllDelatnostiDS();

                if (DS.Tables[0].Rows.Count > 0)
                {
                    delatnostiDataGrid.ItemsSource = DS.Tables[0].DefaultView;
                }

                DataSet DS1 = SqlDataAcces.GetAllTipObjektaDS();

                if (DS1.Tables[0].Rows.Count > 0)
                {
                    tipObjektaDataGrid.ItemsSource = DS1.Tables[0].DefaultView;
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
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

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "0pHs3ssNHB03TpXjDtNqD7pEWzqIG3TYcGfLhBW6",
            BasePath = "https://filmovil-damjan2021-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
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
                    Role = cmbRole.Text
                };

                //Validacija blok
                var userValidator = new UserValidator();
                var result = userValidator.Validate(user);
                if (!result.IsValid)
                {
                    foreach (var faliure in result.Errors)
                    {
                        MessageBox.Show(faliure.ErrorMessage, "Admin panel", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                } else
                {
                    if (CheckUserExist(txtUsername.Text))
                    {
                        MessageBox.Show("Korisnik sa izabranim korisnickim imenom vec postoji u bazi!", "Admin panel", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        SetResponse set = client.Set(@"Users/" + txtUsername.Text, user);

                        MessageBox.Show("Korisnik je uspešno registrovan!", "Admin panel", MessageBoxButton.OK, MessageBoxImage.Information);

                        ResetFields();
                    }
                }

            }

            catch (Exception er)
            {
                MessageBox.Show("Nema interneta ili je problem u konekciji!" + er.Message, "Login - Greška", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool CheckUserExist(string text)
        {
            FirebaseResponse res = client.Get(@"Users/" + txtUsername.Text);
            User ResUser = res.ResultAs<User>();// database result

            if (ResUser == null)
                return false;
            else
                return true;
        }

        private void ResetFields()
        {
            txtUsername.Text = null;
            txtPassword.Text = null;
            txtEmail.Text = null;
            txtFullName.Text = null;
            txtPhoneNumber.Text = null;
            cmbRole.Text = null;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemAddUser":
                    userAddGrid.Visibility = Visibility.Visible;
                    userTableGrid.Visibility = Visibility.Hidden;
                    poljaAddGrid.Visibility = Visibility.Hidden;
                    break;
                case "ItemListUser":
                    userAddGrid.Visibility = Visibility.Hidden;
                    userTableGrid.Visibility = Visibility.Visible;
                    poljaAddGrid.Visibility = Visibility.Hidden;
                    break;
                case "ItemAddPolja":
                    userAddGrid.Visibility = Visibility.Hidden;
                    userTableGrid.Visibility = Visibility.Hidden;
                    poljaAddGrid.Visibility = Visibility.Visible;
                    break;
                default:
                    break;

            }
        }

        private void btnDelUser_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAddTipObjekta_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TipObjekta tipObjekta = new TipObjekta()
                {
                    Naziv = txtTipObjekta.Text
                };

                //Validacija blok
                var tipObjektaValidator = new TipObjektaValidator();
                var result = tipObjektaValidator.Validate(tipObjekta);
                if (!result.IsValid)
                {
                    foreach (var faliure in result.Errors)
                    {
                        MessageBox.Show(faliure.ErrorMessage, "Dodavanje tipa objekta", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    if (SqlDataAcces.CheckTipObjektaExist(tipObjekta))
                    {
                        MessageBox.Show("Takva delatnost već postoji u bazi!", "Dodavanje tipa objekta - Greška", MessageBoxButton.OK, MessageBoxImage.Error);

                    }
                    else
                    {
                        if (SqlDataAcces.AddTipObjekta(tipObjekta))
                        {
                            MessageBox.Show("Novi tip objekta je uspešno dodat!", "Dodavanje tipa objekta - Uspešno!", MessageBoxButton.OK, MessageBoxImage.Information);
                            txtTipObjekta.Text = "";
                            LoadDelatnostiTipObjekta();
                        }
                        else
                        {
                            MessageBox.Show("Desila se greška!", "Dodavanje tipa objekta - Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }

            }

            catch (Exception er)
            {
                MessageBox.Show("Desila se greška!" + er.Message, "Dodavanje tipa objekta - Greška", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnAddDelatnost_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Delatnosti delatnost = new Delatnosti()
                {
                    Naziv = txtDelatnost.Text
                };

                //Validacija blok
                var delatnostValidator = new DelatnostiValidator();
                var result = delatnostValidator.Validate(delatnost);
                if (!result.IsValid)
                {
                    foreach (var faliure in result.Errors)
                    {
                        MessageBox.Show(faliure.ErrorMessage, "Dodavanje delatnosti", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    if (SqlDataAcces.CheckDelatnostExist(delatnost))
                    {
                        MessageBox.Show("Takva delatnost već postoji u bazi!", "Dodavanje delatnosti - Greška", MessageBoxButton.OK, MessageBoxImage.Error);

                    }
                    else
                    {
                        if (SqlDataAcces.AddDelatnost(delatnost))
                        {
                            MessageBox.Show("Nova delatnost je uspešno dodata!", "Dodavanje delatnosti - Uspešno!", MessageBoxButton.OK, MessageBoxImage.Information);
                            txtDelatnost.Text = "";
                            LoadDelatnostiTipObjekta();
                        }
                        else
                        {
                            MessageBox.Show("Desila se greška!", "Dodavanje delatnosti - Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }

            }

            catch (Exception er)
            {
                MessageBox.Show("Desila se greška!" + er.Message, "Dodavanje delatnosti - Greška", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnDelDelatnosti_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView dataRowView = (DataRowView)((Button)e.Source).DataContext;
                String id = dataRowView[0].ToString();
                String name = dataRowView[1].ToString();

                if (SqlDataAcces.DelDelatnosti(id))
                {
                    MessageBox.Show("Delatnost: '" + name + "' je uspešno obrisana", "Birsanje delatnosti - Uspešno!", MessageBoxButton.OK, MessageBoxImage.Information);
                    LoadDelatnostiTipObjekta();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnDelTip_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView dataRowView = (DataRowView)((Button)e.Source).DataContext;
                String id = dataRowView[0].ToString();
                String name = dataRowView[1].ToString();

                if (SqlDataAcces.DelTipObjekta(id))
                {
                    MessageBox.Show("Tip: '" + name + "' je uspešno obrisan", "Birsanje tipa - Uspešno!", MessageBoxButton.OK, MessageBoxImage.Information);
                    LoadDelatnostiTipObjekta();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
