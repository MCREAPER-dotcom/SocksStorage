using SocksStore.Contexts;
using SocksStore.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SocksStore.ApplicationViewModel
{
    public class MySocksViewModel : INotifyPropertyChanged
    {
        private Sock selectedSock;
        private SocksCompanyDbContext context;
        public ObservableCollection<SocksViewModel> Socks { get; set; }
        public MySocksViewModel()
        {
            context = new SocksCompanyDbContext();
            context.Socks.Load();
            var socksElements = context.Socks.Local.ToBindingList();
            Socks = new ObservableCollection<SocksViewModel>();
            foreach (var item in socksElements)
            {
                Socks.Add(new SocksViewModel() {
                    SocksId = item.SocksId,
                    Size = item.Size,
                    Color = item.Color,
                    Material = item.Material
                }) ;
            }

        }
        public Sock SelectedSock
        {
            get { return selectedSock; }
            set
            {
                selectedSock = value;
                OnPropertyChanged("SelectedSock");
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
