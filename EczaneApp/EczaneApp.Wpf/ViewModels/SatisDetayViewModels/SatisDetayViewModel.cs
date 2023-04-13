using EczaneApp.EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EczaneApp.Wpf.ViewModels.SatisDetayViewModels
{
    public class SatisDetayViewModel : BaseViewModel, IDataErrorInfo
    {
        private SatisDetay _satisDetay;
        public SatisDetay SatisDetay
        {
            get { return _satisDetay; }
        }
        public SatisDetayViewModel() : this(new SatisDetay()) { }
        public SatisDetayViewModel(SatisDetay satisDetay)
        {
            this._satisDetay = satisDetay;
        }
        public int Id
        {
            get { return _satisDetay.Id; }
            set
            {
                if (_satisDetay.Id != value)
                {
                    _satisDetay.Id = value;
                    OnPropertyChanged();
                }
            }
        }
        public int Adet
        {
            get { return _satisDetay.Adet; }
            set
            {
                if (_satisDetay.Adet != value)
                {
                    _satisDetay.Adet = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Tutar));
                }
            }
        }
        public decimal AdetFiyat
        {
            get { return _satisDetay.AdetFiyat; }
            set
            {
                if (_satisDetay.AdetFiyat != value)
                {
                    _satisDetay.AdetFiyat = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Tutar));
                }
            }
        }
        public decimal Tutar
        {
            get { return _satisDetay.Tutar; }
        }
        public int IlacId
        {
            get { return _satisDetay.IlacId; }
            set
            {
                if (_satisDetay.IlacId != value)
                {
                    _satisDetay.IlacId = value;
                    OnPropertyChanged();
                }
            }
        } 
        public Ilac Ilac
        {
            get { return _satisDetay.Ilac; }
            set
            {
                if (_satisDetay.Ilac != value)
                {
                    _satisDetay.Ilac = value;
                    OnPropertyChanged();
                }
            }
        } 
        public int SatisId
        {
            get { return _satisDetay.SatisId; }
            set
            {
                if (_satisDetay.SatisId != value)
                {
                    _satisDetay.SatisId = value;
                    OnPropertyChanged();
                }
            }
        }    
        public Satis Satis
        {
            get { return _satisDetay.Satis; }
            set
            {
                if (_satisDetay.Satis != value)
                {
                    _satisDetay.Satis = value;
                    OnPropertyChanged();
                }
            }
        }
        public string this[string columnName] => throw new NotImplementedException();
        public string Error { get { return null; } }
    }
}
