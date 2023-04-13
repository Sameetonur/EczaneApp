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

namespace EczaneApp.Wpf.Views.SatisViews
{
    /// <summary>
    /// Interaction logic for SatisWindow.xaml
    /// </summary>
    public partial class SatisWindow : Window
    {
        public SatisWindow()
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
    }
}
