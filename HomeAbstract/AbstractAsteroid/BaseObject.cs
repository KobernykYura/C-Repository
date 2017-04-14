using System;

using System.IO;
using System.Drawing;
using AbstractAsteroid.Interface;

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

    abstract class BaseObject : ICollision
    {
        protected Point pos;
        protected Point dir;
        protected Size size;

        /// <summary>
        /// Конструктор звезды.
        /// </summary>
        /// <param name="pos">Позиция объекта.</param>
        /// <param name="dir">Направление.</param>
        /// <param name="size">Размер объекта.</param>
        public BaseObject(Point pos, Point dir, Size size)
        {
            this.pos = pos;
            this.dir = dir;
            this.size = size;
        }
        /// <summary>
        /// Абстрактный метод вывода звезд.
        /// </summary>
        abstract public void Draw();


        /// <summary>
        /// Абстрактный метод изменения положения.
        /// </summary>
        abstract public void Update();
    
        /// <summary>
        /// Виртуальный метод создания звезд.
        /// </summary>
        virtual public void DrawCrossStar()
        {
            Game.buffer.Graphics.DrawLine(Pens.White, pos.X, pos.Y, pos.X + size.Width, pos.Y + size.Height);
            Game.buffer.Graphics.DrawLine(Pens.White, pos.X + size.Width , pos.Y, pos.X, pos.Y + size.Height);
        }

        /// <summary>
        /// Абстрактный метод регенерации при столкновении.
        /// </summary>
        abstract public void New();

        public bool Collision(ICollision o)
        {
            if (o.Rect.IntersectsWith(this.Rect)) return true; else return false;
        }
        public Rectangle Rect
        {
            get { return new Rectangle(pos, size); }
        }
    }
}
