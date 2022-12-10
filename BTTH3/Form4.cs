using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace BTTH3
{
    public partial class Form4 : Form
    {
        string name; string author; string type, lyric; Image img;
        public Form4(string name_, string author_, string type_, Image img_, string lyric_)
        {
            name = name_;
            author = author_;
            type = type_;
            img = img_;
            lyric = lyric_;
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labAuthor.Text = author;
            labName.Text = name;
            labType.Text = type;
            picSong.BackgroundImage = img;
            txtLyric.Text = lyric;
            wplayer.URL = "C:\\Users\\LENOVO\\Desktop\\BTTH3\\BTTH3\\music\\rap\\8.mp3";
            wplayer.Ctlcontrols.play();
        }
        public int time = 0, degree = 0;
        RotateImageClass rot = new RotateImageClass();
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            degree += 2;
            //if (time == 50)
            //{
            //    timer1.Stop();
            //}
            picSong.BackgroundImage = rot.RotateImage(img, degree);
        }
    }
}
