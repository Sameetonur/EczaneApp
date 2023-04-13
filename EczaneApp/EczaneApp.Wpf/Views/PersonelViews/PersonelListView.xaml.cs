using EczaneApp.BusinnessLayer;
using EczaneApp.EntityLayer;
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

namespace EczaneApp.Wpf.Views.PersonelViews
{
    /// <summary>
    /// Interaction logic for PersonelListView.xaml
    /// </summary>
    public partial class PersonelListView : Page
    {
        
        public PersonelListView()
        {
            InitializeComponent();
            DataContext = new PersonelListViewModel();
        }
        
    }
}
