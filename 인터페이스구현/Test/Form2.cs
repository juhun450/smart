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
    public partial class Form2 : Form
    {
        private Panel panel1;                                            //넘겨 받은 Form과 Panel을 전역 변수로 지정.
        private Form parentform;

        public Form2()
        {
            InitializeComponent();
        }


        public Form2(Form parentform, Panel panel)                     //2번 Form에서 사용 될 변수로 초기화
        {
            InitializeComponent();
            this.parentform = parentform;
            this.panel1 = panel;
            //Load += Form2_Load;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)           //입력 버튼 클릭 후 오답일때 예외처리
        {
            if (checkBox2.Checked && checkBox1.Checked)
            {
                MessageBox.Show("오답입니다..다시 생각해보세요..");
            }
            else if (checkBox1.Checked)
            {
                MessageBox.Show("오답입니다..다시 생각해보세요..");
            }
            else if (checkBox3.Checked)
            {
                MessageBox.Show("오답입니다..다시 생각해보세요..");
            }
            else if (checkBox2.Checked && checkBox3.Checked)
            {
                MessageBox.Show("오답입니다..다시 생각해보세요..");
            }
            else if (checkBox2.Checked)                                   //정답일때 처리부분
            {
                checkBox2.Text = "2번) 60";
                MessageBox.Show("정답입니다!!");
                MessageBox.Show("다음 문제로 이동합니다.");
                Form3 f3 = new Form3(parentform, panel1);
                f3.FormBorderStyle = FormBorderStyle.None;
                f3.MdiParent = parentform;
                panel1.Controls.Add(f3);
                this.Visible = false;
                f3.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)            // 뒤로가기 버튼
        {
            this.Visible = false;
        }
    }
}
