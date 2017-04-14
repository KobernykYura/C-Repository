﻿using System;
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

    /// <summary>
    /// Типы еды.
    /// </summary>
    public enum FoodType
    {
        meat = 10,
        bread = 20,
        water =30,
        worms
    }
    /// <summary>
    /// Класс создания еды (название и тип еды)
    /// </summary>
    public abstract class AbstractFood
    {
        // Поля  названия и типа еды
        private string foodName;
        private FoodType foodType;

        /// <summary>
        /// Конструктор создаваемого объекта еда.
        /// </summary>
        /// <param name="name">Имя объекта еда.</param>
        /// <param name="type">Тип объекта еда.</param>
        public AbstractFood(string name, FoodType type)
        {
            this.foodName = name;
            this.foodType = type;
        }
        /// <summary>
        /// Возвращает имя еды.
        /// </summary>
        public string FoodName
        {
            get { return this.foodName; }
        }
        /// <summary>
        /// Возвращает тип еды.
        /// </summary>
        public FoodType FoodType
        {
            get { return this.foodType; }
        }

    }
}
