using System;
using System.Collections.Generic;
using System.Text;

namespace 第8周_二叉树
{
    public class CQueue<Type>
    {
        private int front, rear;
        private Type[] elems;
        private const int Maxsize = 1000;
        //--------------------------------------------------------------------------------
        public void MakeEmpty() { front=rear=0; }//清空
        public bool IsEmpty() { return front==rear; }//判队空
        public bool IsFull() { return (rear+1)%Maxsize==front; }//判队满
		public int Front() { return front; }
		public int Rear() { return rear; }
        ///////////////////////////////////////////////////////////
        public CQueue()
        {
            elems = new Type[Maxsize];
            front = rear = 0;
        }
        ///////////////////////////////////////////////////////////
        public bool In(Type item)//入队
        {
            if (!IsFull())
            {
                rear = (rear + 1) % Maxsize;
                elems[rear] = item;
                return (true);
            }
            else
                return (false);
        }
        ///////////////////////////////////////////////////////////
        public Type Out()//出队
        {
            front = (front + 1) % Maxsize;
            return elems[front];
        }
        ///////////////////////////////////////////////////////////
        public Type Getfront()
        {
            return elems[(front + 1) % Maxsize];
        }
        ///////////////////////////////////////////////////////////
        public Type Getdata(int k)
        {
            return elems[k];
        }
        ///////////////////////////////////////////////////////////
    }
}
