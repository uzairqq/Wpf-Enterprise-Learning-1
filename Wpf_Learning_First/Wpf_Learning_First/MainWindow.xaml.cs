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
        private Student stu;
        public MainWindow()
        {
            InitializeComponent();
            stu = new Student()
                {
                    StudentId = 3378,
                    StudentName = "Uzair",
                    RollNo = 155
                };
            DataContext = stu;

        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            stu.studentId = 059;
            stu.studentName = "Laraib";
            stu.rollNo = 123123;
        }
    }
}
