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
    public partial class frmkmin : Form
    {
        public frmkmin()
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
        int[] kmin = new int[1111111];
        int showm = 0;
        int nowshow = 0;
        int spx, spy;
        double pointwidth = 5.0;
        double pointwidth2 = 6.0;
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
        }

        private void doit()
        {
            double t1 = Convert.ToDouble(xx1[nowm] - minx) / Convert.ToDouble(maxx - minx);
            t1 = t1 * (this.pic1.Width - 20);
            double t2 = Convert.ToDouble(yy1[nowm] - miny) / Convert.ToDouble(maxy - miny);
            t2 = t2 * (this.pic1.Height - 20);
            g.FillEllipse(Brushes.Red, (float)(t1+10 - pointwidth), (float)(t2+10- pointwidth), (float)(2 * pointwidth), (float)(2 * pointwidth));
            txtnear.Text = Convert.ToString(kmin[nowm]);
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
                kmin[i] = kmin[i + 1];
            }
            if (nowm == m) { nowm--; txtnow.Text = Convert.ToString(nowm); }
            m--;
            if (m == 0) nowm = 0;
            lblgang.Text = "/" + Convert.ToString(m);
            if (m != 0) doit();            
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
                    doit();
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
                kmin[nowm] = int.Parse(txtnear.Text);     
            }
            catch (System.FormatException err)
            {
                return;
            }        
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            if (m == 0) return;
            if (nowm != 0) repaint1();
            nowm = 1;
            doit();
            txtnow.Text = "1";
            double tmp = Convert.ToDouble(xx1[1]) / Convert.ToDouble(10000000.0);
            txtx1.Text = Convert.ToString(tmp);            
            tmp = Convert.ToDouble(yy1[1]) / Convert.ToDouble(1000000.0);
            txty1.Text = Convert.ToString(tmp);
            txtnear.Text = Convert.ToString(kmin[1]);
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            if (m == 0) return;
            if (nowm != 0) repaint1();
            nowm = m;
            doit();            
            txtnow.Text = Convert.ToString(m);
            double tmp = Convert.ToDouble(xx1[m]) / Convert.ToDouble(10000000.0);
            txtx1.Text = Convert.ToString(tmp);            
            tmp = Convert.ToDouble(yy1[m]) / Convert.ToDouble(1000000.0);
            txty1.Text = Convert.ToString(tmp);
            txtnear.Text = Convert.ToString(kmin[m]);
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            if (m == 0 || nowm == 1) return;
            if (nowm != 0) repaint1();
            nowm = nowm - 1;
            doit();
            txtnow.Text = Convert.ToString(nowm);
            double tmp = Convert.ToDouble(xx1[nowm]) / Convert.ToDouble(10000000.0);
            txtx1.Text = Convert.ToString(tmp);            
            tmp = Convert.ToDouble(yy1[nowm]) / Convert.ToDouble(1000000.0);
            txty1.Text = Convert.ToString(tmp);
            txtnear.Text = Convert.ToString(kmin[nowm]);
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (m == 0 || nowm == m) return;
            if (nowm != 0) repaint1();
            nowm = nowm + 1;
            doit();
            txtnow.Text = Convert.ToString(nowm);
            double tmp = Convert.ToDouble(xx1[nowm]) / Convert.ToDouble(10000000.0);
            txtx1.Text = Convert.ToString(tmp);            
            tmp = Convert.ToDouble(yy1[nowm]) / Convert.ToDouble(1000000.0);
            txty1.Text = Convert.ToString(tmp);
            txtnear.Text = Convert.ToString(kmin[nowm]);
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
                    sw.WriteLine(Convert.ToString(kmin[i])+" "+Convert.ToString(xx1[i]) + " " + Convert.ToString(yy1[i]));
                }
                sw.Close();
            }            

        }

        private void btncall_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo();
            //设置外部程序名 
            Info.FileName = "kdtreekmin.exe";
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
            Info.FileName = "gen3.exe";
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
       
        private void frmkmin_MouseMove(object sender, MouseEventArgs e)
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
                while (nowdone<int.Parse(txtid.Text))
                {
                    ++nowdone;
                    n = (int)double.Parse(reader.ReadLine());
                    input = reader.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => double.Parse(x.Trim())).ToArray();
                    spx = (int)input[0];
                    spy = (int)input[1];
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
                            lvi.SubItems.Add(Convert.ToString(input[0]/10000000.0));
                            lvi.SubItems.Add(Convert.ToString(input[1]/1000000.0));                            
                            lvi.SubItems.Add(Convert.ToString(input[2]));
                            this.listView1.Items.Add(lvi);                            
                        }                    
                    }                
                    showm = n;            
                    if (nowdone==int.Parse(txtid.Text))break;
                }                                
                reader.Close();      
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
                    MessageBox.Show(this.listView1.Items[nownum - 1].SubItems[1].ToString()+"\n"+this.listView1.Items[nownum - 1].SubItems[2].ToString()+"\n"+this.listView1.Items[nownum - 1].SubItems[3].ToString());
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
                g.FillEllipse(Brushes.Red, (float)(t1+10 - pointwidth), (float)(t2+10- pointwidth), (float)(2 * pointwidth), (float)(2 * pointwidth));                
            }
            catch(System.FormatException)
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
                    g.FillEllipse(Brushes.Blue, (float)(t1 + 10 - pointwidth2), (float)(t2 + 10 - pointwidth), (float)(2 * pointwidth2), (float)(2* pointwidth2));                                   
                }                
                double tt1 = Convert.ToDouble((int)spx- minx) / Convert.ToDouble(maxx - minx);
                tt1 = tt1 * (this.pic1.Width - 20);
                double tt2 = Convert.ToDouble((int)spy- miny) / Convert.ToDouble(maxy - miny);
                tt2 = tt2 * (this.pic1.Height - 20);
                g.FillEllipse(Brushes.Red, (float)(tt1+10-pointwidth), (float)(tt2+10 - pointwidth), (float)(2 * pointwidth), (float)(2 * pointwidth));
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
                    g.FillEllipse(Brushes.Blue, (float)(t1 + 10 - pointwidth2), (float)(t2 + 10 - pointwidth), (float)(2 * pointwidth2), (float)(2 * pointwidth2));
                }
                nowshow += 1000;
            }                
        }

        private void txtorigin_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pointwidth = double.Parse(txtorigin.Text);
            }
            catch (System.FormatException err)
            {
                return;
            }  
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
                      
    }
}
     