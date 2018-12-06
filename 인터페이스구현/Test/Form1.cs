using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)                  // 1번문제 버튼
        {
            Form2 f2 = new Form2(this, panel1);
            f2.MdiParent = this;
            f2.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(f2);
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)                 // 2번문제 버튼
        {
            Form3 f3 = new Form3(this, panel1);
            f3.MdiParent = this;
            f3.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(f3);
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)                 // 3번문제 버튼
        {
            Form4 f4 = new Form4(this, panel1);
            f4.MdiParent = this;
            f4.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(f4);
            f4.Show();
        }

        private void button4_Click(object sender, EventArgs e)                 // 4번 문제 버튼
        {
            Form5 f5 = new Form5(this, panel1);
            f5.MdiParent = this;
            f5.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(f5);
            f5.Show();
        }
    }
}
