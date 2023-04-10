using System;
using System.Collections.Generic;
using System.Text;

namespace 第8周_二叉树
{
    public interface ICStack<Type>      //接口
    {
        bool IsEmpty();//判栈空
        bool IsFull();//判栈满
        void MakeEmpty();//清空
        bool Push(Type item);//入栈
        Type Pop();//出栈
        Type Gettop();//取栈顶
        string GetStackALLData(string sname);
    }

    class CStacknode<Type>      //链栈结点类
    {
        private Type data;
        private CStacknode<Type> next;
        //--------------------------------------------------------------------------------
        public CStacknode()
        {
            next = null;
        }
        public CStacknode(Type data)
        {
            this.data = data;
            next = null;
        }
        public CStacknode(Type data, CStacknode<Type> next)
        {
            this.data = data;
            this.next = next;
        }
        public Type Data
        {
            get { return data; }
            set { data = value; }
        }
        public CStacknode<Type> Next
        {
            get { return next; }
            set { next = value; }
        }
    }
    class CLinkStack<Type>: ICStack<Type>
    {
        private CStacknode<Type> top;
        //--------------------------------------------------------------------------------
        public void MakeEmpty() { top = null; }//清空
        public bool IsEmpty() { return top == null; }//判栈空
        public bool IsFull() { return false; }//判栈满

        public CLinkStack() 
        { 
            top = null; 
        }
        public bool Push(Type item)//入栈
        {
            top = new CStacknode<Type>(item,top);
            return (true);
        }
        public Type Pop()//出栈
        {
            Type dt = top.Data;
            top = top.Next;
            return dt;
        }

        public Type Gettop()//取栈顶
        {
            if (top == null)
                return default(Type);
            else
                return top.Data;
        }

        public string GetStackALLData(string sname)
        {
            string str = " 】";
            if (IsEmpty()) 
                str = sname + " stack is null 】";
            CStacknode<Type> p = top;
            while (p != null)
            {
                str = p.Data + "   " + str;
                p = p.Next;
            }
            str = "【  "+str + "\r\n";
            str = str + "---------------------------------------" + "\r\n";
            return str;
        }
    }

    public class CSeqStack<Type> : ICStack<Type>
    {
        private int top;
		private Type[] elems;
		private int Maxsize=100;
        //--------------------------------------------------------------------------------
		public void MakeEmpty() { top=-1; }//清空
		public bool IsEmpty() { return top==-1; }//判栈空
		public bool IsFull() { return top==Maxsize-1; }//判栈满
        ///////////////////////////////////////////////////////////
        public Type this[int index]
        {
            get { return elems[index]; }
            set { elems[index] = value; }
        }
        public int Top
        {
            get { return top; }
        }

        public CSeqStack()
        {
            elems=new Type[Maxsize];
            top = -1;
        }
        public CSeqStack(int max)
        {
            Maxsize = max;
            elems = new Type[Maxsize];
            top = -1;
        }
        ///////////////////////////////////////////////////////////
        public bool Push(Type item)//入栈
        {
            if(!IsFull())
            {
                elems[++top]=item;
                return(true);
            }
            else
                return(false);
        }
        ///////////////////////////////////////////////////////////
        public Type Pop()//出栈
        {
            if (!IsEmpty())
                return elems[top--];
            else
                return elems[0];
        }
        ///////////////////////////////////////////////////////////
        public Type Gettop()//取栈顶
        {
            if (!IsEmpty())
                return elems[top];
            else
                return elems[0];
        }
        public string GetStackALLData(string sname)
        {
            string str="";
            if (IsEmpty()) str = sname + " stack is null";
            for(int i=0;i<=top;i++)
            {
                str = str + "  " + elems[i].ToString() + "  ";
            }
            str = str + "\r\n";
            //str = str + "--------------------------------------------------" + "\r\n";
            return str;
        }
        ///////////////////////////////////////////////////////////
    }
}
