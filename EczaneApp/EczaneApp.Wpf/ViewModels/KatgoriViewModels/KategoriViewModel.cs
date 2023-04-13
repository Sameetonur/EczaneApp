using EczaneApp.EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EczaneApp.Wpf.ViewModels.KatgoriViewModels
{
    public class KategoriViewModel: BaseViewModel, IDataErrorInfo
    {
        private Kategori _kategori;
        public Kategori Kategori
        {
            get { return _kategori; }
        }
        public KategoriViewModel() : this(new Kategori()) { }

        public KategoriViewModel(Kategori kategori)
        {
            this._kategori = kategori;
        }
        public int Id
        {
            get { return _kategori.Id; }
            set
            {
                if (_kategori.Id != value)
                {
                    _kategori.Id = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Ad
        {
            get { return _kategori.Ad; }
            set
            {
                if (_kategori.Ad != value)
                {
                    _kategori.Ad = value;
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
                            if (String.IsNullOrWhiteSpace(_kategori.Ad)) msj = "Boş olamaz.";
                            else if (_kategori.Ad.Length < 3 || _kategori.Ad.Length > 15) msj = "En az 3 karakter uzunluğunda olmalı.";
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
