using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LinqExtention
{
    internal static class Extentions
    {

        public static IEnumerable<T> SkipWhile<T>(this IEnumerable<T> collection, Predicate<T> condition)
        {
            foreach(T item in collection)
            {
                if(!condition(item))
                    yield return item;
            }
        }

        public static IEnumerable<T> Except<T>(this IEnumerable<T> collection1, IEnumerable<T> collection2)
        {
            bool flag = false;
            foreach(T item1 in collection1)
            {
                foreach(T item2 in collection2)
                {
                    if (item1.Equals(item2))
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                    yield return item1;
                flag = false;
            }

            foreach (T item2 in collection1)
            {
                foreach (T item1 in collection2)
                {
                    if (item2.Equals(item1))
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                    yield return item2;
                flag = false;
            }

        }

        public static T Single<T>(this IEnumerable<T> collection, Predicate<T> condition)
        {
            foreach (T item in collection)
                if (condition(item))
                    return item;

            return default(T);
        }

        public static bool All<T>(this IEnumerable<T> collection, Predicate<T> condition)
        {

            foreach (T item in collection)
                if (!condition(item))
                    return false;

            return true;
        }

        public static bool Any<T>(this IEnumerable<T> collection, Predicate<T> condition)
        {

            foreach (T item in collection)
                if (condition(item))
                    return true;

            return false;
        }

    }
}
