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

namespace ISGradnja.Windows
{
    /// <summary>
    /// Interaction logic for ProjketiView.xaml
    /// </summary>
    public partial class ProjketiView : Window
    {
        public ProjketiView()
        {
            InitializeComponent();
            LoadData();
            AddHotKeys();
        }

        private void LoadData()
        {
            Class.Projekti projekti = SqlDataAcces.GetProjekat(Global.idProjekatView);

            naslov.Text = "Projekat - " + projekti.Naziv;

            txtAdresa.Text = projekti.Adresa;
            txtInvestitor.Text = projekti.Investitor;
            txtNaziv.Text = projekti.Naziv;
            txtPocetak.Text = projekti.PocetakDatum;
            txtRok.Text = projekti.RokDatum;
            txtSpratnost.Text = projekti.Spratnost;
            txtTip.Text = projekti.Tip;
            btnDoc1.Content = projekti.Dokument1;
            btnDoc2.Content = projekti.Dokument2;
            btnDoc3.Content = projekti.Dokument3;
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
            Process.Start(AppDomain.CurrentDomain.BaseDirectory + "docs\\" + btnDoc1.Content);
        }

        private void btnDoc2_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(AppDomain.CurrentDomain.BaseDirectory + "docs\\" + btnDoc2.Content);
        }

        private void btnDoc3_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(AppDomain.CurrentDomain.BaseDirectory + "docs\\" + btnDoc3.Content);
        }
    }
}
