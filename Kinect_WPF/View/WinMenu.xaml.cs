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

namespace Kinect_WPF.View
{
    /// <summary>
    /// Lógica interna para WinMenu.xaml
    /// </summary>
    public partial class WinMenu : Window
    {
        public WinMenu()
        {
            InitializeComponent();
            DataContext = new ViewModel.MenuModel();

            _carouselDABDancas.SelectionChanged += _carouselDABDancas_SelectionChanged;
        }

        private void _carouselDABDancas_SelectionChanged(FrameworkElement selectedElement)
        {
            var viewModel = DataContext as ViewModel.MenuModel;
            if (viewModel == null)
            {
                return;
            }

            viewModel.SelectedDancaDAB = selectedElement.DataContext as Model.Danca;
        }

        private void _buttonLeftArrow_Click(object sender, RoutedEventArgs e)
        {
            _carouselDABDancas.RotateRight();
        }

        private void _buttonRightArrow_Click(object sender, RoutedEventArgs e)
        {
            _carouselDABDancas.RotateLeft();
        }
    }
}
