using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using HomeFormAsynk.XMLData;
using System.Threading.Tasks;
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

    public partial class asynk_Form : Form
    {
        ListInitial listURL = new ListInitial();

        public asynk_Form()
        {
            InitializeComponent();
            listURL.AddManualURL();
        }
        /// <summary>
        /// Метод создания запроса по списку адрксов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void makerequest_button_Click(object sender, EventArgs e)
        {
            foreach (var req in listURL.UrlString)
            {
                bool isrequesting = false;
                new Currency.CurrencyManager().MakeRequest( isrequesting, req);
            } 
        }
        /// <summary>
        /// Метод добавления введенного адреса в список.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addsite_Click(object sender, EventArgs e)
        {
            string url = textBox_inputsite.Text;
            listURL.AddUrl(url);
        }
        /// <summary>
        /// Метод очистки всего списка.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete_list_Click(object sender, EventArgs e)
        {
            if(listURL.Ask()) listView1.Items.Clear();
        }
        /// <summary>
        /// Метод удаления одного элемента списка.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete_one_site_Click(object sender, EventArgs e)
        {
            string url = textBox_inputsite.Text;
            listURL.RemoveUrl(url);
        }
        /// <summary>
        /// Метод инициализации списка в ListView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void initial_site_list_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (var s in listURL.UrlString)
            {
                var l = listURL.Init(new ListViewItem(s.URLname) , s);     
                listView1.Items.Add(l);
            }
        }
        /// <summary>
        /// Метод инициализации спика адресов по умолчанию.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_manual_Click(object sender, EventArgs e)
        {
            listURL.AddManualURL();
        }
    }
}
