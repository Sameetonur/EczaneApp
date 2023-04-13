using EczaneApp.BusinnessLayer;
using EczaneApp.EntityLayer;
using EczaneApp.Wpf.Common.Commands;
using EczaneApp.Wpf.ViewModels.KatgoriViewModels;
using EczaneApp.Wpf.Views.KategoriViews;
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
    public class KategoriListViewModel : BaseViewModel
    {
        private KategoriManager manager;
        private ObservableCollection<KategoriViewModel> _Items;
        private KategoriViewModel _SelectedItem;

        public ObservableCollection<KategoriViewModel> Items
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
        public KategoriViewModel SelectedItem
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

        public KategoriListViewModel()
        {
            manager = new KategoriManager();
            EkleCommand = new RelayCommand(x => { OnEkle(); }, x => { return true; });
            SilCommand = new RelayCommand(x => { OnSil(x); }, x => { return x != null; });
            GuncelleCommand = new RelayCommand(x => { OnGuncelle(x); }, x => { return x != null; });

            Yenile();
        }

        private void Yenile()
        {
            Items = new ObservableCollection<KategoriViewModel>();
            List<Kategori> kategoriler = manager.Listele();
            foreach (var item in kategoriler)
            {
                Items.Add(new KategoriViewModel(item));
            }
        }
        private void OnEkle()
        {
            KategoriViewModel k = new KategoriViewModel();
            KategoriWindow pw = new KategoriWindow(k.Kategori) { DataContext = k };
            if (pw.ShowDialog() == true)
            {
                manager.Ekle(k.Kategori);
                Items.Add(k);
            }
        }
        private void OnSil(object parameter)
        {
            KategoriViewModel kw = parameter as KategoriViewModel;
            if (MessageBox.Show(kw.Kategori.Ad + " isimli kategoriyi silmek istediğinizden emin misiniz?", "Kategori Sil", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                manager.Sil(kw.Kategori);
                Items.Remove(kw);
            }
        }
        private void OnGuncelle(object parameter)
        {
            KategoriViewModel kw = parameter as KategoriViewModel;
            KategoriWindow pw = new KategoriWindow(kw.Kategori) { DataContext = kw };
            if (pw.ShowDialog() == true)
            {
                manager.Guncelle(kw.Kategori);
            }
        }
    }
}
