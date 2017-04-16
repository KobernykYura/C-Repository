using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeFormAsynk.XMLData
{/*Создайте WindowsForms приложение, которое будет, используя многопоточность(асинхронность), выполнять запросы к различным сайтам.
На форме должна быть возможность добавить адрес сайта, к которому будет осуществлен запрос.
Должна присутствовать визуализация уже добавленных адресов в виде списка и возможность очистки всего списка адресов.
На форме должна присутствовать кнопка "Выполнить запросы", при нажатии на которую происходит обработка всех добавленных в список адресов сайтов и рядом с каждым из сайтов выводится либо ошибка (при возникновении), либо размер контента страницы (просто длина загруженной строки)
При желании можете так же выводить время, затраченное на загрузку каждой отдельной страницы и всех страниц.
Для запросов используйте код из класса CurrencyManager.
В нем нужно будет поменять тип контента на text/html и, соотвественно, url будет уже не статический, а будет получается извне (с формы), тип запроса остается GET.
Весь остальной код по обработке xml файла не нужен. Нужно забрать из примера только получение responseString.*/

    public class Valute
    {
        [XmlAttribute("ID")]
        public string Id { get; set; }

        [XmlElement("NumCode")]
        public string NumCode { get; set; }

        public int NumCodeSurrogate
        {
            get { return int.Parse(NumCode); }
            set { NumCode = value.ToString(); }
        }

        [XmlElement("CharCode")]
        public string CharCode { get; set; }

        [XmlElement("Nominal")]
        public string Nominal { get; set; }

        public int NominalSurrogate
        {
            get { return int.Parse(Nominal); }
            set { Nominal = value.ToString(); }
        }

        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Value")]
        public string Value { get; set; }

        public double ValueSurrogate
        {
            get { return double.Parse(Value); }
            set { Value = value.ToString(); }
        }
    }
}