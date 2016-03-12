namespace WindowsFormsApplication1
{
    partial class frmdemo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnrandom = new System.Windows.Forms.Button();
            this.btnbf = new System.Windows.Forms.Button();
            this.btnsts = new System.Windows.Forms.Button();
            this.lblbf = new System.Windows.Forms.Label();
            this.txtbf = new System.Windows.Forms.TextBox();
            this.lblrand = new System.Windows.Forms.Label();
            this.txtrand = new System.Windows.Forms.TextBox();
            this.lblsts = new System.Windows.Forms.Label();
            this.txtsts = new System.Windows.Forms.TextBox();
            this.btnopen1 = new System.Windows.Forms.Button();
            this.btnopen2 = new System.Windows.Forms.Button();
            this.btnopen3 = new System.Windows.Forms.Button();
            this.lblsts2 = new System.Windows.Forms.Label();
            this.txtsts2 = new System.Windows.Forms.TextBox();
            this.btnopen4 = new System.Windows.Forms.Button();
            this.btnsts2 = new System.Windows.Forms.Button();
            this.lblsfs = new System.Windows.Forms.Label();
            this.txtsfs = new System.Windows.Forms.TextBox();
            this.btnopen5 = new System.Windows.Forms.Button();
            this.btnsfs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtrange = new System.Windows.Forms.TextBox();
            this.btnopen6 = new System.Windows.Forms.Button();
            this.btnrange = new System.Windows.Forms.Button();
            this.lbldash = new System.Windows.Forms.Label();
            this.lblrand2 = new System.Windows.Forms.Label();
            this.txtrand2 = new System.Windows.Forms.TextBox();
            this.btnopen7 = new System.Windows.Forms.Button();
            this.btnrand2 = new System.Windows.Forms.Button();
            this.lblbf2 = new System.Windows.Forms.Label();
            this.txtbf2 = new System.Windows.Forms.TextBox();
            this.btnopen8 = new System.Windows.Forms.Button();
            this.btnopen9 = new System.Windows.Forms.Button();
            this.lblrange2 = new System.Windows.Forms.Label();
            this.btnbf2 = new System.Windows.Forms.Button();
            this.btnrange2 = new System.Windows.Forms.Button();
            this.txtrange2 = new System.Windows.Forms.TextBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.btnopen = new System.Windows.Forms.Button();
            this.lblxy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnrandom
            // 
            this.btnrandom.Location = new System.Drawing.Point(559, 11);
            this.btnrandom.Name = "btnrandom";
            this.btnrandom.Size = new System.Drawing.Size(117, 55);
            this.btnrandom.TabIndex = 0;
            this.btnrandom.Text = "生成随机数据";
            this.btnrandom.UseVisualStyleBackColor = true;
            this.btnrandom.Click += new System.EventHandler(this.btnrandom_Click);
            // 
            // btnbf
            // 
            this.btnbf.Location = new System.Drawing.Point(559, 89);
            this.btnbf.Name = "btnbf";
            this.btnbf.Size = new System.Drawing.Size(117, 55);
            this.btnbf.TabIndex = 1;
            this.btnbf.Text = "暴力解法";
            this.btnbf.UseVisualStyleBackColor = true;
            this.btnbf.Click += new System.EventHandler(this.btnbf_Click);
            // 
            // btnsts
            // 
            this.btnsts.Location = new System.Drawing.Point(559, 170);
            this.btnsts.Name = "btnsts";
            this.btnsts.Size = new System.Drawing.Size(117, 55);
            this.btnsts.TabIndex = 2;
            this.btnsts.Text = "线段树套红黑树";
            this.btnsts.UseVisualStyleBackColor = true;
            this.btnsts.Click += new System.EventHandler(this.btnsts_Click);
            // 
            // lblbf
            // 
            this.lblbf.AutoSize = true;
            this.lblbf.Location = new System.Drawing.Point(12, 114);
            this.lblbf.Name = "lblbf";
            this.lblbf.Size = new System.Drawing.Size(125, 12);
            this.lblbf.TabIndex = 3;
            this.lblbf.Text = "暴力解法程序所在目录";
            // 
            // txtbf
            // 
            this.txtbf.Location = new System.Drawing.Point(218, 107);
            this.txtbf.Name = "txtbf";
            this.txtbf.Size = new System.Drawing.Size(181, 21);
            this.txtbf.TabIndex = 4;
            // 
            // lblrand
            // 
            this.lblrand.AutoSize = true;
            this.lblrand.Location = new System.Drawing.Point(15, 34);
            this.lblrand.Name = "lblrand";
            this.lblrand.Size = new System.Drawing.Size(101, 12);
            this.lblrand.TabIndex = 5;
            this.lblrand.Text = "随机程序所在目录";
            // 
            // txtrand
            // 
            this.txtrand.Location = new System.Drawing.Point(218, 29);
            this.txtrand.Name = "txtrand";
            this.txtrand.Size = new System.Drawing.Size(181, 21);
            this.txtrand.TabIndex = 6;
            // 
            // lblsts
            // 
            this.lblsts.AutoSize = true;
            this.lblsts.Location = new System.Drawing.Point(12, 191);
            this.lblsts.Name = "lblsts";
            this.lblsts.Size = new System.Drawing.Size(161, 12);
            this.lblsts.TabIndex = 7;
            this.lblsts.Text = "线段树套红黑树程序所在目录";
            // 
            // txtsts
            // 
            this.txtsts.Location = new System.Drawing.Point(218, 188);
            this.txtsts.Name = "txtsts";
            this.txtsts.Size = new System.Drawing.Size(181, 21);
            this.txtsts.TabIndex = 8;
            // 
            // btnopen1
            // 
            this.btnopen1.Location = new System.Drawing.Point(419, 10);
            this.btnopen1.Name = "btnopen1";
            this.btnopen1.Size = new System.Drawing.Size(105, 55);
            this.btnopen1.TabIndex = 9;
            this.btnopen1.Text = "浏览";
            this.btnopen1.UseVisualStyleBackColor = true;
            this.btnopen1.Click += new System.EventHandler(this.btnopen1_Click);
            // 
            // btnopen2
            // 
            this.btnopen2.Location = new System.Drawing.Point(419, 89);
            this.btnopen2.Name = "btnopen2";
            this.btnopen2.Size = new System.Drawing.Size(105, 55);
            this.btnopen2.TabIndex = 10;
            this.btnopen2.Text = "浏览";
            this.btnopen2.UseVisualStyleBackColor = true;
            this.btnopen2.Click += new System.EventHandler(this.btnopen2_Click);
            // 
            // btnopen3
            // 
            this.btnopen3.Location = new System.Drawing.Point(419, 170);
            this.btnopen3.Name = "btnopen3";
            this.btnopen3.Size = new System.Drawing.Size(105, 55);
            this.btnopen3.TabIndex = 11;
            this.btnopen3.Text = "浏览";
            this.btnopen3.UseVisualStyleBackColor = true;
            this.btnopen3.Click += new System.EventHandler(this.btnopen3_Click);
            // 
            // lblsts2
            // 
            this.lblsts2.AutoSize = true;
            this.lblsts2.Location = new System.Drawing.Point(12, 274);
            this.lblsts2.Name = "lblsts2";
            this.lblsts2.Size = new System.Drawing.Size(173, 12);
            this.lblsts2.TabIndex = 12;
            this.lblsts2.Text = "树状数组套红黑树程序所在目录";
            // 
            // txtsts2
            // 
            this.txtsts2.Location = new System.Drawing.Point(218, 269);
            this.txtsts2.Name = "txtsts2";
            this.txtsts2.Size = new System.Drawing.Size(181, 21);
            this.txtsts2.TabIndex = 13;
            // 
            // btnopen4
            // 
            this.btnopen4.Location = new System.Drawing.Point(419, 251);
            this.btnopen4.Name = "btnopen4";
            this.btnopen4.Size = new System.Drawing.Size(105, 55);
            this.btnopen4.TabIndex = 14;
            this.btnopen4.Text = "浏览";
            this.btnopen4.UseVisualStyleBackColor = true;
            this.btnopen4.Click += new System.EventHandler(this.btnopen4_Click);
            // 
            // btnsts2
            // 
            this.btnsts2.Location = new System.Drawing.Point(559, 251);
            this.btnsts2.Name = "btnsts2";
            this.btnsts2.Size = new System.Drawing.Size(117, 55);
            this.btnsts2.TabIndex = 15;
            this.btnsts2.Text = "树状数组套红黑树";
            this.btnsts2.UseVisualStyleBackColor = true;
            this.btnsts2.Click += new System.EventHandler(this.btnsts2_Click);
            // 
            // lblsfs
            // 
            this.lblsfs.AutoSize = true;
            this.lblsfs.Location = new System.Drawing.Point(15, 354);
            this.lblsfs.Name = "lblsfs";
            this.lblsfs.Size = new System.Drawing.Size(137, 12);
            this.lblsfs.TabIndex = 16;
            this.lblsfs.Text = "象限四分树程序所在目录";
            // 
            // txtsfs
            // 
            this.txtsfs.Location = new System.Drawing.Point(218, 350);
            this.txtsfs.Name = "txtsfs";
            this.txtsfs.Size = new System.Drawing.Size(181, 21);
            this.txtsfs.TabIndex = 17;
            // 
            // btnopen5
            // 
            this.btnopen5.Location = new System.Drawing.Point(419, 332);
            this.btnopen5.Name = "btnopen5";
            this.btnopen5.Size = new System.Drawing.Size(105, 55);
            this.btnopen5.TabIndex = 18;
            this.btnopen5.Text = "浏览";
            this.btnopen5.UseVisualStyleBackColor = true;
            this.btnopen5.Click += new System.EventHandler(this.btnopen5_Click);
            // 
            // btnsfs
            // 
            this.btnsfs.Location = new System.Drawing.Point(559, 332);
            this.btnsfs.Name = "btnsfs";
            this.btnsfs.Size = new System.Drawing.Size(117, 55);
            this.btnsfs.TabIndex = 19;
            this.btnsfs.Text = "象限四分树";
            this.btnsfs.UseVisualStyleBackColor = true;
            this.btnsfs.Click += new System.EventHandler(this.btnsfs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "Range Tree程序所在目录";
            // 
            // txtrange
            // 
            this.txtrange.Location = new System.Drawing.Point(218, 431);
            this.txtrange.Name = "txtrange";
            this.txtrange.Size = new System.Drawing.Size(181, 21);
            this.txtrange.TabIndex = 21;
            // 
            // btnopen6
            // 
            this.btnopen6.Location = new System.Drawing.Point(419, 413);
            this.btnopen6.Name = "btnopen6";
            this.btnopen6.Size = new System.Drawing.Size(105, 55);
            this.btnopen6.TabIndex = 22;
            this.btnopen6.Text = "浏览";
            this.btnopen6.UseVisualStyleBackColor = true;
            this.btnopen6.Click += new System.EventHandler(this.btnopen6_Click);
            // 
            // btnrange
            // 
            this.btnrange.Location = new System.Drawing.Point(559, 413);
            this.btnrange.Name = "btnrange";
            this.btnrange.Size = new System.Drawing.Size(117, 55);
            this.btnrange.TabIndex = 23;
            this.btnrange.Text = "Range Tree";
            this.btnrange.UseVisualStyleBackColor = true;
            this.btnrange.Click += new System.EventHandler(this.btnrange_Click);
            // 
            // lbldash
            // 
            this.lbldash.AutoSize = true;
            this.lbldash.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbldash.Location = new System.Drawing.Point(12, 470);
            this.lbldash.Name = "lbldash";
            this.lbldash.Size = new System.Drawing.Size(668, 26);
            this.lbldash.TabIndex = 24;
            this.lbldash.Text = "---------------------------------------------------------------------------------" +
    "-";
            // 
            // lblrand2
            // 
            this.lblrand2.AutoSize = true;
            this.lblrand2.Location = new System.Drawing.Point(15, 520);
            this.lblrand2.Name = "lblrand2";
            this.lblrand2.Size = new System.Drawing.Size(101, 12);
            this.lblrand2.TabIndex = 25;
            this.lblrand2.Text = "随机程序所在目录";
            // 
            // txtrand2
            // 
            this.txtrand2.Location = new System.Drawing.Point(218, 517);
            this.txtrand2.Name = "txtrand2";
            this.txtrand2.Size = new System.Drawing.Size(181, 21);
            this.txtrand2.TabIndex = 26;
            // 
            // btnopen7
            // 
            this.btnopen7.Location = new System.Drawing.Point(419, 499);
            this.btnopen7.Name = "btnopen7";
            this.btnopen7.Size = new System.Drawing.Size(105, 55);
            this.btnopen7.TabIndex = 27;
            this.btnopen7.Text = "浏览";
            this.btnopen7.UseVisualStyleBackColor = true;
            this.btnopen7.Click += new System.EventHandler(this.btnopen7_Click);
            // 
            // btnrand2
            // 
            this.btnrand2.Location = new System.Drawing.Point(559, 499);
            this.btnrand2.Name = "btnrand2";
            this.btnrand2.Size = new System.Drawing.Size(117, 55);
            this.btnrand2.TabIndex = 28;
            this.btnrand2.Text = "生成随机数据";
            this.btnrand2.UseVisualStyleBackColor = true;
            this.btnrand2.Click += new System.EventHandler(this.btnrand2_Click);
            // 
            // lblbf2
            // 
            this.lblbf2.AutoSize = true;
            this.lblbf2.Location = new System.Drawing.Point(15, 595);
            this.lblbf2.Name = "lblbf2";
            this.lblbf2.Size = new System.Drawing.Size(101, 12);
            this.lblbf2.TabIndex = 29;
            this.lblbf2.Text = "暴力程序所在目录";
            // 
            // txtbf2
            // 
            this.txtbf2.Location = new System.Drawing.Point(218, 592);
            this.txtbf2.Name = "txtbf2";
            this.txtbf2.Size = new System.Drawing.Size(181, 21);
            this.txtbf2.TabIndex = 30;
            // 
            // btnopen8
            // 
            this.btnopen8.Location = new System.Drawing.Point(419, 574);
            this.btnopen8.Name = "btnopen8";
            this.btnopen8.Size = new System.Drawing.Size(105, 55);
            this.btnopen8.TabIndex = 31;
            this.btnopen8.Text = "浏览";
            this.btnopen8.UseVisualStyleBackColor = true;
            this.btnopen8.Click += new System.EventHandler(this.btnopen8_Click);
            // 
            // btnopen9
            // 
            this.btnopen9.Location = new System.Drawing.Point(419, 648);
            this.btnopen9.Name = "btnopen9";
            this.btnopen9.Size = new System.Drawing.Size(105, 55);
            this.btnopen9.TabIndex = 32;
            this.btnopen9.Text = "浏览";
            this.btnopen9.UseVisualStyleBackColor = true;
            this.btnopen9.Click += new System.EventHandler(this.btnopen9_Click);
            // 
            // lblrange2
            // 
            this.lblrange2.AutoSize = true;
            this.lblrange2.Location = new System.Drawing.Point(15, 670);
            this.lblrange2.Name = "lblrange2";
            this.lblrange2.Size = new System.Drawing.Size(113, 12);
            this.lblrange2.TabIndex = 33;
            this.lblrange2.Text = "Range Tree所在目录";
            // 
            // btnbf2
            // 
            this.btnbf2.Location = new System.Drawing.Point(559, 574);
            this.btnbf2.Name = "btnbf2";
            this.btnbf2.Size = new System.Drawing.Size(117, 55);
            this.btnbf2.TabIndex = 34;
            this.btnbf2.Text = "暴力解法";
            this.btnbf2.UseVisualStyleBackColor = true;
            this.btnbf2.Click += new System.EventHandler(this.btnbf2_Click);
            // 
            // btnrange2
            // 
            this.btnrange2.Location = new System.Drawing.Point(559, 649);
            this.btnrange2.Name = "btnrange2";
            this.btnrange2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnrange2.Size = new System.Drawing.Size(117, 54);
            this.btnrange2.TabIndex = 35;
            this.btnrange2.Text = "Range Tree";
            this.btnrange2.UseVisualStyleBackColor = true;
            this.btnrange2.Click += new System.EventHandler(this.btnrange2_Click);
            // 
            // txtrange2
            // 
            this.txtrange2.Location = new System.Drawing.Point(218, 666);
            this.txtrange2.Name = "txtrange2";
            this.txtrange2.Size = new System.Drawing.Size(181, 21);
            this.txtrange2.TabIndex = 36;
            // 
            // pic1
            // 
            this.pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic1.Location = new System.Drawing.Point(710, 11);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(628, 576);
            this.pic1.TabIndex = 37;
            this.pic1.TabStop = false;
            this.pic1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic1_MouseMove);
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(1240, 621);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(85, 47);
            this.btnopen.TabIndex = 38;
            this.btnopen.Text = "读文件";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // lblxy
            // 
            this.lblxy.AutoSize = true;
            this.lblxy.Location = new System.Drawing.Point(933, 633);
            this.lblxy.Name = "lblxy";
            this.lblxy.Size = new System.Drawing.Size(35, 12);
            this.lblxy.TabIndex = 39;
            this.lblxy.Text = "(0,0)";
            // 
            // frmdemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.lblxy);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.txtrange2);
            this.Controls.Add(this.btnrange2);
            this.Controls.Add(this.btnbf2);
            this.Controls.Add(this.lblrange2);
            this.Controls.Add(this.btnopen9);
            this.Controls.Add(this.btnopen8);
            this.Controls.Add(this.txtbf2);
            this.Controls.Add(this.lblbf2);
            this.Controls.Add(this.btnrand2);
            this.Controls.Add(this.btnopen7);
            this.Controls.Add(this.txtrand2);
            this.Controls.Add(this.lblrand2);
            this.Controls.Add(this.lbldash);
            this.Controls.Add(this.btnrange);
            this.Controls.Add(this.btnopen6);
            this.Controls.Add(this.txtrange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsfs);
            this.Controls.Add(this.btnopen5);
            this.Controls.Add(this.txtsfs);
            this.Controls.Add(this.lblsfs);
            this.Controls.Add(this.btnsts2);
            this.Controls.Add(this.btnopen4);
            this.Controls.Add(this.txtsts2);
            this.Controls.Add(this.lblsts2);
            this.Controls.Add(this.btnopen3);
            this.Controls.Add(this.btnopen2);
            this.Controls.Add(this.btnopen1);
            this.Controls.Add(this.txtsts);
            this.Controls.Add(this.lblsts);
            this.Controls.Add(this.txtrand);
            this.Controls.Add(this.lblrand);
            this.Controls.Add(this.txtbf);
            this.Controls.Add(this.lblbf);
            this.Controls.Add(this.btnsts);
            this.Controls.Add(this.btnbf);
            this.Controls.Add(this.btnrandom);
            this.Name = "frmdemo";
            this.Text = "子问题演示";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnrandom;
        private System.Windows.Forms.Button btnbf;
        private System.Windows.Forms.Button btnsts;
        private System.Windows.Forms.Label lblbf;
        private System.Windows.Forms.TextBox txtbf;
        private System.Windows.Forms.Label lblrand;
        private System.Windows.Forms.TextBox txtrand;
        private System.Windows.Forms.Label lblsts;
        private System.Windows.Forms.TextBox txtsts;
        private System.Windows.Forms.Button btnopen1;
        private System.Windows.Forms.Button btnopen2;
        private System.Windows.Forms.Button btnopen3;
        private System.Windows.Forms.Label lblsts2;
        private System.Windows.Forms.TextBox txtsts2;
        private System.Windows.Forms.Button btnopen4;
        private System.Windows.Forms.Button btnsts2;
        private System.Windows.Forms.Label lblsfs;
        private System.Windows.Forms.TextBox txtsfs;
        private System.Windows.Forms.Button btnopen5;
        private System.Windows.Forms.Button btnsfs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtrange;
        private System.Windows.Forms.Button btnopen6;
        private System.Windows.Forms.Button btnrange;
        private System.Windows.Forms.Label lbldash;
        private System.Windows.Forms.Label lblrand2;
        private System.Windows.Forms.TextBox txtrand2;
        private System.Windows.Forms.Button btnopen7;
        private System.Windows.Forms.Button btnrand2;
        private System.Windows.Forms.Label lblbf2;
        private System.Windows.Forms.TextBox txtbf2;
        private System.Windows.Forms.Button btnopen8;
        private System.Windows.Forms.Button btnopen9;
        private System.Windows.Forms.Label lblrange2;
        private System.Windows.Forms.Button btnbf2;
        private System.Windows.Forms.Button btnrange2;
        private System.Windows.Forms.TextBox txtrange2;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Label lblxy;
    }
}