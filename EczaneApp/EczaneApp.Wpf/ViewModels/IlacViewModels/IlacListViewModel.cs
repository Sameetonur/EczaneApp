using EczaneApp.BusinnessLayer;
using EczaneApp.EntityLayer;
using EczaneApp.Wpf.Common.Commands;
using EczaneApp.Wpf.Views.IlacViews;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace EczaneApp.Wpf.ViewModels.IlacViewModels
{
    public class IlacListViewModel : BaseViewModel
    {
        private IlacManager manager;
        private ObservableCollection<IlacViewModel> _Items;
        private IlacViewModel _SelectedItem;

        public ObservableCollection<IlacViewModel> Items
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
        public IlacViewModel SelectedItem
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

        public IlacListViewModel()
        {
            manager = new IlacManager();
            Yenile();
            EkleCommand = new RelayCommand(x => { OnEkle(); }, x => { return true; });
            SilCommand = new RelayCommand(x => { OnSil(x); }, x => { return x != null; });
            GuncelleCommand = new RelayCommand(x => { OnGuncelle(x); }, x => { return x != null; });
        }

        private void Yenile()
        {
            Items = new ObservableCollection<IlacViewModel>();
            List<Ilac> ilaclar = manager.Listele();
            foreach (var item in ilaclar)
            {
                Items.Add(new IlacViewModel(item));
            }
        }
        private void OnEkle()
        {
            IlacViewModel k = new IlacViewModel();
            IlacWindow pw = new IlacWindow(k.Ilac) { DataContext = k };
            if (pw.ShowDialog() == true)
            {
                if (manager.Ekle(k.Ilac) == 0)
                    Items.Add(k);
                else Yenile();
            }
        }
        private void OnSil(object parameter)
        {
            IlacViewModel kw = parameter as IlacViewModel;
            if (MessageBox.Show(kw.Ilac.Ad + " isimli ilacı silmek istediğinizden emin misiniz?", "Ilacı Sil", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                manager.Sil(kw.Ilac);
                Items.Remove(kw);
            }
        }
        private void OnGuncelle(object parameter)
        {
            IlacViewModel kw = parameter as IlacViewModel;
            IlacWindow pw = new IlacWindow(kw.Ilac) { DataContext = kw };
            if (pw.ShowDialog() == true)
            {
                manager.Guncelle(kw.Ilac);
            }
        }
    }
}
