using SocksStore.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static SocksStore.MVC;

namespace SocksStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMainWindowsCodeBehind
    {
        PageSocks view1;
        public MainWindow()
        {
            view1 = new PageSocks();
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
            DataContext = new ApplicationViewModel();
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //загрузка вьюмодел для кнопок меню
            MenuViewModel vm = new MenuViewModel();
            //даем доступ к этому кодбихайнд
            vm.CodeBehind = this;
            //делаем эту вьюмодел контекстом данных
            this.DataContext = vm;
            //загрузка стартовой View
            LoadView(ViewType.PageSocks);
        }
        public void LoadView(ViewType typeView)
        {
            switch (typeView)
            {
                case ViewType.PageSocks:

                    view1 = new PageSocks();

                    this.OutputView.Content = view1;
                    break;
            }
        }
    }
}
