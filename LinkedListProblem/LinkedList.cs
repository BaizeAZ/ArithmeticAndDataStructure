using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    sealed class LinkedList<T> : IListDs<T>
    {        
        public Node<T> Head { get;private set; }        

        public LinkedList()
        {
            Head = null;
        }
        
        public void Append(T val)
        {
            if (null==Head)
            {
                Node<T> p = new Node<T>(val);
                Head = p;
                return;
            }
            Node<T> pp = new Node<T>();
            pp = Head;
            while (null!=pp.Next)
            {
                pp = pp.Next;
            }
            pp.Next = new Node<T>(val);
        }

        public void Clear()
        {
            Head = null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i">从0开始，即0代表一个节点</param>
        /// <returns></returns>
        public T Delete(int i)
        {
            int length = GetLength();
            if (i < 0 || i >= length)
            {
                Console.WriteLine("删除的序号不在范围内");
                return default(T);
            }                     
            Node<T> node = Head;
            Node<T> temp = new Node<T>();            
            if (i == 0)
            {
                Head = Head.Next;
                return node.Data;
            }           
                                      
            for(int j = 0; j < i; j++)
            {
                temp = node;
                node = node.Next;
            }
            temp.Next = node.Next;
            return node.Data;
        }

        public T GetElem(int i)
        {
            int length = GetLength();
            if (i < 0 || i >= length)
            {
                Console.WriteLine("查找的序号不在范围内");
                return default(T);
            }
            Node<T> node = Head;
            for (int j = 0; j < i; j++)
            {
                node = node.Next;
            }
            return node.Data;
        }

        public int GetLength()
        {
            Node<T> node = new Node<T>();
            int count = 0;
            node = Head;
            while (null!=node)
            {
                count++;
                node = node.Next;
            }
            return count;
        }
        /// <summary>
        /// 插入，从选定的位置前，也是成为了指定位置的新节点
        /// </summary>
        /// <param name="val"></param>
        /// <param name="i">大于等于0，小于Length</param>s
        public void Insert(T val, int i)
        {
            int length = GetLength();
            if (i<0||i>=length)
            {
                Console.WriteLine("\r\n{0}", "插入的序号不在范围内");
                return;
            }
            Node<T> node = Head;
            Node<T> temp = new Node<T>();
            Node<T> valNode = new Node<T>(val);
            int j = 0;
            //插入头节点
            if (i==0)
            {
                valNode.Next = node;
                Head = valNode;
                return;
            }
            //非插入头节点
            while (j!=i)
            {
                j++;
                temp = node;
                node = node.Next;
            }
            temp.Next = valNode;
            valNode.Next = node;
        }

        public bool IsEmpty()
        {
            return Head == null;
        }

        public int[] Locate(T val)
        {
            Node<T> node = Head;
            List<int> index = new List<int>();
            int i = 0;
            while (null!=node)
            {               
                if (node.Data.Equals(val))                
                    index.Add(i);                
                i++;
                node = node.Next;
            }
            return index.ToArray();
        }

        public void Display()
        {
            Node<T> node = new Node<T>();
            node = Head;
            Console.Write("\r\n 节点数：{0}\r\n",GetLength());
            while (null!=node)
            {                
                Console.Write("{0}\t", node.Data);
                node = node.Next;
            }
        }
        
    }
}
