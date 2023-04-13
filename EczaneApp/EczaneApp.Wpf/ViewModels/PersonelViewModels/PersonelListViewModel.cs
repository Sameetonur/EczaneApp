using EczaneApp.BusinnessLayer;
using EczaneApp.EntityLayer;
using EczaneApp.Wpf.Common.Commands;
using EczaneApp.Wpf.ViewModels.PersonelViewModels;
using EczaneApp.Wpf.Views.PersonelViews;
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
    public class PersonelListViewModel : BaseViewModel
    {
        private PersonelManager manager;
        private ObservableCollection<PersonelViewModel> _Items;
        private PersonelViewModel _SelectedItem;

        public ObservableCollection<PersonelViewModel> Items
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
        public PersonelViewModel SelectedItem
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
        public ICommand SilCommand{ get; set; }
        public ICommand GuncelleCommand { get; set; }

        public PersonelListViewModel()
        {
            manager = new PersonelManager();
            EkleCommand = new RelayCommand(x => { OnEkle(); }, x => { return true; });
            SilCommand = new RelayCommand(x=> { OnSil(x); },x=> { return x != null; });
            GuncelleCommand = new RelayCommand(x => { OnGuncelle(x); }, x => { return x != null; });
            Yenile();
        }

        private void Yenile()
        {
            Items = new ObservableCollection<PersonelViewModel>();
            List<Personel> personeller = manager.Listele();
            foreach (var item in personeller)
            {
                Items.Add(new PersonelViewModel(item));
            }
        }
        private void OnEkle()
        {
            PersonelViewModel p = new PersonelViewModel();
            PersonelWindow pw = new PersonelWindow(p.Personel) { DataContext = p};
            if (pw.ShowDialog() == true)
            {
                manager.Ekle(p.Personel);
                Items.Add(p);
            }
        }
        private void OnSil(object parameter)
        {
            PersonelViewModel p = parameter as PersonelViewModel;
            if (MessageBox.Show(p.Ad+" isimli personeli silmek istediğinizden emin misiniz?","Personel Sil",MessageBoxButton.YesNo,MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                manager.Sil(p.Personel);
                Items.Remove(p);
            }
        }
        private void OnGuncelle(object parameter)
        {
            PersonelViewModel p = parameter as PersonelViewModel;
            PersonelWindow pw = new PersonelWindow(p.Personel) { DataContext = p};
            if (pw.ShowDialog() == true)
            {
                manager.Guncelle(p.Personel);
            }
        }
    }
}
