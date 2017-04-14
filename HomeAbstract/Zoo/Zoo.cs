using System;
using System.Collections;
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
    /// Класс Зоопарк, способный перечислять своих животных.
    /// </summary>
    public class Zoo : IEnumerable<AbstractAnimal>
    {
        // Поле список животных.
        private List<AbstractAnimal> _list;

        // Конструктор списка.
        public Zoo()
        {
            _list = new List<AbstractAnimal>();
        }

        //Метод для обращения по индексу
        public AbstractAnimal this[int index]
        {
            get
            {
                if (index >= _list.Count)
                    return null;

                return _list[index];
            }
        }

        /// <summary>
        /// Метод добавления животного.
        /// </summary>
        /// <param name="animal">Добавляемое животное.</param>
        public void Add(AbstractAnimal animal)
        {
            _list.Add(animal);
        }

        /// <summary>
        /// Метод вывода животного.
        /// </summary>
        /// <returns>Возвращает животных по именам.</returns>
        public string GetAnimals()
        {
            return String.Join(", ", _list.Select(x => x.Name));
        }

        /// <summary>
        /// Каждому животному из списка Зоопарка даем еду.
        /// </summary>
        /// <param name="food">Передаваемая еда.</param>
        public void FeedAnimals(AbstractFood food)
        {
            foreach (AbstractAnimal animal in _list)
            {
                animal.Feed(food);
            }
        }

        //При реализации IEnumerable(T), 
        // необходимо реализовать IEnumerable and IEnumerator(T).

        public IEnumerator<AbstractAnimal> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }

}
