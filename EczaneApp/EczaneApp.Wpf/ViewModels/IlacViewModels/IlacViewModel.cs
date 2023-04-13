using EczaneApp.BusinnessLayer;
using EczaneApp.EntityLayer;
using EczaneApp.Wpf.ViewModels.KatgoriViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EczaneApp.Wpf.ViewModels.IlacViewModels
{
    public class IlacViewModel : BaseViewModel, IDataErrorInfo
    {
        private Ilac _ilac;
        public Ilac Ilac
        {
            get { return _ilac; }
        }
        public IlacViewModel() : this(new Ilac()) { }
        public IlacViewModel(Ilac ilac)
        {
            this._ilac = ilac;
            this._kategori = new KategoriViewModel(ilac.Kategori);
            using (KategoriManager pm = new KategoriManager())
                this._kategoriler = new ObservableCollection<Kategori>(pm.Listele());
        }
        public int Id
        {
            get { return _ilac.Id; }
            set
            {
                if (_ilac.Id != value)
                {
                    _ilac.Id = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Ad
        {
            get { return _ilac.Ad; }
            set
            {
                if (_ilac.Ad != value)
                {
                    _ilac.Ad = value;
                    OnPropertyChanged();
                }
            }
        }
        public DateTime SKT
        {
            get { return _ilac.SKT; }
            set
            {
                if (_ilac.SKT != value)
                {
                    _ilac.SKT = value;
                    OnPropertyChanged();
                }
            }
        }
        public decimal Fiyat
        {
            get { return _ilac.Fiyat; }
            set
            {
                if (_ilac.Fiyat != value)
                {
                    _ilac.Fiyat = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Aciklama
        {
            get { return _ilac.Aciklama; }
            set
            {
                if (_ilac.Aciklama != value)
                {
                    _ilac.Aciklama = value;
                    OnPropertyChanged();
                }
            }
        }
        public int Adet
        {
            get { return _ilac.Adet; }
            set
            {
                if (_ilac.Adet != value)
                {
                    _ilac.Adet = value;
                    OnPropertyChanged();
                }
            }
        }
        public int KategoriId
        {
            get { return _ilac.KategoriId; }
            set
            {
                if (_ilac.KategoriId != value)
                {
                    _ilac.KategoriId = value;
                    Kategori = new KategoriViewModel(Kategoriler.First(x => x.Id == _ilac.KategoriId));
                    OnPropertyChanged();
                }
            }
        }
        public KategoriViewModel _kategori;
        public KategoriViewModel Kategori
        {
            get { return _kategori; }
            set
            {
                if (_kategori != value)
                {
                    _kategori = value;
                    OnPropertyChanged();
                }
            }
        }
        private ObservableCollection<Kategori> _kategoriler;
        public ObservableCollection<Kategori> Kategoriler
        {
            get { return _kategoriler; }
            set
            {
                if (_kategoriler != value)
                {
                    _kategoriler = value;
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
                            if (String.IsNullOrWhiteSpace(_ilac.Ad)) msj = "Boş olamaz.";
                            else if (_ilac.Ad.Length < 3) msj = "En az 3 karakter uzunluğunda olmalı.";
                            break;
                        }
                    case nameof(Aciklama):
                        {
                            if (String.IsNullOrWhiteSpace(_ilac.Aciklama)) msj = "Boş olamaz.";
                            break;
                        }
                    case nameof(Fiyat):
                        {
                            if (String.IsNullOrWhiteSpace(_ilac.Fiyat.ToString())) msj = "Boş olamaz.";
                            else if (!decimal.TryParse(_ilac.Fiyat.ToString(), out decimal a)) msj = "Sayı girmelisiniz.";
                            break;
                        }
                    case nameof(Adet):
                        {
                            if (String.IsNullOrWhiteSpace(_ilac.Adet.ToString())) msj = "Boş olamaz.";
                            else if (!Int32.TryParse(_ilac.Adet.ToString(), out int a)) msj = "Sayı girmelisiniz.";
                            break;
                        }
                    case nameof(SKT):
                        {
                            if (_ilac.SKT == default(DateTime)) msj = "Boş olamaz.";
                            else if (_ilac.SKT.Year < 2000) msj = "Geçersiz yıl.";
                            break;
                        }
                    case nameof(KategoriId):
                        {
                            if (_ilac.KategoriId == 0) msj = "Boş olamaz.";
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
