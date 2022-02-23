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
using System.Windows.Shapes;

namespace GestionEmploye.WPF
{
    /// <summary>
    /// Logique d'interaction pour SubWindow.xaml
    /// </summary>
    public partial class SubWindow : Window
    {
        private SubViewModel _viewModel;

        public SubWindow(EmployeDataProvider employeDataProvider)
        {
            InitializeComponent();

            _viewModel = new SubViewModel(employeDataProvider);
            DataContext = _viewModel;
            Activated += MainWindow_Activated1;

        }
        private void MainWindow_Activated1(object sender, EventArgs e)
        {
            _viewModel.Charger();
        }
    }
}
