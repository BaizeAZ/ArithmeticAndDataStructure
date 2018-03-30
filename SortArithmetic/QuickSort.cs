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
            QSort(Qlist, low, high);          
        }

        private void QSort(List<int> list, int low, int high)
        {  
            if (low >= high)
                return;
            int index = SortUnit(Qlist, low, high);
            QSort(Qlist, low, index - 1);
            QSort(Qlist, index + 1, high);
        }
        private int SortUnit(List<int> list, int low, int high)
        {
            int key = Qlist[low];
            while (low < high)
            {
                while (Qlist[high] >= key && high > low)
                    --high;
                Qlist[low] = Qlist[high];
                while (Qlist[low] <= key && high > low)
                    ++low;
                Qlist[high] = Qlist[low];
            }
            Qlist[low] = key;

            return high;
        }
    }

}
