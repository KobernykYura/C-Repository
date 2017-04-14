using System;

using System.IO;
using System.Drawing;

namespace AbstractAsteroid  // Коберник-Березовский Юрий 
{/*
    5. *Создать собственное исключение GameObjectException, которое появляется при попытке
создать объект с неправильными характеристиками (например, отрицательные размеры,
слишком большая скорость или позиция).*/
    using static Console;
    class MyExсeption : Exception
    {
        /// <summary>
        /// Информация об ошибке.
        /// </summary>
        public MyExсeption()
        {
            WriteLine("Сработало мое исключение!");
            WriteLine("Неверные размеры объекта. Задаю значения по умолчанию.");
            ReadKey();
        }
    }
}
