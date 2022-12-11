using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH3
{
    public partial class playlist : UserControl
    {
        public playlist()
        {
            InitializeComponent();
        }
        private string namePlayList;

        public string NamePlayList { get => namePlayList; set => namePlayList = value; }

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

        private void playlist_Load(object sender, EventArgs e)
        {
            labName.Text = NamePlayList;
            picPlaylist.BackgroundImage = Image.FromFile(@"..//..//img/background/3.png");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form2 page = new Form2(NamePlayList);
            page.Show();
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }



        private void picPlaylist_Click_1(object sender, EventArgs e)
        {
            FormPLItem page = new FormPLItem(NamePlayList);
            page.Text = "PlayList " + NamePlayList;
            page.Show();
        }
    }
}
