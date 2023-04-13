using EczaneApp.EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EczaneApp.Wpf.ViewModels.SatisViewModels
{
    public class SatisViewModel : BaseViewModel, IDataErrorInfo
    {
        private Satis _satis;
        public Satis Satis
        {
            get { return _satis; }
        }
        public SatisViewModel() : this(new Satis()) { }
        public SatisViewModel(Satis satis)
        {
            this._satis = satis;
        }
        public int Id
        {
            get { return _satis.Id; }
            set
            {
                if (_satis.Id != value)
                {
                    _satis.Id = value;
                    OnPropertyChanged();
                }
            }
        }
        public DateTime Tarih
        {
            get { return _satis.Tarih; }
            set
            {
                if (_satis.Tarih != value)
                {
                    _satis.Tarih = value;
                    OnPropertyChanged();
                }
            }
        }
        public decimal Tutar
        {
            get { return _satis.Tutar; }
            set
            {
                if (_satis.Tutar != value)
                {
                    _satis.Tutar = value;
                    OnPropertyChanged();
                }
            }
        }
        public int MusteriId
        {
            get { return _satis.MusteriId; }
            set
            {
                if (_satis.MusteriId != value)
                {
                    _satis.MusteriId = value;
                    OnPropertyChanged();
                }
            }
        }
        public Musteri Musteri
        {
            get { return _satis.Musteri; }
            set
            {
                if (_satis.Musteri != value)
                {
                    _satis.Musteri = value;
                    OnPropertyChanged();
                }
            }
        }
        public int PersonelId
        {
            get { return _satis.PersonelId; }
            set
            {
                if (_satis.PersonelId != value)
                {
                    _satis.PersonelId = value;
                    OnPropertyChanged();
                }
            }
        }
        public Personel Personel
        {
            get { return _satis.Personel; }
            set
            {
                if (_satis.Personel != value)
                {
                    _satis.Personel = value;
                    OnPropertyChanged();
                }
            }
        }
        public ICollection<SatisDetay> SatisDetaylar
        {
            get { return _satis.SatisDetaylar; }
            set
            {
                if (_satis.SatisDetaylar != value)
                {
                    _satis.SatisDetaylar = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Error { get { return null; } }

        public string this[string columnName] => throw new NotImplementedException();
    }
}
