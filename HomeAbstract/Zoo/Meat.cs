using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Meat : AbstractFood
    {
        public Meat(string name) : base(name, FoodType.meat)
        {
        }
    }
}
