using EczaneApp.BusinnessLayer;
using EczaneApp.EntityLayer;
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

namespace EczaneApp.Wpf
{
    /// <summary>
    /// Interaction logic for GirisYap.xaml
    /// </summary>
    public partial class GirisYap : Window
    {
        public Kullanici k= new Kullanici();
        public GirisYap()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (MouseButtonState.Pressed != e.RightButton) this.DragMove();
        }

        private void btnGiris_Click(object sender, RoutedEventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string sifre = txtSifre.Password.Trim();
            if (ad == "" || sifre == "")
            {
                hataMesaji.Text = "Boş bırakmayınız.";
                return;
            }
            else hataMesaji.Text = "";

            KullaniciManager manager = new KullaniciManager();
            if (manager.GirisYap(ad, sifre))
            {
                k = manager.kullaniciGetir(ad);
                DialogResult = true;
            }
            else hataMesaji.Text = "Kullanıcı bulunamadı.";
        }
    }
}
