using System;

using System.IO;
using System.Drawing;

namespace AppHome   // Коберник-Березовский Юрий
{/*
    1.Добавить свои объекты в иерархию объектов, чтобы получился красивый задний фон, похожий
    на полёт в звёздном пространстве.
    2. *Заменить кружочки картинками, используя метод DrawImage.
    3. **Разработать собственный класс Screensaver, аналогичный классу Game.*/

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
        /// Переписанный виртуальный метод DrawCrossStar() создания звезды.
        /// </summary>
        public override void Update()
        {
            pos.X = pos.X + dir.X;
            if (pos.X < 0) pos.X = Game.Width + size.Width + 20;
        }
    }
}
