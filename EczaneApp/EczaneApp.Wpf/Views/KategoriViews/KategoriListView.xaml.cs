using EczaneApp.Wpf.ViewModels;
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

namespace EczaneApp.Wpf.Views.KategoriViews
{
    /// <summary>
    /// Interaction logic for KategoriListView.xaml
    /// </summary>
    public partial class KategoriListView : Page
    {
        public KategoriListView()
        {
            InitializeComponent();
            DataContext = new KategoriListViewModel();
        }
    }
}
