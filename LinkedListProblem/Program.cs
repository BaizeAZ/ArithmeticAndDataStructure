using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);
            list.Display();
            //ReverstLinkedList1(list.Head);
            //list.Delete(0);
            //list.Display();
            //list.Delete(1);
            //list.Display();
            //list.Delete(1);
            //list.Display();
            //list.Delete(0);
            //list.Display();
            list.Insert(10, 3);
            list.Display();
            Console.WriteLine("\r\n{0}", list.GetElem(4));
            
            Console.Read();
        }

        //已知链表头结点head，把链表逆序
        static void ReverstLinkedList1(Node<int> headNode)
        {
            //遍历链表节点
            Stack<int> stackA = new Stack<int>();
            Node<int> temp = headNode;
            while (null!=temp)
            {
                stackA.Push(temp.Data);
                temp = temp.Next;
            }

            temp = headNode;
            while (null!=temp)
            {
                temp.Data = stackA.Pop();
                temp = temp.Next;
            }
        }

    }
}
