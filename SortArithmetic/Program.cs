using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> iList = new List<int>() { 4, 2, 6, 8, 1, 5, 7, 3, 9, 10, 21, 18, 10, 2 };
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            //QSort(list1, 0, iList.Count - 1);
            Test test = new Test();
            test.GetSortStrategy(new QuickSort(iList, 0, iList.Count - 1));
            //test.GetSortStrategy(new BubbleSort(iList));
            //test.GetSortStrategy(new SelectionSort(iList));
            test.DoSort();
            Console.WriteLine("Finally:");
            foreach (var item in iList)
            {
                Console.Write("{0}\t", item);
            }
            Console.ReadLine();
        }

        static void QSort(List<int> list,int low,int high)
        {
            if (low >= high)
                return;
            int index = SortUnit(list, low, high);
            QSort(list, low, index -1);
            QSort(list, index + 1, high);
        }
        static int SortUnit(List<int> list,int low,int high)
        {
            int key = list[low];//设定基准数，最终位于区域中间位置，使得左边的数都小于它，右边的数都大于它
            while (low<high)//当low==high时，第一遍轮询完成
            {
                while (list[high] >= key && high > low)//从后往前轮询找到一个比左标识小的数               
                    --high;
                
                list[low] = list[high];//把较小的数放在左标识的位置

                while (list[low] <= key && high > low)
                    ++low; 

                list[high] = list[low];//把较大的数放在右标识的位置，和上一步的放置结合起来看就是把找到的更大数和更小数作交换。
            }
            list[low] = key;

            foreach (var item in list)
            {
                Console.Write("{0}\t", item);
            }
            Console.WriteLine();
            return high;
        }
        
    }
}
