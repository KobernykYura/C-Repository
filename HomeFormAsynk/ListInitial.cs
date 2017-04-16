using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeFormAsynk.XMLData;
using System.Windows.Forms;

namespace HomeFormAsynk  // Коберник-Березовский Юрий
{/*Создайте WindowsForms приложение, которое будет, используя многопоточность(асинхронность), выполнять запросы к различным сайтам.
На форме должна быть возможность добавить адрес сайта, к которому будет осуществлен запрос.
Должна присутствовать визуализация уже добавленных адресов в виде списка и возможность очистки всего списка адресов.
На форме должна присутствовать кнопка "Выполнить запросы", при нажатии на которую происходит обработка всех добавленных в список адресов сайтов и рядом с каждым из сайтов выводится либо ошибка (при возникновении), либо размер контента страницы (просто длина загруженной строки)
При желании можете так же выводить время, затраченное на загрузку каждой отдельной страницы и всех страниц.
Для запросов используйте код из класса CurrencyManager.
В нем нужно будет поменять тип контента на text/html и, соотвественно, url будет уже не статический, а будет получается извне (с формы), тип запроса остается GET.
Весь остальной код по обработке xml файла не нужен. Нужно забрать из примера только получение responseString.*/

    

    class ListInitial : Form
    {
        public List<URLsettings> UrlString;
        /// <summary>
        /// Конструктор.
        /// </summary>
        public ListInitial()
        {
            this.UrlString = new List<URLsettings>();
        }
        /// <summary>
        /// Добавление непроверенного адреса в список.
        /// </summary>
        /// <param name="url"></param>
        public void AddUrl(string url)
        {
            UrlString.Add(new URLsettings(url: url, stat:"N/A"));
        }
        /// <summary>
        /// Удаление элемента списка.
        /// </summary>
        /// <param name="url"></param>
        public void RemoveUrl(string url)
        {
            int i = 0;
            foreach (var item in UrlString)
            {
                if (item.URLname == url) i = UrlString.IndexOf(item);
            }
            UrlString.RemoveAt(i);
            UrlString.TrimExcess();
        }
        /// <summary>
        /// Метод удаления всех элементов списка.
        /// </summary>
        public void RemoveUrlAll()
        {
            UrlString.Clear();
            UrlString.TrimExcess();
        }
        /// <summary>
        /// Метод добавления адреса.
        /// </summary>
        /// <param name="l"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public ListViewItem Init(ListViewItem l, URLsettings s)
        {
            l.SubItems.Add(s.status);
            return l;
        }
        /// <summary>
        /// Метод добавления адресов по умолчанию.
        /// </summary>
        public void AddManualURL ()
        {
            UrlString.Add(new URLsettings(url:"http://www.webservicex.net/врапрвапнкененвапр.asmx", stat:"N/A"));
            UrlString.Add(new URLsettings(url: "http://www.webservicex.net/globalweather.asmx", stat: "N/A"));
            UrlString.Add(new URLsettings(url: "http://www.cbr.ru/DailyInfoWebServ/DailyInfo.asmx", stat: "N/A"));
            UrlString.Add(new URLsettings(url: "http://www.cbr.ru/DailyInfoWebServ/adfsdfsdfserrrrrwrwerwr", stat: "N/A"));
            UrlString.Add(new URLsettings(url: "http://www.cbr.ru/DailyInfoWebServ/DailyInfo.asmx?op=SwapInfoSellUSDXML", stat: "N/A"));
            UrlString.Add(new URLsettings(url: "http://www.cbr.ru/DailyInfoWebServ/DailyInfo.asmx?op=XVol", stat: "N/A"));
            UrlString.Add(new URLsettings(url: "http://www.cbr.ru/scripts/XML_daily.asp?date_req={0}", stat: "N/A"));
        }
        /// <summary>
        /// Вывод диалогового окна полной очистки списка.
        /// </summary>
        /// <returns></returns>
        public bool Ask()
        {
            DialogResult idres = MessageBox.Show("Make List enpty. Are sure?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            if (idres == DialogResult.Yes) { RemoveUrlAll(); return true; }
            else return false;
                
        }
    }
}
