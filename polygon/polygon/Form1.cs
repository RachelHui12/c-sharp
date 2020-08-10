using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using polygon;
namespace polygon
{
    //鼠标画多边形，并判断凹凸型
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point[] points = new Point[100];
        List<Point> pt1 = new List<Point>();
        List<Point> pt2 = new List<Point>();
        int num1 = 0,num2=0;
        Point mouseLocation;
        bool flag = false;
        Graphics g;
        polygon polygon1, polygon2;
        int type = 0;
        bool position = false;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            if (flag && type==1)
            {
                num1++;
                pt1.Add(this.mouseLocation);
                if (num1 > 1)
                    g.DrawLine(Pens.Black, pt1[num1 - 2], pt1[num1 - 1]);
            }
            if (flag && type == 2)
            {
                num2++;
                pt2.Add(this.mouseLocation);
                if (num2 > 1)
                    g.DrawLine(Pens.Black, pt2[num2 - 2], pt2[num2 - 1]);
            }
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //两种写法
             g = pictureBox1.CreateGraphics();
             //g = e.Graphics;
             pictureBox1.BackColor= Color.White;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            this.mouseLocation = e.Location;
        }




        private void area_click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                MessageBox.Show("多边形还未画完!");
                return;
            }
            if(type==1)
            {
                if (polygon1.isvalid())
                {
                    double area = polygon1.calculate_area();
                    MessageBox.Show("面积为：" + area.ToString());
                }
                else
                    MessageBox.Show("请输入正确的多边形!");
            }
            if (type == 2)
            {
                if (polygon2.isvalid())
                {
                    double area = polygon2.calculate_area();
                    MessageBox.Show("面积为：" + area.ToString());
                }
                else
                    MessageBox.Show("请输入正确的多边形!");
            }

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //右键结束画多边形
            if(e.Button == MouseButtons.Right && type==1)
            {
                polygon1 = new polygon(pt1, num1);
                if(polygon1.isvalid())
                {
                    flag = false;
                    g.DrawLine(Pens.Black, pt1[num1-1], pt1[0]);
                }
                else
                    MessageBox.Show("请输入正确的多边形!");
            }
            if (e.Button == MouseButtons.Right && type == 2)
            {
                polygon2 = new polygon(pt2, num2);
                if (polygon2.isvalid())
                {
                    flag = false;
                    g.DrawLine(Pens.Black, pt2[num2 - 1], pt2[0]);
                }
                else
                    MessageBox.Show("请输入正确的多边形!");
            }
            if (e.Button == MouseButtons.Left && position)
            {

                int re = 0;
                if(polygon1.isvalid())
                {
                    re = polygon1.getposition(e.Location);
                    if (re == 0)
                        MessageBox.Show("点在多边形1上");
                    else if(re==-1)
                        MessageBox.Show("点在多边形1内");
                    else
                        MessageBox.Show("点在多边形1外");

                }
                //if (polygon2.isvalid())
                //{
                //    re = polygon2.getposition(e.Location);
                //}
            }
        }

        private void polygon1_click(object sender, EventArgs e)
        {
            flag = true;
            type = 1;
            num1 = 0;
            pt1.Clear();
        }

        private void polygon2_click(object sender, EventArgs e)
        {
            flag = true;
            type = 2;
            num2 = 0;
            pt2.Clear();
        }

        private void fill_color_click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                MessageBox.Show("多边形还未画完!");
                return;
            }
            if (type == 1)
            {
                if (polygon1.isvalid())
                {
                    g.FillPolygon(Brushes.Blue, pt1.ToArray());
                }
                else
                {
                    MessageBox.Show("请输入正确的多边形!");
                }
            }
            if (type == 2)
            {
                if (polygon2.isvalid())
                {
                    g.FillPolygon(Brushes.Blue, pt2.ToArray());
                }
                else
                {
                    MessageBox.Show("请输入正确的多边形!");
                }
            }
        }

        private void location_click(object sender, EventArgs e)
        {
            //点击一个点，判断点在多边形里面还是外面
            position = true;
        }

        //多边形凹凸性
        private void Convexity(object sender, EventArgs e)
        {
            //判断凹凸性
            if(flag==true)
            {
                MessageBox.Show("多边形还未画完!");
                return;
            }
            if (type==1 )
            {
                if(polygon1.isvalid())
                {
                    if(polygon1.cal_Convexity())
                        MessageBox.Show("凹多边形");
                    else
                        MessageBox.Show("凸多边形");

                }
                else
                {
                    MessageBox.Show("请输入正确的多边形!");
                }
            }
            if (type == 2)
            {
                if (polygon2.isvalid())
                {
                    if (polygon2.cal_Convexity())
                        MessageBox.Show("凹多边形");
                    else
                        MessageBox.Show("凸多边形");

                }
                else
                {
                    MessageBox.Show("请输入正确的多边形!");
                }
            }

        }
        //清除画布
        private void clear_click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            type = 0;
            //polygon1.num = 0;
            //polygon2.num = 0;
            //polygon1.pt.Clear();
            //polygon2.pt.Clear();
        }
    }
}
