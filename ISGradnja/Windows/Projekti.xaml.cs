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
    /// Interaction logic for Projekti.xaml
    /// </summary>
    public partial class Projekti : UserControl
    {
        public Projekti()
        {
            InitializeComponent();
            LoadProjekti();
        }

        private void LoadProjekti()
        {
            try
            {
                DataSet DS = SqlDataAcces.GetAllProjekti();

                if (DS.Tables[0].Rows.Count > 0)
                {
                    projketiDataGrid.ItemsSource = DS.Tables[0].DefaultView;
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            ProjektiDodaj projektiDodaj = new ProjektiDodaj();
            projektiDodaj.Show();

        }

        private void btnVew_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView dataRowView = (DataRowView)((Button)e.Source).DataContext;
                Global.idProjekatView = dataRowView[0].ToString();

                ProjketiView projketiView  = new ProjketiView();
                projketiView.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView dataRowView = (DataRowView)((Button)e.Source).DataContext;
                String id = dataRowView[0].ToString();
                String name = dataRowView[1].ToString();

                if (SqlDataAcces.DelProjekat(id))
                {
                    MessageBox.Show("Projekat: '" + name + "' je uspešno obrisan", "Birsanje projekta - Uspešno!", MessageBoxButton.OK, MessageBoxImage.Information);
                    LoadProjekti();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            LoadProjekti();
        }
    }
}
