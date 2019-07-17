using System;
using System.Linq.Expressions;

namespace Tropical
{
    class GenericOperation<T>
    {
        public GenericOperation()
        {
            var p1 = Expression.Parameter(typeof(T));
            var p2 = Expression.Parameter(typeof(T));

            Add = Expression.Lambda<Func<T, T, T>>(Expression.Add(p1, p2), p1, p2).Compile();
            Multiply = Expression.Lambda<Func<T, T, T>>(Expression.Multiply(p1, p2), p1, p2).Compile();
        }

        public Func<T, T, T> Add { get; private set; }

        public Func<T, T, T> Multiply { get; private set; }
    }
}
