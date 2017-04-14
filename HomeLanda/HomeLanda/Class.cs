using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HomeLanda
{
    delegate void Del(NewObj obj);
    delegate Int32 DelFact(int obj);
    
    class Class : IQueryable<int>
    {
        public IList<NewObj>List;
        protected string Name;
        protected int Int;

        public Class()
        {
            List = new List<NewObj>();
        }

        public Expression Expression => throw new NotImplementedException();

        public Type ElementType => throw new NotImplementedException();

        public IQueryProvider Provider => throw new NotImplementedException();

        public void Add(NewObj obj)
        {
            List.Add(obj);
        }

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Print(NewObj obj)
        {
            Console.WriteLine("Имя: {0}, Значение: {1}", obj.Name, obj.Int);
        }
        public void Sum(NewObj obj)
        {
            Console.WriteLine("Сумма: {0}", List.Sum(x => x.Int));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
