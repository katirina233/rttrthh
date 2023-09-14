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

namespace фонд_книг
{
    /// <summary>
    /// Логика взаимодействия для polzovatel.xaml
    /// </summary>
    public partial class polzovatel : Window
    {
        public polzovatel()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow = new MainWindow();
            MainWindow.Show();
            this close();
        }
    }
}
