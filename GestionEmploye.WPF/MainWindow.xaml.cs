using GestionEmploye.DataAccess;
using GestionEmploye.ViewModels;
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

namespace GestionEmploye.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel _viewModel;
        private EmployeDataProvider _employeDataProvider;

        public MainWindow()
        {
            InitializeComponent();

            _employeDataProvider = new EmployeDataProvider();
            _viewModel = new MainViewModel(_employeDataProvider);
            DataContext = _viewModel;
            Activated += MainWindow_Activated1;
        }

        private void MainWindow_Activated1(object sender, EventArgs e)
        {
            _viewModel.Charger();
        }
        private void AddButton(object sender, RoutedEventArgs e)
        {
            SubWindow subWindow = new SubWindow(_employeDataProvider);
            subWindow.Show();
        }
    }
}
