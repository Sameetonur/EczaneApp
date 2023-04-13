using EczaneApp.Wpf.ViewModels.SatisViewModels;
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

namespace EczaneApp.Wpf.Views.SatisViews
{
    /// <summary>
    /// Interaction logic for SatisListView.xaml
    /// </summary>
    public partial class SatisListView : Page
    {
        public SatisListView()
        {
            InitializeComponent();
            DataContext = new SatisListViewModel();
        }
    }
}
