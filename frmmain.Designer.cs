namespace WindowsFormsApplication1
{
    partial class frmmain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btndemo = new System.Windows.Forms.Button();
            this.btn2Dsingle = new System.Windows.Forms.Button();
            this.btn2Dall = new System.Windows.Forms.Button();
            this.btn3Dsingle = new System.Windows.Forms.Button();
            this.btnkth = new System.Windows.Forms.Button();
            this.btnrange = new System.Windows.Forms.Button();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic6 = new System.Windows.Forms.PictureBox();
            this.pic7 = new System.Windows.Forms.PictureBox();
            this.pic8 = new System.Windows.Forms.PictureBox();
            this.pic9 = new System.Windows.Forms.PictureBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lblname1 = new System.Windows.Forms.Label();
            this.lblname2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic9)).BeginInit();
            this.SuspendLayout();
            // 
            // btndemo
            // 
            this.btndemo.Location = new System.Drawing.Point(31, 90);
            this.btndemo.Name = "btndemo";
            this.btndemo.Size = new System.Drawing.Size(120, 50);
            this.btndemo.TabIndex = 0;
            this.btndemo.Text = "子问题演示";
            this.btndemo.UseVisualStyleBackColor = true;
            this.btndemo.Click += new System.EventHandler(this.btndemo_Click);
            // 
            // btn2Dsingle
            // 
            this.btn2Dsingle.Location = new System.Drawing.Point(31, 170);
            this.btn2Dsingle.Name = "btn2Dsingle";
            this.btn2Dsingle.Size = new System.Drawing.Size(121, 50);
            this.btn2Dsingle.TabIndex = 1;
            this.btn2Dsingle.Text = "单一轨迹二维查询";
            this.btn2Dsingle.UseVisualStyleBackColor = true;
            this.btn2Dsingle.Click += new System.EventHandler(this.btn2Dsingle_Click);
            // 
            // btn2Dall
            // 
            this.btn2Dall.Location = new System.Drawing.Point(31, 250);
            this.btn2Dall.Name = "btn2Dall";
            this.btn2Dall.Size = new System.Drawing.Size(122, 50);
            this.btn2Dall.TabIndex = 2;
            this.btn2Dall.Text = "所有轨迹二维查询";
            this.btn2Dall.UseVisualStyleBackColor = true;
            this.btn2Dall.Click += new System.EventHandler(this.btn2Dall_Click);
            // 
            // btn3Dsingle
            // 
            this.btn3Dsingle.Location = new System.Drawing.Point(31, 330);
            this.btn3Dsingle.Name = "btn3Dsingle";
            this.btn3Dsingle.Size = new System.Drawing.Size(121, 50);
            this.btn3Dsingle.TabIndex = 3;
            this.btn3Dsingle.Text = "单一轨迹三维查询";
            this.btn3Dsingle.UseVisualStyleBackColor = true;
            this.btn3Dsingle.Click += new System.EventHandler(this.btn3Dsingle_Click);
            // 
            // btnkth
            // 
            this.btnkth.Location = new System.Drawing.Point(31, 410);
            this.btnkth.Name = "btnkth";
            this.btnkth.Size = new System.Drawing.Size(121, 50);
            this.btnkth.TabIndex = 4;
            this.btnkth.Text = "所有轨迹k邻近查询";
            this.btnkth.UseVisualStyleBackColor = true;
            this.btnkth.Click += new System.EventHandler(this.btnkth_Click);
            // 
            // btnrange
            // 
            this.btnrange.Location = new System.Drawing.Point(31, 490);
            this.btnrange.Name = "btnrange";
            this.btnrange.Size = new System.Drawing.Size(120, 50);
            this.btnrange.TabIndex = 5;
            this.btnrange.Text = "所有轨迹范围查询";
            this.btnrange.UseVisualStyleBackColor = true;
            this.btnrange.Click += new System.EventHandler(this.btnrange_Click);
            // 
            // pic1
            // 
            this.pic1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic1.Location = new System.Drawing.Point(224, 17);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(251, 178);
            this.pic1.TabIndex = 6;
            this.pic1.TabStop = false;
            this.pic1.Click += new System.EventHandler(this.btndemo_Click);
            this.pic1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic1_MouseMove);
            // 
            // pic2
            // 
            this.pic2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic2.Location = new System.Drawing.Point(611, 17);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(251, 178);
            this.pic2.TabIndex = 7;
            this.pic2.TabStop = false;
            this.pic2.Click += new System.EventHandler(this.btn2Dsingle_Click);
            this.pic2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic2_MouseMove);
            // 
            // pic3
            // 
            this.pic3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic3.Location = new System.Drawing.Point(996, 17);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(251, 178);
            this.pic3.TabIndex = 8;
            this.pic3.TabStop = false;
            this.pic3.Click += new System.EventHandler(this.btn2Dall_Click);
            this.pic3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic3_MouseMove);
            // 
            // pic4
            // 
            this.pic4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic4.Location = new System.Drawing.Point(224, 244);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(251, 178);
            this.pic4.TabIndex = 9;
            this.pic4.TabStop = false;
            this.pic4.Click += new System.EventHandler(this.btn3Dsingle_Click);
            this.pic4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic4_MouseMove);
            // 
            // pic5
            // 
            this.pic5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic5.Location = new System.Drawing.Point(611, 244);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(251, 178);
            this.pic5.TabIndex = 10;
            this.pic5.TabStop = false;
            this.pic5.Click += new System.EventHandler(this.btnkth_Click);
            this.pic5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic5_MouseMove);
            // 
            // pic6
            // 
            this.pic6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic6.Location = new System.Drawing.Point(996, 244);
            this.pic6.Name = "pic6";
            this.pic6.Size = new System.Drawing.Size(251, 178);
            this.pic6.TabIndex = 11;
            this.pic6.TabStop = false;
            this.pic6.Click += new System.EventHandler(this.btnrange_Click);
            this.pic6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic6_MouseMove);
            // 
            // pic7
            // 
            this.pic7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic7.Location = new System.Drawing.Point(224, 487);
            this.pic7.Name = "pic7";
            this.pic7.Size = new System.Drawing.Size(251, 178);
            this.pic7.TabIndex = 12;
            this.pic7.TabStop = false;
            this.pic7.Click += new System.EventHandler(this.btnrange_Click);
            this.pic7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic7_MouseMove);
            // 
            // pic8
            // 
            this.pic8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic8.Location = new System.Drawing.Point(611, 487);
            this.pic8.Name = "pic8";
            this.pic8.Size = new System.Drawing.Size(251, 178);
            this.pic8.TabIndex = 13;
            this.pic8.TabStop = false;
            // 
            // pic9
            // 
            this.pic9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic9.Location = new System.Drawing.Point(996, 487);
            this.pic9.Name = "pic9";
            this.pic9.Size = new System.Drawing.Size(251, 178);
            this.pic9.TabIndex = 14;
            this.pic9.TabStop = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(323, 214);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(65, 12);
            this.lbl1.TabIndex = 15;
            this.lbl1.Text = "子问题演示";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(698, 214);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(101, 12);
            this.lbl2.TabIndex = 16;
            this.lbl2.Text = "单一轨迹二维查询";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(1084, 214);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(101, 12);
            this.lbl3.TabIndex = 17;
            this.lbl3.Text = "所有轨迹二维查询";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(310, 448);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(101, 12);
            this.lbl4.TabIndex = 18;
            this.lbl4.Text = "单一轨迹三维查询";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(692, 448);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(107, 12);
            this.lbl5.TabIndex = 20;
            this.lbl5.Text = "所有轨迹k邻近查询";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(1084, 448);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(107, 12);
            this.lbl6.TabIndex = 21;
            this.lbl6.Text = "所有轨迹范围查询1";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(310, 687);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(107, 12);
            this.lbl7.TabIndex = 22;
            this.lbl7.Text = "所有轨迹范围查询2";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(714, 687);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(59, 12);
            this.lbl8.TabIndex = 23;
            this.lbl8.Text = "轨迹总览1";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Location = new System.Drawing.Point(1103, 687);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(59, 12);
            this.lbl9.TabIndex = 24;
            this.lbl9.Text = "轨迹总览2";
            // 
            // lblname1
            // 
            this.lblname1.AutoSize = true;
            this.lblname1.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblname1.Location = new System.Drawing.Point(44, 574);
            this.lblname1.Name = "lblname1";
            this.lblname1.Size = new System.Drawing.Size(107, 16);
            this.lblname1.TabIndex = 25;
            this.lblname1.Text = "13307130173";
            // 
            // lblname2
            // 
            this.lblname2.AutoSize = true;
            this.lblname2.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblname2.Location = new System.Drawing.Point(92, 594);
            this.lblname2.Name = "lblname2";
            this.lblname2.Size = new System.Drawing.Size(59, 16);
            this.lblname2.TabIndex = 26;
            this.lblname2.Text = "万清甫";
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.lblname2);
            this.Controls.Add(this.lblname1);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.pic9);
            this.Controls.Add(this.pic8);
            this.Controls.Add(this.pic7);
            this.Controls.Add(this.pic6);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.btnrange);
            this.Controls.Add(this.btnkth);
            this.Controls.Add(this.btn3Dsingle);
            this.Controls.Add(this.btn2Dall);
            this.Controls.Add(this.btn2Dsingle);
            this.Controls.Add(this.btndemo);
            this.Name = "frmmain";
            this.Text = "轨迹分析系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmmain_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndemo;
        private System.Windows.Forms.Button btn2Dsingle;
        private System.Windows.Forms.Button btn2Dall;
        private System.Windows.Forms.Button btn3Dsingle;
        private System.Windows.Forms.Button btnkth;
        private System.Windows.Forms.Button btnrange;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.PictureBox pic6;
        private System.Windows.Forms.PictureBox pic7;
        private System.Windows.Forms.PictureBox pic8;
        private System.Windows.Forms.PictureBox pic9;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lblname1;
        private System.Windows.Forms.Label lblname2;
    }
}

