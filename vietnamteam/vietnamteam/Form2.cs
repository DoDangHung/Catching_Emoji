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

namespace vietnamteam
{


    public partial class Form2 : Form
    {
        public Label Label1
        {
            get { return label1; }
            set { label1 = value; }
        }
        Random rand = new Random();
        List<PictureBox> items = new List<PictureBox>();
        public Form2(string name)
        {
            InitializeComponent();
            label1.Text = "Welcome " + name; ;
            label1 = new Label();
        }
        public static string GameMode { get; set; }
        public Form2()
        {
            InitializeComponent();
            label1 = new Label();
            label1.Text = " ";
            
        }

        private bool isPlaying = false;
    
        private void btnPlay_Click(object sender, EventArgs e)
        {
            isPlaying= true;    
        }

        private void MakePictureBox(object sender, EventArgs e)
        {
            PictureBox newPic = new PictureBox();
            newPic.Image = Properties.Resources.emoji1;
            newPic.SizeMode = PictureBoxSizeMode.StretchImage;
            int x = rand.Next(20, this.ClientSize.Width - newPic.Width);
            int y = rand.Next(20, this.ClientSize.Height - newPic.Height);
            newPic.Location = new Point(x, y);
            newPic.Click += NewPic_Click;
            items.Add(newPic);
            this.Controls.Add(newPic);
        }
        private void TimerEvent(object sender, EventArgs e)
        {
           
                MakePictureBox(sender, e);
                lbltime.Text = "Items: " + items.Count();
            
        }
        private void NewPic_Click(object sender, EventArgs e)
        {
           
                PictureBox temPic = sender as PictureBox;
                items.Remove(temPic);
                this.Controls.Remove(temPic);
                lbltime.Text = "Times: " + items.Count();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                if (rbEasy.Checked)
                {
                    GameMode = "Easy";
                }
                else if (rbMedium.Checked)
                {
                    GameMode = "Medium";
                }
                else if (rbHard.Checked)
                {
                    GameMode = "Hard";
                }
            }
            else
            {
                MessageBox.Show("choose Difficult");
            }
            

        }
        private void Form2_Load(object sender, EventArgs e)
        {
          
   

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    
        private void lbltime_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lable1(object sender, EventArgs e)
        {

        }
    }
}
