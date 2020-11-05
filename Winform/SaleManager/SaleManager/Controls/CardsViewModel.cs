using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Controls
{
    public class CardsViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<CardViewModel> Cards { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void Notify([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public CardsViewModel(ObservableCollection<CardViewModel> cards)
        {
            Cards = cards;
        }
    }
}
