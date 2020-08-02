using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 数字华容道
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //定义
        const int N = 4;
        //创建按钮
        Button[,] buttons = new Button[N , N];

        private void start_click(object sender, EventArgs e)
        {
            shuffle();
        }
        void shuffle()
        {
            //打乱顺序
            Random rdm = new Random();
            for(int i=0;i<100;i++)
            {
                int a = rdm.Next(N);
                int b = rdm.Next(N);
                int c = rdm.Next(N);
                int d = rdm.Next(N);
                Swap(buttons[a, b], buttons[c, d]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //初始化按钮
            Generateallbuttons();
        }

        void Generateallbuttons()
        {
            //x0,y0表示第一个按钮初始的位置，w表示按钮的宽度，d表示间隙
            int x0 = 100, y0 = 10, w = 45, d = 50;
            for (int r = 0; r < N; r++)
                for (int c = 0; c < N; c++)
                {
                    //Num+1表示按钮显示的文字
                    int num = r * N + c;
                    Button btn = new Button();
                    btn.Text = (num + 1).ToString();
                    btn.Top = y0 + r * d;
                    btn.Left = x0 + c * d;
                    btn.Width = w;
                    btn.Height = w;
                    btn.Visible = true;
                    btn.Tag = r * N + c; //这个数据用来表示它所在行列位置

                    //注册事件
                    btn.Click += Btn_Click;

                    buttons[r, c] = btn; //放到数组中
                    this.Controls.Add(btn); //加到界面上
                }
            buttons[N - 1, N - 1].Visible = false; //最后一个不可见
        }

        //按钮点击，如果周围有空白就交换，没有就无
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;//获取当前点中的那个按钮
            Button blank = FindHiddenButton();
            //判断这两个是否相邻
            if(isNeibor(btn,blank))
            {
                Swap(btn, blank);
                blank.Focus();//光标focus到这个空白按钮
            }
            if(ResultOK())
            {
                MessageBox.Show("已完成");
            }
        }
        Button FindHiddenButton()
        {
            for(int i=0;i<N;i++)
            {
                for(int j=0;j<N;j++)
                {
                    if (buttons[i, j].Visible == false)
                        return buttons[i, j];
                }
            }
            return null;
        }
        bool isNeibor(Button b1,Button b2)
        {
            int a =(int) b1.Tag;
            int b =(int) b2.Tag;
            //获取两个按钮的行列号
            int r1 = a / N, c1 = a % N;
            int r2 = b / N, c2 = b % N;

            if ((r1 == r2 && (c1 == (c2 + 1) || (c1 == (c2 - 1)))) ||
                (c1 == c2 && (r1 == (r2 + 1) || (r1 == (r2 - 1)))))
                return true;
            return false;
        }
        void Swap(Button b1, Button b2)
        {
            string s = b1.Text;
            b1.Text = b2.Text;
            b2.Text = s;

            bool v = b1.Visible;
            b1.Visible = b2.Visible;
            b2.Visible = v;
        }
        bool ResultOK()
        {
            for (int i = 0; i < N;i++)
                for(int j=0;j<N;j++)
                {
                    if (buttons[i, j].Text != ((int)buttons[i, j].Tag + 1).ToString())
                        return false;
                }
            return true;
        }
    }
}
