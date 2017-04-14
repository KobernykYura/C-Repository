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

    /// <summary>
    /// Типы животных.
    /// </summary>
    public enum AnimalType
    {
        Mammals = 10,
        Birds= 20,
        Coldanimals 
    }

    /// <summary>
    /// Класс животных. (кол-во ног, имена, тип, голоден или нет)
    /// </summary>
    public abstract class AbstractAnimal : IDisposable, Interfaces.IFeedable
    {
        private int legsCount;
        private string animalName;
        private AnimalType animalType;
        private bool IsHungry;

        /// <summary>
        /// Конструктор животного.
        /// </summary>
        /// <param name="name">Его имя.</param>
        /// <param name="legsCount">Кол-во ног.</param>
        /// <param name="animalType">Тип животного.</param>
        /// <param name="IsHungry">Голодный ли он.</param>
        public AbstractAnimal(string name, int legsCount, AnimalType animalType, bool IsHungry)
         {
            animalName = name;
            this.legsCount = legsCount;          
            this.animalType = animalType;
            this.IsHungry = IsHungry;
         }

        /// <summary>
        /// Возвращает имя животного.
        /// </summary>
        public string Name
        {
            get { return this.animalName; }
        }

        /// <summary>
        /// Возвращает тип животного.
        /// </summary>
        public AnimalType Type
        {
            get { return this.animalType; }
        }

        /// <summary>
        /// Возвращает кол-во ног животного.
        /// </summary>
        public int LegsCount
        {
            get { return this.legsCount; }
        }

        /// <summary>
        /// Возвращает голодно ли оно.
        /// </summary>
        public bool isHungry
        {
            get { return this.IsHungry; }
        }

        /// <summary>
        /// Метод вывода благодарности кормешку.
        /// </summary>
        /// <param name="food">Чем кормим.</param>
        public void GoodOut(AbstractFood food)
        {
            WriteLine($"Спасибо за {food.FoodType}! {Name} теперь не голоден.");
        }

        /// <summary>
        /// Вывод отказа есть предоставленную еду.
        /// </summary>
        /// <param name="food">Предоставленная еда.</param>
        public void BadOut(AbstractFood food)
        {
            WriteLine($"{Name} не ест {food.FoodName}!");
        }

        //Заглушка требующая реализации в наследниках
        public abstract string Sound(); // Абстрактный метод команды "голос"!
        public abstract void Dispose();
        public abstract void Feed(AbstractFood food);   // Абстрактный метод кормления
        
    }

}
