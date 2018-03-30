using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArithmetic
{
    class InsertionSort : ISortStrategy
    {
        private List<int> iList;

        public InsertionSort(List<int> list)
        {
            iList = list;
        }

        public void Sort()
        {
            
        }

        private void ISort()
        {

        }
        //改进版：二分插入排序
        private void BinaryISort()
        {

        }
        //更高效改进版：shell排序
        private void ShellISort()
        {

        }
    }
}
