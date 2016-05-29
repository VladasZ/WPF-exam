using ERP_system.Database;
using RandomUserGenerator;
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

namespace ERP_system
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            

            listBox.ItemsSource = (from usr in DataSource.getRandomUsers(3)
                                   select usr.FirstName).ToArray();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DatabaseManager.loadData();

            listBox.ItemsSource = (from usr in DatabaseManager.DbContext.Employees
                                   select usr.FirstName).ToArray();
        }
    }
}
