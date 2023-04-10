// author:赵维嘉 信计211 U202142209
//       :孙远   统计211 U202142203
//       :贺凌峰 数学211 U202142212 
// wx:19908428905
// qq:2869210303@qq.com
// CopyRight:未经允许，禁止转载

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace 第8周_二叉树
{
    public class TreePoint  // 节点类
    {
        public Point p0;    // 起点
        public Point p1;    // 终点
        public double len;  // 长度
        public double arg;
        public int level;   // 层数
        public TreePoint(Point start, Point end, double l, double args, int levels)
        {
            p0 = start;
            p1 = end;
            len = l;
            arg = args;
            level = levels;
        }
    }

    public class drawbtreetype<Type>
    {
        public CBinaryTreenode<Type> pbtnode;
        public double px, py;
        public int level;
    };   //画二叉树图时的辅助表

    public class help<Type>
    {
        public int t1b, t2b, tln;     //先序中开始位置,中序中开始位置,树长
        public CBinaryTreenode<Type> adr;
    };         //由先序序列,中序序列生成二叉树的帮助表

    public class CBinaryTreenode<Type>
    {
        public Type data;
        public CBinaryTreenode<Type> lchild, rchild;
        public CBinaryTreenode()
        {
            lchild = rchild = null;
        }
        public CBinaryTreenode(Type item)
        {
            data = item;
            lchild = rchild = null;
        }
        public CBinaryTreenode(Type item, CBinaryTreenode<Type> lc, CBinaryTreenode<Type> rc)
        {
            data = item;
            lchild = lc; rchild = rc;
        }
    }

    class CBinaryTree
    {
        public CBinaryTreenode<char> treeroot;  // root节点

        public void MakeEmpty()
        {
            treeroot = null;
        }
        public void CreateBinTreestr(string bintreestr)//根据字符串生成二叉树表
        {
            if (treeroot != null)
                treeroot = null;
            string strt = "1234567890+-*/";
            char ch, chlr = ' ';
            CLinkStack<CBinaryTreenode<char>> mystack = new CLinkStack<CBinaryTreenode<char>>();
            CBinaryTreenode<char> stp, stpnew;  //存放栈顶的返回值
            stpnew = null;
            int n = bintreestr.Length;
            for (int i = 0; i < n; i++)
            {
                ch = bintreestr[i];
                // A-Z 或者 a-z 或者属于 "1234567890+-*/"
                if (((ch >= 'A') && (ch <= 'Z')) || ((ch >= 'a') && (ch <= 'z')) || (strt.IndexOf(ch) >= 0))
                {
                    //取栈顶
                    stp = mystack.Gettop();
                    //创建节点并于栈顶链接
                    stpnew = new CBinaryTreenode<char>(ch);
                    if (stp == null)
                        treeroot = stpnew;
                    else
                    {
                        if (chlr == 'l')
                            stp.lchild = stpnew;
                        else
                            stp.rchild = stpnew;
                    }
                }
                else if (ch == '(')
                {
                    chlr = 'l';             //设置左右
                    mystack.Push(stpnew);   //当前点入栈
                }
                else if (ch == ',')
                    chlr = 'r';         //设置左右
                else if (ch == ')')
                    mystack.Pop();      //出栈
            }
        }
        // 在树的最左结点(即中序序列的第一个结点)插入一个孩子结点
        public void CreateNewLeftNode(string str)
        {

        }

        public int max = 0;         //深度
        public int count = 0;       //结点数
        public string str = "";
        public void init()
        {
            max = 0;
            count = 0;
            str = "";
        }
        //求二叉树的递归运算(遍历, 求高度, 结点数, 求和)参数: [当前节点, 当前结点深度]
        public void calDeep(CBinaryTreenode<char> root, int deep)
        {
            //补充程序，函数的输入可以修改或不修改，都可以
            // 获取深度
            this.max = this.getDepth(this.treeroot);
            // 获取节点数
            this.getCount(this.treeroot);

        }
        // 获取深度
        private int getDepth(CBinaryTreenode<char> t)
        {
            int dep1, dep2;
            if (t == null)
                return 0;
            dep1 = getDepth(t.lchild);
            dep2 = getDepth(t.rchild);
            if (dep1 > dep2)
                return dep1 + 1;
            return dep2 + 1;
        }
        // 获取节点数
        private void getCount(CBinaryTreenode<char> t)
        {
            if (t != null)
            {
                getCount(t.lchild);
                this.count++;
                getCount(t.rchild);
            }
        }
        // 先序遍历，顺便统计叶节点的数量
        private void preorder(CBinaryTreenode<char> t)
        {
            if (t != null)
            {
                // visit(t.data);
                if (t.lchild != null &&
                    t.rchild != null)
                    LeavesNodeNum++;
                preorder(t.lchild);
                preorder(t.rchild);
            }
        }
        // 中序遍历
        private void inorder(CBinaryTreenode<char> t)
        {
            if (t != null)
            {
                inorder(t.lchild);
                // visit(t.data);
                inorder(t.lchild);
            }
        }
        // 统计所有叶节点的个数
        public short LeavesNodeNum = 0;
        public int GetLeavesNodeNum()
        {
            this.LeavesNodeNum = 0;
            preorder(this.treeroot);
            return LeavesNodeNum == 0 ? 0 : LeavesNodeNum + 1;
        }
        // 删除所有的叶节点的遍历函数
        protected void deleteLeaveNodeIterate(CBinaryTreenode<char> t, CBinaryTreenode<char> pre)
        {
            if (t != null)
            {
                // visit(t.data);
                if (t.lchild == null && t.rchild == null)
                {
                    // 没有子节点，即为叶节点
                    if (t == pre.lchild)
                        pre.lchild = null;
                    else
                        pre.rchild = null;  // 删除
                }
                else
                {
                    // 没有子节点，无需向下遍历
                    deleteLeaveNodeIterate(t.lchild, t);
                    deleteLeaveNodeIterate(t.rchild, t);
                }
            }
        }
        // 删除所有的叶节点
        public void RemoveAllLeaveNodes()
        {
            deleteLeaveNodeIterate(treeroot, null);
        }
        // 交换左右子树
        private void SwapLeftRight(CBinaryTreenode<char> node)
        {
            if (node == null) return;

            CBinaryTreenode<char> temp = node.lchild;
            node.lchild = node.rchild;
            node.rchild = temp;

            SwapLeftRight(node.lchild);
            SwapLeftRight(node.rchild);
        }
        // 交换左右子树
        public void SwapLeftRight()
        {
            SwapLeftRight(this.treeroot);
        }
        // 生成一棵结点数为n的完全二叉树
        public void GenerateCompleteBinTree(int n)
        {
            // code
            this.treeroot=new CBinaryTreenode<char>('a');

            Queue<CBinaryTreenode<char>> queue = new Queue<CBinaryTreenode<char>>();
            if (n <= 0) throw new Exception("输入的数必须大于0");
            queue.Enqueue(this.treeroot);
            for (int i = 2; i <= n; i += 2)
            {
                CBinaryTreenode<char> parent = queue.Dequeue();
                parent.lchild = new CBinaryTreenode<char>('a');
                queue.Enqueue(parent.lchild);
                if (i + 1 <= n)
                {
                    parent.rchild = new CBinaryTreenode<char>('a');
                    queue.Enqueue(parent.rchild);
                }
            }
        }

        // 在二叉树中查找具有给定值的节点
        //public CBinaryTreenode<char> findnode(CBinaryTreenode<char> t,char x)                            
        //{
        //    if (t == null)
        //        return null;
        //    else if (t.data == x)
        //        return t;
        //    else
        //        return findnode(t.lchild, x) || findnode(t.rchild, x);            
        //}


        //二叉树的遍历 
        public void Traversal(int k, out string m_strout)
        {
            m_strout = "";
            CLinkStack<int> sno = new CLinkStack<int>();
            CLinkStack<CBinaryTreenode<char>> stree
                = new CLinkStack<CBinaryTreenode<char>>();
            CBinaryTreenode<char> p;
            int no;

            CQueue<CBinaryTreenode<char>> qtree
                = new CQueue<CBinaryTreenode<char>>();
            if (k == 0)//层次
            {
                if (treeroot != null)
                {
                    qtree.In(treeroot);
                    sno.Push(1);
                }
                else
                {
                    m_strout = "这是个空树!\n";
                    return;
                }
                while (!qtree.IsEmpty())
                {
                    p = qtree.Out();
                    if (p != null)
                    {
                        qtree.In(p.lchild);
                        qtree.In(p.rchild);
                        m_strout += " " + p.data.ToString();
                    }
                }
            }
            else
            {
                if (treeroot != null)
                {
                    stree.Push(treeroot);
                    sno.Push(1);
                }
                else
                {
                    m_strout = "这是个空树!\n";
                    return;
                }
                while (!stree.IsEmpty())
                {
                    p = stree.Gettop();
                    no = sno.Pop();
                    if (no == 1)
                    {
                        sno.Push(2);
                        if (p != null)
                        {
                            stree.Push(p.lchild);
                            sno.Push(1);
                            if (k == 1)
                                m_strout += " " + p.data.ToString();
                        }
                    }
                    else if (no == 2)
                    {
                        sno.Push(3);
                        if (p != null)
                        {
                            stree.Push(p.rchild);
                            sno.Push(1);
                            if (k == 2)
                                m_strout += " " + p.data.ToString();
                        }
                    }
                    else if (no == 3)
                    {
                        stree.Pop();
                        if (p != null)
                        {
                            if (k == 3)
                                m_strout += " " + p.data.ToString();
                        }
                    }
                }
            }
        }

        public void Delete_DegreeZero(CBinaryTreenode<char> p, CBinaryTreenode<char> pre)
        {

            if (p != null)
            {

                if (p.lchild == null && p.rchild == null)
                {
                    if (p == pre.lchild)
                        pre.lchild = null;
                    else
                        pre.rchild = null;
                }
                else
                {

                    Delete_DegreeZero(p.lchild, p);
                    Delete_DegreeZero(p.rchild, p);
                }
            }
        }

        public void DrawBTree(PictureBox pb_bstree)
        {
            CLinkStack<drawbtreetype<char>> stree = new CLinkStack<drawbtreetype<char>>();
            drawbtreetype<char> sp, spt;
            CBinaryTreenode<char> pbtnode, pbtnodenow;
            //if (treeroot == null)
            //return;
            Graphics myg;
            int xmin = 0;
            int ymin = 0;
            int xmax, ymax;

            myg = pb_bstree.CreateGraphics();
            xmax = pb_bstree.Width;
            ymax = pb_bstree.Height;
            //设置显示颜色
            Color bkColor0;
            Brush bkBrush0;
            Brush bkbrush = new SolidBrush(Color.White);//背景色
            bkColor0 = Color.FromArgb(255, 0, 255, 255);
            bkBrush0 = new SolidBrush(bkColor0);
            bkBrush0 = new SolidBrush(bkColor0);
            bkBrush0 = new SolidBrush(bkColor0);
            bkBrush0 = new SolidBrush(bkColor0);
            bkBrush0 = new SolidBrush(bkColor0);
            bkBrush0 = new SolidBrush(bkColor0);
            bkBrush0 = new SolidBrush(bkColor0);
            bkBrush0 = new SolidBrush(bkColor0);
            bkBrush0 = new SolidBrush(bkColor0);
            bkBrush0 = new SolidBrush(bkColor0);
            Pen pen1 = new Pen(Color.Red, 2);
            //画背景
            myg.FillRectangle(bkbrush, xmin, ymin, xmax - xmin, ymax - ymin);
            string str;
            Font font = new Font("Arial", 10);
            SolidBrush b1 = new SolidBrush(Color.Blue);
            StringFormat sf1 = new StringFormat();


            if (treeroot == null)
                return;

            //画图数据初始化
            double xx = xmax / 2;
            double yy = ymax - 50;
            int level = 1;
            double xnow;
            double ynow;
            double alpha;

            double len = 150;
            double lenbl = 0.8;
            double dw = 0;
            int dt = 1;
            //画树根中心点
            spt = new drawbtreetype<char>();
            spt.pbtnode = treeroot;
            spt.px = xx;
            spt.py = yy;
            spt.level = level;
            stree.Push(spt);//树根入栈
            myg.FillEllipse(bkBrush0, (int)(xx - 12), (int)(ymax - yy - 12), 24, 24);
            myg.DrawEllipse(pen1, (int)(xx - 12), (int)(ymax - yy - 12), 24, 24);
            str = "" + treeroot.data;
            myg.DrawString(str, font, b1, (int)(xx - 5), (int)(ymax - yy - 8), sf1);
            Thread.Sleep(dt);
            while (!stree.IsEmpty())
            {
                sp = stree.Pop();
                pbtnode = sp.pbtnode;
                xx = sp.px;
                yy = sp.py;
                level = sp.level;
                //设置比例
                if (level == 0)
                { lenbl = 0; dw = 0; }
                else if (level == 1)
                { lenbl = 1; dw = 70; }
                else if (level == 2)
                { lenbl = 0.8; dw = 40; }
                else if (level == 3)
                { lenbl = 0.6; dw = 30; }
                else if (level == 4)
                { lenbl = 0.5; dw = 20; }
                else if (level == 5)
                { lenbl = 0.4; dw = 15; }
                else
                { lenbl = 0.3; dw = 15; }
                pbtnodenow = pbtnode.lchild;
                if (pbtnodenow != null)
                {
                    //设置转角
                    alpha = -90 - dw;
                    //求新点坐标
                    xnow = xx + len * lenbl * Math.Cos(alpha * 3.14 / 180.0);
                    ynow = yy + len * lenbl * Math.Sin(alpha * 3.14 / 180.0);
                    //画线
                    myg.DrawLine(pen1, (int)xx, (int)(ymax - yy), (int)xnow, (int)(ymax - ynow));
                    //画中心点
                    myg.FillEllipse(bkBrush0, (int)(xx - 12), (int)(ymax - yy - 12), 24, 24);
                    myg.DrawEllipse(pen1, (int)(xx - 12), (int)(ymax - yy - 12), 24, 24);
                    str = "" + pbtnode.data;
                    myg.DrawString(str, font, b1, (int)(xx - 5), (int)(ymax - yy - 8), sf1);
                    myg.FillEllipse(bkBrush0, (int)(xnow - 12), (int)(ymax - ynow - 12), 24, 24);
                    myg.DrawEllipse(pen1, (int)(xnow - 12), (int)(ymax - ynow - 12), 24, 24);
                    str = "" + pbtnodenow.data;
                    myg.DrawString(str, font, b1, (int)(xnow - 5), (int)(ymax - ynow - 8), sf1);

                    //左孩子结点入栈
                    spt = new drawbtreetype<char>();
                    spt.pbtnode = pbtnodenow;
                    spt.px = xnow;
                    spt.py = ynow;
                    spt.level = level + 1;
                    stree.Push(spt);
                }
                Thread.Sleep(dt);
                pbtnodenow = pbtnode.rchild;
                if (pbtnodenow != null)
                {
                    //设置转角
                    alpha = -90 + dw;
                    //求新点坐标
                    xnow = xx + len * lenbl * Math.Cos(alpha * 3.14 / 180.0);
                    ynow = yy + len * lenbl * Math.Sin(alpha * 3.14 / 180.0);
                    //画线
                    myg.DrawLine(pen1, (int)xx, (int)(ymax - yy), (int)xnow, (int)(ymax - ynow));
                    //画中心点
                    myg.FillEllipse(bkBrush0, (int)(xx - 12), (int)(ymax - yy - 12), 24, 24);
                    myg.DrawEllipse(pen1, (int)(xx - 12), (int)(ymax - yy - 12), 24, 24);
                    str = "" + pbtnode.data;
                    myg.DrawString(str, font, b1, (int)(xx - 5), (int)(ymax - yy - 8), sf1);
                    myg.FillEllipse(bkBrush0, (int)(xnow - 12), (int)(ymax - ynow - 12), 24, 24);
                    myg.DrawEllipse(pen1, (int)(xnow - 12), (int)(ymax - ynow - 12), 24, 24);
                    str = "" + pbtnodenow.data;
                    myg.DrawString(str, font, b1, (int)(xnow - 5), (int)(ymax - ynow - 8), sf1);

                    //右孩子结点入栈
                    spt = new drawbtreetype<char>();
                    spt.pbtnode = pbtnodenow;
                    spt.px = xnow;
                    spt.py = ynow;
                    spt.level = level + 1;
                    stree.Push(spt);
                    Thread.Sleep(dt);
                }
            }
        }

        //public void StoBT(string t1,string t2)
        //{
        //    return;
        //}
        //public int Traversalpp(int k, out string m_strout)
        //{
        //    return 0;
        //}

    }
}
