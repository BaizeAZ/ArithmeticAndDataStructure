using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    interface IListDs<T>
    {
        int GetLength();
        void Clear();
        bool IsEmpty();
        void Append(T val);
        void Insert(T val, int i);
        T Delete(int i);
        T GetElem(int i);
        int[] Locate(T val);
        void Display();
    }
}
