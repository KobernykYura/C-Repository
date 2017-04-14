using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLanda
{
    using static Console;
    delegate void DelegateEvent();

    class EventClass
    {
        public event DelegateEvent Event;

        public void GoEvent()
        {
            if (Event != null) Event();
        }
}}
