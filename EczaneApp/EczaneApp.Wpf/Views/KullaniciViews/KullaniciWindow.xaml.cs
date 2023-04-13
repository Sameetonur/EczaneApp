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

namespace EczaneApp.Wpf.Views.KullaniciViews
{
    /// <summary>
    /// Interaction logic for KullaniciWindow.xaml
    /// </summary>
    public partial class KullaniciWindow : Window
    {
        private Kullanici p = new Kullanici();
        public KullaniciWindow(Kullanici p)
        {
            InitializeComponent();
            this.p.Ad = p.Ad;
            this.p.Sifre = p.Sifre;
            this.p.Yetki = p.Yetki;
            this.p.sonGirisT = p.sonGirisT;
            this.p.Personel = p.Personel;
            this.p.PersonelId = p.PersonelId;

            yetki.Items.Add("Kullanıcı");
            yetki.Items.Add("Admin");
            if (p.PersonelId != 0)
                yetki.SelectedIndex = p.Yetki == Yetkiler.Kullanıcı ? 0 : 1;
            else yetki.SelectedIndex = 0;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (MouseButtonState.Pressed != e.RightButton) this.DragMove();
        }

        private void btnIptal_Click(object sender, RoutedEventArgs e)
        {
            if (p.Ad != null)
            {
                txtAd.Text = p.Ad;
                txtSifre.Text = p.Sifre;
                yetki.SelectedItem = p.Yetki;
                personel.SelectedValue = p.PersonelId;
                txtAd.GetBindingExpression(TextBox.TextProperty).UpdateSource();
                txtSifre.GetBindingExpression(TextBox.TextProperty).UpdateSource();
                yetki.GetBindingExpression(ComboBox.SelectedItemProperty).UpdateSource();
                personel.GetBindingExpression(ComboBox.SelectedValueProperty).UpdateSource();
            }

            DialogResult = false;
        }

        private void btnTamam_Click(object sender, RoutedEventArgs e)
        {
            txtAd.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtSifre.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            yetki.GetBindingExpression(ComboBox.SelectedItemProperty).UpdateSource();
            personel.GetBindingExpression(ComboBox.SelectedValueProperty).UpdateSource();

            if (!txtAd.GetBindingExpression(TextBox.TextProperty).HasValidationError &&
                !txtSifre.GetBindingExpression(TextBox.TextProperty).HasValidationError &&
                !personel.GetBindingExpression(ComboBox.SelectedValueProperty).HasValidationError) DialogResult = true;
        }
    }
}
