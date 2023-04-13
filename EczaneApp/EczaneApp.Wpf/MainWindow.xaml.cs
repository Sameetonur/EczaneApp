using EczaneApp.EntityLayer;
using EczaneApp.Wpf.Views.SatisYapViews;
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

namespace EczaneApp.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Kullanici k;
        public MainWindow(Kullanici k)
        {
            InitializeComponent();
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
            if (MouseButtonState.Pressed != e.RightButton) this.DragMove();
        }

        private void btnPersoneller_Click(object sender, RoutedEventArgs e)
        {
            mainFrm.Source= new Uri("Views/PersonelViews/PersonelListView.xaml",UriKind.Relative);
            DrawerHost.IsLeftDrawerOpen = false;
        }

        private void btnMusteriler_Click(object sender, RoutedEventArgs e)
        {
            mainFrm.Source = new Uri("Views/MusteriViews/MusteriListView.xaml", UriKind.Relative);
            DrawerHost.IsLeftDrawerOpen = false;
        }

        private void btnKategoriler_Click(object sender, RoutedEventArgs e)
        {
            mainFrm.Source = new Uri("Views/KategoriViews/KategoriListView.xaml", UriKind.Relative);
            DrawerHost.IsLeftDrawerOpen = false;
        }

        private void btnKullanicilar_Click(object sender, RoutedEventArgs e)
        {
            mainFrm.Source = new Uri("Views/KullaniciViews/KullaniciListView.xaml", UriKind.Relative);
            DrawerHost.IsLeftDrawerOpen = false;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //this.Title = k.Personel.Ad;
        }

        private void btnIlaclar_Click(object sender, RoutedEventArgs e)
        {
            mainFrm.Source = new Uri("Views/IlacViews/IlacListView.xaml", UriKind.Relative);
            DrawerHost.IsLeftDrawerOpen = false;
        }

        private void btnSatis_Click(object sender, RoutedEventArgs e)
        {
            SatisYap mw = new SatisYap(k);
            mw.ShowDialog();
        }

        private void btnSatislar_Click(object sender, RoutedEventArgs e)
        {
            mainFrm.Source = new Uri("Views/SatisViews/SatisListView.xaml", UriKind.Relative);
            DrawerHost.IsLeftDrawerOpen = false;
        }
    }
}
