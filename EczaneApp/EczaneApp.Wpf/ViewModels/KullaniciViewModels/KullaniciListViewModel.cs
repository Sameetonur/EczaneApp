using EczaneApp.BusinnessLayer;
using EczaneApp.EntityLayer;
using EczaneApp.Wpf.Common.Commands;
using EczaneApp.Wpf.ViewModels.KullaniciViewModels;
using EczaneApp.Wpf.Views.KullaniciViews;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace EczaneApp.Wpf.ViewModels
{
    public class KullaniciListViewModel : BaseViewModel
    {
        private KullaniciManager manager;
        private ObservableCollection<KullaniciViewModel> _Items;
        private KullaniciViewModel _SelectedItem;

        public ObservableCollection<KullaniciViewModel> Items
        {
            get { return _Items; }
            set
            {
                if (_Items != value)
                {
                    _Items = value;
                    OnPropertyChanged();
                }
            }
        }
        public KullaniciViewModel SelectedItem
        {
            get { return _SelectedItem; }
            set
            {
                if (_SelectedItem != value)
                {
                    _SelectedItem = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand EkleCommand { get; set; }
        public ICommand SilCommand { get; set; }
        public ICommand GuncelleCommand { get; set; }

        public KullaniciListViewModel()
        {
            manager = new KullaniciManager();
            EkleCommand = new RelayCommand(x => { OnEkle(); }, x => { return true; });
            SilCommand = new RelayCommand(x => { OnSil(x); }, x => { return x != null; });
            GuncelleCommand = new RelayCommand(x => { OnGuncelle(x); }, x => { return x != null; });
            Yenile();
        }

        void Yenile()
        {
            Items = new ObservableCollection<KullaniciViewModel>();
            List<Kullanici> kullanicilar = manager.Listele();
            foreach (var item in kullanicilar)
            {
                Items.Add(new KullaniciViewModel(item));
            }
        }
        private void OnEkle()
        {
            KullaniciViewModel p = new KullaniciViewModel();
            KullaniciWindow pw = new KullaniciWindow(p.Kullanici) { DataContext = p };
            if (pw.ShowDialog() == true)
            {
                try
                {
                    manager.Ekle(p.Kullanici);
                    Items.Add(p);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Hata",MessageBoxButton.OK,MessageBoxImage.Error);
                }
            }
        }
        private void OnSil(object parameter)
        {
            KullaniciViewModel p = parameter as KullaniciViewModel;
            if (MessageBox.Show(p.Ad + " isimli kullanıcıyı silmek istediğinizden emin misiniz?", "Kullanıcı Sil", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                manager.Sil(p.Kullanici);
                Items.Remove(p);
            }
        }
        private void OnGuncelle(object parameter)
        {
            KullaniciViewModel p = parameter as KullaniciViewModel;
            KullaniciWindow pw = new KullaniciWindow(p.Kullanici) { DataContext = p };
            if (pw.ShowDialog() == true)
            {
                manager.Guncelle(p.Kullanici);
            }
        }
    }
}
