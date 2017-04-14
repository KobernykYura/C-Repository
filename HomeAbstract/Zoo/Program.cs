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
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Goofy");
            Cow cow = new Cow("Maggie");
            Duck duck = new Duck("McQuack");
            Elefant elefant = new Elefant("Dambo");
            Snake snake = new Snake("Kaa");

            // Животные выполняют действия.
            WriteLine(dog.Sound());
            WriteLine(dog.Sniff());
            WriteLine(cow.Sound());
            WriteLine(duck.Sound());
            WriteLine(duck.Fly());
            WriteLine(snake.Sound());
            WriteLine(elefant.Sound());
            WriteLine(elefant.Run());
            
            Interfaces.ISniff dogsniff = new Dog("Goofy");
            dogsniff.Sniff();

            FeedMethod(snake, cow, dog, elefant, duck); // Переход в метод кормления.

            ReadKey();
        }
        /// <summary>
        /// Метод кормления зверей зоопарка.
        /// </summary>
        /// <param name="snake">Животное.</param>
        /// <param name="cow">Животное.</param>
        /// <param name="dog">Животное.</param>
        /// <param name="elefant">Животное.</param>
        /// <param name="duck">Животное.</param>
        protected static void FeedMethod(AbstractAnimal snake, AbstractAnimal cow, AbstractAnimal dog, AbstractAnimal elefant, AbstractAnimal duck)
        {
            Zoo zoo = new Zoo();
            // Добавляем животных в зоопарк.
            zoo.Add(snake);
            zoo.Add(cow);
            zoo.Add(dog);
            zoo.Add(elefant);
            zoo.Add(duck);

            WriteLine(zoo.GetAnimals());
            Write("\n");

            // Создаем еду.
            Worms worm = new Worms("Червяк");
            Meat meat = new Meat("Мясо");
            Water water = new Water("Вода");
            Bread bread = new Bread("Хлеб");
            
            //Кормим животных всеми видами еды.
            zoo.FeedAnimals(worm);
            Write("\n");
            zoo.FeedAnimals(meat);
            Write("\n");
            zoo.FeedAnimals(water);
            Write("\n");
            zoo.FeedAnimals(bread);


            ReadKey();
        }
    }
}
