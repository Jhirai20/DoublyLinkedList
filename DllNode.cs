using System;
using System.Collections.Generic;

namespace DoublyLinkedList
{
    public class DllNode
    {
        public int Value;
        public DllNode Next;
        public DllNode Prev;
        public DllNode(int Val)
        {
            Value=Val;
            this.Next=null;
            this.Prev=null;
        }
    }

}