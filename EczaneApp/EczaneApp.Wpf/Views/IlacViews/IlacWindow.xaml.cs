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

namespace EczaneApp.Wpf.Views.IlacViews
{
    /// <summary>
    /// Interaction logic for IlacWindow.xaml
    /// </summary>
    public partial class IlacWindow : Window
    {
        private Ilac p = new Ilac();
        public IlacWindow(Ilac p)
        {
            InitializeComponent();
            if (p != null)
            {
                this.p.Ad = p.Ad;
                this.p.Fiyat = p.Fiyat;
                this.p.Adet = p.Adet;
                this.p.Aciklama = p.Aciklama;
                this.p.Kategori = p.Kategori;
                this.p.KategoriId = p.KategoriId;
                this.p.SKT = p.SKT;
            }
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
                txtFiyat.Text = p.Fiyat.ToString();
                txtAdet.Text = p.Adet.ToString();
                txtAciklama.Text = p.Aciklama;
                sonKullanmaTarihi.SelectedDate = p.SKT;
                kategori.SelectedValue = p.KategoriId;
                txtAd.GetBindingExpression(TextBox.TextProperty).UpdateSource();
                txtFiyat.GetBindingExpression(TextBox.TextProperty).UpdateSource();
                txtAdet.GetBindingExpression(TextBox.TextProperty).UpdateSource();
                txtAciklama.GetBindingExpression(TextBox.TextProperty).UpdateSource();
                sonKullanmaTarihi.GetBindingExpression(DatePicker.SelectedDateProperty).UpdateSource();
                kategori.GetBindingExpression(ComboBox.SelectedValueProperty).UpdateSource();
            }

            DialogResult = false;
        }

        private void btnTamam_Click(object sender, RoutedEventArgs e)
        {
            txtAd.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtFiyat.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtAdet.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtAciklama.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            sonKullanmaTarihi.GetBindingExpression(DatePicker.SelectedDateProperty).UpdateSource();
            kategori.GetBindingExpression(ComboBox.SelectedValueProperty).UpdateSource();

            if (!txtAd.GetBindingExpression(TextBox.TextProperty).HasValidationError &&
                !txtFiyat.GetBindingExpression(TextBox.TextProperty).HasValidationError &&
                !txtAdet.GetBindingExpression(TextBox.TextProperty).HasValidationError &&
                !txtAciklama.GetBindingExpression(TextBox.TextProperty).HasValidationError &&
                !sonKullanmaTarihi.GetBindingExpression(DatePicker.SelectedDateProperty).HasValidationError) DialogResult = true;
        }
    }
}
