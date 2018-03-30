using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArithmetic
{
    class SelectionSort : ISortStrategy
    {
        private List<int> sList;

        public SelectionSort(List<int> list)
        {
            sList = list;
        }

        public void Sort()
        {
            for (int i = 1; i < sList.Count; i++)
            {
                int minIdx = i - 1;

                for (int j = i; j < sList.Count; j++)
                {
                    if (sList[minIdx] > sList[j])
                    {
                        minIdx = j;
                    }
                }

                if (minIdx != i - 1)
                {
                    int temp = sList[minIdx];
                    sList[minIdx] = sList[i - 1];
                    sList[i - 1] = temp;
                }

            }
        }

        
    }
}
