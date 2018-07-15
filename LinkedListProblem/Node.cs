using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    class Node<T>
    {
        T data;
        Node<T> next;

        public Node()
        {
            data = default(T);
            next = null;
        }
        public Node(T _data)
        {
            data = _data;            
        }
        public Node(Node<T> _next)
        {
            next = _next;
        }

        public T Data
        {
            get { return data; }
            set { data = value; }
        }
        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }
    }
}
