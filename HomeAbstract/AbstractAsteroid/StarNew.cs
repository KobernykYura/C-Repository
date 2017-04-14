using System;

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
            // pos.X = pos.X + dir.X;
            //if (pos.X < 0) pos.X = Game.Width + size.Width + 10;

            pos.X = pos.X + dir.X;
            if (pos.X > Game.Width || pos.X < 0) pos.X = Game.Width / 2;
            pos.Y = pos.Y + dir.Y;
            if (pos.Y > Game.Height || pos.Y < 0) pos.Y = Game.Height / 2;
        }
        /// <summary>
        /// Переписанный виртуальный метод DrawCrossStar() создания звезды.
        /// </summary>
        public override void DrawCrossStar()
        {
            Game.buffer.Graphics.DrawLine(Pens.White, pos.X, pos.Y, pos.X + size.Width, pos.Y + size.Height);
            Game.buffer.Graphics.DrawLine(Pens.White, pos.X + size.Width, pos.Y, pos.X, pos.Y + size.Height);
        }

        public override void New() { }
    }
}
