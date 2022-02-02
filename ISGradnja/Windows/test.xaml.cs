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
using Microsoft.Win32;
using System.IO;

namespace ISGradnja.Windows
{
    /// <summary>
    /// Interaction logic for test.xaml
    /// </summary>
    public partial class test : Window
    {
        public test()
        {
            InitializeComponent();
        }





        private void btnTest_Click(object sender, RoutedEventArgs e)
        {







            var fileContent = string.Empty;
            var filePath = string.Empty;


            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            openFileDialog.ShowDialog();
            //Get the path of specified file
            filePath = openFileDialog.FileName;
            string sourceFile = filePath;

            var onlyFileName = System.IO.Path.GetFileName(openFileDialog.FileName);

            string destinationFile = AppDomain.CurrentDomain.BaseDirectory + "docs\\" + onlyFileName;

            System.IO.File.Copy(sourceFile, destinationFile,true);

            

            

        }

    }
}
