namespace WindowsFormsApplication1
{
    partial class frm2Dsingle
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
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.lblfile = new System.Windows.Forms.Label();
            this.txtfile = new System.Windows.Forms.TextBox();
            this.lblnum = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.lblminx = new System.Windows.Forms.Label();
            this.lblminXshow = new System.Windows.Forms.Label();
            this.lblmaxX = new System.Windows.Forms.Label();
            this.lblmaxXshow = new System.Windows.Forms.Label();
            this.minY = new System.Windows.Forms.Label();
            this.lblminYshow = new System.Windows.Forms.Label();
            this.lblmaxY = new System.Windows.Forms.Label();
            this.lblmaxYshow = new System.Windows.Forms.Label();
            this.btnopen = new System.Windows.Forms.Button();
            this.btnbrowse = new System.Windows.Forms.Button();
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
            this.lblxy = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.GroupBox();
            this.lblline = new System.Windows.Forms.Label();
            this.lblchoose = new System.Windows.Forms.Label();
            this.txtchoose = new System.Windows.Forms.TextBox();
            this.btndisplay = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtorigin = new System.Windows.Forms.TextBox();
            this.lblorigin = new System.Windows.Forms.Label();
            this.lblorigin2 = new System.Windows.Forms.Label();
            this.txtorigin2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.rect.SuspendLayout();
            this.result.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.Color.Black;
            this.pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic1.Location = new System.Drawing.Point(270, 12);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(1068, 661);
            this.pic1.TabIndex = 38;
            this.pic1.TabStop = false;
            this.pic1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic1_MouseDown);
            this.pic1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic1_MouseMove);
            this.pic1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic1_MouseUp);
            // 
            // lblfile
            // 
            this.lblfile.AutoSize = true;
            this.lblfile.Location = new System.Drawing.Point(12, 12);
            this.lblfile.Name = "lblfile";
            this.lblfile.Size = new System.Drawing.Size(101, 12);
            this.lblfile.TabIndex = 39;
            this.lblfile.Text = "轨迹文件所在目录";
            // 
            // txtfile
            // 
            this.txtfile.Location = new System.Drawing.Point(14, 34);
            this.txtfile.Name = "txtfile";
            this.txtfile.Size = new System.Drawing.Size(172, 21);
            this.txtfile.TabIndex = 40;
            this.txtfile.TextChanged += new System.EventHandler(this.txtfile_TextChanged);
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(12, 69);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(53, 12);
            this.lblnum.TabIndex = 42;
            this.lblnum.Text = "轨迹编号";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(14, 97);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(172, 21);
            this.txtnum.TabIndex = 43;
            // 
            // lblminx
            // 
            this.lblminx.AutoSize = true;
            this.lblminx.Location = new System.Drawing.Point(12, 134);
            this.lblminx.Name = "lblminx";
            this.lblminx.Size = new System.Drawing.Size(29, 12);
            this.lblminx.TabIndex = 44;
            this.lblminx.Text = "minX";
            // 
            // lblminXshow
            // 
            this.lblminXshow.AutoSize = true;
            this.lblminXshow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblminXshow.Location = new System.Drawing.Point(47, 134);
            this.lblminXshow.Name = "lblminXshow";
            this.lblminXshow.Size = new System.Drawing.Size(26, 12);
            this.lblminXshow.TabIndex = 45;
            this.lblminXshow.Text = "111";
            // 
            // lblmaxX
            // 
            this.lblmaxX.AutoSize = true;
            this.lblmaxX.Location = new System.Drawing.Point(12, 160);
            this.lblmaxX.Name = "lblmaxX";
            this.lblmaxX.Size = new System.Drawing.Size(29, 12);
            this.lblmaxX.TabIndex = 46;
            this.lblmaxX.Text = "maxX";
            // 
            // lblmaxXshow
            // 
            this.lblmaxXshow.AutoSize = true;
            this.lblmaxXshow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblmaxXshow.Location = new System.Drawing.Point(47, 160);
            this.lblmaxXshow.Name = "lblmaxXshow";
            this.lblmaxXshow.Size = new System.Drawing.Size(26, 12);
            this.lblmaxXshow.TabIndex = 47;
            this.lblmaxXshow.Text = "111";
            // 
            // minY
            // 
            this.minY.AutoSize = true;
            this.minY.Location = new System.Drawing.Point(12, 189);
            this.minY.Name = "minY";
            this.minY.Size = new System.Drawing.Size(29, 12);
            this.minY.TabIndex = 48;
            this.minY.Text = "minY";
            // 
            // lblminYshow
            // 
            this.lblminYshow.AutoSize = true;
            this.lblminYshow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblminYshow.Location = new System.Drawing.Point(47, 189);
            this.lblminYshow.Name = "lblminYshow";
            this.lblminYshow.Size = new System.Drawing.Size(26, 12);
            this.lblminYshow.TabIndex = 49;
            this.lblminYshow.Text = "111";
            // 
            // lblmaxY
            // 
            this.lblmaxY.AutoSize = true;
            this.lblmaxY.Location = new System.Drawing.Point(12, 219);
            this.lblmaxY.Name = "lblmaxY";
            this.lblmaxY.Size = new System.Drawing.Size(29, 12);
            this.lblmaxY.TabIndex = 50;
            this.lblmaxY.Text = "maxY";
            // 
            // lblmaxYshow
            // 
            this.lblmaxYshow.AutoSize = true;
            this.lblmaxYshow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblmaxYshow.Location = new System.Drawing.Point(47, 219);
            this.lblmaxYshow.Name = "lblmaxYshow";
            this.lblmaxYshow.Size = new System.Drawing.Size(26, 12);
            this.lblmaxYshow.TabIndex = 51;
            this.lblmaxYshow.Text = "111";
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(192, 89);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(44, 35);
            this.btnopen.TabIndex = 52;
            this.btnopen.Text = "打开";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(192, 26);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(44, 35);
            this.btnbrowse.TabIndex = 53;
            this.btnbrowse.Text = "浏览";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // rect
            // 
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
            this.rect.TabIndex = 55;
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
            // lblxy
            // 
            this.lblxy.AutoSize = true;
            this.lblxy.Location = new System.Drawing.Point(758, 687);
            this.lblxy.Name = "lblxy";
            this.lblxy.Size = new System.Drawing.Size(35, 12);
            this.lblxy.TabIndex = 56;
            this.lblxy.Text = "(0,0)";
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
            this.result.TabIndex = 57;
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
            // txtorigin
            // 
            this.txtorigin.Location = new System.Drawing.Point(218, 194);
            this.txtorigin.Name = "txtorigin";
            this.txtorigin.Size = new System.Drawing.Size(44, 21);
            this.txtorigin.TabIndex = 104;
            this.txtorigin.Text = "1";
            this.txtorigin.TextChanged += new System.EventHandler(this.txtorigin_TextChanged);
            // 
            // lblorigin
            // 
            this.lblorigin.AutoSize = true;
            this.lblorigin.Location = new System.Drawing.Point(216, 179);
            this.lblorigin.Name = "lblorigin";
            this.lblorigin.Size = new System.Drawing.Size(41, 12);
            this.lblorigin.TabIndex = 103;
            this.lblorigin.Text = "点粗细";
            // 
            // lblorigin2
            // 
            this.lblorigin2.AutoSize = true;
            this.lblorigin2.Location = new System.Drawing.Point(216, 218);
            this.lblorigin2.Name = "lblorigin2";
            this.lblorigin2.Size = new System.Drawing.Size(41, 12);
            this.lblorigin2.TabIndex = 105;
            this.lblorigin2.Text = "框粗细";
            // 
            // txtorigin2
            // 
            this.txtorigin2.Location = new System.Drawing.Point(218, 233);
            this.txtorigin2.Name = "txtorigin2";
            this.txtorigin2.Size = new System.Drawing.Size(44, 21);
            this.txtorigin2.TabIndex = 106;
            this.txtorigin2.Text = "1";
            this.txtorigin2.TextChanged += new System.EventHandler(this.txtorigin2_TextChanged);
            // 
            // frm2Dsingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.txtorigin2);
            this.Controls.Add(this.lblorigin2);
            this.Controls.Add(this.txtorigin);
            this.Controls.Add(this.result);
            this.Controls.Add(this.lblxy);
            this.Controls.Add(this.lblorigin);
            this.Controls.Add(this.rect);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.lblmaxYshow);
            this.Controls.Add(this.lblmaxY);
            this.Controls.Add(this.lblminYshow);
            this.Controls.Add(this.minY);
            this.Controls.Add(this.lblmaxXshow);
            this.Controls.Add(this.lblmaxX);
            this.Controls.Add(this.lblminXshow);
            this.Controls.Add(this.lblminx);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.txtfile);
            this.Controls.Add(this.lblfile);
            this.Controls.Add(this.pic1);
            this.Name = "frm2Dsingle";
            this.Text = "单一轨迹二维查询";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm2Dsingle_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.rect.ResumeLayout(false);
            this.rect.PerformLayout();
            this.result.ResumeLayout(false);
            this.result.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Label lblfile;
        private System.Windows.Forms.TextBox txtfile;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label lblminx;
        private System.Windows.Forms.Label lblminXshow;
        private System.Windows.Forms.Label lblmaxX;
        private System.Windows.Forms.Label lblmaxXshow;
        private System.Windows.Forms.Label minY;
        private System.Windows.Forms.Label lblminYshow;
        private System.Windows.Forms.Label lblmaxY;
        private System.Windows.Forms.Label lblmaxYshow;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.GroupBox rect;
        private System.Windows.Forms.TextBox txty2;
        private System.Windows.Forms.Label lbly2;
        private System.Windows.Forms.TextBox txtx2;
        private System.Windows.Forms.Label lblx2;
        private System.Windows.Forms.TextBox txty1;
        private System.Windows.Forms.Label lbly1;
        private System.Windows.Forms.TextBox txtx1;
        private System.Windows.Forms.Label lblx1;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label lblgang;
        private System.Windows.Forms.TextBox txtnow;
        private System.Windows.Forms.Label lblxy;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnoutput;
        private System.Windows.Forms.Button btncall;
        private System.Windows.Forms.GroupBox result;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.Label lblline;
        private System.Windows.Forms.Label lblchoose;
        private System.Windows.Forms.TextBox txtchoose;
        private System.Windows.Forms.Button btnrand;
        private System.Windows.Forms.TextBox txtorigin;
        private System.Windows.Forms.Label lblorigin;
        private System.Windows.Forms.Label lblorigin2;
        private System.Windows.Forms.TextBox txtorigin2;
    }
}