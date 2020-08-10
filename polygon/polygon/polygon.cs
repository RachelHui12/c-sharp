using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace polygon
{
    class polygon
    {
        public List<Point> pt;
        public int num;
        public polygon(List<Point> points,int n)
        {
            this.pt = points;
            this.num = n;
        }
        //判断多边形是否正确
        public bool isvalid()
        {
            //至少三个顶点
            if (num < 3)
                return false;
            //判断多边形是否相交
            for(int i=0;i<num-2;i++)
            {
                for(int j=i+2;j<num;j++)
                {
                    if (i == 0 && j == num - 1)
                        continue;
                    if (ifintersect(pt[i], pt[i + 1], pt[j], pt[(j + 1)%num]))
                        return false;
                }
            }
            return true;
        }
        public bool ifintersect(Point p1,Point p2,Point p3,Point p4)
        {
            //求两条线段的交点
            //求k,b
            double k1 = (double)(p2.Y - p1.Y) / (p2.X - p1.X);
            double k2 = (double)(p3.Y - p4.Y) / (p3.X - p4.X);
            double b1 = p1.Y - k1 * p1.X;
            double b2 = p3.Y - k2 * p3.X;
            double delta_x = (b2 - b1) / (k1 - k2);
            double delta_y = delta_x * k2 + b2;
            if (delta_y > Math.Min(p3.Y, p4.Y) && delta_y < Math.Max(p3.Y, p4.Y))
                return true;
            else
                return false;
        }
        public void drawpolygon(Graphics g,Pen p)
        {
            g.DrawPolygon(p,pt.ToArray());
        }
        //计算多边形面积
        public double calculate_area()
        {
            double area = 0.0;
            for (int i = 0; i < num; i++)
            {
                area += (pt[i].X * pt[(i + 1)%num].Y - pt[i].Y * pt[(i + 1) % num].X);
            }
            return Math.Abs(area / 2);
        }
        public bool cal_Convexity()
        {

            //想法1：向量点乘计算夹角，夹角相加等于(n-2)*180就是对的
            //想法2：向量叉乘，变成一个个三角形面积相加
            double area, last_area = 0.0;
            for (int i = 0; i < num; i++)
            {
                int x1 = pt[i].X;
                int y1 = pt[i].Y;
                int x2 = pt[(i + 1) % num].X;
                int y2 = pt[(i + 1) % num].Y;
                int x3 = pt[(i + 2) % num].X;
                int y3 = pt[(i + 2) % num].Y;
                area = x1 * y2 + x2 * y3 + x3 * y1 - x1 * y3 - x2 * y1 - x3 * y2;
                if ((area * last_area) < 0)
                    return true;
                last_area = area;
            }
            return false;
        }

        public int getposition(Point p)
        {
            //水平射线法
            //正常情况与多边形的交点为偶数的话在多边形外，奇数的话在多边形内
            //特殊情况1：点为多边形顶点，点在多边形上
            //特殊情况2：射线经过多边形
            bool flag = true;
            for(int i=0;i<num;i++)
            {
                //点为多边形顶点
                if ((p == pt[i]) || (p == pt[(i + 1)%num]))
                    return 0;
                else if((p.Y>=pt[i].Y && p.Y<pt[(i+1)%num].Y) || (p.Y >= pt[(i + 1) % num].Y && p.Y < pt[i].Y))
                {
                    //如何线段不是都在
                    double x = (double)(pt[i].X - pt[(i + 1) % num].X) * (p.Y - pt[i].Y) / (pt[i].Y - pt[(i + 1) % num].Y) + pt[i].X;
                    if (Math.Abs(x - p.X) < 1e-4)
                        return 0;
                    if (x > p.X)
                        flag = !flag;
                }
            }
            return flag ? 1 : -1;
        }
    }
}
