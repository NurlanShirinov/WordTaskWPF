using System;
using System.Collections.Generic;
using System.IO;
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

namespace WordTaskWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        
        public MainWindow()
        {
            InitializeComponent();
            PathTxtB.Text = filePath;
        }

        private void cutBtn_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Cut();
        }

        private void copyBtn_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Copy();
        }

        private void PasteBtn_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Paste();
        }

        private void SelectAllBtn_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.SelectAll();
        }

        private void infoItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("It is just a info");
        }

        private void SaveItem_Click(object sender, RoutedEventArgs e)
        {
            filePath = filePath + "/Your.txt";
            TextWriter sw = new StreamWriter(filePath);
            sw.WriteLine(TextBox1.Text);
            sw.Close();
            MessageBox.Show("File txt creato correttamente");
        }
    }
}
