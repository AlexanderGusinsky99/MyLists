using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class LinkedList : IList
    {
        private Node _root;
        private Node _tail;
        public int this[int index]
        {
            get
            {

                Node crnt = _root;
                for (int i = 1; i <= index; i++)
                {
                    crnt = crnt.Next;
                }
                return crnt.Value;
            }
            set
            {
            }
        }
        public int Length
        {
            get
            {
                int count = 0;
                Node crnt = _root;
                while (crnt.Next != null)
                {
                    crnt = crnt.Next;
                    count++;
                }
                return count;
            }
            private set
            {
            }
        }
        public LinkedList()
        {
            _root = null;
            _tail = null;
        }
        public LinkedList(int value)
        {
            _root = new Node(value);
            _tail = _root;
        }
        public void Add(int value)
        {
            _tail = new Node(value);
            _tail = _tail.Next;
        }
        public void DeleteByIndex(int index)
        {
            Node crnt = _root;
            for (int i = 1; i < index-1; i++)
            {
                crnt = crnt.Next;
            }
            crnt.Next = crnt.Next.Next;
        }
        public override string ToString()
        {
            string s = "";
            Node crnt = _root;
            while (crnt != null)
            {
                s += $"{crnt.Value} ";
                crnt = crnt.Next;
            }
            return s;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is LinkedList))
            {
                return false;
            }
            LinkedList list = (LinkedList)obj;
            if (list.Length != this.Length)
            {
                return false;
            }
            Node thisCrnt = this._root;
            Node listCrnt = list._root;
            while(thisCrnt != null)
            {
                if (thisCrnt.Value != listCrnt.Value)
                {
                    return false;
                }
                thisCrnt = thisCrnt.Next;
                listCrnt = listCrnt.Next;
            }
            return true;
        }
    }
}