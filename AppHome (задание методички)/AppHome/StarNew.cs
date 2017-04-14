using System;

using System.Drawing;


namespace AppHome   // Коберник-Березовский Юрий
{/*
    1.Добавить свои объекты в иерархию объектов, чтобы получился красивый задний фон, похожий
    на полёт в звёздном пространстве.
    2. *Заменить кружочки картинками, используя метод DrawImage.
    3. **Разработать собственный класс Screensaver, аналогичный классу Game.*/

    class StarNew : BaseObject
    {
        /// <summary>
        /// Конструктор звезды.
        /// </summary>
        /// <param name="pos">Позиция объекта.</param>
        /// <param name="dir">Направление.</param>
        /// <param name="size">Размер объекта.</param>
        public StarNew(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
        }
        /// <summary>
        /// Переписанный метод Draw() вывода звезд.
        /// </summary>
        public override void Draw()
        {
            DrawCrossStar();
        }
        /// <summary>
        /// Переписанный виртуальный метод Update() изменения положения звезды.
        /// </summary>
        public override void Update()
        {
            pos.X = pos.X + dir.X;
            if (pos.X < 0) pos.X = Game.Width + size.Width + 10;
        }
        /// <summary>
        /// Переписанный виртуальный метод DrawCrossStar() создания звезды.
        /// </summary>
        public override void DrawCrossStar()
        {
            Game.buffer.Graphics.DrawLine(Pens.White, pos.X, pos.Y, pos.X + size.Width, pos.Y + size.Height);
            Game.buffer.Graphics.DrawLine(Pens.White, pos.X + size.Width, pos.Y, pos.X, pos.Y + size.Height);
        }
    }
}
