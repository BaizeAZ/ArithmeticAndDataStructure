using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArithmetic
{
    class BubbleSort:ISortStrategy
    {
        private List<int> BList;
        public BubbleSort(List<int> list)
        {
            BList = list;
        }

        public void Sort()
        {
            for (int i = 0; i < BList.Count; i++)
            {
                for (int j = 1; j < BList.Count-i; j++)
                {
                    int temp;
                    if (BList[j-1]>BList[j])
                    {
                        temp = BList[j-1];
                        BList[j-1] = BList[j];
                        BList[j] = temp;
                    }
                }
            }
        }

    }
}
