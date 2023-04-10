// author:赵维嘉 信计211 U202142209
//       :孙远   统计211 U202142203
//       :贺凌峰 数学211 U202142212 
// wx:19908428905
// qq:2869210303@qq.com
// CopyRight:未经允许，禁止转载

using System;
using System.Drawing;
using System.Windows.Forms;

namespace 第8周_二叉树
{
    public partial class MainForm : Form
    {
        CBinaryTree m_tree;
        Graphics myg = null;

        public MainForm()
        {
            m_tree = new CBinaryTree();
            InitializeComponent();

        }
        // 初始化
        private void bt_create1_Click(object sender, EventArgs e)
        {
            m_tree.CreateBinTreestr(tb_strin.Text);
            m_tree.DrawBTree(pb_bstree);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tb_strin.Text = "A(B(C,D(E(F),G(,H))),I(,J(K)))";
            textBox1.Text = "4";
            textBox2.Text = "4";
            textBox3.Text = "120";
            textBox4.Text = "90";
            textBox5.Text = "30";
            textBox6.Text = "0.66";
            textBox7.Text = "45";
            textBox8.Text = "0.66";
            textBox9.Text = "45";
            myg = pb_bstree.CreateGraphics();
            midx = pb_bstree.Width / 2;
            midy = pb_bstree.Height / 2;
        }
        
        //遍历画字符串函数
        private void drawStr(string str, PictureBox pb)
        {
            myg = pb.CreateGraphics();
            Brush b0 = new SolidBrush(Color.Red);
            Brush b1 = new SolidBrush(Color.White);
            Font f0 = new Font("Arial", 16);
            Font f1 = new Font("Arial", 16);
            //myg.DrawString(temp, f0, b1, 10, 10);//之前的涂掉
            myg.FillRectangle(b1, 5, 5, pb.Width, 20);
            //temp = str;
            myg.DrawString(str, f0, b0, 5, 5);
        }
        //遍历函数
        private void bt_Traversal_Click(object sender, EventArgs e)
        {
            //this.Refresh();
            string strout = "";
            int k;
            if (rb_levels.Checked == true)
                k = 0;
            else if (rb_first.Checked == true)
                k = 1;
            else if (rb_mid.Checked == true)
                k = 2;
            else
                k = 3;
            m_tree.Traversal(k, out strout);
            tb_strin2.Text = strout;
            drawStr(strout, pb_bstree);
        }


        double pi = Math.PI;
        double th1, th2;//左枝，右枝倾角
        double per1, per2;//左枝，右枝长度比
        int width, length;//树线宽度
        int n, y0, midx, midy;//n:树的层数  y0:树的初始高度     
        double th0;//树干的倾角
        public void drawLine(double x0, double y0, double x1, double y1, Pen p)
        {       //定义画线，实现输入double类型的坐标值也能画线，还加了画笔宽度
                //Pen p= new Pen(Color.LimeGreen, width);
            myg.DrawLine(p, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        //求二叉树深度/结点数
        private void bt_deep_Click(object sender, EventArgs e)
        {
            m_tree.init();
            m_tree.calDeep(m_tree.treeroot, 0);
            tb_deep.Text = "深度:" + m_tree.max.ToString() + ", 结点数:" + m_tree.count.ToString();
            tb_strin2.Text = m_tree.str;
        }

        private void bt_create2_Click(object sender, EventArgs e)
        {
            m_tree.Delete_DegreeZero(m_tree.treeroot, m_tree.treeroot);

            m_tree.DrawBTree(pb_bstree);
        }

        private void button_MakeEmpty_Click(object sender, EventArgs e)
        {
            m_tree.MakeEmpty();

            m_tree.DrawBTree(pb_bstree);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        // 交换左右子数
        private void button3_Click(object sender, EventArgs e)
        {
            m_tree.SwapLeftRight();
            m_tree.DrawBTree(pb_bstree);
        }
        // 生成完全二叉树
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBox10.Text);
                m_tree.GenerateCompleteBinTree(n);
                m_tree.DrawBTree(pb_bstree);
            }
            catch (FormatException)
            {
                MessageBox.Show("请输入整数。");
            }catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        //分形树1实现
        public void drawTree(int n, double x0, double y0, double length, double th0)
        {
            //递归函数，输入层数，初始x坐标，初始y坐标，树干长度，树干倾角
            if (n == 0)
                return;//递归结束条件
            double x1 = x0 + length * Math.Cos(th0); //th=-90,th增加x往右偏   th减少x往左偏
            double y1 = y0 + length * Math.Sin(th0); //th=-90，不管th增加减少，y都要减少
            Pen p1 = new Pen(Color.Gold, width);
            Pen p2 = new Pen(Color.DarkBlue, width);
            if (n % 2 == 0)//n是偶数
                drawLine(x0, y0, x1, y1, p2);//第一层连线
            else//n是奇数
                drawLine(x0, y0, x1, y1, p1);
            //↓调用递归
            drawTree(n - 1, x1, y1, per1 * length, th0 - th1); //左树枝，th减少  x往左偏
            drawTree(n - 1, x1, y1, per2 * length, th0 + th2); //右树枝，th增加  x往右偏
        }

        //分形树1
        private void bt_fenxing1_Click(object sender, EventArgs e)
        {
            Brush b0 = new SolidBrush(Color.Red);
            this.Refresh();
            y0 = Convert.ToInt32(textBox5.Text);//初始高度
            per1 = Convert.ToDouble(textBox6.Text);//左长度比
            per2 = Convert.ToDouble(textBox8.Text);//右长度比
            th0 = pi / 180 * Convert.ToInt32(textBox4.Text);//树干偏角
            width = Convert.ToInt32(textBox1.Text);//树的宽度
            n = Convert.ToInt32(textBox2.Text);//树的层数
            th1 = pi / 180 * Convert.ToInt32(textBox7.Text);//左倾角
            th2 = pi / 180 * Convert.ToInt32(textBox9.Text);//右倾角
            length = Convert.ToInt32(textBox3.Text);//长度

            drawTree(n, midx, 2 * midy - y0, length, -th0);
        }


        private void QueueTree(int n, double len, double arg, int x0, int y0)
        {
            CQueue<TreePoint> tp = new CQueue<TreePoint>();
            int x1 = x0 + (int)(len * Math.Cos(arg));
            int y1 = y0 + (int)(len * Math.Sin(arg));
            Point p0 = new Point(x0, y0);
            Point p1 = new Point(x1, y1);
            TreePoint cur;
            TreePoint head = new TreePoint(p0, p1, len, arg, 1);
            tp.In(head);
            while (!tp.IsEmpty())
            {
                cur = tp.Getfront();
                Pen pen = new Pen(cur.level % 2 == 0 ? Color.DarkViolet : Color.Gold, width);//颜色交替
                myg.DrawLine(pen, cur.p0, cur.p1);
                if (cur.level < n)
                {
                    //两个进队, 左点
                    int lx1 = cur.p1.X + (int)(cur.len * Math.Cos(cur.arg - th1));
                    int ly1 = cur.p1.Y + (int)(cur.len * Math.Sin(cur.arg - th1));
                    TreePoint left = new TreePoint(cur.p1, new Point(lx1, ly1), cur.len * per1, cur.arg - th1, cur.level + 1);
                    //右点
                    int rx1 = cur.p1.X + (int)(cur.len * Math.Cos(cur.arg + th2));
                    int ry1 = cur.p1.Y + (int)(cur.len * Math.Sin(cur.arg + th2));
                    TreePoint right = new TreePoint(cur.p1, new Point(rx1, ry1), cur.len * per2, cur.arg + th2, cur.level + 1);
                    tp.In(left);
                    tp.In(right);
                }
                tp.Out();
            }
        }
        //队列实现分形
        private void bt_queue_Click(object sender, EventArgs e)
        {
            this.Refresh();
            y0 = Convert.ToInt32(textBox5.Text);//初始高度
            per1 = Convert.ToDouble(textBox6.Text);//左长度比
            per2 = Convert.ToDouble(textBox8.Text);//右长度比
            th0 = pi / 180 * Convert.ToInt32(textBox4.Text);//树干偏角
            width = Convert.ToInt32(textBox1.Text);//树的宽度
            n = Convert.ToInt32(textBox2.Text);//树的层数
            th1 = pi / 180 * Convert.ToInt32(textBox7.Text);//左倾角
            th2 = pi / 180 * Convert.ToInt32(textBox9.Text);//右倾角
            length = Convert.ToInt32(textBox3.Text);//长度

            QueueTree(n, length, -th0, midx, 2 * midy - y0);
        }
        //分形树2      
        private void DrawTree2(int n, double len, double arg, double x, double y)
        {
            Pen pen1 = null;
            pen1 = new Pen(n % 2 == 0 ? Color.Blue : Color.Gold, width);

            double lang = arg + pi / 4;
            double rang = arg - pi / 4;
            double ang = pi / 12;
            int h = pb_bstree.Height;
            double p2x = (x + len * Math.Cos(arg));
            double p2y = h - (y + len * Math.Sin(arg));
            double p3x = (x + len * Math.Cos(arg) / 3);
            double p3y = h - (y + len * Math.Sin(arg) / 3);
            double p2lx = (p2x + len * Math.Cos(lang) / 3);
            double p2ly = h - (h - p2y + len * Math.Sin(lang) / 3);

            double p2rx = (p2x + len * Math.Cos(rang) / 3);
            double p2ry = p2y - len * Math.Sin(rang) / 3;

            double p3lx = (p3x + len * Math.Cos(lang) / 3);
            double p3ly = h - (h - p3y + len * Math.Sin(lang) / 3);

            double p3rx = (p3x + len * Math.Cos(rang) / 3);
            double p3ry = h - (h - p3y + len * Math.Sin(rang) / 3);
            //int p2x = (int)(x + len * Math.Cos(arg));
            //int p2y = h - (int)(y + len * Math.Sin(arg));
            //int p3x = (int)(x + len * Math.Cos(arg) / 3);
            //int p3y = h - (int)(y + len * Math.Sin(arg) / 3);
            //int p2lx = (int)(p2x + len * Math.Cos(lang) / 3);
            //int p2ly = h- (int)(h - p2y + len * Math.Sin(lang) / 3);

            //int p2rx = (int)(p3x + len * Math.Cos(rang) / 3);
            //int p2ry = h - (int)(h - p2y + len * Math.Sin(rang) / 3);

            //int p3lx = (int)(p3x + len * Math.Cos(lang) / 3);
            //int p3ly = h - (int)(h - p3y + len * Math.Sin(lang) / 3);

            //int p3rx = (int)(p3x + len * Math.Cos(rang) / 3);
            //int p3ry = h - (int)(h- p3y + len * Math.Sin(rang) / 3);
            //Point p1 = new Point(x, h - y);
            //Point p2 = new Point(p2x, p2y);
            //Point p3 = new Point(p3x, p3y);
            //Point p3l = new Point(p3lx, p3ly);
            //Point p3r = new Point(p3rx, p3ry);

            //Point p2l = new Point(p2lx, p2ly);
            //Point p2r = new Point(p2rx, p2ry);
            ///////////////////////////////////////////////////////////////////////
            drawLine(x, h - y, p2x, p2y, pen1);
            drawLine(p3x, p3y, p3lx, p3ly, pen1);
            drawLine(p3x, p3y, p3rx, p3ry, pen1);
            drawLine(p2x, p2y, p2lx, p2ly, pen1);
            drawLine(p2x, p2y, p2rx, p2ry, pen1);

            //myg.DrawLine(pen1, p1, p2);
            //myg.DrawLine(pen1, p3, p3l);
            //myg.DrawLine(pen1, p3, p3r);
            //myg.DrawLine(pen1, p2, p2l);
            //myg.DrawLine(pen1, p2, p2r);
            ///////////////////////////////////////////////////////////////////////
            double lt = th1;
            double rt = th2;

            if ((n > 1) && (len >= 1))
            {
                DrawTree2(n - 1, len / 1.25, arg - ang, p2x, h - p2y);
                DrawTree2(n - 1, len / 3, lang, p2lx, h - p2ly);
                DrawTree2(n - 1, len / 3, rang, p2rx, h - p2ry);
                DrawTree2(n - 1, len / 3, lang, p3lx, h - p3ly);
                DrawTree2(n - 1, len / 3, rang, p3rx, h - p3ry);
                //DrawTree2(n - 1, len / 1.25, arg - ang, p2.X, h - p2.Y);
                //DrawTree2(n - 1, len / 3, lang, p2l.X, h - p2l.Y);
                //DrawTree2(n - 1, len / 3, rang, p2r.X, h - p2r.Y);
                //DrawTree2(n - 1, len / 3, lang, p3l.X, h - p3l.Y);
                //DrawTree2(n - 1, len / 3, rang, p3r.X, h - p3r.Y);
            }
        }
        private void bt_fenxing2_Click(object sender, EventArgs e)
        {
            Brush b0 = new SolidBrush(Color.Red);
            this.Refresh();
            y0 = Convert.ToInt32(textBox5.Text);//初始高度
            th0 = pi / 180 * Convert.ToInt32(textBox4.Text);//树干偏角
            width = Convert.ToInt32(textBox1.Text);//树的宽度
            n = Convert.ToInt32(textBox2.Text);//树的层数
            length = Convert.ToInt32(textBox3.Text);//长度
            DrawTree2(n, length, th0, pb_bstree.Width / 2, y0);
        }


    }

}
