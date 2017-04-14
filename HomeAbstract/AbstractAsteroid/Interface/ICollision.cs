using System;

using System.IO;
using System.Drawing;


namespace AbstractAsteroid.Interface
{
    interface ICollision
    {
        bool Collision(ICollision obj);
        Rectangle Rect { get; }
    }
}
