using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SocksStore.ViewModel
{
    public class SocksViewModel : INotifyPropertyChanged
    {
        private int socksId;
        private string size;
        private string material;
        private string color;

        public int SocksId
        {
            get { return socksId; }
            set
            {
                socksId = value;
                OnPropertyChanged("SocksId");
            }
        }
        public string Size
        {
            get { return size; }
            set
            {
                size = value;
                OnPropertyChanged("Size");
            }
        }
        public string Color
        {
            get { return color; }
            set
            {
                color = value;
                OnPropertyChanged("Color");
            }
        }
        public string Material
        {
            get { return material; }
            set
            {
                material = value;
                OnPropertyChanged("Material");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
