using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SocksStore.MVC;

namespace SocksStore
{
    class MenuViewModel
    {
        public MenuViewModel()
        {

        }

        public IMainWindowsCodeBehind CodeBehind { get; set; }


        private RelayCommand _LoadPageSocks;
        public RelayCommand LoadPageSocks
        {
            get
            {
                return _LoadPageSocks = _LoadPageSocks ??
                  new RelayCommand(OnLoadPageSocks, CanLoadPageSocks);
            }
        }
        private bool CanLoadPageSocks()
        {
            return true;
        }
        private void OnLoadPageSocks()
        {
            CodeBehind.LoadView(ViewType.PageSocks);
        }



        private RelayCommand _LoadPageMySocks;
        public RelayCommand LoadPageMySocks
        {
            get
            {
                return _LoadPageMySocks = _LoadPageMySocks ??
                  new RelayCommand(OnLoadPageMySocks, CanLoadPageMySocks);
            }
        }
        private bool CanLoadPageMySocks()
        {
            return true;
        }
        private void OnLoadPageMySocks()
        {
            CodeBehind.LoadView(ViewType.PageMySocks);
        }
    }
}
