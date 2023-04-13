using EczaneApp.BusinnessLayer;
using EczaneApp.EntityLayer;
using EczaneApp.Wpf.Common.Commands;
using EczaneApp.Wpf.ViewModels.IlacViewModels;
using EczaneApp.Wpf.ViewModels.MusteriViewModels;
using EczaneApp.Wpf.ViewModels.PersonelViewModels;
using EczaneApp.Wpf.ViewModels.SatisDetayViewModels;
using EczaneApp.Wpf.ViewModels.SatisViewModels;
using EczaneApp.Wpf.Views.SatisYapViews;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace EczaneApp.Wpf.ViewModels.SatisYapViewModels
{
    public class SatisYapListViewModel : BaseViewModel
    {
        private IlacManager manager;
        private SatisManager satisManager;

        private ObservableCollection<IlacViewModel> _itemsIlac;
        private IlacViewModel _selectedItemIlac;
        private ObservableCollection<SatisDetayViewModel> _itemsDetaylar;
        private SatisDetayViewModel _selectedItemDetay;
        private MusteriViewModel _selectedMusteri;

        public ObservableCollection<IlacViewModel> ItemsIlac
        {
            get { return _itemsIlac; }
            set
            {
                if(_itemsIlac != value)
                {
                    _itemsIlac = value;
                    OnPropertyChanged();
                }
            }
        }
        public IlacViewModel SelectedItemIlac
        {
            get { return _selectedItemIlac; }
            set
            {
                if(_selectedItemIlac != value)
                {
                    _selectedItemIlac = value;
                    OnPropertyChanged();
                }
            }
        }
        public ObservableCollection<SatisDetayViewModel> ItemsDetaylar
        {
            get { return _itemsDetaylar; }
            set
            {
                if(_itemsDetaylar != value)
                {
                    _itemsDetaylar = value;
                    OnPropertyChanged();
                }
            }
        }
        public SatisDetayViewModel SelectedItemDetay
        {
            get { return _selectedItemDetay; }
            set
            {
                if(_selectedItemDetay != value)
                {
                    _selectedItemDetay = value;
                    OnPropertyChanged();
                }
            }
        }
        public MusteriViewModel SelectedMusteri
        {
            get { return _selectedMusteri; }
            set
            {
                if (_selectedMusteri != value)
                {
                    _selectedMusteri = value;
                    OnPropertyChanged();
                }
            }
        }

        private decimal _toplamTutar=0;
        public decimal ToplamTutar
        {
            get { return _toplamTutar; }
            set
            {
                if(_toplamTutar != value)
                {
                    _toplamTutar = value;
                    OnPropertyChanged();
                }
            }
        }

        private ObservableCollection<MusteriViewModel> _musteriler;
        public ObservableCollection<MusteriViewModel> Musteriler
        {
            get { return _musteriler; }
            set
            {
                if (_musteriler != value)
                {
                    _musteriler = value;
                    OnPropertyChanged();
                }
            }
        }

        private Personel _personel;
        public Personel Personel
        {
            get { return _personel; }
            set
            {
                if(_personel != value)
                {
                    _personel = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand SepeteEkle { get; set; }
        public ICommand SepettenCikar { get; set; }
        public ICommand SepetIptal { get; set; }
        public ICommand SepetOnayla { get; set; }

        public SatisYapListViewModel()
        {
            musterileriGetir();
            ItemsDetaylar = new ObservableCollection<SatisDetayViewModel>();
            manager = new IlacManager();
            satisManager = new SatisManager();
            SepeteEkle = new RelayCommand(x => { OnSepeteEkle(x); },x => { return x != null; });
            SepettenCikar = new RelayCommand(x => { OnSepettenCikar(x); }, x => { return x != null; });
            SepetIptal = new RelayCommand(x => { OnSepetIptal(); }, x => { return ItemsDetaylar.Count > 0; });
            SepetOnayla = new RelayCommand(x => { OnSepetOnayla(); }, x => { return ItemsDetaylar.Count > 0 && SelectedMusteri != null; });
            ilaclariGetir();
        }

        private void musterileriGetir()
        {
            Musteriler = new ObservableCollection<MusteriViewModel>();
            using (MusteriManager mm = new MusteriManager())
            {
                List<Musteri> musteriler = mm.Listele();
                foreach (var item in musteriler)
                {
                    Musteriler.Add(new MusteriViewModel(item));
                }
            }
        }

        private void OnSepetOnayla()
        {
            Satis satis = new Satis() { Tarih=DateTime.Now,Tutar=ToplamTutar, PersonelId=Personel.Id,MusteriId=SelectedMusteri.Musteri.Id};
            foreach (var item in ItemsDetaylar)
            {
                SatisDetay detay = new SatisDetay()
                {
                    IlacId = item.IlacId,
                    Adet = item.Adet,
                    AdetFiyat = item.AdetFiyat
                };
                satis.SatisDetaylar.Add(detay);
            }
            satisManager.Ekle(satis);
            ItemsDetaylar.Clear();
            ToplamTutar = 0;
        }

        private void OnSepetIptal()
        {
            foreach (var vm in ItemsDetaylar.ToList())
            {
                IlacViewModel ilac = ItemsIlac.FirstOrDefault(o => o.Ilac == vm.Ilac);
                ilac.Adet+= vm.Adet;
                vm.Adet = 0;
                ItemsDetaylar.Remove(vm);
            }
            ToplamTutar = 0;
        }

        private void ilaclariGetir()
        {
            ItemsIlac = new ObservableCollection<IlacViewModel>();
            List<Ilac> ilaclar = manager.Listele();
            foreach (var item in ilaclar)
            {
                ItemsIlac.Add(new IlacViewModel(item));
            }
        }

        private void OnSepettenCikar(object x)
        {
            SatisDetayViewModel vm = x as SatisDetayViewModel;

            IlacViewModel ilac = ItemsIlac.FirstOrDefault(o => o.Ilac == vm.Ilac);
            vm.Adet--;
            ilac.Adet++;
            ToplamTutar -= ilac.Fiyat;
            if (vm.Adet == 0)
            {
                ItemsDetaylar.Remove(vm);
            }
        }

        private void OnSepeteEkle(object x)
        {
            IlacViewModel vm = x as IlacViewModel;
            if(vm.Adet == 0)
            {
                MessageBox.Show(vm.Ilac.Ad+" adlı ilacın stoğu bitmiş.","Stok Tükendi", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            SatisDetayViewModel detay = ItemsDetaylar.FirstOrDefault(o => o.IlacId == vm.Ilac.Id);
            if(detay == null)
            {
                SatisDetayViewModel item = new SatisDetayViewModel { Ilac = vm.Ilac, IlacId = vm.Ilac.Id, Adet = 1, AdetFiyat = vm.Ilac.Fiyat};
                ItemsDetaylar.Add(item);
            }
            else
            {
                detay.Adet++;
            }
            ToplamTutar += vm.Fiyat;
            vm.Adet--;
        }
    }
}
