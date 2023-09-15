using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPF_Pertemuan3_PBKK_B
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> names = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();
            nameListBox.ItemsSource = names;
        }

        private void AddNameButton_Click(object sender, RoutedEventArgs e)
        {
            string newName = nameTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(newName))
            {
                names.Add(newName);
                nameTextBox.Clear();
            }
        }

    }
}
