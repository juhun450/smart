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
    public partial class Form5 : Form
    {

        Panel panel1;                            //
        Form parentform;                         

        public Form5()
        {
            InitializeComponent();
        }

        public Form5(Form parentform, Panel panel)                    //
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
            else if(checkBox3.Checked)
            {
                MessageBox.Show("오답입니다..다시 생각해보세요..");
            }
            else if (checkBox3.Checked && checkBox2.Checked)
            {
                MessageBox.Show("오답입니다..다시 생각해보세요..");
            }
            else if (checkBox3.Checked && checkBox1.Checked)
            {
                MessageBox.Show("오답입니다..다시 생각해보세요..");
            }
            else if(checkBox2.Checked)
            {
                checkBox2.Text = "2번) 100";
                MessageBox.Show("정답입니다!!");
                MessageBox.Show("수고하셨습니다~ 첫 화면으로 이동합니다!!");
                this.Visible = false;
            }
        }
    }
}
