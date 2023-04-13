using EczaneApp.EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EczaneApp.Wpf.ViewModels.PersonelViewModels
{
    public class PersonelViewModel : BaseViewModel, IDataErrorInfo
    {
        private Personel _personel;
        public Personel Personel
        {
            get { return _personel; }
        }
        public PersonelViewModel() : this(new Personel()) { }

        public PersonelViewModel(Personel personel)
        {
            this._personel = personel;
        }

        public int Id
        {
            get { return _personel.Id; }
            set
            {
                if (_personel.Id != value)
                {
                    _personel.Id = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Ad
        {
            get { return _personel.Ad; }
            set
            {
                if (_personel.Ad != value)
                {
                    _personel.Ad = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Soyad
        {
            get { return _personel.Soyad; }
            set
            {
                if (_personel.Soyad != value)
                {
                    _personel.Soyad = value;
                    OnPropertyChanged();
                }
            }
        }
        public string TC
        {
            get { return _personel.TC; }
            set
            {
                if (_personel.TC != value)
                {
                    _personel.TC = value;
                    OnPropertyChanged();
                }
            }
        }
        public DateTime DogumTarih
        {
            get { return _personel.DogumTarih; }
            set
            {
                if (_personel.DogumTarih != value)
                {
                    _personel.DogumTarih = value;
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
                            if (String.IsNullOrWhiteSpace(_personel.Ad)) msj = "Boş olamaz.";
                            else if (_personel.Ad.Length < 3 || _personel.Ad.Length > 15) msj = "En az 3 karakter uzunluğunda olmalı.";
                            break;
                        }
                    case nameof(Soyad):
                        {
                            if (String.IsNullOrWhiteSpace(_personel.Soyad)) msj = "Boş olamaz.";
                            else if (_personel.Soyad.Length < 3) msj = "En az 3 karakter uzunluğunda olmalı.";
                            break;
                        }
                    case nameof(TC):
                        {
                            if (String.IsNullOrWhiteSpace(_personel.TC)) msj = "Boş olamaz.";
                            else if (_personel.TC.Length < 11) msj = "En az 11 karakter uzunluğunda olmalı.";
                            else if (!Int64.TryParse(_personel.TC, out long a)) msj = "Sayı girmelisiniz.";
                            break;
                        }
                    case nameof(DogumTarih):
                        {
                            if (_personel.DogumTarih == default(DateTime)) msj = "Boş olamaz.";
                            else if (_personel.DogumTarih.Year < 2000) msj = "Geçersiz yıl.";
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
