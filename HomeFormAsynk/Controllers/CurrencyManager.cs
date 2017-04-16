using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HomeFormAsynk.XMLData;
using System.Xml;
using System.Xml.Serialization;

namespace HomeFormAsynk.Currency  // Коберник-Березовский Юрий
{/*Создайте WindowsForms приложение, которое будет, используя многопоточность(асинхронность), выполнять запросы к различным сайтам.
На форме должна быть возможность добавить адрес сайта, к которому будет осуществлен запрос.
Должна присутствовать визуализация уже добавленных адресов в виде списка и возможность очистки всего списка адресов.
На форме должна присутствовать кнопка "Выполнить запросы", при нажатии на которую происходит обработка всех добавленных в список адресов сайтов и рядом с каждым из сайтов выводится либо ошибка (при возникновении), либо размер контента страницы (просто длина загруженной строки)
При желании можете так же выводить время, затраченное на загрузку каждой отдельной страницы и всех страниц.
Для запросов используйте код из класса CurrencyManager.
В нем нужно будет поменять тип контента на text/html и, соотвественно, url будет уже не статический, а будет получается извне (с формы), тип запроса остается GET.
Весь остальной код по обработке xml файла не нужен. Нужно забрать из примера только получение responseString.*/

    public class CurrencyManager
    {
        //private string _url = "http://www.cbr.ru/scripts/XML_daily.asp?date_req={0}";
        private HttpWebRequest _request;

        /// <summary>
        /// Асинхронный метод.
        /// </summary>
        /// <param name="isRequesting"></param>
        /// <param name="_url">Список.</param>
        public async void MakeRequest(bool isRequesting, URLsettings _url)
        {
            isRequesting = true;

            var url = string.Format(_url.URLname, DateTime.Now.ToString("dd.MM.yyyy"));
            _request = WebRequest.CreateHttp(new Uri(url));

            RequestSettings();
            _url.status = await AsynkM();

        }
        /// <summary>
        /// Проверка доступа к адресу.
        /// </summary>
        /// <returns>Результат проверки.</returns>
        private Task<string> AsynkM()
        {
            try
            {
                var response = _request.GetResponse();
                var responseString = string.Empty;

                responseString = ResponseResult(response);
            }
            catch (Exception)
            {
               return Task.Run(()=> "404");
            }
            return Task.Run(() => "Availible");
        }
        /// <summary>
        /// Настройки запроса.
        /// </summary>
        private void RequestSettings()
        {
            _request.Method = "GET";
            _request.KeepAlive = false;
            _request.Timeout = 1000;
            _request.ContentType = "text/html";
        }

        private string ResponseResult(WebResponse _response)
        {
            var response = _response;
            string result = string.Empty;

            using (var stream = response.GetResponseStream())
            using (var sr = new StreamReader(stream))
                result = sr.ReadToEnd();

            return result;
        }
    }
}