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

            DatabaseManager.loadData();

            DatabaseManager.DbContext.Employees.Include("Tasks").Load();

            employeesNameListBox.ItemsSource = DatabaseManager.DbContext.Employees.Local;
            employeesNameListBox.SelectedIndex = 0;




        }

        private void employeesNameListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            taskEfficiencyLabel.DataContext = ((Employee)employeesNameListBox.SelectedItem).Tasks.Average(task => task.PercentDone);

            DataContext = employeesNameListBox.SelectedItem;
        }
    }
}
