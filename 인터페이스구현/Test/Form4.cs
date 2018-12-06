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
    public partial class Form4 : Form
    {
        Panel panel1;
        Form parentform;

        public Form4()
        {
            InitializeComponent();
        }

        public Form4(Form parentform, Panel panel)
        {
            InitializeComponent();
            this.parentform = parentform;
            this.panel1 = panel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("오답입니다..다시 생각해보세요..");
            }
            else if(checkBox2.Checked)
            {
                MessageBox.Show("오답입니다..다시 생각해보세요..");
            }
            else if (checkBox1.Checked && checkBox3.Checked)
            {
                MessageBox.Show("오답입니다..다시 생각해보세요..");
            }
            else if (checkBox2.Checked && checkBox3.Checked)
            {
                MessageBox.Show("오답입니다..다시 생각해보세요..");
            }
            else if (checkBox3.Checked)
            {
                checkBox3.Text = "3번) 640";
                MessageBox.Show("정답입니다!!");
                MessageBox.Show("다음 문제로 이동합니다.");
                Form5 f5 = new Form5(parentform, panel1);
                f5.FormBorderStyle = FormBorderStyle.None;
                f5.MdiParent = parentform;
                panel1.Controls.Add(f5);
                this.Visible = false;
                f5.Show();
            }
        }
    }
}
