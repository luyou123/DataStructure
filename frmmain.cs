using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
            pic1.BackgroundImage = Properties.Resources.pj1;
            pic2.BackgroundImage = Properties.Resources.pj2;
            pic3.BackgroundImage = Properties.Resources.pj3;
            pic4.BackgroundImage = Properties.Resources.pj4;
            pic5.BackgroundImage = Properties.Resources.pj5;
            pic6.BackgroundImage = Properties.Resources.pj6;
            pic7.BackgroundImage = Properties.Resources.pj7;
            pic8.BackgroundImage = Properties.Resources.pj9;
            pic9.BackgroundImage = Properties.Resources.pj10;

        }

        private void btndemo_Click(object sender, EventArgs e)
        {
            frmdemo f = new frmdemo();
            f.Show();
        }

        private void btn2Dsingle_Click(object sender, EventArgs e)
        {
            frm2Dsingle f = new frm2Dsingle();
            f.Show();
        }

        private void btn2Dall_Click(object sender, EventArgs e)
        {
            frm2Dall f = new frm2Dall();
            f.Show();
        }

        private void btn3Dsingle_Click(object sender, EventArgs e)
        {
            frm3Dsingle f = new frm3Dsingle();
            f.Show();
        }

        private void btnkth_Click(object sender, EventArgs e)
        {
            frmkmin f = new frmkmin();
            f.Show();
        }
        private void btnrange_Click(object sender, EventArgs e)
        {
            frmrange f = new frmrange();
            f.Show();
        }

        private void frmmain_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void pic1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void pic2_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void pic3_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void pic4_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void pic5_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void pic6_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void pic7_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
        }


    }
}
