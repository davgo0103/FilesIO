using System;
using System.IO;
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
using Microsoft.Win32;
using CsvHelper;

namespace FilesIO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            OpenFileDialog openfileDialog = new OpenFileDialog();
            openfileDialog.DefaultExt = "*.csv";
            string path;
            if(openfileDialog.ShowDialog() == true)
            {
                path = openfileDialog.FileName;
                StreamReader sr = new StreamReader(path, Encoding.Default);

            }
            
        }
    }
}
