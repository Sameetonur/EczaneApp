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
using EczaneApp.EntityLayer;

namespace EczaneApp.Wpf.Views.PersonelViews
{
    /// <summary>
    /// Interaction logic for PersonelWindow.xaml
    /// </summary>
    public partial class PersonelWindow : Window
    {
        private Personel p = new Personel();
        public PersonelWindow(Personel p)
        {
            InitializeComponent();
            this.p.Ad = p.Ad;
            this.p.Soyad = p.Soyad;
            this.p.TC = p.TC;
            this.p.DogumTarih = p.DogumTarih;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (MouseButtonState.Pressed != e.RightButton) this.DragMove();
        }

        private void btnIptal_Click(object sender, RoutedEventArgs e)
        {
            if(p.Ad != null)
            {
                txtAd.Text = p.Ad;
                txtSoyad.Text = p.Soyad;
                txtTC.Text = p.TC;
                dateDogumTarih.SelectedDate = p.DogumTarih;
                txtAd.GetBindingExpression(TextBox.TextProperty).UpdateSource();
                txtSoyad.GetBindingExpression(TextBox.TextProperty).UpdateSource();
                txtTC.GetBindingExpression(TextBox.TextProperty).UpdateSource();
                dateDogumTarih.GetBindingExpression(DatePicker.SelectedDateProperty).UpdateSource();
            }
            
            DialogResult = false;
        }

        private void btnTamam_Click(object sender, RoutedEventArgs e)
        {
            txtAd.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtSoyad.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtTC.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            dateDogumTarih.GetBindingExpression(DatePicker.SelectedDateProperty).UpdateSource();

            if(!txtAd.GetBindingExpression(TextBox.TextProperty).HasValidationError &&
                !txtSoyad.GetBindingExpression(TextBox.TextProperty).HasValidationError &&
                !txtTC.GetBindingExpression(TextBox.TextProperty).HasValidationError &&
                !dateDogumTarih.GetBindingExpression(DatePicker.SelectedDateProperty).HasValidationError)  DialogResult = true;
        }
    }
}
