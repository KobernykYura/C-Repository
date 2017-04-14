using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo // Коберник-Березовский Юрий
{
    /* Задание 
В продолжение наших начинаний на уроке, Вам необоходимо развить зоопарк и дополнить его следующими возможностями.
1. Создайте интерфейс IFeedable, который определяет метод Feed и свойство IsHungry типа bool. Метод Feed принимает ссылку на класс AbstractFood. 
2. Реализуйте абстрактный класс AbstractFood, который представляет из себя базовый абстрактный класс еды. Этот класс должен принимать название еды и ее тип в конструкторе.
3. Реализуйте интерфейс IFeedable у животных и изначально установите флаг IsHungry = false; 
4. В классе Zoo небоходимо добавить новый метод FeedAnimals, который принимает ссылку на AbstractFood и обходит всех животных в цикле и если реализован интерфейс IFeedable и животное голодное, то передает ему ссылку на AbstractFood в метод Feed.
Внутри реализации метода feed, необходимо проверять тип еды, который передается животному. Если тип не подходит животному, то оно должно отказываться от еды и оставаться голодным, если еда подходит, то меняется флаг IsHungry на true.
После вывода метода Zoo.FeedAnimals необходимо выводить в консоль информацию о том, какие животные и сколько были накормлены и какие животные и сколько не были, а так же чем пытались накормить конкретное животное.
*/

    using static Console;

    class Snake : AbstractAnimal, Interfaces.IСrawl
    {
        /// <summary>
        /// Конструктор змеи.
        /// </summary>
        /// <param name="name">Имя змея.</param>
        public Snake(string name) : base(name, 0, AnimalType.Coldanimals, false)
        {
        }
        
        public override void Dispose()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Метод анализа предоставленной животному еды.
        /// </summary>
        /// <param name="food">Передаваемая еда.</param>
        public override void Feed(AbstractFood food)
        {
            if (food.FoodType == FoodType.meat || food.FoodType == FoodType.water || food.FoodType == FoodType.worms) { GoodOut(food); }
            else { BadOut(food); }
        }

        /// <summary>
        /// Метод команды "голос"!
        /// </summary>
        /// <returns>Возвращает строку "Sss-ss-ss"</returns>
        public override string Sound()
        {
            return "Sss-ss-ss";
        }

        /// <summary>
        /// Метод интерфейса IСrawl.
        /// </summary>
        /// <returns>Возвращает строку "I can crawl."</returns>
        public string Crawl()
        {
            return "I can crawl.";
        }

    }
}
