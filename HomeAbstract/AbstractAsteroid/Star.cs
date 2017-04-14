using System;

using System.IO;
using System.Drawing;

namespace AbstractAsteroid   // Коберник-Березовский Юрий
{/*
     2. Переделать виртуальный метод Update в BaseObject в абстрактный и реализовать его в
наследниках.
3. Сделать так, чтобы при столкновениях пули с астероидом пуля и астероид регенерировались в
разных концах экрана;
4. Сделать проверку на задание размера экрана в классе Game. Если высота или ширина больше
1000 или принимает отрицательное значение, то выбросить исключение
ArgumentOutOfRangeException().
5. *Создать собственное исключение GameObjectException, которое появляется при попытке
создать объект с неправильными характеристиками (например, отрицательные размеры,
слишком большая скорость или позиция).*/

    class Star : BaseObject
    {
        /// <summary>
        /// Конструктор звезды.
        /// </summary>
        /// <param name="pos">Позиция объекта.</param>
        /// <param name="dir">Направление.</param>
        /// <param name="size">Размер объекта.</param>
        public Star(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
        }
        /// <summary>
        /// Переписанный виртуальный метод Update() изменения положения звезды.
        /// </summary>
        public override void Draw()
        {
            string path = Path.GetFullPath("StarNew.png");    // Путь к файлу

            Image newImage = Image.FromFile(path);
            Game.buffer.Graphics.DrawImage(newImage, pos.X, pos.Y, size.Width * 3, size.Height * 3);
        }

        /// <summary>
        /// Задание начальных координат при столкновении(регенерация)
        /// </summary>
        public override void New() { }

        /// <summary>
        /// Переписанный виртуальный метод DrawCrossStar() создания звезды.
        /// </summary>
        public override void Update()
        {
            pos.X = pos.X + dir.X;
            if (pos.X > Game.Width || pos.X < 0) pos.X = Game.Width/2;
            pos.Y = pos.Y + dir.Y;
            if (pos.Y > Game.Height || pos.Y < 0) pos.Y = Game.Height/2;
        }
    }
}
