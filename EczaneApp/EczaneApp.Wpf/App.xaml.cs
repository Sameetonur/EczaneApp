using EczaneApp.EntityLayer;
using EczaneApp.Wpf.Views.SatisYapViews;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace EczaneApp.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            GirisYap gr = new GirisYap();
            SatisYap satisYap = new SatisYap(gr.k);
            MainWindow main = new MainWindow(gr.k);
            if (gr.ShowDialog() == true)
            {
                main.k = satisYap.k = gr.k;
                if (gr.k.Yetki == Yetkiler.Admin)
                {
                    main.Show();
                    satisYap.Close();
                }
                else
                {
                    satisYap.Show();
                    main.Close();
                }
            }
            else
            {
                main.Close();
                satisYap.Close();
            }
        }
    }
}
