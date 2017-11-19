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

namespace Wpf_Learning_First
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Full Name: ");
            sb.Append(FullName.Text);
            sb.Append("Sex?");
            sb.Append((bool)Male.IsChecked ? "Male" : "Female");
            sb.Append("Computer:  ");
            sb.Append((bool)Desktop.IsChecked ? "Desktop" : "");
            sb.Append((bool)Laptop.IsChecked ? "Laptop" : "");
            sb.Append((bool)Tablet.IsChecked ? "Tablet" : "");
            sb.Append("Your Job");
            sb.Append(Job.SelectedItem);
            sb.Append("Delivery Date");
            sb.Append(Date.SelectedDate);
            MessageBox.Show(sb.ToString());
        }
    }
}
