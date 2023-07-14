using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WPF_Research_Practise.Models;
using static WPF_Research_Practise.Commands.JsonHandling;

namespace WPF_Research_Practise.ViewModels {
    public class GaleryPageViewModel : INotifyPropertyChanged {

        private List<Galery> _Galery = paths;
        public List<Galery> Galery { get => _Galery;
            set {
                _Galery = value;
                PrpertyChanged();
            } 
        }

        public GaleryPageViewModel() {
            
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void PrpertyChanged([CallerMemberName] string? name = null) {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
