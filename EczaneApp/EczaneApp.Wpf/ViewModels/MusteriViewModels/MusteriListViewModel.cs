using EczaneApp.BusinnessLayer;
using EczaneApp.EntityLayer;
using EczaneApp.Wpf.Common.Commands;
using EczaneApp.Wpf.ViewModels.MusteriViewModels;
using EczaneApp.Wpf.Views.MusteriViews;
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
    public class MusteriListViewModel : BaseViewModel
    {
        private MusteriManager manager;
        private ObservableCollection<MusteriViewModel> _Items;
        private MusteriViewModel _SelectedItem;

        public ObservableCollection<MusteriViewModel> Items
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
        public MusteriViewModel SelectedItem
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

        public MusteriListViewModel()
        {
            manager = new MusteriManager();
            EkleCommand = new RelayCommand(x => { OnEkle(); }, x => { return true; });
            SilCommand = new RelayCommand(x => { OnSil(x); }, x => { return x != null; });
            GuncelleCommand = new RelayCommand(x => { OnGuncelle(x); }, x => { return x != null; });
            Yenile();
        }

        void Yenile()
        {
            Items = new ObservableCollection<MusteriViewModel>();
            List<Musteri> musteriler = manager.Listele();
            foreach (var item in musteriler)
            {
                Items.Add(new MusteriViewModel(item));
            }
        }
        private void OnEkle()
        {
            MusteriViewModel p = new MusteriViewModel();
            MusteriWindow pw = new MusteriWindow(p.Musteri) { DataContext = p };
            if (pw.ShowDialog() == true)
            {
                manager.Ekle(p.Musteri);
                Items.Add(p);
            }
        }
        private void OnSil(object parameter)
        {
            MusteriViewModel p = parameter as MusteriViewModel;
            if (MessageBox.Show(p.Ad + " isimli müşteriyi silmek istediğinizden emin misiniz?", "Müşteri Sil", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                manager.Sil(p.Musteri);
                Items.Remove(p);
            }
        }
        private void OnGuncelle(object parameter)
        {
            MusteriViewModel p = parameter as MusteriViewModel;
            MusteriWindow pw = new MusteriWindow(p.Musteri) { DataContext = p };
            if (pw.ShowDialog() == true)
            {
                manager.Guncelle(p.Musteri);
            }
        }
    }
}
