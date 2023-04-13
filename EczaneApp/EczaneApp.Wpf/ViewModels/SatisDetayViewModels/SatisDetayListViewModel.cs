using EczaneApp.BusinnessLayer;
using EczaneApp.EntityLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EczaneApp.Wpf.ViewModels.SatisDetayViewModels
{
    public class SatisDetayListViewModel : BaseViewModel
    {
        private SatisDetaylarManager manager;
        private ObservableCollection<SatisDetay> _Items;
        public ObservableCollection<SatisDetay> Items
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

        public SatisDetayListViewModel(List<SatisDetay> detaylar)
        {
            Items = new ObservableCollection<SatisDetay>(detaylar);
            manager = new SatisDetaylarManager();
        }

    }
}
