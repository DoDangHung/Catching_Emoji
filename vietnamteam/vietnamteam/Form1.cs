using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace vietnamteam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            Form2 form2 = new Form2(name);
            form2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender)
        {
        

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Tạo đối tượng Form2 và gán giá trị tên từ TextBox1
                string name = textBox1.Text;
                Form2 form2 = new Form2(name);
                form2.label1.Text = textBox1.Text;
                textBox1.Text = "";

                // Xóa nội dung của Label1 trên Form2 trước khi gán giá trị tên mới
                form2.label1.Text = string.Empty;
               

                // Hiển thị Form2
                form2.Show();



                // Mô phỏng việc ấn phím Tab để chuyển đến Label1 trên Form2
                
            }
        }
    }
}
