using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArithmetic
{
    

    class QuickSort : ISortStrategy
    {
        private int low;
        private int high;
        
        private List<int> Qlist;

        public QuickSort(List<int> list,int _low,int _high)
        {
            low = _low;
            high = _high;
            Qlist = list;
        }

        public void Sort()
        {
            QSort(low, high);          
        }

        private void QSort(int low, int high)
        {  
            if (low >= high)
                return;
            int index = SortUnit1(low, high);
            QSort(low, index - 1);
            QSort(index + 1, high);
        }
        private int SortUnit(int low, int high)
        {
            int key = Qlist[low];
            while (low < high)
            {
                foreach (var item in Qlist)
                {
                    Console.Write("\t{0}", item);
                }
                Console.WriteLine();
                while (Qlist[high] >= key && high > low)
                    --high;
                int temp = Qlist[low];
                Qlist[low] = Qlist[high];
                Console.WriteLine("[{0}]:{1} -> [{2}]:{3}", high, Qlist[high], low, temp);
                while (Qlist[low] <= key && high > low)
                    ++low;
                int temp1 = Qlist[high];
                Qlist[high] = Qlist[low];
                Console.WriteLine("[{0}]:{1} -> [{2}]:{3}", low, Qlist[low], high, temp1);

                foreach (var item in Qlist)
                {
                    Console.Write("\t{0}", item);                    
                }
                Console.WriteLine();
            }
            Qlist[low] = key;

            return high;
        }
        private int SortUnit1(int low, int high)
        {
            int i, j, temp;
            temp = Qlist[low];
            i = low;
            j = high;
            while (i!=j)
            {
                while (Qlist[j]>=temp&&i<j)
                {
                    j--;
                }
                while (Qlist[i]<=temp&&i<j)
                {
                    i++;
                }
                if (i<j)
                {
                    Exchange(i, j);
                }
                
            }
            Qlist[low] = Qlist[i];
            Qlist[i] = temp;

            return i;
        }
        private void Exchange(int a,int b)
        {
            int temp = Qlist[a];
            Qlist[a] = Qlist[b];
            Qlist[b] = temp;
        }

    }

}
