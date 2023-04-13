using EczaneApp.EntityLayer;
using EczaneApp.Wpf.ViewModels.SatisYapViewModels;
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
using System.Windows.Threading;

namespace EczaneApp.Wpf.Views.SatisYapViews
{
    /// <summary>
    /// Interaction logic for SatisYap.xaml
    /// </summary>
    public partial class SatisYap : Window
    {
        public Kullanici k;
        SatisYapListViewModel st = new SatisYapListViewModel();    
        
        public SatisYap(Kullanici k)
        {
            InitializeComponent();
            DataContext = st;
            this.k = k;
        }
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
            else this.WindowState = WindowState.Maximized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(MouseButtonState.Pressed != e.RightButton) this.DragMove();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //this.Title +=" "+ k.Personel.Ad;
            st.Personel = k.Personel;
        }
    }
}
