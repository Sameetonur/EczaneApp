using EczaneApp.EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EczaneApp.Wpf.ViewModels.MusteriViewModels
{
    public class MusteriViewModel : BaseViewModel,IDataErrorInfo
    {
        private Musteri _musteri;
        public Musteri Musteri
        {
            get { return _musteri; }
        }
        public MusteriViewModel() : this(new Musteri()) { }

        public MusteriViewModel(Musteri musteri)
        {
            this._musteri = musteri;
        }

        public int Id
        {
            get { return _musteri.Id; }
            set
            {
                if (_musteri.Id != value)
                {
                    _musteri.Id = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Ad
        {
            get { return _musteri.Ad; }
            set
            {
                if (_musteri.Ad != value)
                {
                    _musteri.Ad = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Soyad
        {
            get { return _musteri.Soyad; }
            set
            {
                if (_musteri.Soyad != value)
                {
                    _musteri.Soyad = value;
                    OnPropertyChanged();
                }
            }
        }
        public string TC
        {
            get { return _musteri.TC; }
            set
            {
                if (_musteri.TC != value)
                {
                    _musteri.TC = value;
                    OnPropertyChanged();
                }
            }
        }
        public DateTime DogumTarih
        {
            get { return _musteri.DogumTarih; }
            set
            {
                if (_musteri.DogumTarih != value)
                {
                    _musteri.DogumTarih = value;
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
                            if (String.IsNullOrWhiteSpace(_musteri.Ad)) msj = "Boş olamaz.";
                            else if (_musteri.Ad.Length < 3 || _musteri.Ad.Length > 15) msj = "En az 3 karakter uzunluğunda olmalı.";
                            break;
                        }
                    case nameof(Soyad):
                        {
                            if (String.IsNullOrWhiteSpace(_musteri.Soyad)) msj = "Boş olamaz.";
                            else if (_musteri.Soyad.Length < 3) msj = "En az 3 karakter uzunluğunda olmalı.";
                            break;
                        }
                    case nameof(TC):
                        {
                            if (String.IsNullOrWhiteSpace(_musteri.TC)) msj = "Boş olamaz.";
                            else if (_musteri.TC.Length < 11) msj = "En az 11 karakter uzunluğunda olmalı.";
                            else if (!Int64.TryParse(_musteri.TC, out long a)) msj = "Sayı girmelisiniz.";
                            break;
                        }
                    case nameof(DogumTarih):
                        {
                            if (_musteri.DogumTarih == default(DateTime)) msj = "Boş olamaz.";
                            else if (_musteri.DogumTarih.Year < 2000) msj = "Geçersiz yıl.";
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
