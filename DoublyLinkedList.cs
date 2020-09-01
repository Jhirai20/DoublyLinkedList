using System;
using System.Collections.Generic;

namespace DoublyLinkedList
{
    public class DLList
    {

        public DllNode Head;
        public DllNode Tail;
        public int Size;
        public DLList()
        {
            Head=null;
            Tail=null;
            Size=0;
        }
        public void Add(int val)
        {
            DllNode newNode=new DllNode(val);
            if(Head==null)
            {
                Head=newNode;
                Tail=newNode;
                Size=1;
            }
            else
            {  
                int count =1;
                DllNode runner=Head;
                while(runner.Next!=null)
                {
                    runner=runner.Next;
                    count++;
                }
                runner.Next=newNode;
                runner.Next.Prev=runner;
                Tail=runner.Next;
                Size=count+1;
            }
        }
        public void DisplayAll()
        {
            DllNode runner=Head;
            while(runner!=null)
            {
                Console.WriteLine(runner.Value);
                runner=runner.Next;
            }
            Console.WriteLine($"DLL size: {Size}");
        }
        public bool Remove(int val)
        {
            //list empty
            if(Head==null)
            {
                Console.WriteLine("List is empty!");
                return false;
            }
            //list not empty
            else
            {   
                //In Head
                if( Head.Value==val)
                {
                    Head=Head.Next;
                    Head.Prev=null;
                    Size--;
                    return true;
                }
                //In Tail
                else if(Tail.Value==val)
                {
                    Tail=Tail.Prev;
                    Tail.Next=null;
                    Size--;
                    return true;
                }
                else
                {
                    DllNode runner= Head;
                    while(runner!=null)
                    {
                        if(runner.Value==val)
                        {
                            runner.Prev.Next=runner.Next;
                            runner.Next.Prev=runner.Prev;
                            Size--; 
                            return true;
                        }
                        runner=runner.Next;
                    }
                    return false;
                }
            }
        }
        public void Reverse()
        {
            if (Head==null)
            {
                Console.WriteLine("List is empty!");
            }
            else
            {
                DllNode runner =Head;
                DllNode temp=null;
                while(runner!=null)
                {
                temp =runner.Prev;
                runner.Prev=runner.Next;
                runner.Next=temp;//remember its not temp.prev (because its already set to that)
                runner=runner.Prev;
                }
                temp=Head;
                Head=Tail;
                Tail=temp;
            }
        }
    }
}