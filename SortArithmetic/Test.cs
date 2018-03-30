using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArithmetic
{
    class Test
    {
        //public static Test Instance;
        //public Action<int, int> add = null;
        //public Test()
        //{
        //    add = Sum;
        //}

        //private void Sum(int a,int b)
        //{
        //    Console.WriteLine(a + b);
        //}

        private ISortStrategy sort;

        public void GetSortStrategy(ISortStrategy _sort)
        {
            sort = _sort;
        }

        public void DoSort()
        {
            sort.Sort();
        }
    }

}
