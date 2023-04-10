namespace 第8周_二叉树
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_strin = new System.Windows.Forms.TextBox();
            this.tb_strin2 = new System.Windows.Forms.TextBox();
            this.bt_create1 = new System.Windows.Forms.Button();
            this.bt_create2 = new System.Windows.Forms.Button();
            this.bt_Traversal = new System.Windows.Forms.Button();
            this.rb_levels = new System.Windows.Forms.RadioButton();
            this.rb_first = new System.Windows.Forms.RadioButton();
            this.rb_mid = new System.Windows.Forms.RadioButton();
            this.rb_back = new System.Windows.Forms.RadioButton();
            this.pb_bstree = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_queue = new System.Windows.Forms.Button();
            this.bt_fenxing2 = new System.Windows.Forms.Button();
            this.bt_fenxing1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_deep = new System.Windows.Forms.Button();
            this.tb_deep = new System.Windows.Forms.TextBox();
            this.button_MakeEmpty = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bstree)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_strin
            // 
            this.tb_strin.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_strin.Location = new System.Drawing.Point(12, 12);
            this.tb_strin.Name = "tb_strin";
            this.tb_strin.Size = new System.Drawing.Size(405, 31);
            this.tb_strin.TabIndex = 0;
            // 
            // tb_strin2
            // 
            this.tb_strin2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_strin2.Location = new System.Drawing.Point(12, 64);
            this.tb_strin2.Name = "tb_strin2";
            this.tb_strin2.Size = new System.Drawing.Size(405, 31);
            this.tb_strin2.TabIndex = 1;
            // 
            // bt_create1
            // 
            this.bt_create1.Location = new System.Drawing.Point(444, 13);
            this.bt_create1.Name = "bt_create1";
            this.bt_create1.Size = new System.Drawing.Size(113, 36);
            this.bt_create1.TabIndex = 2;
            this.bt_create1.Text = "生成二叉树1";
            this.bt_create1.UseVisualStyleBackColor = true;
            this.bt_create1.Click += new System.EventHandler(this.bt_create1_Click);
            // 
            // bt_create2
            // 
            this.bt_create2.Location = new System.Drawing.Point(444, 63);
            this.bt_create2.Name = "bt_create2";
            this.bt_create2.Size = new System.Drawing.Size(113, 40);
            this.bt_create2.TabIndex = 3;
            this.bt_create2.Text = "删除叶结点";
            this.bt_create2.UseVisualStyleBackColor = true;
            this.bt_create2.Click += new System.EventHandler(this.bt_create2_Click);
            // 
            // bt_Traversal
            // 
            this.bt_Traversal.Location = new System.Drawing.Point(707, 192);
            this.bt_Traversal.Name = "bt_Traversal";
            this.bt_Traversal.Size = new System.Drawing.Size(69, 40);
            this.bt_Traversal.TabIndex = 4;
            this.bt_Traversal.Text = "遍历";
            this.bt_Traversal.UseVisualStyleBackColor = true;
            this.bt_Traversal.Click += new System.EventHandler(this.bt_Traversal_Click);
            // 
            // rb_levels
            // 
            this.rb_levels.AutoSize = true;
            this.rb_levels.Location = new System.Drawing.Point(718, 120);
            this.rb_levels.Name = "rb_levels";
            this.rb_levels.Size = new System.Drawing.Size(58, 19);
            this.rb_levels.TabIndex = 5;
            this.rb_levels.Text = "层次";
            this.rb_levels.UseVisualStyleBackColor = true;
            // 
            // rb_first
            // 
            this.rb_first.AutoSize = true;
            this.rb_first.Checked = true;
            this.rb_first.Location = new System.Drawing.Point(718, 162);
            this.rb_first.Name = "rb_first";
            this.rb_first.Size = new System.Drawing.Size(58, 19);
            this.rb_first.TabIndex = 6;
            this.rb_first.TabStop = true;
            this.rb_first.Text = "先序";
            this.rb_first.UseVisualStyleBackColor = true;
            // 
            // rb_mid
            // 
            this.rb_mid.AutoSize = true;
            this.rb_mid.Location = new System.Drawing.Point(802, 120);
            this.rb_mid.Name = "rb_mid";
            this.rb_mid.Size = new System.Drawing.Size(58, 19);
            this.rb_mid.TabIndex = 7;
            this.rb_mid.Text = "中序";
            this.rb_mid.UseVisualStyleBackColor = true;
            // 
            // rb_back
            // 
            this.rb_back.AutoSize = true;
            this.rb_back.Location = new System.Drawing.Point(802, 162);
            this.rb_back.Name = "rb_back";
            this.rb_back.Size = new System.Drawing.Size(58, 19);
            this.rb_back.TabIndex = 8;
            this.rb_back.Text = "后序";
            this.rb_back.UseVisualStyleBackColor = true;
            // 
            // pb_bstree
            // 
            this.pb_bstree.BackColor = System.Drawing.Color.White;
            this.pb_bstree.Location = new System.Drawing.Point(12, 108);
            this.pb_bstree.Name = "pb_bstree";
            this.pb_bstree.Size = new System.Drawing.Size(684, 493);
            this.pb_bstree.TabIndex = 9;
            this.pb_bstree.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.bt_queue);
            this.panel1.Controls.Add(this.bt_fenxing2);
            this.panel1.Controls.Add(this.bt_fenxing1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(936, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 607);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bt_queue
            // 
            this.bt_queue.Location = new System.Drawing.Point(174, 541);
            this.bt_queue.Margin = new System.Windows.Forms.Padding(4);
            this.bt_queue.Name = "bt_queue";
            this.bt_queue.Size = new System.Drawing.Size(101, 47);
            this.bt_queue.TabIndex = 15;
            this.bt_queue.Text = "队列";
            this.bt_queue.UseVisualStyleBackColor = true;
            this.bt_queue.Click += new System.EventHandler(this.bt_queue_Click);
            // 
            // bt_fenxing2
            // 
            this.bt_fenxing2.Location = new System.Drawing.Point(34, 543);
            this.bt_fenxing2.Margin = new System.Windows.Forms.Padding(4);
            this.bt_fenxing2.Name = "bt_fenxing2";
            this.bt_fenxing2.Size = new System.Drawing.Size(124, 43);
            this.bt_fenxing2.TabIndex = 14;
            this.bt_fenxing2.Text = "分形树二";
            this.bt_fenxing2.UseVisualStyleBackColor = true;
            this.bt_fenxing2.Click += new System.EventHandler(this.bt_fenxing2_Click);
            // 
            // bt_fenxing1
            // 
            this.bt_fenxing1.Location = new System.Drawing.Point(31, 481);
            this.bt_fenxing1.Margin = new System.Windows.Forms.Padding(4);
            this.bt_fenxing1.Name = "bt_fenxing1";
            this.bt_fenxing1.Size = new System.Drawing.Size(127, 45);
            this.bt_fenxing1.TabIndex = 13;
            this.bt_fenxing1.Text = "分形树一";
            this.bt_fenxing1.UseVisualStyleBackColor = true;
            this.bt_fenxing1.Click += new System.EventHandler(this.bt_fenxing1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 479);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 47);
            this.button1.TabIndex = 12;
            this.button1.Text = "默认值";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 22);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 25);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "2";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(20, 266);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(237, 194);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "树枝";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(103, 151);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(125, 25);
            this.textBox9.TabIndex = 15;
            this.textBox9.Text = "45";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(103, 116);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(125, 25);
            this.textBox8.TabIndex = 14;
            this.textBox8.Text = "0.66";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(103, 74);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(125, 25);
            this.textBox7.TabIndex = 13;
            this.textBox7.Text = "45";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(103, 32);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(125, 25);
            this.textBox6.TabIndex = 12;
            this.textBox6.Text = "0.66";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "左长度比";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "左枝倾角";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 151);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "右枝倾角";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "右长度比";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(20, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(237, 196);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "树干";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(103, 160);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(125, 25);
            this.textBox5.TabIndex = 15;
            this.textBox5.Text = "100";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(103, 116);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 25);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "90";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(103, 66);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 25);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "150";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 31);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 25);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "12";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "树的层数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "树干长度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "树干倾角";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "起点高度";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "树线宽度";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(802, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 40);
            this.button2.TabIndex = 11;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bt_deep
            // 
            this.bt_deep.Location = new System.Drawing.Point(563, 66);
            this.bt_deep.Name = "bt_deep";
            this.bt_deep.Size = new System.Drawing.Size(159, 38);
            this.bt_deep.TabIndex = 13;
            this.bt_deep.Text = "求深度/结点数";
            this.bt_deep.UseVisualStyleBackColor = true;
            this.bt_deep.Click += new System.EventHandler(this.bt_deep_Click);
            // 
            // tb_deep
            // 
            this.tb_deep.Location = new System.Drawing.Point(564, 26);
            this.tb_deep.Name = "tb_deep";
            this.tb_deep.Size = new System.Drawing.Size(159, 25);
            this.tb_deep.TabIndex = 12;
            // 
            // button_MakeEmpty
            // 
            this.button_MakeEmpty.Location = new System.Drawing.Point(727, 67);
            this.button_MakeEmpty.Name = "button_MakeEmpty";
            this.button_MakeEmpty.Size = new System.Drawing.Size(113, 36);
            this.button_MakeEmpty.TabIndex = 14;
            this.button_MakeEmpty.Text = "清空二叉树";
            this.button_MakeEmpty.UseVisualStyleBackColor = true;
            this.button_MakeEmpty.Click += new System.EventHandler(this.button_MakeEmpty_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 12F);
            this.button3.Location = new System.Drawing.Point(718, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 37);
            this.button3.TabIndex = 16;
            this.button3.Text = "交换左右子树";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 12F);
            this.button4.Location = new System.Drawing.Point(707, 425);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(202, 83);
            this.button4.TabIndex = 17;
            this.button4.Text = "生成一棵结点数为n的完全二叉树";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 15F);
            this.label10.Location = new System.Drawing.Point(718, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "第八周上机";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(718, 384);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4);
            this.textBox10.Name = "textBox10";
            this.textBox10.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox10.Size = new System.Drawing.Size(125, 25);
            this.textBox10.TabIndex = 19;
            this.textBox10.Text = "10";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 607);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_MakeEmpty);
            this.Controls.Add(this.bt_deep);
            this.Controls.Add(this.tb_deep);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pb_bstree);
            this.Controls.Add(this.rb_back);
            this.Controls.Add(this.rb_mid);
            this.Controls.Add(this.rb_first);
            this.Controls.Add(this.rb_levels);
            this.Controls.Add(this.bt_Traversal);
            this.Controls.Add(this.bt_create2);
            this.Controls.Add(this.bt_create1);
            this.Controls.Add(this.tb_strin2);
            this.Controls.Add(this.tb_strin);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "二叉树_26组";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_bstree)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_strin;
        private System.Windows.Forms.TextBox tb_strin2;
        private System.Windows.Forms.Button bt_create1;
        private System.Windows.Forms.Button bt_create2;
        private System.Windows.Forms.Button bt_Traversal;
        private System.Windows.Forms.RadioButton rb_levels;
        private System.Windows.Forms.RadioButton rb_first;
        private System.Windows.Forms.RadioButton rb_mid;
        private System.Windows.Forms.RadioButton rb_back;
        private System.Windows.Forms.PictureBox pb_bstree;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_fenxing1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_fenxing2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_queue;
        private System.Windows.Forms.Button bt_deep;
        private System.Windows.Forms.TextBox tb_deep;
        private System.Windows.Forms.Button button_MakeEmpty;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox10;
    }
}

