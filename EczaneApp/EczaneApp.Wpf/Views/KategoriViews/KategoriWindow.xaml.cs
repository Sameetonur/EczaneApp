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

namespace EczaneApp.Wpf.Views.KategoriViews
{
    /// <summary>
    /// Interaction logic for KategoriWindow.xaml
    /// </summary>
    public partial class KategoriWindow : Window
    {
        private Kategori p = new Kategori();
        public KategoriWindow(Kategori p)
        {
            InitializeComponent();
            this.p.Ad = p.Ad;
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
                txtAd.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            }

            DialogResult = false;
        }

        private void btnTamam_Click(object sender, RoutedEventArgs e)
        {
            txtAd.GetBindingExpression(TextBox.TextProperty).UpdateSource();

            if (!txtAd.GetBindingExpression(TextBox.TextProperty).HasValidationError) DialogResult = true;
        }
    }
}
