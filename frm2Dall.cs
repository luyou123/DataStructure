﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class frm2Dall : Form
    {
        public frm2Dall()
        {
            InitializeComponent();
            lblminXshow.Text = lblmaxXshow.Text = lblminYshow.Text = lblmaxYshow.Text = "";
            this.listView1.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度               
            g = this.pic1.CreateGraphics();
            pen1 = new Pen(Color.Red, float.Parse(txtorigin.Text));
            pointwidth2 = double.Parse(txtorigin2.Text);
        }
        Bitmap bmp;
        string filename;
        int[] input;
        int[] xx;
        int[] yy;
        int n = 0;
        int minx = 396000000, miny = 115800001, maxx = 407999983, maxy = 116999998;
        int ok = 0;
        Graphics g;
        private Point start = new Point();
        private Point end = new Point();
        private bool blnDraw = false;
        int m = 0, nowm = 0;
        int[] xx1 = new int[1111111];
        int[] yy1 = new int[1111111];
        int[] xx2 = new int[1111111];
        int[] yy2 = new int[1111111];
        int showm = 0;
        PointF[] p;
        double pointwidth, pointwidth2;
        Pen pen1;
        private void btnbrowse_Click(object sender, EventArgs e)
        {
            filename = "";
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filename = dialog.SelectedPath;
            }
            txtfile.Text = filename;
        }


        private void pic1_MouseMove(object sender, MouseEventArgs e)
        {
          
            if (ok == 0) return;
            if (e.X < 10 || e.X > this.pic1.Width - 10)
            {
                this.Cursor = System.Windows.Forms.Cursors.Default;
                return;
            }
            if (e.Y < 10 || e.Y > this.pic1.Height - 10)
            {
                this.Cursor = System.Windows.Forms.Cursors.Default;
                return;
            }
            if (blnDraw)
            {
                g.DrawRectangle(new Pen(pic1.BackColor,1000), 0,0,this.pic1.Width,this.pic1.Height);
                end.X = e.X;
                end.Y = e.Y;
                g.DrawRectangle(new Pen(Color.Blue,(float)pointwidth2), start.X, start.Y, end.X - start.X, end.Y - start.Y);
            }
            if (e.X >= 10 && e.X <= this.pic1.Width - 10 && e.Y >= 10 && e.Y <= this.pic1.Height - 10)
            {
                this.Cursor = System.Windows.Forms.Cursors.Cross;
                double t1 = Convert.ToDouble(e.X - 10) / Convert.ToDouble(this.pic1.Width - 20);
                double t2 = Convert.ToDouble(e.Y - 10) / Convert.ToDouble(this.pic1.Height - 20);
                t1 = t1 * (maxx - minx) + minx;
                t1 = t1 / 10000000.0;
                t2 = t2 * (maxy - miny) + miny;
                t2 = t2 / 1000000.0;
                lblxy.Text = "(" + Convert.ToString(t1) + "  ,  " + Convert.ToString(t2) + ")";
            }
            else
            {
                this.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }

        private void pic1_MouseDown(object sender, MouseEventArgs e)
        {
            repaint1(this.pic1.BackColor);
            if (ok == 0) return;
            if (e.X < 10 || e.X > this.pic1.Width - 10) return;
            if (e.Y < 10 || e.Y > this.pic1.Height - 10) return;
            g = this.pic1.CreateGraphics();
            if (nowm != 0) repaint1(this.pic1.BackColor);
            g.DrawRectangle(new Pen(pic1.BackColor, 1000), start.X, start.Y, end.X - start.X, end.Y - start.Y);
            start.X = e.X;
            start.Y = e.Y;
            end.X = e.X;
            end.Y = e.Y;
            blnDraw = true;
        }

        private void pic1_MouseUp(object sender, MouseEventArgs e)
        {
            repaint1(this.pic1.BackColor);
            if (ok == 0) return;
            if (e.X < 10 || e.X > this.pic1.Width - 10) return;
            if (e.Y < 10 || e.Y > this.pic1.Height - 10) return;
            g.DrawRectangle(new Pen(Color.Blue, (float)pointwidth2),  start.X, start.Y, e.X - start.X, e.Y - start.Y);
            double tt1 = Convert.ToDouble(start.X - 10) / Convert.ToDouble(this.pic1.Width - 20);
            double tt2 = Convert.ToDouble(start.Y - 10) / Convert.ToDouble(this.pic1.Height - 20);
            tt1 = tt1 * (maxx - minx) + minx;
            tt1 = tt1 / 10000000.0;
            tt2 = tt2 * (maxy - miny) + miny;
            tt2 = tt2 / 1000000.0;
            txtx1.Text = Convert.ToString(tt1);
            txty1.Text = Convert.ToString(tt2);
            tt1 = Convert.ToDouble(e.X - 10) / Convert.ToDouble(this.pic1.Width - 20);
            tt2 = Convert.ToDouble(e.Y - 10) / Convert.ToDouble(this.pic1.Height - 20);
            tt1 = tt1 * (maxx - minx) + minx;
            tt1 = tt1 / 10000000.0;
            tt2 = tt2 * (maxy - miny) + miny;
            tt2 = tt2 / 1000000.0;
            txtx2.Text = Convert.ToString(tt1);
            txty2.Text = Convert.ToString(tt2);
            blnDraw = false;
            //doit();
            btnopen1_Click(sender, e);
        }

        public void repaint1(Color col)
        {
            double t1 = Convert.ToDouble(xx1[nowm] - minx) / Convert.ToDouble(maxx - minx);
            t1 = t1 * (this.pic1.Width - 20);
            double t2 = Convert.ToDouble(yy1[nowm] - miny) / Convert.ToDouble(maxy - miny);
            t2 = t2 * (this.pic1.Height - 20);
            double t3 = Convert.ToDouble(xx2[nowm] - minx) / Convert.ToDouble(maxx - minx);
            t3 = t3 * (this.pic1.Width - 20);
            double t4 = Convert.ToDouble(yy2[nowm] - miny) / Convert.ToDouble(maxy - miny);
            t4 = t4 * (this.pic1.Height - 20);
            if (col == Color.Blue) g.DrawRectangle(new Pen(col, (float)pointwidth2), (float)(t1 + 10), (float)(t2 + 10), (float)(t3 - t1), (float)(t4 - t2));
            else g.DrawRectangle(new Pen(col, 1000), 0, 0, this.pic1.Width, this.pic1.Height);       
        }
        public void repaint2(Color col)
        {
            try
            {
                double t1 = Convert.ToDouble(double.Parse(txtx1.Text) * 10000000.0 - minx) / Convert.ToDouble(maxx - minx);
                t1 = t1 * (this.pic1.Width - 20);
                double t2 = Convert.ToDouble(double.Parse(txty1.Text) * 1000000.0 - miny) / Convert.ToDouble(maxy - miny);
                t2 = t2 * (this.pic1.Height - 20);
                double t3 = Convert.ToDouble(double.Parse(txtx2.Text) * 10000000.0 - minx) / Convert.ToDouble(maxx - minx);
                t3 = t3 * (this.pic1.Width - 20);
                double t4 = Convert.ToDouble(double.Parse(txty2.Text) * 1000000.0 - miny) / Convert.ToDouble(maxy - miny);
                t4 = t4 * (this.pic1.Height - 20);
                if (col == Color.Blue) g.DrawRectangle(new Pen(col, (float)pointwidth2), (float)(t1 + 10), (float)(t2 + 10), (float)(t3 - t1), (float)(t4 - t2));
                else g.DrawRectangle(new Pen(col, 1000), 0, 0, this.pic1.Width, this.pic1.Height);
            }
            catch (System.FormatException err)
            {
                return;
            }

        }
        public void doit()
        {
            try
            {
                try
                {
                    g.DrawLines(pen1, p);
                }
                catch(System.ArgumentException err)
                {
                    return;
                }                
            }
            catch(System.ArgumentNullException err)
            {
                return;
            }            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (nowm != 0) repaint1(this.pic1.BackColor);
                    m++;
                    nowm = m;
                    txtnow.Text = Convert.ToString(nowm);
                    lblgang.Text = "/" + Convert.ToString(m);
                }
                catch (OverflowException err2)
                {
                    return;
                }
            }
            catch (System.FormatException err)
            {
                return;
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (m == 0 || nowm == 0) return;
            repaint1(this.pic1.BackColor);
            for (int i = nowm; i < m; i++)
            {
                xx1[i] = xx1[i + 1];
                xx2[i] = xx2[i + 1];
                yy1[i] = yy1[i + 1];
                yy2[i] = yy2[i + 1];
            }
            if (nowm == m) { nowm--; txtnow.Text = Convert.ToString(nowm); }
            m--;
            if (m == 0) nowm = 0;
            lblgang.Text = "/" + Convert.ToString(m);
            if (m != 0) repaint1(Color.Blue);
            //doit();
        }

        private void txtnow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (nowm != 0) repaint1(this.pic1.BackColor);
                    nowm = int.Parse(txtnow.Text);
                    if (nowm < 1 || nowm > m) return;
                    repaint1(Color.Blue);
                    //doit();
                }
                catch (System.FormatException err)
                {
                    return;
                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (nowm == 0) return;
            double x1 = double.Parse(txtx1.Text);
            double x2 = double.Parse(txtx2.Text);
            double y1 = double.Parse(txty1.Text);
            double y2 = double.Parse(txty2.Text);
            x1 = x1 * 10000000.0;
            x2 = x2 * 10000000.0;
            y1 = y1 * 1000000.0;
            y2 = y2 * 1000000.0;
            if ((int)x1 < minx || (int)x1 > maxx || (int)x2 < minx || (int)x2 > maxx || (int)y1 < miny || (int)y1 > maxy || (int)y2 < miny || (int)y2 > maxy) return;
            if ((int)x1 > (int)x2 || (int)y1 > (int)y2) return;
            xx1[nowm] = (int)x1;
            xx2[nowm] = (int)x2;
            yy1[nowm] = (int)y1;
            yy2[nowm] = (int)y2;
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            if (nowm != 0) repaint1(this.pic1.BackColor);
            if (m == 0) return;
            if (nowm != 0) repaint1(this.pic1.BackColor);
            nowm = 1;
            repaint1(Color.Blue);
            txtnow.Text = "1";
            double tmp = Convert.ToDouble(xx1[1]) / Convert.ToDouble(10000000.0);
            txtx1.Text = Convert.ToString(tmp);
            tmp = Convert.ToDouble(xx2[1]) / Convert.ToDouble(10000000.0);
            txtx2.Text = Convert.ToString(tmp);
            tmp = Convert.ToDouble(yy1[1]) / Convert.ToDouble(1000000.0);
            txty1.Text = Convert.ToString(tmp);
            tmp = Convert.ToDouble(yy2[1]) / Convert.ToDouble(1000000.0);
            txty2.Text = Convert.ToString(tmp);
            //doit();
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            if (nowm != 0) repaint1(this.pic1.BackColor);
            if (m == 0) return;
            if (nowm != 0) repaint1(this.pic1.BackColor);
            nowm = m;
            repaint1(Color.Blue);
            txtnow.Text = Convert.ToString(m);
            double tmp = Convert.ToDouble(xx1[m]) / Convert.ToDouble(10000000.0);
            txtx1.Text = Convert.ToString(tmp);
            tmp = Convert.ToDouble(xx2[m]) / Convert.ToDouble(10000000.0);
            txtx2.Text = Convert.ToString(tmp);
            tmp = Convert.ToDouble(yy1[m]) / Convert.ToDouble(1000000.0);
            txty1.Text = Convert.ToString(tmp);
            tmp = Convert.ToDouble(yy2[m]) / Convert.ToDouble(1000000.0);
            txty2.Text = Convert.ToString(tmp);
            //doit();
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            if (nowm != 0) repaint1(this.pic1.BackColor);
            if (m == 0 || nowm == 1) return;
            if (nowm != 0) repaint1(this.pic1.BackColor);
            nowm = nowm - 1;
            repaint1(Color.Blue);
            txtnow.Text = Convert.ToString(nowm);
            double tmp = Convert.ToDouble(xx1[nowm]) / Convert.ToDouble(10000000.0);
            txtx1.Text = Convert.ToString(tmp);
            tmp = Convert.ToDouble(xx2[nowm]) / Convert.ToDouble(10000000.0);
            txtx2.Text = Convert.ToString(tmp);
            tmp = Convert.ToDouble(yy1[nowm]) / Convert.ToDouble(1000000.0);
            txty1.Text = Convert.ToString(tmp);
            tmp = Convert.ToDouble(yy2[nowm]) / Convert.ToDouble(1000000.0);
            txty2.Text = Convert.ToString(tmp);
            //doit();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (nowm != 0) repaint1(this.pic1.BackColor);
            if (m == 0 || nowm == m) return;
            if (nowm != 0) repaint1(this.pic1.BackColor);
            nowm = nowm + 1;
            repaint1(Color.Blue);
            txtnow.Text = Convert.ToString(nowm);
            double tmp = Convert.ToDouble(xx1[nowm]) / Convert.ToDouble(10000000.0);
            txtx1.Text = Convert.ToString(tmp);
            tmp = Convert.ToDouble(xx2[nowm]) / Convert.ToDouble(10000000.0);
            txtx2.Text = Convert.ToString(tmp);
            tmp = Convert.ToDouble(yy1[nowm]) / Convert.ToDouble(1000000.0);
            txty1.Text = Convert.ToString(tmp);
            tmp = Convert.ToDouble(yy2[nowm]) / Convert.ToDouble(1000000.0);
            txty2.Text = Convert.ToString(tmp);
            //doit();
        }

        private void btnoutput_Click(object sender, EventArgs e)
        {
            if (m == 0) return;
            string path = filename + "\\" + "query.in";
            for (int i = 1; i <= m; i++)
            {
                if (xx1[i] == 0 || xx2[i] == 0 || yy1[i] == 0 || yy2[i] == 0 || xx1[i] > xx2[i] || yy1[i] > yy2[i]) return;
            }
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(Convert.ToString(m));
                for (int i = 1; i <= m; i++)
                {
                    sw.WriteLine(Convert.ToString(xx1[i]) + " " + Convert.ToString(yy1[i]) + " " + Convert.ToString(xx2[i]) + " " + Convert.ToString(yy2[i]));
                }
                sw.Close();
            }            
        }

        private void btncall_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo();
            //设置外部程序名 
            Info.FileName = "prerangetreeall.exe";
            if (txtfile.Text != "") Info.WorkingDirectory = txtfile.Text;
            //声明一个程序类   
            System.Diagnostics.Process Proc;
            try
            {
                //启动外部程序 
                Proc = System.Diagnostics.Process.Start(Info);
            }
            catch (System.ComponentModel.Win32Exception err)
            {
                return;
            }
        }

    
        private void btndisplay_Click(object sender, EventArgs e)
        {
            try
            {
                string filename2 = filename + "\\" + "2.out";
                System.IO.StreamReader reader = new System.IO.StreamReader(filename2, System.Text.Encoding.Default);
                int i = 0;
                this.listView1.Items.Clear();
                while (!reader.EndOfStream)
                {
                    i++;
                    string s1 = reader.ReadLine();
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = Convert.ToString(i);
                    lvi.SubItems.Add(s1);
                    this.listView1.Items.Add(lvi);
                }
                showm = i;
                reader.Close();
            }
            catch (System.IO.FileNotFoundException)
            {
                return;
            }
        }

        private void txtchoose_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int nownum = int.Parse(txtchoose.Text);
                    if (nownum < 1 || nownum > showm) return;
                    MessageBox.Show(this.listView1.Items[nownum - 1].SubItems[1].ToString());
                    this.listView1.Items[nownum - 1].Focused = true;
                    this.listView1.Items[nownum - 1].Selected = true;
                }
                catch (System.FormatException err)
                {
                    return;
                }
            }
        }

        private void txtfile_TextChanged(object sender, EventArgs e)
        {
            filename = txtfile.Text;
        }

        private void btnrand_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo();
            //设置外部程序名 
            Info.FileName = "gendata.exe";
            if (txtfile.Text != "") Info.WorkingDirectory = txtfile.Text;
            //声明一个程序类   
            System.Diagnostics.Process Proc;
            try
            {
                //启动外部程序 
                Proc = System.Diagnostics.Process.Start(Info);
            }
            catch (System.ComponentModel.Win32Exception err)
            {
                return;
            }
        }

        public void paintit()
        {
            for (int i = 1; i <= m; i++) xx1[i] = xx2[i] = yy1[i] = yy2[i] = 0;
            filename = txtfile.Text;
            
            //g.Clear(this.pic1.BackColor);

            for (int u = down; u <= up;u++ )
            {
                string filename2 = filename + "\\" + Convert.ToString(u) + ".in";
                int cont = 0;
                try
                {             
                    System.IO.StreamReader reader = new System.IO.StreamReader(filename2, System.Text.Encoding.Default);
                    n = Convert.ToInt32(reader.ReadLine());
                    xx = new int[n + 1];
                    yy = new int[n + 1];
                    p = new PointF[n];
                    for (int i = 1; i <= n; i++)
                    {
                        input = reader.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => int.Parse(x.Trim())).ToArray();
                        xx[i] = input[0];
                        yy[i] = input[1];

                        if (xx[i] < minx) { cont = 1; break; }
                        if (xx[i] > maxx) { cont = 1; break; }
                        if (yy[i] < miny) { cont = 1; break; }
                        if (yy[i] > maxy) { cont = 1; break; }
                    }
                    if (cont == 1 || n == 1 || n == 0) continue;
                    for (int i = 1; i <= n - 1; i++)
                    {
                        double tt1 = Convert.ToDouble(xx[i] - minx) / Convert.ToDouble(maxx - minx);
                        tt1 = tt1 * (this.pic1.Width - 20);
                        double tt2 = Convert.ToDouble(yy[i] - miny) / Convert.ToDouble(maxy - miny);
                        tt2 = tt2 * (this.pic1.Height - 20);
                        double tt3 = Convert.ToDouble(xx[i + 1] - minx) / Convert.ToDouble(maxx - minx);
                        tt3 = tt3 * (this.pic1.Width - 20);
                        double tt4 = Convert.ToDouble(yy[i + 1] - miny) / Convert.ToDouble(maxy - miny);
                        tt4 = tt4 * (this.pic1.Height - 20);
                        p[i - 1].X = (float)(tt1 + 10); p[i - 1].Y = (float)(tt2 + 10);
                        p[i].X = (float)(tt3 + 10); p[i].Y = (float)(tt4 + 10);
                    }
                    reader.Close();
                    lblminXshow.Text = Convert.ToString(Convert.ToDouble(minx / 10000000.0));
                    lblmaxXshow.Text = Convert.ToString(Convert.ToDouble(maxx / 10000000.0));
                    lblminYshow.Text = Convert.ToString(Convert.ToDouble(miny / 1000000.0));
                    lblmaxYshow.Text = Convert.ToString(Convert.ToDouble(maxy / 1000000.0));
                }
                catch (System.IO.FileNotFoundException err)
                {
                    return;
                }
                doit();
                ok = 1;

            }
        }
        int down = 0, up = 0;

        private void btnopen1_Click(object sender, EventArgs e)
        {
            down = 1;
            up = 3000;
            paintit();

        }

        private void btnopen2_Click(object sender, EventArgs e)
        {
            down = 3001;
            up = 5000;
            paintit();
        }

        private void btnopen3_Click(object sender, EventArgs e)
        {
            down = 5001;
            up = 7000;
            paintit();
        }

        private void btnopen4_Click(object sender, EventArgs e)
        {
            down = 7001;
            up = 9000;
            paintit();
        }

        private void btnopen5_Click(object sender, EventArgs e)
        {
            down = 9001;
            up = 10000;
            paintit();
        }

        private void btnopen6_Click(object sender, EventArgs e)
        {
            down = 10001;
            up = 11000; 
            paintit();
        }

        private void btnopen7_Click(object sender, EventArgs e)
        {
            down = 11001;
            up = 12000;
            paintit();
        }

        private void btnopen8_Click(object sender, EventArgs e)
        {
            down = 12001;
            up = 13000;
            paintit();
        }

        private void btnopen9_Click(object sender, EventArgs e)
        {
            down = 13001;
            up = 14000;
            paintit();
        }

        private void btnopen10_Click(object sender, EventArgs e)
        {
            down = 14001;
            up = 15000;
            paintit();
        }

        private void btnopen11_Click(object sender, EventArgs e)
        {
            down = 15001;
            up = 16000;
            paintit();
        }

        private void btnopen12_Click(object sender, EventArgs e)
        {
            down = 16001;
            up = 17000;
            paintit();
        }


        private void btnopen13_Click(object sender, EventArgs e)
        {
            down = 17001;
            up = 18000;
            paintit();
        }

        private void btnopen14_Click(object sender, EventArgs e)
        {
            down = 17001;
            up = 18507;
            paintit();
            
        }

        private void frm2Dall_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X >= pic1.Left + 10 && e.X <= pic1.Left + pic1.Width - 10 && e.Y >= pic1.Top + 10 && e.Y <= pic1.Top + pic1.Height - 10)
                return;
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void txtx1_TextChanged(object sender, EventArgs e)
        {
            if (m == 0) return;
            if (nowm != 0) repaint1(this.pic1.BackColor);
            //btnsave_Click(sender, e);
            repaint2(Color.Blue);
            //doit();
        }

        private void txty1_TextChanged(object sender, EventArgs e)
        {
            if (m == 0) return;
            if (nowm != 0) repaint1(this.pic1.BackColor);
            //btnsave_Click(sender, e);
            repaint2(Color.Blue);
            //doit();
        }

        private void txtorigin_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pointwidth = double.Parse(txtorigin.Text);
                pen1 = new Pen(Color.Red, (float)pointwidth);
            }
            catch (System.FormatException err)
            {
                return;
            }

        }

        private void txtorigin2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pointwidth2 = double.Parse(txtorigin2.Text);
            }
            catch (System.FormatException err)
            {
                return;
            }
        }

        private void txtx2_TextChanged(object sender, EventArgs e)
        {
            if (m == 0) return;
            if (nowm != 0) repaint1(this.pic1.BackColor);
            //btnsave_Click(sender, e);
            repaint2(Color.Blue);
            //doit();
        }

        private void txty2_TextChanged(object sender, EventArgs e)
        {
            if (m == 0) return;
            if (nowm != 0) repaint1(this.pic1.BackColor);
            //btnsave_Click(sender, e);
            repaint2(Color.Blue);
            //doit();
        }
     

        private void btnclear_Click(object sender, EventArgs e)
        {
            m = 0;
            nowm = 0;
            txtx1.Text = txtx2.Text = txty1.Text = txty2.Text = txtnow.Text = "";
            lblgang.Text = "/0";
        }
    
    }
}
