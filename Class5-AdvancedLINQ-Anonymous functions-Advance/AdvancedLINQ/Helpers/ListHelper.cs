using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedLINQ.Helpers
{
    public static class ListHelper
    {
        public static void Print<T>(this List<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
