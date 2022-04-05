using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class LinkedList : IList
    {
        public int Length { get; private set; }
        private Node _root;
        private Node _tail;
        public LinkedList()
        {
            Length = 0;
            _root = null;
            _tail = null;
        }
        public LinkedList(int value)
        {
            Length = 1;
            _root = new Node(value);
            _tail = _root;
        }
        public void Add(int value)
        {
            if (_root == null)
            {
                _root = new Node(value);
            }
            else
            {
                _tail.Next = new Node(value);
                _tail = _tail.Next;
            }
         }
    }
}