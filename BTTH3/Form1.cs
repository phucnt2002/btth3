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
    public partial class Form1 : Form
    {
        public int time = 0, degree = 0;
        RotateImageClass rot = new RotateImageClass();
        public Form1()
        {
            InitializeComponent();
        }

        public static class songs
        {
            private static List<string> name = new List<string>();
            private static List<string> author = new List<string>();
            private static List<string> id = new List<string>();
            private static List<string> star = new List<string>();
            private static List<string> type = new List<string>();
            private static List<string> title = new List<string>();
            private static List<string> love = new List<string>();
            private static List<string> playList = new List<string>();

            public static List<string> Name { get => name; set => name = value; }
            public static List<string> Author { get => author; set => author = value; }
            public static List<string> Id { get => id; set => id = value; }
            public static List<string> Star { get => star; set => star = value; }
            public static List<string> Type { get => type; set => type = value; }
            public static List<string> Title { get => title; set => title = value; }
            public static List<string> Love { get => love; set => love = value; }
            public static List<string> PlayList { get => playList; set => playList = value; }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();


            //string b="";
            //for(int i =0; i < list.Count; i++)
            //{
            //    b = b+list[i].ToString()+" ";
            //}
            //MessageBox.Show(b);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 form3= new Form3();
            form3.Show();
        }


        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            degree += 4;
            //if (time == 50)
            //{
            //    timer1.Stop();
            //}
            pictureBox1.Image = rot.RotateImage(Image.FromFile(@"..//..//img/background/2.png"), degree);
        }
    }
}
