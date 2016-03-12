namespace WindowsFormsApplication1
{
    partial class frm2Dall
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
            this.lblfile = new System.Windows.Forms.Label();
            this.txtfile = new System.Windows.Forms.TextBox();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.btnopen1 = new System.Windows.Forms.Button();
            this.lblminx = new System.Windows.Forms.Label();
            this.lblminXshow = new System.Windows.Forms.Label();
            this.lblmaxX = new System.Windows.Forms.Label();
            this.lblmaxXshow = new System.Windows.Forms.Label();
            this.lblminYshow = new System.Windows.Forms.Label();
            this.lblminY = new System.Windows.Forms.Label();
            this.lblmaxY = new System.Windows.Forms.Label();
            this.lblmaxYshow = new System.Windows.Forms.Label();
            this.rect = new System.Windows.Forms.GroupBox();
            this.btnrand = new System.Windows.Forms.Button();
            this.btncall = new System.Windows.Forms.Button();
            this.btnoutput = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnprev = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.lblgang = new System.Windows.Forms.Label();
            this.txtnow = new System.Windows.Forms.TextBox();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txty2 = new System.Windows.Forms.TextBox();
            this.lbly2 = new System.Windows.Forms.Label();
            this.txtx2 = new System.Windows.Forms.TextBox();
            this.lblx2 = new System.Windows.Forms.Label();
            this.txty1 = new System.Windows.Forms.TextBox();
            this.lbly1 = new System.Windows.Forms.Label();
            this.txtx1 = new System.Windows.Forms.TextBox();
            this.lblx1 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.GroupBox();
            this.lblline = new System.Windows.Forms.Label();
            this.lblchoose = new System.Windows.Forms.Label();
            this.txtchoose = new System.Windows.Forms.TextBox();
            this.btndisplay = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblxy = new System.Windows.Forms.Label();
            this.btnopen2 = new System.Windows.Forms.Button();
            this.btnopen3 = new System.Windows.Forms.Button();
            this.btnopen4 = new System.Windows.Forms.Button();
            this.btnopen5 = new System.Windows.Forms.Button();
            this.btnopen6 = new System.Windows.Forms.Button();
            this.btnopen7 = new System.Windows.Forms.Button();
            this.btnopen8 = new System.Windows.Forms.Button();
            this.btnopen9 = new System.Windows.Forms.Button();
            this.btnopen10 = new System.Windows.Forms.Button();
            this.btnopen11 = new System.Windows.Forms.Button();
            this.btnopen12 = new System.Windows.Forms.Button();
            this.btnopen13 = new System.Windows.Forms.Button();
            this.btnopen14 = new System.Windows.Forms.Button();
            this.txtorigin2 = new System.Windows.Forms.TextBox();
            this.lblorigin2 = new System.Windows.Forms.Label();
            this.txtorigin = new System.Windows.Forms.TextBox();
            this.lblorigin = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.rect.SuspendLayout();
            this.result.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblfile
            // 
            this.lblfile.AutoSize = true;
            this.lblfile.Location = new System.Drawing.Point(12, 12);
            this.lblfile.Name = "lblfile";
            this.lblfile.Size = new System.Drawing.Size(101, 12);
            this.lblfile.TabIndex = 40;
            this.lblfile.Text = "轨迹文件所在目录";
            // 
            // txtfile
            // 
            this.txtfile.Location = new System.Drawing.Point(14, 34);
            this.txtfile.Name = "txtfile";
            this.txtfile.Size = new System.Drawing.Size(172, 21);
            this.txtfile.TabIndex = 41;
            this.txtfile.TextChanged += new System.EventHandler(this.txtfile_TextChanged);
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(192, 26);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(44, 35);
            this.btnbrowse.TabIndex = 54;
            this.btnbrowse.Text = "浏览";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.Color.Black;
            this.pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic1.Location = new System.Drawing.Point(270, 12);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(1068, 661);
            this.pic1.TabIndex = 55;
            this.pic1.TabStop = false;
            this.pic1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic1_MouseDown);
            this.pic1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic1_MouseMove);
            this.pic1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic1_MouseUp);
            // 
            // btnopen1
            // 
            this.btnopen1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnopen1.Location = new System.Drawing.Point(6, 61);
            this.btnopen1.Name = "btnopen1";
            this.btnopen1.Size = new System.Drawing.Size(35, 35);
            this.btnopen1.TabIndex = 56;
            this.btnopen1.Text = "1";
            this.btnopen1.UseVisualStyleBackColor = true;
            this.btnopen1.Click += new System.EventHandler(this.btnopen1_Click);
            // 
            // lblminx
            // 
            this.lblminx.AutoSize = true;
            this.lblminx.Location = new System.Drawing.Point(12, 134);
            this.lblminx.Name = "lblminx";
            this.lblminx.Size = new System.Drawing.Size(29, 12);
            this.lblminx.TabIndex = 57;
            this.lblminx.Text = "minX";
            // 
            // lblminXshow
            // 
            this.lblminXshow.AutoSize = true;
            this.lblminXshow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblminXshow.Location = new System.Drawing.Point(47, 134);
            this.lblminXshow.Name = "lblminXshow";
            this.lblminXshow.Size = new System.Drawing.Size(26, 12);
            this.lblminXshow.TabIndex = 58;
            this.lblminXshow.Text = "111";
            // 
            // lblmaxX
            // 
            this.lblmaxX.AutoSize = true;
            this.lblmaxX.Location = new System.Drawing.Point(12, 160);
            this.lblmaxX.Name = "lblmaxX";
            this.lblmaxX.Size = new System.Drawing.Size(29, 12);
            this.lblmaxX.TabIndex = 59;
            this.lblmaxX.Text = "maxX";
            // 
            // lblmaxXshow
            // 
            this.lblmaxXshow.AutoSize = true;
            this.lblmaxXshow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblmaxXshow.Location = new System.Drawing.Point(47, 160);
            this.lblmaxXshow.Name = "lblmaxXshow";
            this.lblmaxXshow.Size = new System.Drawing.Size(26, 12);
            this.lblmaxXshow.TabIndex = 60;
            this.lblmaxXshow.Text = "111";
            // 
            // lblminYshow
            // 
            this.lblminYshow.AutoSize = true;
            this.lblminYshow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblminYshow.Location = new System.Drawing.Point(47, 189);
            this.lblminYshow.Name = "lblminYshow";
            this.lblminYshow.Size = new System.Drawing.Size(26, 12);
            this.lblminYshow.TabIndex = 61;
            this.lblminYshow.Text = "111";
            // 
            // lblminY
            // 
            this.lblminY.AutoSize = true;
            this.lblminY.Location = new System.Drawing.Point(12, 189);
            this.lblminY.Name = "lblminY";
            this.lblminY.Size = new System.Drawing.Size(29, 12);
            this.lblminY.TabIndex = 62;
            this.lblminY.Text = "minY";
            // 
            // lblmaxY
            // 
            this.lblmaxY.AutoSize = true;
            this.lblmaxY.Location = new System.Drawing.Point(12, 219);
            this.lblmaxY.Name = "lblmaxY";
            this.lblmaxY.Size = new System.Drawing.Size(29, 12);
            this.lblmaxY.TabIndex = 63;
            this.lblmaxY.Text = "maxY";
            // 
            // lblmaxYshow
            // 
            this.lblmaxYshow.AutoSize = true;
            this.lblmaxYshow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblmaxYshow.Location = new System.Drawing.Point(47, 219);
            this.lblmaxYshow.Name = "lblmaxYshow";
            this.lblmaxYshow.Size = new System.Drawing.Size(26, 12);
            this.lblmaxYshow.TabIndex = 64;
            this.lblmaxYshow.Text = "111";
            // 
            // rect
            // 
            this.rect.Controls.Add(this.btnclear);
            this.rect.Controls.Add(this.btnrand);
            this.rect.Controls.Add(this.btncall);
            this.rect.Controls.Add(this.btnoutput);
            this.rect.Controls.Add(this.btnlast);
            this.rect.Controls.Add(this.btnnext);
            this.rect.Controls.Add(this.btnprev);
            this.rect.Controls.Add(this.btnfirst);
            this.rect.Controls.Add(this.btnsave);
            this.rect.Controls.Add(this.lblgang);
            this.rect.Controls.Add(this.txtnow);
            this.rect.Controls.Add(this.btnremove);
            this.rect.Controls.Add(this.btnadd);
            this.rect.Controls.Add(this.txty2);
            this.rect.Controls.Add(this.lbly2);
            this.rect.Controls.Add(this.txtx2);
            this.rect.Controls.Add(this.lblx2);
            this.rect.Controls.Add(this.txty1);
            this.rect.Controls.Add(this.lbly1);
            this.rect.Controls.Add(this.txtx1);
            this.rect.Controls.Add(this.lblx1);
            this.rect.Location = new System.Drawing.Point(14, 253);
            this.rect.Name = "rect";
            this.rect.Size = new System.Drawing.Size(250, 274);
            this.rect.TabIndex = 65;
            this.rect.TabStop = false;
            this.rect.Text = "查询矩形框选取";
            // 
            // btnrand
            // 
            this.btnrand.Location = new System.Drawing.Point(94, 214);
            this.btnrand.Name = "btnrand";
            this.btnrand.Size = new System.Drawing.Size(66, 40);
            this.btnrand.TabIndex = 73;
            this.btnrand.Text = "随机数据";
            this.btnrand.UseVisualStyleBackColor = true;
            this.btnrand.Click += new System.EventHandler(this.btnrand_Click);
            // 
            // btncall
            // 
            this.btncall.Location = new System.Drawing.Point(171, 213);
            this.btncall.Name = "btncall";
            this.btncall.Size = new System.Drawing.Size(73, 41);
            this.btncall.TabIndex = 72;
            this.btncall.Text = "调用程序";
            this.btncall.UseVisualStyleBackColor = true;
            this.btncall.Click += new System.EventHandler(this.btncall_Click);
            // 
            // btnoutput
            // 
            this.btnoutput.Location = new System.Drawing.Point(12, 214);
            this.btnoutput.Name = "btnoutput";
            this.btnoutput.Size = new System.Drawing.Size(69, 40);
            this.btnoutput.TabIndex = 71;
            this.btnoutput.Text = "导出";
            this.btnoutput.UseVisualStyleBackColor = true;
            this.btnoutput.Click += new System.EventHandler(this.btnoutput_Click);
            // 
            // btnlast
            // 
            this.btnlast.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnlast.Location = new System.Drawing.Point(195, 184);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(24, 23);
            this.btnlast.TabIndex = 70;
            this.btnlast.Text = ">>";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnnext
            // 
            this.btnnext.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnnext.Location = new System.Drawing.Point(171, 184);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(24, 23);
            this.btnnext.TabIndex = 69;
            this.btnnext.Text = ">";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnprev
            // 
            this.btnprev.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnprev.Location = new System.Drawing.Point(67, 184);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(24, 23);
            this.btnprev.TabIndex = 68;
            this.btnprev.Text = "<";
            this.btnprev.UseVisualStyleBackColor = true;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnfirst.Location = new System.Drawing.Point(43, 184);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(24, 23);
            this.btnfirst.TabIndex = 67;
            this.btnfirst.Text = "<<";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(206, 143);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(38, 25);
            this.btnsave.TabIndex = 66;
            this.btnsave.Text = "保存";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // lblgang
            // 
            this.lblgang.AutoSize = true;
            this.lblgang.Location = new System.Drawing.Point(135, 189);
            this.lblgang.Name = "lblgang";
            this.lblgang.Size = new System.Drawing.Size(17, 12);
            this.lblgang.TabIndex = 65;
            this.lblgang.Text = "/0";
            // 
            // txtnow
            // 
            this.txtnow.Location = new System.Drawing.Point(94, 186);
            this.txtnow.Name = "txtnow";
            this.txtnow.Size = new System.Drawing.Size(41, 21);
            this.txtnow.TabIndex = 64;
            this.txtnow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtnow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnow_KeyDown);
            // 
            // btnremove
            // 
            this.btnremove.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnremove.Location = new System.Drawing.Point(224, 184);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(22, 23);
            this.btnremove.TabIndex = 63;
            this.btnremove.Text = "-";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnadd.Location = new System.Drawing.Point(11, 184);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(21, 23);
            this.btnadd.TabIndex = 62;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txty2
            // 
            this.txty2.Location = new System.Drawing.Point(87, 146);
            this.txty2.Name = "txty2";
            this.txty2.Size = new System.Drawing.Size(110, 21);
            this.txty2.TabIndex = 61;
            this.txty2.TextChanged += new System.EventHandler(this.txty2_TextChanged);
            // 
            // lbly2
            // 
            this.lbly2.AutoSize = true;
            this.lbly2.Location = new System.Drawing.Point(10, 149);
            this.lbly2.Name = "lbly2";
            this.lbly2.Size = new System.Drawing.Size(71, 12);
            this.lbly2.TabIndex = 60;
            this.lbly2.Text = "右下角坐标Y";
            // 
            // txtx2
            // 
            this.txtx2.Location = new System.Drawing.Point(87, 110);
            this.txtx2.Name = "txtx2";
            this.txtx2.Size = new System.Drawing.Size(110, 21);
            this.txtx2.TabIndex = 59;
            this.txtx2.TextChanged += new System.EventHandler(this.txtx2_TextChanged);
            // 
            // lblx2
            // 
            this.lblx2.AutoSize = true;
            this.lblx2.Location = new System.Drawing.Point(10, 113);
            this.lblx2.Name = "lblx2";
            this.lblx2.Size = new System.Drawing.Size(71, 12);
            this.lblx2.TabIndex = 58;
            this.lblx2.Text = "右下角坐标X";
            // 
            // txty1
            // 
            this.txty1.Location = new System.Drawing.Point(87, 70);
            this.txty1.Name = "txty1";
            this.txty1.Size = new System.Drawing.Size(110, 21);
            this.txty1.TabIndex = 57;
            this.txty1.TextChanged += new System.EventHandler(this.txty1_TextChanged);
            // 
            // lbly1
            // 
            this.lbly1.AutoSize = true;
            this.lbly1.Location = new System.Drawing.Point(10, 73);
            this.lbly1.Name = "lbly1";
            this.lbly1.Size = new System.Drawing.Size(71, 12);
            this.lbly1.TabIndex = 56;
            this.lbly1.Text = "左上角坐标Y";
            // 
            // txtx1
            // 
            this.txtx1.Location = new System.Drawing.Point(87, 27);
            this.txtx1.Name = "txtx1";
            this.txtx1.Size = new System.Drawing.Size(110, 21);
            this.txtx1.TabIndex = 1;
            this.txtx1.TextChanged += new System.EventHandler(this.txtx1_TextChanged);
            // 
            // lblx1
            // 
            this.lblx1.AutoSize = true;
            this.lblx1.Location = new System.Drawing.Point(10, 30);
            this.lblx1.Name = "lblx1";
            this.lblx1.Size = new System.Drawing.Size(71, 12);
            this.lblx1.TabIndex = 0;
            this.lblx1.Text = "左上角坐标X";
            // 
            // result
            // 
            this.result.Controls.Add(this.lblline);
            this.result.Controls.Add(this.lblchoose);
            this.result.Controls.Add(this.txtchoose);
            this.result.Controls.Add(this.btndisplay);
            this.result.Controls.Add(this.listView1);
            this.result.Location = new System.Drawing.Point(13, 535);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(244, 183);
            this.result.TabIndex = 66;
            this.result.TabStop = false;
            this.result.Text = "查看结果";
            // 
            // lblline
            // 
            this.lblline.AutoSize = true;
            this.lblline.Location = new System.Drawing.Point(101, 152);
            this.lblline.Name = "lblline";
            this.lblline.Size = new System.Drawing.Size(17, 12);
            this.lblline.TabIndex = 4;
            this.lblline.Text = "行";
            // 
            // lblchoose
            // 
            this.lblchoose.AutoSize = true;
            this.lblchoose.Location = new System.Drawing.Point(17, 152);
            this.lblchoose.Name = "lblchoose";
            this.lblchoose.Size = new System.Drawing.Size(29, 12);
            this.lblchoose.TabIndex = 3;
            this.lblchoose.Text = "显示";
            // 
            // txtchoose
            // 
            this.txtchoose.Location = new System.Drawing.Point(49, 148);
            this.txtchoose.Name = "txtchoose";
            this.txtchoose.Size = new System.Drawing.Size(48, 21);
            this.txtchoose.TabIndex = 2;
            this.txtchoose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtchoose_KeyDown);
            // 
            // btndisplay
            // 
            this.btndisplay.Location = new System.Drawing.Point(138, 140);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(82, 37);
            this.btndisplay.TabIndex = 1;
            this.btndisplay.Text = "显示";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(19, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(201, 118);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "查询编号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "值";
            this.columnHeader2.Width = 120;
            // 
            // lblxy
            // 
            this.lblxy.AutoSize = true;
            this.lblxy.Location = new System.Drawing.Point(758, 687);
            this.lblxy.Name = "lblxy";
            this.lblxy.Size = new System.Drawing.Size(35, 12);
            this.lblxy.TabIndex = 67;
            this.lblxy.Text = "(0,0)";
            // 
            // btnopen2
            // 
            this.btnopen2.Location = new System.Drawing.Point(40, 61);
            this.btnopen2.Name = "btnopen2";
            this.btnopen2.Size = new System.Drawing.Size(35, 35);
            this.btnopen2.TabIndex = 69;
            this.btnopen2.Text = "2";
            this.btnopen2.UseVisualStyleBackColor = true;
            this.btnopen2.Click += new System.EventHandler(this.btnopen2_Click);
            // 
            // btnopen3
            // 
            this.btnopen3.Location = new System.Drawing.Point(74, 61);
            this.btnopen3.Name = "btnopen3";
            this.btnopen3.Size = new System.Drawing.Size(35, 35);
            this.btnopen3.TabIndex = 70;
            this.btnopen3.Text = "3";
            this.btnopen3.UseVisualStyleBackColor = true;
            this.btnopen3.Click += new System.EventHandler(this.btnopen3_Click);
            // 
            // btnopen4
            // 
            this.btnopen4.Location = new System.Drawing.Point(108, 61);
            this.btnopen4.Name = "btnopen4";
            this.btnopen4.Size = new System.Drawing.Size(35, 35);
            this.btnopen4.TabIndex = 71;
            this.btnopen4.Text = "4";
            this.btnopen4.UseVisualStyleBackColor = true;
            this.btnopen4.Click += new System.EventHandler(this.btnopen4_Click);
            // 
            // btnopen5
            // 
            this.btnopen5.Location = new System.Drawing.Point(142, 61);
            this.btnopen5.Name = "btnopen5";
            this.btnopen5.Size = new System.Drawing.Size(35, 35);
            this.btnopen5.TabIndex = 72;
            this.btnopen5.Text = "5";
            this.btnopen5.UseVisualStyleBackColor = true;
            this.btnopen5.Click += new System.EventHandler(this.btnopen5_Click);
            // 
            // btnopen6
            // 
            this.btnopen6.Location = new System.Drawing.Point(176, 61);
            this.btnopen6.Name = "btnopen6";
            this.btnopen6.Size = new System.Drawing.Size(35, 35);
            this.btnopen6.TabIndex = 73;
            this.btnopen6.Text = "6";
            this.btnopen6.UseVisualStyleBackColor = true;
            this.btnopen6.Click += new System.EventHandler(this.btnopen6_Click);
            // 
            // btnopen7
            // 
            this.btnopen7.Location = new System.Drawing.Point(210, 61);
            this.btnopen7.Name = "btnopen7";
            this.btnopen7.Size = new System.Drawing.Size(35, 35);
            this.btnopen7.TabIndex = 74;
            this.btnopen7.Text = "7";
            this.btnopen7.UseVisualStyleBackColor = true;
            this.btnopen7.Click += new System.EventHandler(this.btnopen7_Click);
            // 
            // btnopen8
            // 
            this.btnopen8.Location = new System.Drawing.Point(6, 96);
            this.btnopen8.Name = "btnopen8";
            this.btnopen8.Size = new System.Drawing.Size(35, 35);
            this.btnopen8.TabIndex = 75;
            this.btnopen8.Text = "8";
            this.btnopen8.UseVisualStyleBackColor = true;
            this.btnopen8.Click += new System.EventHandler(this.btnopen8_Click);
            // 
            // btnopen9
            // 
            this.btnopen9.Location = new System.Drawing.Point(40, 96);
            this.btnopen9.Name = "btnopen9";
            this.btnopen9.Size = new System.Drawing.Size(35, 35);
            this.btnopen9.TabIndex = 76;
            this.btnopen9.Text = "9";
            this.btnopen9.UseVisualStyleBackColor = true;
            this.btnopen9.Click += new System.EventHandler(this.btnopen9_Click);
            // 
            // btnopen10
            // 
            this.btnopen10.Location = new System.Drawing.Point(74, 96);
            this.btnopen10.Name = "btnopen10";
            this.btnopen10.Size = new System.Drawing.Size(35, 35);
            this.btnopen10.TabIndex = 77;
            this.btnopen10.Text = "10";
            this.btnopen10.UseVisualStyleBackColor = true;
            this.btnopen10.Click += new System.EventHandler(this.btnopen10_Click);
            // 
            // btnopen11
            // 
            this.btnopen11.Location = new System.Drawing.Point(108, 96);
            this.btnopen11.Name = "btnopen11";
            this.btnopen11.Size = new System.Drawing.Size(35, 35);
            this.btnopen11.TabIndex = 78;
            this.btnopen11.Text = "11";
            this.btnopen11.UseVisualStyleBackColor = true;
            this.btnopen11.Click += new System.EventHandler(this.btnopen11_Click);
            // 
            // btnopen12
            // 
            this.btnopen12.Location = new System.Drawing.Point(142, 96);
            this.btnopen12.Name = "btnopen12";
            this.btnopen12.Size = new System.Drawing.Size(35, 35);
            this.btnopen12.TabIndex = 79;
            this.btnopen12.Text = "12";
            this.btnopen12.UseVisualStyleBackColor = true;
            this.btnopen12.Click += new System.EventHandler(this.btnopen12_Click);
            // 
            // btnopen13
            // 
            this.btnopen13.Location = new System.Drawing.Point(176, 96);
            this.btnopen13.Name = "btnopen13";
            this.btnopen13.Size = new System.Drawing.Size(35, 35);
            this.btnopen13.TabIndex = 81;
            this.btnopen13.Text = "13";
            this.btnopen13.UseVisualStyleBackColor = true;
            this.btnopen13.Click += new System.EventHandler(this.btnopen13_Click);
            // 
            // btnopen14
            // 
            this.btnopen14.Location = new System.Drawing.Point(210, 96);
            this.btnopen14.Name = "btnopen14";
            this.btnopen14.Size = new System.Drawing.Size(35, 35);
            this.btnopen14.TabIndex = 82;
            this.btnopen14.Text = "14";
            this.btnopen14.UseVisualStyleBackColor = true;
            this.btnopen14.Click += new System.EventHandler(this.btnopen14_Click);
            // 
            // txtorigin2
            // 
            this.txtorigin2.Location = new System.Drawing.Point(218, 236);
            this.txtorigin2.Name = "txtorigin2";
            this.txtorigin2.Size = new System.Drawing.Size(44, 21);
            this.txtorigin2.TabIndex = 114;
            this.txtorigin2.Text = "1";
            this.txtorigin2.TextChanged += new System.EventHandler(this.txtorigin2_TextChanged);
            // 
            // lblorigin2
            // 
            this.lblorigin2.AutoSize = true;
            this.lblorigin2.Location = new System.Drawing.Point(219, 221);
            this.lblorigin2.Name = "lblorigin2";
            this.lblorigin2.Size = new System.Drawing.Size(41, 12);
            this.lblorigin2.TabIndex = 113;
            this.lblorigin2.Text = "框粗细";
            // 
            // txtorigin
            // 
            this.txtorigin.Location = new System.Drawing.Point(216, 197);
            this.txtorigin.Name = "txtorigin";
            this.txtorigin.Size = new System.Drawing.Size(44, 21);
            this.txtorigin.TabIndex = 112;
            this.txtorigin.Text = "1";
            this.txtorigin.TextChanged += new System.EventHandler(this.txtorigin_TextChanged);
            // 
            // lblorigin
            // 
            this.lblorigin.AutoSize = true;
            this.lblorigin.Location = new System.Drawing.Point(219, 178);
            this.lblorigin.Name = "lblorigin";
            this.lblorigin.Size = new System.Drawing.Size(41, 12);
            this.lblorigin.TabIndex = 111;
            this.lblorigin.Text = "点粗细";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(207, 113);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(37, 24);
            this.btnclear.TabIndex = 115;
            this.btnclear.Text = "清空";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // frm2Dall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.txtorigin2);
            this.Controls.Add(this.lblorigin2);
            this.Controls.Add(this.txtorigin);
            this.Controls.Add(this.lblorigin);
            this.Controls.Add(this.btnopen14);
            this.Controls.Add(this.btnopen13);
            this.Controls.Add(this.btnopen12);
            this.Controls.Add(this.btnopen11);
            this.Controls.Add(this.btnopen10);
            this.Controls.Add(this.btnopen9);
            this.Controls.Add(this.btnopen8);
            this.Controls.Add(this.btnopen7);
            this.Controls.Add(this.btnopen6);
            this.Controls.Add(this.btnopen5);
            this.Controls.Add(this.btnopen4);
            this.Controls.Add(this.btnopen3);
            this.Controls.Add(this.btnopen2);
            this.Controls.Add(this.lblxy);
            this.Controls.Add(this.result);
            this.Controls.Add(this.rect);
            this.Controls.Add(this.lblmaxYshow);
            this.Controls.Add(this.lblmaxY);
            this.Controls.Add(this.lblminY);
            this.Controls.Add(this.lblminYshow);
            this.Controls.Add(this.lblmaxXshow);
            this.Controls.Add(this.lblmaxX);
            this.Controls.Add(this.lblminXshow);
            this.Controls.Add(this.lblminx);
            this.Controls.Add(this.btnopen1);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.txtfile);
            this.Controls.Add(this.lblfile);
            this.Name = "frm2Dall";
            this.Text = "所有轨迹二维查询";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm2Dall_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.rect.ResumeLayout(false);
            this.rect.PerformLayout();
            this.result.ResumeLayout(false);
            this.result.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfile;
        private System.Windows.Forms.TextBox txtfile;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Button btnopen1;
        private System.Windows.Forms.Label lblminx;
        private System.Windows.Forms.Label lblminXshow;
        private System.Windows.Forms.Label lblmaxX;
        private System.Windows.Forms.Label lblmaxXshow;
        private System.Windows.Forms.Label lblminYshow;
        private System.Windows.Forms.Label lblminY;
        private System.Windows.Forms.Label lblmaxY;
        private System.Windows.Forms.Label lblmaxYshow;
        private System.Windows.Forms.GroupBox rect;
        private System.Windows.Forms.Button btnrand;
        private System.Windows.Forms.Button btncall;
        private System.Windows.Forms.Button btnoutput;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label lblgang;
        private System.Windows.Forms.TextBox txtnow;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txty2;
        private System.Windows.Forms.Label lbly2;
        private System.Windows.Forms.TextBox txtx2;
        private System.Windows.Forms.Label lblx2;
        private System.Windows.Forms.TextBox txty1;
        private System.Windows.Forms.Label lbly1;
        private System.Windows.Forms.TextBox txtx1;
        private System.Windows.Forms.Label lblx1;
        private System.Windows.Forms.GroupBox result;
        private System.Windows.Forms.Label lblline;
        private System.Windows.Forms.Label lblchoose;
        private System.Windows.Forms.TextBox txtchoose;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblxy;
        private System.Windows.Forms.Button btnopen2;
        private System.Windows.Forms.Button btnopen3;
        private System.Windows.Forms.Button btnopen4;
        private System.Windows.Forms.Button btnopen5;
        private System.Windows.Forms.Button btnopen6;
        private System.Windows.Forms.Button btnopen7;
        private System.Windows.Forms.Button btnopen8;
        private System.Windows.Forms.Button btnopen9;
        private System.Windows.Forms.Button btnopen10;
        private System.Windows.Forms.Button btnopen11;
        private System.Windows.Forms.Button btnopen12;
        private System.Windows.Forms.Button btnopen13;
        private System.Windows.Forms.Button btnopen14;
        private System.Windows.Forms.TextBox txtorigin2;
        private System.Windows.Forms.Label lblorigin2;
        private System.Windows.Forms.TextBox txtorigin;
        private System.Windows.Forms.Label lblorigin;
        private System.Windows.Forms.Button btnclear;
    }
}