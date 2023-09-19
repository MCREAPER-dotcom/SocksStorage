using DataBaseExt;
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

namespace SocksStore.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageSocks.xaml
    /// </summary>
    public partial class PageSocks : System.Windows.Controls.Page
    {
        public PageSocks()
        {
            InitializeComponent();
            using (SocksCompanyContext db = new SocksCompanyContext())
            {
                // получаем объекты из бд и выводим на консоль
                var socks = db.Socks.ToList();
                var company = db.Company.ToList();
                MessageBox.Show(socks[0].ToString());
            }
            DataContext = new ApplicationViewModel();
        }
    }
}
