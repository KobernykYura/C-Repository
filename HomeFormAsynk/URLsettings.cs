using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeFormAsynk  // Коберник-Березовский Юрий
{
    /// <summary>
    /// Класс адреса и его состояния.
    /// </summary>
    public class URLsettings
    {
        public string URLname { get; }
        public string status { get; set; }

        public URLsettings(string url, string stat)
        {
            this.URLname = url;
            this.status = stat;
        }
    }
}
