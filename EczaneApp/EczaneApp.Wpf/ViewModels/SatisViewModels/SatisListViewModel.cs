using EczaneApp.BusinnessLayer;
using EczaneApp.EntityLayer;
using EczaneApp.Wpf.Common.Commands;
using EczaneApp.Wpf.ViewModels.SatisDetayViewModels;
using EczaneApp.Wpf.Views.SatisViews;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace EczaneApp.Wpf.ViewModels.SatisViewModels
{
    public class SatisListViewModel : BaseViewModel
    {
        private SatisManager manager;
        private ObservableCollection<SatisViewModel> _Items;
        private SatisViewModel _SelectedItem;

        public ObservableCollection<SatisViewModel> Items
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
        public SatisViewModel SelectedItem
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

        public ICommand SilCommand { get; set; }
        public ICommand DetayCommand { get; set; }

        public SatisListViewModel()
        {
            manager = new SatisManager();
            Yenile();
            SilCommand = new RelayCommand(x => { OnSil(x); }, x => { return x != null; });
            DetayCommand = new RelayCommand(x => { OnDetay(x); }, x => { return x != null; });
        }

        private void OnDetay(object x)
        {
            SatisViewModel satis = x as SatisViewModel;
            using (SatisDetaylarManager detayManager = new SatisDetaylarManager())
            {
                List<SatisDetay> detaylar=  detayManager.GetDetay(satis.Satis.Id);
                SatisDetayListViewModel vm = new SatisDetayListViewModel(detaylar);
                SatisWindow view = new SatisWindow() { DataContext = vm };
                view.ShowDialog();
            }
        }

        private void Yenile()
        {
            Items = new ObservableCollection<SatisViewModel>();
            List<Satis> satislar = manager.Listele();
            foreach (var item in satislar)
            {
                Items.Add(new SatisViewModel(item));
            }
        }
        private void OnSil(object parameter)
        {
            SatisViewModel kw = parameter as SatisViewModel;
            if (MessageBox.Show("Satışı silmek istediğinizden emin misiniz?", "Satış Sil", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                manager.Sil(kw.Satis);
                Items.Remove(kw);
            }
        }
    }
}
