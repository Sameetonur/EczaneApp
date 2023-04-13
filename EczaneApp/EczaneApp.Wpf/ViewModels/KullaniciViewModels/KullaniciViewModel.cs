using EczaneApp.BusinnessLayer;
using EczaneApp.EntityLayer;
using EczaneApp.Wpf.ViewModels.PersonelViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EczaneApp.Wpf.ViewModels.KullaniciViewModels
{
    public class KullaniciViewModel : BaseViewModel, IDataErrorInfo
    {
        private Kullanici _kullanici;
        public Kullanici Kullanici
        {
            get { return _kullanici; }
        }
        public KullaniciViewModel() : this(new Kullanici()) { }

        public KullaniciViewModel(Kullanici kullanici)
        {
            this._kullanici = kullanici;
            this._personel = new PersonelViewModel(kullanici.Personel);
            using (PersonelManager pm = new PersonelManager())
                this._personeller = new ObservableCollection<Personel>(pm.Listele());
        }
        public int Id
        {
            get { return _kullanici.Id; }
            set
            {
                if (_kullanici.Id != value)
                {
                    _kullanici.Id = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Ad
        {
            get { return _kullanici.Ad; }
            set
            {
                if (_kullanici.Ad != value)
                {
                    _kullanici.Ad = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Sifre
        {
            get { return _kullanici.Sifre; }
            set
            {
                if (_kullanici.Sifre != value)
                {
                    _kullanici.Sifre = value;
                    OnPropertyChanged();
                }
            }
        }
        public DateTime sonGirisT
        {
            get { return _kullanici.sonGirisT; }
            set
            {
                if (_kullanici.sonGirisT != value)
                {
                    _kullanici.sonGirisT = value;
                    OnPropertyChanged();
                }
            }
        }
        public int PersonelId
        {
            get { return _kullanici.PersonelId; }
            set
            {
                if (_kullanici.PersonelId != value)
                {
                    _kullanici.PersonelId = value;
                    Personel = new PersonelViewModel(Personeller.First(x => x.Id == _kullanici.PersonelId));
                    OnPropertyChanged();
                }
            }
        }
        private PersonelViewModel _personel;
        public PersonelViewModel Personel
        {
            get { return _personel; }
            set
            {
                if (_personel != value)
                {
                    _personel = value;
                    OnPropertyChanged();
                }
            }
        }
        public Yetkiler Yetki
        {
            get { return _kullanici.Yetki; }
            set
            {
                if (_kullanici.Yetki != value)
                {
                    _kullanici.Yetki = value;
                    OnPropertyChanged();
                }
            }
        }

        private ObservableCollection<Personel> _personeller;
        public ObservableCollection<Personel> Personeller
        {
            get { return _personeller; }
            set
            {
                if(_personeller != value)
                {
                    _personeller = value;
                    OnPropertyChanged();
                }
            }
        }
        public Dictionary<string, string> Hatalar { get; set; } = new Dictionary<string, string>();
        public string this[string columnName]
        {
            get
            {
                string msj = null;
                switch (columnName)
                {
                    case nameof(Ad):
                        {
                            if (String.IsNullOrWhiteSpace(_kullanici.Ad)) msj = "Boş olamaz.";
                            else if (_kullanici.Ad.Length < 3) msj = "En az 3 karakter uzunluğunda olmalı.";
                            break;
                        }
                    case nameof(Sifre):
                        {
                            if (String.IsNullOrWhiteSpace(_kullanici.Sifre)) msj = "Boş olamaz.";
                            else if (_kullanici.Sifre.Length < 8) msj = "En az 8 karakter uzunluğunda olmalı.";
                            break;
                        }
                    case nameof(sonGirisT):
                        {
                            if (_kullanici.sonGirisT == default(DateTime)) msj = "Boş olamaz.";
                            else if (_kullanici.sonGirisT.Year < 2000) msj = "Geçersiz yıl.";
                            break;
                        }
                    case nameof(PersonelId):
                        {
                            if (_kullanici.PersonelId == 0) msj = "Boş olamaz.";
                            break;
                        }
                    default:
                        break;
                }

                if (Hatalar.ContainsKey(columnName))
                    Hatalar[columnName] = msj;
                else Hatalar.Add(columnName, msj);
                OnPropertyChanged(nameof(Hatalar));

                return msj;
            }
        }
        public string Error { get { return null; } }
    }
}
