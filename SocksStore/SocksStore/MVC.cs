using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocksStore
{
    class MVC
    {
        public interface IMainWindowsCodeBehind
        {

            /// <summary>
            /// Загрузка нужной View
            /// </summary>
            /// <param name="view">экземпляр UserControl</param>
            void LoadView(ViewType typeView);
        }
    }
}
