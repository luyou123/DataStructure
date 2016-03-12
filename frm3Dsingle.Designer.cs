namespace WindowsFormsApplication1
{
    partial class frm3Dsingle
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
            this.lblnum = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.btnopen = new System.Windows.Forms.Button();
            this.lblminx = new System.Windows.Forms.Label();
            this.lblminXshow = new System.Windows.Forms.Label();
            this.lblmaxX = new System.Windows.Forms.Label();
            this.lblmaxXshow = new System.Windows.Forms.Label();
            this.minY = new System.Windows.Forms.Label();
            this.lblminYshow = new System.Windows.Forms.Label();
            this.lblmaxY = new System.Windows.Forms.Label();
            this.lblmaxYshow = new System.Windows.Forms.Label();
            this.rect = new System.Windows.Forms.GroupBox();
            this.lblsec2 = new System.Windows.Forms.Label();
            this.cbosec2 = new System.Windows.Forms.ComboBox();
            this.lblmin2 = new System.Windows.Forms.Label();
            this.cbomin2 = new System.Windows.Forms.ComboBox();
            this.lblhour2 = new System.Windows.Forms.Label();
            this.cbohour2 = new System.Windows.Forms.ComboBox();
            this.lblsec1 = new System.Windows.Forms.Label();
            this.cbosec1 = new System.Windows.Forms.ComboBox();
            this.lblmin1 = new System.Windows.Forms.Label();
            this.cbomin1 = new System.Windows.Forms.ComboBox();
            this.lblhour1 = new System.Windows.Forms.Label();
            this.cbohour1 = new System.Windows.Forms.ComboBox();
            this.lblday2 = new System.Windows.Forms.Label();
            this.cboday2 = new System.Windows.Forms.ComboBox();
            this.lblmonth2 = new System.Windows.Forms.Label();
            this.cbomonth2 = new System.Windows.Forms.ComboBox();
            this.lblyear2 = new System.Windows.Forms.Label();
            this.cboyear2 = new System.Windows.Forms.ComboBox();
            this.lblend = new System.Windows.Forms.Label();
            this.lblday1 = new System.Windows.Forms.Label();
            this.cboday1 = new System.Windows.Forms.ComboBox();
            this.lblmonth1 = new System.Windows.Forms.Label();
            this.cbomonth1 = new System.Windows.Forms.ComboBox();
            this.lblyear1 = new System.Windows.Forms.Label();
            this.cboyear1 = new System.Windows.Forms.ComboBox();
            this.lblstart = new System.Windows.Forms.Label();
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
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.result = new System.Windows.Forms.GroupBox();
            this.lblline = new System.Windows.Forms.Label();
            this.lblchoose = new System.Windows.Forms.Label();
            this.txtchoose = new System.Windows.Forms.TextBox();
            this.btndisplay = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblxy = new System.Windows.Forms.Label();
            this.lblminT = new System.Windows.Forms.Label();
            this.lblminTshow = new System.Windows.Forms.Label();
            this.lblmaxT = new System.Windows.Forms.Label();
            this.lblmaxTshow = new System.Windows.Forms.Label();
            this.txtorigin2 = new System.Windows.Forms.TextBox();
            this.lblorigin2 = new System.Windows.Forms.Label();
            this.txtorigin = new System.Windows.Forms.TextBox();
            this.lblorigin = new System.Windows.Forms.Label();
            this.rect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
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
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(12, 61);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(53, 12);
            this.lblnum.TabIndex = 55;
            this.lblnum.Text = "轨迹编号";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(14, 82);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(172, 21);
            this.txtnum.TabIndex = 56;
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(192, 75);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(44, 35);
            this.btnopen.TabIndex = 57;
            this.btnopen.Text = "打开";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // lblminx
            // 
            this.lblminx.AutoSize = true;
            this.lblminx.Location = new System.Drawing.Point(14, 110);
            this.lblminx.Name = "lblminx";
            this.lblminx.Size = new System.Drawing.Size(29, 12);
            this.lblminx.TabIndex = 58;
            this.lblminx.Text = "minX";
            // 
            // lblminXshow
            // 
            this.lblminXshow.AutoSize = true;
            this.lblminXshow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblminXshow.Location = new System.Drawing.Point(49, 110);
            this.lblminXshow.Name = "lblminXshow";
            this.lblminXshow.Size = new System.Drawing.Size(26, 12);
            this.lblminXshow.TabIndex = 59;
            this.lblminXshow.Text = "111";
            // 
            // lblmaxX
            // 
            this.lblmaxX.AutoSize = true;
            this.lblmaxX.Location = new System.Drawing.Point(14, 124);
            this.lblmaxX.Name = "lblmaxX";
            this.lblmaxX.Size = new System.Drawing.Size(29, 12);
            this.lblmaxX.TabIndex = 60;
            this.lblmaxX.Text = "maxX";
            // 
            // lblmaxXshow
            // 
            this.lblmaxXshow.AutoSize = true;
            this.lblmaxXshow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblmaxXshow.Location = new System.Drawing.Point(49, 124);
            this.lblmaxXshow.Name = "lblmaxXshow";
            this.lblmaxXshow.Size = new System.Drawing.Size(26, 12);
            this.lblmaxXshow.TabIndex = 61;
            this.lblmaxXshow.Text = "111";
            // 
            // minY
            // 
            this.minY.AutoSize = true;
            this.minY.Location = new System.Drawing.Point(14, 138);
            this.minY.Name = "minY";
            this.minY.Size = new System.Drawing.Size(29, 12);
            this.minY.TabIndex = 62;
            this.minY.Text = "minY";
            // 
            // lblminYshow
            // 
            this.lblminYshow.AutoSize = true;
            this.lblminYshow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblminYshow.Location = new System.Drawing.Point(49, 138);
            this.lblminYshow.Name = "lblminYshow";
            this.lblminYshow.Size = new System.Drawing.Size(26, 12);
            this.lblminYshow.TabIndex = 63;
            this.lblminYshow.Text = "111";
            // 
            // lblmaxY
            // 
            this.lblmaxY.AutoSize = true;
            this.lblmaxY.Location = new System.Drawing.Point(14, 152);
            this.lblmaxY.Name = "lblmaxY";
            this.lblmaxY.Size = new System.Drawing.Size(29, 12);
            this.lblmaxY.TabIndex = 64;
            this.lblmaxY.Text = "maxY";
            // 
            // lblmaxYshow
            // 
            this.lblmaxYshow.AutoSize = true;
            this.lblmaxYshow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblmaxYshow.Location = new System.Drawing.Point(49, 153);
            this.lblmaxYshow.Name = "lblmaxYshow";
            this.lblmaxYshow.Size = new System.Drawing.Size(26, 12);
            this.lblmaxYshow.TabIndex = 65;
            this.lblmaxYshow.Text = "111";
            // 
            // rect
            // 
            this.rect.Controls.Add(this.lblsec2);
            this.rect.Controls.Add(this.cbosec2);
            this.rect.Controls.Add(this.lblmin2);
            this.rect.Controls.Add(this.cbomin2);
            this.rect.Controls.Add(this.lblhour2);
            this.rect.Controls.Add(this.cbohour2);
            this.rect.Controls.Add(this.lblsec1);
            this.rect.Controls.Add(this.cbosec1);
            this.rect.Controls.Add(this.lblmin1);
            this.rect.Controls.Add(this.cbomin1);
            this.rect.Controls.Add(this.lblhour1);
            this.rect.Controls.Add(this.cbohour1);
            this.rect.Controls.Add(this.lblday2);
            this.rect.Controls.Add(this.cboday2);
            this.rect.Controls.Add(this.lblmonth2);
            this.rect.Controls.Add(this.cbomonth2);
            this.rect.Controls.Add(this.lblyear2);
            this.rect.Controls.Add(this.cboyear2);
            this.rect.Controls.Add(this.lblend);
            this.rect.Controls.Add(this.lblday1);
            this.rect.Controls.Add(this.cboday1);
            this.rect.Controls.Add(this.lblmonth1);
            this.rect.Controls.Add(this.cbomonth1);
            this.rect.Controls.Add(this.lblyear1);
            this.rect.Controls.Add(this.cboyear1);
            this.rect.Controls.Add(this.lblstart);
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
            this.rect.Location = new System.Drawing.Point(16, 200);
            this.rect.Name = "rect";
            this.rect.Size = new System.Drawing.Size(250, 331);
            this.rect.TabIndex = 66;
            this.rect.TabStop = false;
            this.rect.Text = "查询矩形框选取";
            // 
            // lblsec2
            // 
            this.lblsec2.AutoSize = true;
            this.lblsec2.Location = new System.Drawing.Point(229, 219);
            this.lblsec2.Name = "lblsec2";
            this.lblsec2.Size = new System.Drawing.Size(17, 12);
            this.lblsec2.TabIndex = 99;
            this.lblsec2.Text = "秒";
            // 
            // cbosec2
            // 
            this.cbosec2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosec2.FormattingEnabled = true;
            this.cbosec2.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbosec2.Location = new System.Drawing.Point(187, 216);
            this.cbosec2.Name = "cbosec2";
            this.cbosec2.Size = new System.Drawing.Size(42, 20);
            this.cbosec2.TabIndex = 98;
            // 
            // lblmin2
            // 
            this.lblmin2.AutoSize = true;
            this.lblmin2.Location = new System.Drawing.Point(171, 219);
            this.lblmin2.Name = "lblmin2";
            this.lblmin2.Size = new System.Drawing.Size(17, 12);
            this.lblmin2.TabIndex = 97;
            this.lblmin2.Text = "分";
            // 
            // cbomin2
            // 
            this.cbomin2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomin2.FormattingEnabled = true;
            this.cbomin2.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbomin2.Location = new System.Drawing.Point(129, 216);
            this.cbomin2.Name = "cbomin2";
            this.cbomin2.Size = new System.Drawing.Size(41, 20);
            this.cbomin2.TabIndex = 96;
            // 
            // lblhour2
            // 
            this.lblhour2.AutoSize = true;
            this.lblhour2.Location = new System.Drawing.Point(113, 219);
            this.lblhour2.Name = "lblhour2";
            this.lblhour2.Size = new System.Drawing.Size(17, 12);
            this.lblhour2.TabIndex = 95;
            this.lblhour2.Text = "时";
            // 
            // cbohour2
            // 
            this.cbohour2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbohour2.FormattingEnabled = true;
            this.cbohour2.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cbohour2.Location = new System.Drawing.Point(63, 216);
            this.cbohour2.Name = "cbohour2";
            this.cbohour2.Size = new System.Drawing.Size(48, 20);
            this.cbohour2.TabIndex = 94;
            // 
            // lblsec1
            // 
            this.lblsec1.AutoSize = true;
            this.lblsec1.Location = new System.Drawing.Point(229, 168);
            this.lblsec1.Name = "lblsec1";
            this.lblsec1.Size = new System.Drawing.Size(17, 12);
            this.lblsec1.TabIndex = 93;
            this.lblsec1.Text = "秒";
            // 
            // cbosec1
            // 
            this.cbosec1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosec1.FormattingEnabled = true;
            this.cbosec1.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbosec1.Location = new System.Drawing.Point(187, 165);
            this.cbosec1.Name = "cbosec1";
            this.cbosec1.Size = new System.Drawing.Size(42, 20);
            this.cbosec1.TabIndex = 92;
            // 
            // lblmin1
            // 
            this.lblmin1.AutoSize = true;
            this.lblmin1.Location = new System.Drawing.Point(170, 169);
            this.lblmin1.Name = "lblmin1";
            this.lblmin1.Size = new System.Drawing.Size(17, 12);
            this.lblmin1.TabIndex = 91;
            this.lblmin1.Text = "分";
            // 
            // cbomin1
            // 
            this.cbomin1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomin1.FormattingEnabled = true;
            this.cbomin1.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbomin1.Location = new System.Drawing.Point(129, 165);
            this.cbomin1.Name = "cbomin1";
            this.cbomin1.Size = new System.Drawing.Size(41, 20);
            this.cbomin1.TabIndex = 90;
            // 
            // lblhour1
            // 
            this.lblhour1.AutoSize = true;
            this.lblhour1.Location = new System.Drawing.Point(113, 168);
            this.lblhour1.Name = "lblhour1";
            this.lblhour1.Size = new System.Drawing.Size(17, 12);
            this.lblhour1.TabIndex = 89;
            this.lblhour1.Text = "时";
            // 
            // cbohour1
            // 
            this.cbohour1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbohour1.FormattingEnabled = true;
            this.cbohour1.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cbohour1.Location = new System.Drawing.Point(63, 165);
            this.cbohour1.Name = "cbohour1";
            this.cbohour1.Size = new System.Drawing.Size(49, 20);
            this.cbohour1.TabIndex = 88;
            // 
            // lblday2
            // 
            this.lblday2.AutoSize = true;
            this.lblday2.Location = new System.Drawing.Point(229, 193);
            this.lblday2.Name = "lblday2";
            this.lblday2.Size = new System.Drawing.Size(17, 12);
            this.lblday2.TabIndex = 87;
            this.lblday2.Text = "日";
            // 
            // cboday2
            // 
            this.cboday2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboday2.FormattingEnabled = true;
            this.cboday2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cboday2.Location = new System.Drawing.Point(186, 191);
            this.cboday2.Name = "cboday2";
            this.cboday2.Size = new System.Drawing.Size(43, 20);
            this.cboday2.TabIndex = 86;
            // 
            // lblmonth2
            // 
            this.lblmonth2.AutoSize = true;
            this.lblmonth2.Location = new System.Drawing.Point(171, 193);
            this.lblmonth2.Name = "lblmonth2";
            this.lblmonth2.Size = new System.Drawing.Size(17, 12);
            this.lblmonth2.TabIndex = 85;
            this.lblmonth2.Text = "月";
            // 
            // cbomonth2
            // 
            this.cbomonth2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomonth2.FormattingEnabled = true;
            this.cbomonth2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbomonth2.Location = new System.Drawing.Point(129, 190);
            this.cbomonth2.Name = "cbomonth2";
            this.cbomonth2.Size = new System.Drawing.Size(41, 20);
            this.cbomonth2.TabIndex = 84;
            // 
            // lblyear2
            // 
            this.lblyear2.AutoSize = true;
            this.lblyear2.Location = new System.Drawing.Point(113, 194);
            this.lblyear2.Name = "lblyear2";
            this.lblyear2.Size = new System.Drawing.Size(17, 12);
            this.lblyear2.TabIndex = 83;
            this.lblyear2.Text = "年";
            // 
            // cboyear2
            // 
            this.cboyear2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboyear2.FormattingEnabled = true;
            this.cboyear2.Items.AddRange(new object[] {
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012"});
            this.cboyear2.Location = new System.Drawing.Point(63, 191);
            this.cboyear2.Name = "cboyear2";
            this.cboyear2.Size = new System.Drawing.Size(49, 20);
            this.cboyear2.TabIndex = 82;
            // 
            // lblend
            // 
            this.lblend.AutoSize = true;
            this.lblend.Location = new System.Drawing.Point(10, 190);
            this.lblend.Name = "lblend";
            this.lblend.Size = new System.Drawing.Size(53, 12);
            this.lblend.TabIndex = 81;
            this.lblend.Text = "结束时间";
            // 
            // lblday1
            // 
            this.lblday1.AutoSize = true;
            this.lblday1.Location = new System.Drawing.Point(229, 142);
            this.lblday1.Name = "lblday1";
            this.lblday1.Size = new System.Drawing.Size(17, 12);
            this.lblday1.TabIndex = 80;
            this.lblday1.Text = "日";
            // 
            // cboday1
            // 
            this.cboday1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboday1.FormattingEnabled = true;
            this.cboday1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cboday1.Location = new System.Drawing.Point(187, 139);
            this.cboday1.Name = "cboday1";
            this.cboday1.Size = new System.Drawing.Size(42, 20);
            this.cboday1.TabIndex = 79;
            // 
            // lblmonth1
            // 
            this.lblmonth1.AutoSize = true;
            this.lblmonth1.Location = new System.Drawing.Point(171, 142);
            this.lblmonth1.Name = "lblmonth1";
            this.lblmonth1.Size = new System.Drawing.Size(17, 12);
            this.lblmonth1.TabIndex = 78;
            this.lblmonth1.Text = "月";
            // 
            // cbomonth1
            // 
            this.cbomonth1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomonth1.FormattingEnabled = true;
            this.cbomonth1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbomonth1.Location = new System.Drawing.Point(129, 139);
            this.cbomonth1.Name = "cbomonth1";
            this.cbomonth1.Size = new System.Drawing.Size(41, 20);
            this.cbomonth1.TabIndex = 77;
            // 
            // lblyear1
            // 
            this.lblyear1.AutoSize = true;
            this.lblyear1.Location = new System.Drawing.Point(113, 142);
            this.lblyear1.Name = "lblyear1";
            this.lblyear1.Size = new System.Drawing.Size(17, 12);
            this.lblyear1.TabIndex = 76;
            this.lblyear1.Text = "年";
            // 
            // cboyear1
            // 
            this.cboyear1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboyear1.FormattingEnabled = true;
            this.cboyear1.Items.AddRange(new object[] {
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012"});
            this.cboyear1.Location = new System.Drawing.Point(63, 139);
            this.cboyear1.Name = "cboyear1";
            this.cboyear1.Size = new System.Drawing.Size(48, 20);
            this.cboyear1.TabIndex = 75;
            // 
            // lblstart
            // 
            this.lblstart.AutoSize = true;
            this.lblstart.Location = new System.Drawing.Point(10, 142);
            this.lblstart.Name = "lblstart";
            this.lblstart.Size = new System.Drawing.Size(53, 12);
            this.lblstart.TabIndex = 74;
            this.lblstart.Text = "开始时间";
            // 
            // btnrand
            // 
            this.btnrand.Location = new System.Drawing.Point(94, 278);
            this.btnrand.Name = "btnrand";
            this.btnrand.Size = new System.Drawing.Size(66, 40);
            this.btnrand.TabIndex = 73;
            this.btnrand.Text = "随机数据";
            this.btnrand.UseVisualStyleBackColor = true;
            this.btnrand.Click += new System.EventHandler(this.btnrand_Click);
            // 
            // btncall
            // 
            this.btncall.Location = new System.Drawing.Point(171, 278);
            this.btncall.Name = "btncall";
            this.btncall.Size = new System.Drawing.Size(73, 41);
            this.btncall.TabIndex = 72;
            this.btncall.Text = "调用程序";
            this.btncall.UseVisualStyleBackColor = true;
            this.btncall.Click += new System.EventHandler(this.btncall_Click);
            // 
            // btnoutput
            // 
            this.btnoutput.Location = new System.Drawing.Point(12, 279);
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
            this.btnlast.Location = new System.Drawing.Point(195, 249);
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
            this.btnnext.Location = new System.Drawing.Point(171, 249);
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
            this.btnprev.Location = new System.Drawing.Point(67, 249);
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
            this.btnfirst.Location = new System.Drawing.Point(43, 249);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(24, 23);
            this.btnfirst.TabIndex = 67;
            this.btnfirst.Text = "<<";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(206, 110);
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
            this.lblgang.Location = new System.Drawing.Point(135, 254);
            this.lblgang.Name = "lblgang";
            this.lblgang.Size = new System.Drawing.Size(17, 12);
            this.lblgang.TabIndex = 65;
            this.lblgang.Text = "/0";
            // 
            // txtnow
            // 
            this.txtnow.Location = new System.Drawing.Point(94, 251);
            this.txtnow.Name = "txtnow";
            this.txtnow.Size = new System.Drawing.Size(41, 21);
            this.txtnow.TabIndex = 64;
            this.txtnow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtnow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnow_KeyDown);
            // 
            // btnremove
            // 
            this.btnremove.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnremove.Location = new System.Drawing.Point(224, 249);
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
            this.btnadd.Location = new System.Drawing.Point(11, 249);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(21, 23);
            this.btnadd.TabIndex = 62;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txty2
            // 
            this.txty2.Location = new System.Drawing.Point(87, 112);
            this.txty2.Name = "txty2";
            this.txty2.Size = new System.Drawing.Size(110, 21);
            this.txty2.TabIndex = 61;
            this.txty2.TextChanged += new System.EventHandler(this.txty2_TextChanged);
            // 
            // lbly2
            // 
            this.lbly2.AutoSize = true;
            this.lbly2.Location = new System.Drawing.Point(10, 115);
            this.lbly2.Name = "lbly2";
            this.lbly2.Size = new System.Drawing.Size(71, 12);
            this.lbly2.TabIndex = 60;
            this.lbly2.Text = "右下角坐标Y";
            // 
            // txtx2
            // 
            this.txtx2.Location = new System.Drawing.Point(87, 84);
            this.txtx2.Name = "txtx2";
            this.txtx2.Size = new System.Drawing.Size(110, 21);
            this.txtx2.TabIndex = 59;
            this.txtx2.TextChanged += new System.EventHandler(this.txtx2_TextChanged);
            // 
            // lblx2
            // 
            this.lblx2.AutoSize = true;
            this.lblx2.Location = new System.Drawing.Point(10, 87);
            this.lblx2.Name = "lblx2";
            this.lblx2.Size = new System.Drawing.Size(71, 12);
            this.lblx2.TabIndex = 58;
            this.lblx2.Text = "右下角坐标X";
            // 
            // txty1
            // 
            this.txty1.Location = new System.Drawing.Point(87, 56);
            this.txty1.Name = "txty1";
            this.txty1.Size = new System.Drawing.Size(110, 21);
            this.txty1.TabIndex = 57;
            this.txty1.TextChanged += new System.EventHandler(this.txty1_TextChanged);
            // 
            // lbly1
            // 
            this.lbly1.AutoSize = true;
            this.lbly1.Location = new System.Drawing.Point(10, 59);
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
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.Color.Black;
            this.pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic1.Location = new System.Drawing.Point(270, 12);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(1068, 661);
            this.pic1.TabIndex = 67;
            this.pic1.TabStop = false;
            this.pic1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic1_MouseDown);
            this.pic1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic1_MouseMove);
            this.pic1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic1_MouseUp);
            // 
            // result
            // 
            this.result.Controls.Add(this.lblline);
            this.result.Controls.Add(this.lblchoose);
            this.result.Controls.Add(this.txtchoose);
            this.result.Controls.Add(this.btndisplay);
            this.result.Controls.Add(this.listView1);
            this.result.Location = new System.Drawing.Point(14, 537);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(244, 183);
            this.result.TabIndex = 68;
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
            this.lblxy.TabIndex = 69;
            this.lblxy.Text = "(0,0)";
            // 
            // lblminT
            // 
            this.lblminT.AutoSize = true;
            this.lblminT.Location = new System.Drawing.Point(14, 166);
            this.lblminT.Name = "lblminT";
            this.lblminT.Size = new System.Drawing.Size(29, 12);
            this.lblminT.TabIndex = 70;
            this.lblminT.Text = "minT";
            // 
            // lblminTshow
            // 
            this.lblminTshow.AutoSize = true;
            this.lblminTshow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblminTshow.Location = new System.Drawing.Point(49, 166);
            this.lblminTshow.Name = "lblminTshow";
            this.lblminTshow.Size = new System.Drawing.Size(26, 12);
            this.lblminTshow.TabIndex = 71;
            this.lblminTshow.Text = "111";
            // 
            // lblmaxT
            // 
            this.lblmaxT.AutoSize = true;
            this.lblmaxT.Location = new System.Drawing.Point(14, 181);
            this.lblmaxT.Name = "lblmaxT";
            this.lblmaxT.Size = new System.Drawing.Size(29, 12);
            this.lblmaxT.TabIndex = 72;
            this.lblmaxT.Text = "maxT";
            // 
            // lblmaxTshow
            // 
            this.lblmaxTshow.AutoSize = true;
            this.lblmaxTshow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblmaxTshow.Location = new System.Drawing.Point(49, 181);
            this.lblmaxTshow.Name = "lblmaxTshow";
            this.lblmaxTshow.Size = new System.Drawing.Size(26, 12);
            this.lblmaxTshow.TabIndex = 73;
            this.lblmaxTshow.Text = "111";
            // 
            // txtorigin2
            // 
            this.txtorigin2.Location = new System.Drawing.Point(220, 182);
            this.txtorigin2.Name = "txtorigin2";
            this.txtorigin2.Size = new System.Drawing.Size(44, 21);
            this.txtorigin2.TabIndex = 110;
            this.txtorigin2.Text = "1";
            this.txtorigin2.TextChanged += new System.EventHandler(this.txtorigin2_TextChanged);
            // 
            // lblorigin2
            // 
            this.lblorigin2.AutoSize = true;
            this.lblorigin2.Location = new System.Drawing.Point(221, 167);
            this.lblorigin2.Name = "lblorigin2";
            this.lblorigin2.Size = new System.Drawing.Size(41, 12);
            this.lblorigin2.TabIndex = 109;
            this.lblorigin2.Text = "框粗细";
            // 
            // txtorigin
            // 
            this.txtorigin.Location = new System.Drawing.Point(218, 143);
            this.txtorigin.Name = "txtorigin";
            this.txtorigin.Size = new System.Drawing.Size(44, 21);
            this.txtorigin.TabIndex = 108;
            this.txtorigin.Text = "1";
            this.txtorigin.TextChanged += new System.EventHandler(this.txtorigin_TextChanged);
            // 
            // lblorigin
            // 
            this.lblorigin.AutoSize = true;
            this.lblorigin.Location = new System.Drawing.Point(221, 124);
            this.lblorigin.Name = "lblorigin";
            this.lblorigin.Size = new System.Drawing.Size(41, 12);
            this.lblorigin.TabIndex = 107;
            this.lblorigin.Text = "点粗细";
            // 
            // frm3Dsingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.txtorigin2);
            this.Controls.Add(this.lblorigin2);
            this.Controls.Add(this.txtorigin);
            this.Controls.Add(this.lblorigin);
            this.Controls.Add(this.lblmaxTshow);
            this.Controls.Add(this.lblmaxT);
            this.Controls.Add(this.lblminTshow);
            this.Controls.Add(this.lblminT);
            this.Controls.Add(this.lblxy);
            this.Controls.Add(this.result);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.rect);
            this.Controls.Add(this.lblmaxYshow);
            this.Controls.Add(this.lblmaxY);
            this.Controls.Add(this.lblminYshow);
            this.Controls.Add(this.minY);
            this.Controls.Add(this.lblmaxXshow);
            this.Controls.Add(this.lblmaxX);
            this.Controls.Add(this.lblminXshow);
            this.Controls.Add(this.lblminx);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.txtfile);
            this.Controls.Add(this.lblfile);
            this.Name = "frm3Dsingle";
            this.Text = "单一轨迹三维查询";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm3Dsingle_MouseMove);
            this.rect.ResumeLayout(false);
            this.rect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.result.ResumeLayout(false);
            this.result.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfile;
        private System.Windows.Forms.TextBox txtfile;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Label lblminx;
        private System.Windows.Forms.Label lblminXshow;
        private System.Windows.Forms.Label lblmaxX;
        private System.Windows.Forms.Label lblmaxXshow;
        private System.Windows.Forms.Label minY;
        private System.Windows.Forms.Label lblminYshow;
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
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.GroupBox result;
        private System.Windows.Forms.Label lblline;
        private System.Windows.Forms.Label lblchoose;
        private System.Windows.Forms.TextBox txtchoose;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblxy;
        private System.Windows.Forms.Label lblminT;
        private System.Windows.Forms.Label lblminTshow;
        private System.Windows.Forms.Label lblmaxT;
        private System.Windows.Forms.Label lblmaxTshow;
        private System.Windows.Forms.ComboBox cboyear1;
        private System.Windows.Forms.Label lblstart;
        private System.Windows.Forms.ComboBox cbomonth1;
        private System.Windows.Forms.Label lblyear1;
        private System.Windows.Forms.Label lblmonth1;
        private System.Windows.Forms.Label lblend;
        private System.Windows.Forms.Label lblday1;
        private System.Windows.Forms.ComboBox cboday1;
        private System.Windows.Forms.Label lblday2;
        private System.Windows.Forms.ComboBox cboday2;
        private System.Windows.Forms.Label lblmonth2;
        private System.Windows.Forms.ComboBox cbomonth2;
        private System.Windows.Forms.Label lblyear2;
        private System.Windows.Forms.ComboBox cboyear2;
        private System.Windows.Forms.Label lblsec2;
        private System.Windows.Forms.ComboBox cbosec2;
        private System.Windows.Forms.Label lblmin2;
        private System.Windows.Forms.ComboBox cbomin2;
        private System.Windows.Forms.Label lblhour2;
        private System.Windows.Forms.ComboBox cbohour2;
        private System.Windows.Forms.Label lblsec1;
        private System.Windows.Forms.ComboBox cbosec1;
        private System.Windows.Forms.Label lblmin1;
        private System.Windows.Forms.ComboBox cbomin1;
        private System.Windows.Forms.Label lblhour1;
        private System.Windows.Forms.ComboBox cbohour1;
        private System.Windows.Forms.TextBox txtorigin2;
        private System.Windows.Forms.Label lblorigin2;
        private System.Windows.Forms.TextBox txtorigin;
        private System.Windows.Forms.Label lblorigin;
    }
}