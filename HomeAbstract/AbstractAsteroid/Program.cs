using System;

using System.Windows.Forms;

namespace AbstractAsteroid // Коберник-Березовский Юрий
{/* 2. Переделать виртуальный метод Update в BaseObject в абстрактный и реализовать его в
наследниках.
3. Сделать так, чтобы при столкновениях пули с астероидом пуля и астероид регенерировались в
разных концах экрана;
4. Сделать проверку на задание размера экрана в классе Game. Если высота или ширина больше
1000 или принимает отрицательное значение, то выбросить исключение
ArgumentOutOfRangeException().
5. *Создать собственное исключение GameObjectException, которое появляется при попытке
создать объект с неправильными характеристиками (например, отрицательные размеры,
слишком большая скорость или позиция).*/
    using static Console;

    class Program
    {
        
        static void Main(string[] args)
        {
            Form form = new Form();
            form.Width = Execut(1000);        // Ловим ограничение экрана //  Неверный размер! Должен быть 800.
            form.Height = Execut(800);      // Ловим ограничение экрана


            Game.Init(form); // передаем размеры формы
            form.Show();    
            Game.Draw();    // вызов рисования 
            Application.Run(form);
            ReadKey();
        }

        /// <summary>
        /// Проверка ввода значений экрана.
        /// </summary>
        /// <param name="width">Передаваемый параметр.</param>
        /// <returns></returns>
        static int Execut(int width)
        {
            try
            {

                if (width < 600 || width > 1000) throw new MyExсeption();
                return width;
            }
            catch(MyExсeption)
            {
                WriteLine("Придерживайтесь размера от 600 до 1000.");
                ReadKey();
                return 600;
               
            }
        }
    }
}