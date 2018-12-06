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
    public partial class Form3 : Form
    {
        Panel panel1;
        Form parentform;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form parentform, Panel panel)
        {
            InitializeComponent();
            this.parentform = parentform;
            this.panel1 = panel;
        }

        private void button2_Click(object sender, EventArgs e)             //뒤로가기 버튼
        {
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)             //첫 화면 버튼
        {
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)            //오답일때 예외처리 부분
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
            else if(checkBox3.Checked)                                   //정답일때 처리부분
            {
                checkBox3.Text = "3번) 55";
                MessageBox.Show("정답입니다!!");
                MessageBox.Show("다음 문제로 이동합니다.");
                Form4 f4 = new Form4(parentform, panel1);
                f4.FormBorderStyle = FormBorderStyle.None;
                f4.MdiParent = parentform;
                panel1.Controls.Add(f4);
                this.Visible = false;
                f4.Show();
            }
        }
    }
}
