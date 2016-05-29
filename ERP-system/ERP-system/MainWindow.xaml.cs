using ERP_system.Database;
using ERP_system.Database.Entities;
using RandomUserGenerator;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

            DatabaseManager.DbContext.Employees.Load();

            employeesNameListBox.ItemsSource = DatabaseManager.DbContext.Employees.Local;

            DataContext = employeesNameListBox.SelectedItem;



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
