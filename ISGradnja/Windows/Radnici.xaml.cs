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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SQLite;
using ISGradnja.Class;
using System.Collections;

namespace ISGradnja.Windows
{
    /// <summary>
    /// Interaction logic for Radnici.xaml
    /// </summary>
    public partial class Radnici : UserControl
    {
        public Radnici()
        {
            InitializeComponent();
            LoadRadnici();
        }

        private void LoadRadnici()
        {
            try
            {
                DataSet DS = SqlDataAcces.GetAllRadnik();

                if (DS.Tables[0].Rows.Count > 0)
                {
                    radniciDataGrid.ItemsSource = DS.Tables[0].DefaultView;
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Windows.RadnikDodaj radnikDodaj = new RadnikDodaj();
            radnikDodaj.ShowDialog();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView dataRowView = (DataRowView)((Button)e.Source).DataContext;
                String id = dataRowView[0].ToString();
                String name = dataRowView[1].ToString();

                if (SqlDataAcces.DelRadnik(id))
                {
                    MessageBox.Show("Radnik: '" + name + "' je uspešno obrisan", "Birsanje radnika - Uspešno!", MessageBoxButton.OK, MessageBoxImage.Information);
                    LoadRadnici();
                }
                    

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView dataRowView = (DataRowView)((Button)e.Source).DataContext;
                Global.idRadnikEdit = dataRowView[0].ToString();

                RadnikEdit radnikEdit = new RadnikEdit();
                radnikEdit.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            LoadRadnici();
        }
    }





}
