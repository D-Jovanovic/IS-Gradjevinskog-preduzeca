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
    /// Interaction logic for Magacin.xaml
    /// </summary>
    public partial class Magacin : UserControl
    {
        public Magacin()
        {
            InitializeComponent();
            LoadDataMagacin();
            LoadDataMagacinRaspodela();
        }

        private void LoadDataMagacin()
        {
            try
            {
                DataSet DS = SqlDataAcces.GetAllMagacin();

                if (DS.Tables[0].Rows.Count > 0)
                {
                    magacinDataGrid.ItemsSource = DS.Tables[0].DefaultView;
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void LoadDataMagacinRaspodela()
        {
            try
            {
                DataSet DS = SqlDataAcces.GetAllMagacinRaspodela();

                if (DS.Tables[0].Rows.Count > 0)
                {
                    magacinRaspodelaDataGrid.ItemsSource = DS.Tables[0].DefaultView;
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnAddMagacin_Click(object sender, RoutedEventArgs e)
        {
            MagacinDodaj magacinDodaj = new MagacinDodaj();
            magacinDodaj.ShowDialog();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView dataRowView = (DataRowView)((Button)e.Source).DataContext;
                String id = dataRowView[0].ToString();
                String name = dataRowView[1].ToString();
                String raspodelaId = null;

                if (SqlDataAcces.DelMagacin(id))
                {
                    MessageBox.Show("Stavka: '" + name + "' je uspešno obrisana", "Birsanje iz magacina - Uspešno!", MessageBoxButton.OK, MessageBoxImage.Information);

                    raspodelaId = SqlDataAcces.GetMagacinRaspodelaIDByName(name);
                    if (raspodelaId != null)
                        SqlDataAcces.DelMagacinRaspodela(raspodelaId);


                    LoadDataMagacin();
                    LoadDataMagacinRaspodela();
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
                Global.idMagacinEdit = dataRowView[0].ToString();

                MagacinEdit magacinEdit = new MagacinEdit();
                magacinEdit.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        private void btnOsvezi_Click(object sender, RoutedEventArgs e)
        {
            LoadDataMagacin();
            LoadDataMagacinRaspodela();
        }

        private void btnDelRaspodela_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                DataRowView dataRowView = (DataRowView)((Button)e.Source).DataContext;
                String id = dataRowView[0].ToString();
                String name = dataRowView[1].ToString();

                Class.MagacinRaspodela magacinRaspodela = SqlDataAcces.GetMagacinRaspodela(id);

                Class.Magacin magacin = SqlDataAcces.GetMagacinByName(name);
                

                if (SqlDataAcces.DelMagacinRaspodela(id))
                {
                    MessageBox.Show("Stavka: '" + name + "' je uspešno vraćena u magacin", "Birsanje raspodele - Uspešno!", MessageBoxButton.OK, MessageBoxImage.Information);

                    magacin.Dostupno = magacin.Dostupno + magacinRaspodela.Kolicina;
                    SqlDataAcces.UpdataMagacin(magacin, SqlDataAcces.GetMagacinIDByName(name));

                    LoadDataMagacin();
                    LoadDataMagacinRaspodela();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }


        private void btnRaspodela_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView dataRowView = (DataRowView)((Button)e.Source).DataContext;
                Global.idMagacinEdit = dataRowView[0].ToString();

                MagacinRaspodela magacinRaspodela = new MagacinRaspodela();
                magacinRaspodela.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
