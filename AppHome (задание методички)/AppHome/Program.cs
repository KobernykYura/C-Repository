using System;

using System.Windows.Forms;

namespace AppHome // Коберник-Березовский Юрий
{/*
    1.Добавить свои объекты в иерархию объектов, чтобы получился красивый задний фон, похожий
    на полёт в звёздном пространстве.
    2. *Заменить кружочки картинками, используя метод DrawImage.
    3. **Разработать собственный класс Screensaver, аналогичный классу Game.*/

    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            form.Width = 800;
            form.Height = 600;
            Game.Init(form); // передаем размеры формы
            form.Show();    
            Game.Draw();    // вызов рисования 
            Application.Run(form);
            Console.ReadKey();
        }
        
    }
}