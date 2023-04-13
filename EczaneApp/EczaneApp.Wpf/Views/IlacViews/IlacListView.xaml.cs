using EczaneApp.Wpf.ViewModels.IlacViewModels;
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

namespace EczaneApp.Wpf.Views.IlacViews
{
    /// <summary>
    /// Interaction logic for IlacListView.xaml
    /// </summary>
    public partial class IlacListView : Page
    {
        public IlacListView()
        {
            InitializeComponent();
            DataContext = new IlacListViewModel();
        }
    }
}
