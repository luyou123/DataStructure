using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
namespace WindowsFormsApplication1
{
    public partial class frmdemo : Form
    {
        public frmdemo()
        {               
            InitializeComponent();
        }               

        private void btnrandom_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo();
            //设置外部程序名 
            Info.FileName = "gen.exe";
            if (txtrand.Text != "") Info.WorkingDirectory = txtrand.Text;
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

        private void btnbf_Click(object sender, EventArgs e)
        {
            string srcfile = txtrand.Text + "\\1.in";
            string dstfile = txtbf.Text + "\\1.in";
            try
            {
                if (srcfile != dstfile)
                    System.IO.File.Copy(srcfile, dstfile, true);
            }
            catch (System.IO.FileNotFoundException err)
            {
                return;
            }
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo();
            //设置外部程序名 
            Info.FileName = "bf.exe";
            if (txtbf.Text != "") Info.WorkingDirectory = txtbf.Text;
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
        
        private void btnsts_Click(object sender, EventArgs e)
        {
            string srcfile = txtrand.Text + "\\1.in";
            string dstfile = txtsts.Text + "\\1.in";
            try
            {
                if (srcfile != dstfile)
                    System.IO.File.Copy(srcfile, dstfile, true);
            }
            catch (System.IO.FileNotFoundException err)
            {
                return;
            }
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo();
            //设置外部程序名 
            Info.FileName = "sts.exe";
            if (txtsts.Text != "") Info.WorkingDirectory = txtsts.Text;
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


        private void btnsts2_Click(object sender, EventArgs e)
        {
            string srcfile = txtrand.Text + "\\1.in";
            string dstfile = txtsts2.Text + "\\1.in";
            try
            {
                if (srcfile != dstfile)
                    System.IO.File.Copy(srcfile, dstfile, true);
            }
            catch (System.IO.FileNotFoundException err)
            {
                return;
            }
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo();
            //设置外部程序名 
            Info.FileName = "sts2.exe";
            if (txtsts2.Text != "") Info.WorkingDirectory = txtsts2.Text;
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

        private void btnsfs_Click(object sender, EventArgs e)
        {
            string srcfile = txtrand.Text + "\\1.in";
            string dstfile = txtsfs.Text + "\\1.in";
            try
            {
                if (srcfile != dstfile)
                    System.IO.File.Copy(srcfile, dstfile, true);
            }
            catch (System.IO.FileNotFoundException err)
            {
                return;
            }
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo();
            //设置外部程序名 
            Info.FileName = "pre2.exe";
            if (txtsfs.Text != "") Info.WorkingDirectory = txtsfs.Text;
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


        private void btnrange_Click(object sender, EventArgs e)
        {
            string srcfile = txtrand.Text + "\\1.in";
            string dstfile = txtrange.Text + "\\1.in";
            try
            {
                if (srcfile != dstfile)
                    System.IO.File.Copy(srcfile, dstfile, true);
            }
            catch (System.IO.FileNotFoundException err)
            {
                return;
            }
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo();
            //设置外部程序名 
            Info.FileName = "prerangetree.exe";
            if (txtrange.Text != "") Info.WorkingDirectory = txtrange.Text;
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


        //-----------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------

        private void btnopen1_Click(object sender, EventArgs e)
        {
            string filename = "";
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filename = dialog.SelectedPath;
            }
            txtrand.Text = filename;
        }

        private void btnopen2_Click(object sender, EventArgs e)
        {
            string filename = "";
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filename = dialog.SelectedPath;
            }
            txtbf.Text = filename;
        }

        private void btnopen3_Click(object sender, EventArgs e)
        {
            string filename = "";
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filename = dialog.SelectedPath;
            }
            txtsts.Text = filename;
        }
       
        private void btnopen4_Click(object sender, EventArgs e)
        {
            string filename = "";
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filename = dialog.SelectedPath;
            }
            txtsts2.Text = filename;
        }

        private void btnopen5_Click(object sender, EventArgs e)
        {
            string filename = "";
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filename = dialog.SelectedPath;
            }
            txtsfs.Text = filename;
        }

        private void btnopen6_Click(object sender, EventArgs e)
        {
            string filename = "";
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filename = dialog.SelectedPath;
            }
            txtrange.Text = filename;
        }

        private void btnopen7_Click(object sender, EventArgs e)
        {
            string filename = "";
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filename = dialog.SelectedPath;
            }
            txtrand2.Text = filename;
        }

        private void btnopen8_Click(object sender, EventArgs e)
        {
            string filename = "";
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filename = dialog.SelectedPath;
            }
            txtbf2.Text = filename;
        }

        private void btnopen9_Click(object sender, EventArgs e)
        {
            string filename = "";
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filename = dialog.SelectedPath;
            }
            txtrange2.Text = filename;
        }

        private void btnrand2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo();
            //设置外部程序名 
            Info.FileName = "gen.exe";
            if (txtrand2.Text != "") Info.WorkingDirectory = txtrand2.Text;
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

        private void btnbf2_Click(object sender, EventArgs e)
        {
            string srcfile = txtrand2.Text + "\\1.in";
            string dstfile = txtbf2.Text + "\\1.in";
            try
            {
                if (srcfile != dstfile)
                    System.IO.File.Copy(srcfile, dstfile, true);
            }
            catch (System.IO.FileNotFoundException err)
            {
                return;
            }
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo();
            //设置外部程序名 
            Info.FileName = "bf.exe";
            if (txtbf2.Text != "") Info.WorkingDirectory = txtbf2.Text;
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

        private void btnrange2_Click(object sender, EventArgs e)
        {
            string srcfile = txtrand2.Text + "\\1.in";
            string dstfile = txtrange2.Text + "\\1.in";
            try
            {
                if (srcfile != dstfile)
                    System.IO.File.Copy(srcfile, dstfile, true);
            }
            catch (System.IO.FileNotFoundException err)
            {
                return;
            }
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo();
            //设置外部程序名 
            Info.FileName = "prerangetree3D.exe";
            if (txtrange2.Text != "") Info.WorkingDirectory = txtrange2.Text;
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
        Graphics g;

        string filename;        
        int[] input;
        int[] xx;
        int[] yy;
        int n=0;
        int minx = 0x7FFFFFFF, miny = 0x7FFFFFFF, maxx = 0, maxy = 0;
        int ok = 0;        
        private void btnopen_Click(object sender, EventArgs e)
        {
            ok = 1;            
            g = this.pic1.CreateGraphics();
            g.Clear(this.pic1.BackColor);            
            OpenFileDialog opndlg = new OpenFileDialog();
            opndlg.InitialDirectory = "G:\\";
            opndlg.Filter = "文本文件(*.in)|*.in";
            opndlg.Title = "打开文本文件";
            if (opndlg.ShowDialog() == DialogResult.OK)
            {
                filename = opndlg.FileName;
                System.IO.StreamReader reader = new System.IO.StreamReader(filename, System.Text.Encoding.Default);
                n = Convert.ToInt32(reader.ReadLine());
                xx=new int[n+1];
                yy=new int[n+1];
                for (int i = 1; i <= n; i++)
                {
                    input = reader.ReadLine().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x.Trim())).ToArray();
                    xx[i]=input[0];
                    yy[i]=input[1];
                    if (xx[i] < minx) minx = xx[i];
                    if (xx[i] > maxx) maxx = xx[i];
                    if (yy[i] < miny) miny = yy[i];
                    if (yy[i] > maxy) maxy = yy[i];
                }             
                for (int i = 1; i <= n-1;i++)
                {                    
                    double t1 = Convert.ToDouble(xx[i] - minx) / Convert.ToDouble(maxx - minx);
                    t1 = t1 * (this.pic1.Width-20);
                    double t2 = Convert.ToDouble(yy[i] - miny) / Convert.ToDouble(maxy - miny);
                    t2 = t2 * (this.pic1.Height-20);   
                    double t3 = Convert.ToDouble(xx[i+1] - minx) / Convert.ToDouble(maxx - minx);
                    t3 = t3 * (this.pic1.Width-20);
                    double t4 = Convert.ToDouble(yy[i+1] - miny) / Convert.ToDouble(maxy - miny);
                    t4 = t4 * (this.pic1.Height-20);                                   
                    g.DrawLine(Pens.Red, (float)(t1+10), (float)(t2+10), (float)(t3+10), (float)(t4+10));
                    
                }
                reader.Close();

            }
        }

        private void pic1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ok == 0) return;
            if (e.X >= 10 && e.X <= this.pic1.Width - 10 && e.Y >= 10 && e.Y <= this.pic1.Height - 10)
            {
                this.Cursor = System.Windows.Forms.Cursors.Cross;
                double t1 = Convert.ToDouble(e.X -  10) / Convert.ToDouble(this.pic1.Width - 20);
                double t2 = Convert.ToDouble(e.Y -  10) / Convert.ToDouble(this.pic1.Height- 20);
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
    }
}
