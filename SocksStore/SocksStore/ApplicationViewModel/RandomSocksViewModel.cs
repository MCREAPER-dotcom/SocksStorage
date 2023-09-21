using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SocksStore.ApplicationViewModel
{
    public class RandomSocksViewModel : INotifyPropertyChanged
    {
        private Random random;
        private Sock selectedSock;
        public ObservableCollection<Sock> Socks { get; set; }
        public RandomSocksViewModel()
        {
            random= new Random();
            Socks = new ObservableCollection<Sock>
            {
                new Sock {  Company= Convert.ToString((CompanySocks)random.Next(0,7)), Price=random.Next(100,1000),
                    Color=Convert.ToString((ColorSocks)random.Next(0,5)), Material=Convert.ToString((MaterialSocks)random.Next(0,5)), Size=$"{random.Next(36,45)}"},
                new Sock {  Company=Convert.ToString((CompanySocks)random.Next(0,7)), Price =random.Next(100,1000), 
                    Color=Convert.ToString((ColorSocks)random.Next(0,5)), Material=Convert.ToString((MaterialSocks)random.Next(0,5)), Size=$"{random.Next(36,45)}" },
                new Sock {  Company=Convert.ToString((CompanySocks)random.Next(0,7)), Price=random.Next(100,1000), 
                    Color=Convert.ToString((ColorSocks)random.Next(0,5)), Material=Convert.ToString((MaterialSocks)random.Next(0,5)), Size=$"{random.Next(36,45)}" },
                new Sock {  Company=Convert.ToString((CompanySocks)random.Next(0,7)), Price=random.Next(100,1000), 
                    Color=Convert.ToString((ColorSocks)random.Next(0,5)), Material=Convert.ToString((MaterialSocks)random.Next(0,5)), Size=$"{random.Next(36,45)}" }
            };
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
