using System;
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
    public partial class frmrange : Form
    {
        public frmrange()
        {
            InitializeComponent();
            lblminXshow.Text = lblmaxXshow.Text = lblminYshow.Text = lblmaxYshow.Text = "";
            this.listView1.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度 
            g = this.pic1.CreateGraphics();
        }
        string filename;
        double[] input;
        int[] input2;
        int n = 0;
        int minxx = 396000000, minyy = 115800001, maxxx = 407999983, maxyy = 116999998;
        int minx = 0x7FFFFFFF, miny = 0x7FFFFFFF, maxx = 0, maxy = 0;
        Graphics g;        
        int m = 0, nowm = 0;
        int[] xx = new int[1111111];
        int[] yy = new int[1111111];
        double[] distance = new double[1111111];
        int[] xx1 = new int[1111111];
        int[] yy1 = new int[1111111];
        int[] xx2 = new int[1111111];
        int[] yy2 = new int[1111111];        
        int showm = 0;
        int nowshow = 0;
        int spx, spy;
        int ok = 0;
        PointF start,end;
        int nomove = 0;
        double nowrange=0.0;
        double pointwidth = 5.0;
        double pointwidth2 = 2.0;
        double pointwidthc = 4.0;
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
            if (nomove == 1) return;
            if (e.X >= 10 && e.X <= this.pic1.Width - 10 && e.Y >= 10 && e.Y <= this.pic1.Height - 10)
            {
                this.Cursor = System.Windows.Forms.Cursors.Cross;
                double t1 = Convert.ToDouble(e.X - 10) / Convert.ToDouble(this.pic1.Width - 20);
                double t2 = Convert.ToDouble(e.Y - 10) / Convert.ToDouble(this.pic1.Height - 20);
                t1 = t1 * (maxx - minx) + minx;
                t1 = t1 / 10000000.0;
                t2 = t2 * (maxy - miny) + miny;
                t2 = t2 / 1000000.0;
                txtx2.Text = Convert.ToString(t1);
                txty2.Text = Convert.ToString(t2);
                lblxy.Text = "(" + Convert.ToString(t1) + "  ,  " + Convert.ToString(t2) + ")";
                double dist = Math.Sqrt(Math.Pow(end.X - start.X, 2) + Math.Pow(end.Y - start.Y, 2));
                Pen pen0 = new Pen(pic1.BackColor, (float)pointwidthc);
                g.DrawEllipse(pen0, (float)(start.X - dist), (float)(start.Y - dist), (float)(2 * dist), (float)(2 * dist));                
                t1 = (e.X - start.X) / Convert.ToDouble(this.pic1.Width - 20);
                t1 = t1 * (maxx - minx) ;
                t1 = t1 / 10000000.0;
                t2 = (e.Y - start.Y) / Convert.ToDouble(this.pic1.Height - 20);
                t2 = t2 * (maxy - miny);
                t2 = t2 / 1000000.0;
                dist = Math.Sqrt(Math.Pow(t1, 2) + Math.Pow(t2, 2));
                txtradius.Text = Convert.ToString(dist);
                Pen pen1 = new Pen(Color.DarkBlue, (float)pointwidthc);
                dist = Math.Sqrt(Math.Pow(e.X - start.X, 2) + Math.Pow(e.Y - start.Y, 2));
                g.DrawEllipse(pen1, (float)(start.X - dist),(float)(start.Y - dist), (float)(2 * dist), (float)(2 * dist));
                end.X = e.X;
                end.Y = e.Y;                
                g.FillEllipse(Brushes.Red, (float)(start.X - pointwidth), (float)(start.Y - pointwidth), (float)(2*pointwidth),(float)(2*pointwidth));
            }
            else
            {
                this.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }

        private void pic1_MouseDown(object sender, MouseEventArgs e)
        {
            ok = 1;
            nomove = 0;
            repaint1();            
            if (e.X < 10 || e.X > this.pic1.Width - 10) return;
            if (e.Y < 10 || e.Y > this.pic1.Height - 10) return;
            g = this.pic1.CreateGraphics();
            if (nowm != 0) repaint1();
            g.FillEllipse(Brushes.Red, (float)(e.X - pointwidth), (float)(e.Y - pointwidth), (float)(2 * pointwidth), (float)(2 * pointwidth));
            double t1 = Convert.ToDouble(e.X - 10) / Convert.ToDouble(this.pic1.Width - 20);
            double t2 = Convert.ToDouble(e.Y - 10) / Convert.ToDouble(this.pic1.Height - 20);
            t1 = t1 * (maxx - minx) + minx;
            t1 = t1 / 10000000.0;
            t2 = t2 * (maxy - miny) + miny;
            t2 = t2 / 1000000.0;
            txtx1.Text = Convert.ToString(t1);
            txty1.Text = Convert.ToString(t2);
            start.X = e.X;
            start.Y = e.Y;
            end.X = e.X;
            end.Y = e.Y;

        }

        public void repaint1()
        {
            g.Clear(this.pic1.BackColor);            
        }

       
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (nowm != 0) repaint1();
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
            repaint1();
            for (int i = nowm; i < m; i++)
            {
                xx1[i] = xx1[i + 1];                
                yy1[i] = yy1[i + 1];
                xx2[i] = xx2[i + 1];
                yy2[i] = yy2[i + 1];
            }
            if (nowm == m) { nowm--; txtnow.Text = Convert.ToString(nowm); }
            m--;
            if (m == 0) nowm = 0;
            lblgang.Text = "/" + Convert.ToString(m);
            if (m != 0) commondo();       
        }

        private void txtnow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (nowm != 0) repaint1();
                    nowm = int.Parse(txtnow.Text);
                    if (nowm < 1 || nowm > m) return;
                    commondo();
                }
                catch (System.FormatException err)
                {
                    return;
                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (nowm == 0) return;
                double x1 = double.Parse(txtx1.Text);
                double y1 = double.Parse(txty1.Text);
                x1 = x1 * 10000000.0;
                y1 = y1 * 1000000.0;
                if ((int)x1 < minx || (int)x1 > maxx || (int)y1 < miny || (int)y1 > maxy) return;
                xx1[nowm] = (int)x1;
                yy1[nowm] = (int)y1;
                double x2 = double.Parse(txtx2.Text);
                double y2 = double.Parse(txty2.Text);
                x2 = x2 * 10000000.0;
                y2 = y2 * 1000000.0;                
                xx2[nowm] = (int)x2;
                yy2[nowm] = (int)y2; 
            }
            catch (System.FormatException err)
            {
                return;
            }        
        }

        private void commondo()
        {
            double tmp = Convert.ToDouble(xx1[nowm]) / Convert.ToDouble(10000000.0);
            txtx1.Text = Convert.ToString(tmp);
            tmp = Convert.ToDouble(yy1[nowm]) / Convert.ToDouble(1000000.0);
            txty1.Text = Convert.ToString(tmp);
            tmp = Convert.ToDouble(xx2[nowm]) / Convert.ToDouble(10000000.0);
            txtx2.Text = Convert.ToString(tmp);
            tmp = Convert.ToDouble(yy2[nowm]) / Convert.ToDouble(1000000.0);
            txty2.Text = Convert.ToString(tmp);
            double dist = Math.Sqrt(Math.Pow(double.Parse(txtx1.Text) - double.Parse(txtx2.Text), 2) + Math.Pow(double.Parse(txty1.Text) - double.Parse(txty2.Text), 2));
            txtradius.Text = Convert.ToString(dist);

            double t1 = Convert.ToDouble(double.Parse(txtx1.Text) * 10000000.0 - minx) / Convert.ToDouble(maxx - minx);
            t1 = t1 * (this.pic1.Width - 20);
            double t2 = Convert.ToDouble(double.Parse(txty1.Text) * 1000000.0 - miny) / Convert.ToDouble(maxy - miny);
            t2 = t2 * (this.pic1.Height - 20);

            dist = Convert.ToDouble(double.Parse(txtradius.Text) * 10000000.0) / Convert.ToDouble(maxx - minx);
            dist = dist * (this.pic1.Width - 20);
            Pen pen1 = new Pen(Color.DarkBlue, (float)pointwidthc);
            g.DrawEllipse(pen1, (float)(t1 + 10 - dist), (float)(t2 + 10 - dist), (float)(2 * dist), (float)(2 * dist));
            g.FillEllipse(Brushes.Red, (float)(t1 + 10 - pointwidth), (float)(t2 + 10 - pointwidth), (float)(2 * pointwidth), (float)(2 * pointwidth));
        }
        private void btnfirst_Click(object sender, EventArgs e)
        {
            if (m == 0) return;
            if (nowm != 0) repaint1();
            nowm = 1;           
            txtnow.Text = "1";
            commondo();
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            if (m == 0) return;
            if (nowm != 0) repaint1();
            nowm = m;
            commondo();
            txtnow.Text = Convert.ToString(m);
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            if (m == 0 || nowm == 1) return;
            if (nowm != 0) repaint1();
            nowm = nowm - 1;
            commondo();
            txtnow.Text = Convert.ToString(nowm);
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (m == 0 || nowm == m) return;
            if (nowm != 0) repaint1();
            nowm = nowm + 1;
            commondo();
            txtnow.Text = Convert.ToString(nowm);           
        }

        private void btnoutput_Click(object sender, EventArgs e)
        {
            if (m == 0) return;
            string path = filename + "\\" + "query.in";
            for (int i = 1; i <= m; i++)
            {
                if (xx1[i] == 0 || yy1[i] == 0 ) return;
            }
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(Convert.ToString(m));
                for (int i = 1; i <= m; i++)
                {
                    double tmpx1 = Convert.ToDouble(xx1[i]) / Convert.ToDouble(10000000.0);                    
                    double tmpy1 = Convert.ToDouble(yy1[i]) / Convert.ToDouble(1000000.0);                    
                    double tmpx2 = Convert.ToDouble(xx2[i]) / Convert.ToDouble(10000000.0);                    
                    double tmpy2 = Convert.ToDouble(yy2[i]) / Convert.ToDouble(1000000.0);                    
                    double dist = Math.Sqrt(Math.Pow(tmpx1 - tmpx2, 2) + Math.Pow(tmpy1 - tmpy2, 2));                   
                    sw.WriteLine(Convert.ToString(dist)+" "+Convert.ToString(xx1[i]) + " " + Convert.ToString(yy1[i]));
                }
                sw.Close();
            }            

        }

        private void btncall_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo();
            //设置外部程序名 
            Info.FileName = "kdtreerange.exe";
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
        

        private void txtfile_TextChanged(object sender, EventArgs e)
        {
            filename = txtfile.Text;
        }

        private void btnrand_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo();
            //设置外部程序名 
            Info.FileName = "gen.exe";
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
       

        private void frmrange_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X >= pic1.Left + 10 && e.X <= pic1.Left + pic1.Width - 10 && e.Y >= pic1.Top + 10 && e.Y <= pic1.Top + pic1.Height - 10)
                return;
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }


        private void btndisplay_Click(object sender, EventArgs e)
        {
            try
            {
                string filename2 = filename + "\\" + "2.out";
                System.IO.StreamReader reader = new System.IO.StreamReader(filename2, System.Text.Encoding.Default);
                int nowdone = 0;
                this.listView1.Items.Clear();
                try
                {
                    while (nowdone < int.Parse(txtid.Text))
                    {
                        ++nowdone;
                        n = (int)double.Parse(reader.ReadLine());
                        input = reader.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => double.Parse(x.Trim())).ToArray();
                        spx = (int)input[0];
                        spy = (int)input[1];
                        nowrange = input[2];
                        for (int i = 1; i <= n; i++)
                        {
                            input = reader.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => double.Parse(x.Trim())).ToArray();
                            if (nowdone == int.Parse(txtid.Text))
                            {
                                xx[i] = (int)input[0];
                                yy[i] = (int)input[1];
                                distance[i] = input[2];
                                nowshow = 0;
                                ListViewItem lvi = new ListViewItem();
                                lvi.Text = Convert.ToString(i);
                                lvi.SubItems.Add(Convert.ToString(input[0] / 10000000.0));
                                lvi.SubItems.Add(Convert.ToString(input[1] / 1000000.0));
                                lvi.SubItems.Add(Convert.ToString(input[2]));
                                this.listView1.Items.Add(lvi);
                            }
                        }
                        showm = n;
                        if (nowdone == int.Parse(txtid.Text)) break;
                    }
                    reader.Close();      
                }
                catch (System.ArgumentNullException)
                {
                    return;
                }
                
            }
            catch (System.IO.FileNotFoundException err)
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
                    MessageBox.Show(this.listView1.Items[nownum - 1].SubItems[1].ToString() + "\n" + this.listView1.Items[nownum - 1].SubItems[2].ToString() + "\n" + this.listView1.Items[nownum - 1].SubItems[3].ToString());
                    this.listView1.Items[nownum - 1].Focused = true;
                    this.listView1.Items[nownum - 1].Selected = true;
                }
                catch (System.FormatException err)
                {
                    return;
                }
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            try
            {
                repaint1();
                double t1 = Convert.ToDouble(double.Parse(txtx1.Text) * 10000000.0 - minx) / Convert.ToDouble(maxx - minx);
                t1 = t1 * (this.pic1.Width - 20);
                double t2 = Convert.ToDouble(double.Parse(txty1.Text) * 1000000.0 - miny) / Convert.ToDouble(maxy - miny);
                t2 = t2 * (this.pic1.Height - 20);


                double dist = Convert.ToDouble(double.Parse(txtradius.Text) * 10000000.0) / Convert.ToDouble(maxx - minx);
                dist = dist * (this.pic1.Width - 20);
                Pen pen1 = new Pen(Color.DarkBlue, (float)pointwidthc);
                g.DrawEllipse(pen1, (float)(t1 + 10 - dist), (float)(t2 + 10 - dist), (float)(2 * dist), (float)(2 * dist));
                g.FillEllipse(Brushes.Red, (float)(t1 + 10 - pointwidth), (float)(t2 + 10 - pointwidth), (float)(2 * pointwidth), (float)(2 * pointwidth));
                txtx2.Text = Convert.ToString(double.Parse(txtx1.Text) + double.Parse(txtradius.Text));
                txty2.Text = txty1.Text;
            }
            catch (System.FormatException)
            {
                return;
            }            
        }

        private void btnopenfile_Click(object sender, EventArgs e)
        {
            try
            {
                string filename2=txtfile.Text+"\\1.txt";
                System.IO.StreamReader reader = new System.IO.StreamReader(filename2, System.Text.Encoding.Default);
                n = Convert.ToInt32(reader.ReadLine());
                if (n == 0) return;
                xx = new int[n + 1];
                yy = new int[n + 1];                
                int flag=0;
                for (int i = 1; i <= n; i++)
                {
                    input2 = reader.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x.Trim())).ToArray();                    
                    if (input2[0] < minxx) { flag=1; break; }
                    if (input2[0] > maxxx) { flag=1; break; }
                    if (input2[1] < minyy) { flag=1; break; }
                    if (input2[1] > maxyy) { flag=1; break; }
                    if (input2[0] < minx) minx = input2[0];
                    if (input2[0]> maxx) maxx = input2[0];
                    if (input2[1] < miny) miny = input2[1];
                    if (input2[1] > maxy) maxy = input2[1];
                }
                lblminXshow.Text = Convert.ToString(Convert.ToDouble(minx / 10000000.0));
                lblmaxXshow.Text = Convert.ToString(Convert.ToDouble(maxx / 10000000.0));
                lblminYshow.Text = Convert.ToString(Convert.ToDouble(miny / 1000000.0));
                lblmaxYshow.Text = Convert.ToString(Convert.ToDouble(maxy / 1000000.0));
                if (flag == 1) { MessageBox.Show("错误数据，请重载另一文件"); return; }
                reader.Close();
            }
            catch (System.IO.FileNotFoundException err)
            {
                return;
            }
            double ww = (maxx - minx) / 10000000.0;
            double hh = (maxy - miny) / 1000000.0;
            if (ww - hh > 1e-8)
            {
                double ratio = ww / hh;
                double t = (620.0 - 20.0) / ratio + 20.0;
                this.pic1.Height = (int)t;
            }
            else
            {
                double ratio = hh / ww;
                double t = (620.0 - 20.0) / ratio + 20.0;
                this.pic1.Width = (int)t;
            }
        }

        private void btnpaint_Click(object sender, EventArgs e)
        {
            if (showm==nowshow) return;
            if (showm - nowshow <= 1000)
            {
                for (int i = nowshow + 1; i <= showm; i++)
                {
                    double t1 = Convert.ToDouble((int)xx[i] - minx) / Convert.ToDouble(maxx - minx);
                    t1 = t1 * (this.pic1.Width - 20);
                    double t2 = Convert.ToDouble((int)yy[i] - miny) / Convert.ToDouble(maxy - miny);
                    t2 = t2 * (this.pic1.Height - 20);
                    if (i == 1) repaint1();
                    g.FillEllipse(Brushes.Blue, (float)(t1 + 10 -pointwidth2), (float)(t2 + 10 -  pointwidth2), (float)(2*pointwidth2), (float)(2*pointwidth2));
                }                
                double tt1 = Convert.ToDouble((int)spx- minx) / Convert.ToDouble(maxx - minx);
                tt1 = tt1 * (this.pic1.Width - 20);
                double tt2 = Convert.ToDouble((int)spy- miny) / Convert.ToDouble(maxy - miny);
                tt2 = tt2 * (this.pic1.Height - 20);
                try
                {
                    g.FillEllipse(Brushes.Red, (float)(tt1 + 10 - pointwidth), (float)(tt2 + 10 - pointwidth), (float)(2 * pointwidth), (float)(2 * pointwidth));
                }                
                catch(System.ArgumentNullException err)
                {
                    return;
                }
                double dist = Convert.ToDouble(nowrange * 10000000.0) / Convert.ToDouble(maxx - minx);
                dist = dist * (this.pic1.Width - 20);
                Pen pen1 = new Pen(Color.DarkBlue, (float)pointwidthc);
                try
                {
                    try
                    {
                        g.DrawEllipse(pen1, (float)(tt1 + 10 - dist), (float)(tt2 + 10 - dist), (float)(2 * dist), (float)(2 * dist));
                        g.FillEllipse(Brushes.Red, (float)(tt1 + 10 - pointwidth), (float)(tt2 + 10 - pointwidth), (float)(2 * pointwidth), (float)(2 * pointwidth));
                    }
                    catch (System.OverflowException)
                    {
                        return;
                    }                    
                }
                catch(System.ArgumentNullException err)
                {
                    return;
                }
                
                MessageBox.Show("画完了^_^");
            }
            else
            {
                for (int i = nowshow + 1; i <= nowshow + 1000; i++)
                {
                    double t1 = Convert.ToDouble((int)xx[i] - minx) / Convert.ToDouble(maxx - minx);
                    t1 = t1 * (this.pic1.Width - 20);
                    double t2 = Convert.ToDouble((int)yy[i] - miny) / Convert.ToDouble(maxy - miny);
                    t2 = t2 * (this.pic1.Height - 20);
                    if (i == 1) repaint1();
                    g.FillEllipse(Brushes.Blue, (float)(t1 + 10 - pointwidth2), (float)(t2 + 10 -  pointwidth2), (float)(2 * pointwidth2), (float)(2 * pointwidth2));
                }
                nowshow += 1000;
            }                
        }

        private void pic1_MouseUp(object sender, MouseEventArgs e)
        {
            nomove = 1;
            ok = 0;
        }
    

        private void txtorigin_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pointwidth = double.Parse(txtorigin.Text);
            }
            catch(System.FormatException err)
            {
                return;
            }            
        }

        private void txtx1_TextChanged(object sender, EventArgs e)
        {
            btnshow_Click(sender, e);
        }

        private void txtresult_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pointwidth2 = double.Parse(txtresult.Text);
            }
            catch (System.FormatException err)
            {
                return;
            }          

        }

        private void txtcircle_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pointwidthc = double.Parse(txtcircle.Text);
            }
            catch (System.FormatException err)
            {
                return;
            }    
        }
                      
    }
}
     