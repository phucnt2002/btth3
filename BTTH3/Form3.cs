using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace BTTH3
{
    public partial class Form3 : Form
    {
        bool sidebarExpand = true;
        bool homeCollaped = true;
        public Form3()
        {
            InitializeComponent();
            loadData();
        }

        public static class songsPlayList
        {
            private static List<string> name = new List<string>();
            private static List<string> playList = new List<string>();

            public static List<string> Name { get => name; set => name = value; }
            public static List<string> PlayList { get => playList; set => playList = value; }
        }

        public static class listFavorite
        {
            private static List<string> name = new List<string>();
            private static List<string> type = new List<string>();
            public static List<string> Name { get => name; set => name = value; }
            public static List<string> Type { get => type; set => type = value; }
        }

        private List<int> ranList(int sl)
        {
            Random rand = new Random();
            List<int> list = new List<int>();
            while (list.Count < sl)
            {
                int a = rand.Next(0, sl);
                if (list.Contains(a))
                {
                    continue;
                }
                else
                {
                    list.Add(a);
                }
            }
            return list;
        }
        public void loadData()
        {
            var xml = new XmlDocument();
            xml.Load(@"..//..//XML/music.xml");
            var type = new List<string>()
                    {
                        "remix",
                        "acoustic",
                        "rap",
                    };
            for(int k = 0; k < type.Count; k++)
            {
                XmlNodeList nodeList = xml.SelectNodes("/music" + "/" + type[k]+"/item");
                for (int i = 0; i < nodeList.Count; i++)
                {
                    Form1.songs.Name.Add(nodeList[i].SelectSingleNode("name").InnerText.Trim());
                    Form1.songs.Author.Add(nodeList[i].SelectSingleNode("author").InnerText.Trim());
                    Form1.songs.Id.Add(nodeList[i].SelectSingleNode("id").InnerText.Trim());
                    Form1.songs.Star.Add(nodeList[i].SelectSingleNode("star").InnerText.Trim());
                    Form1.songs.Title.Add(nodeList[i].SelectSingleNode("title").InnerText.Trim());
                    Form1.songs.Love.Add("false");
                    Form1.songs.Type.Add(type[k]);
                }
            }
        }



        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if(sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private bool menuOpen = true;
        private bool homeOpen = false;
        private void menuBtn_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
            menuOpen = !menuOpen;
            if (homeOpen)
            {
                Hometimer.Start();
                homeOpen = !homeOpen;
            }
        }

        private void Hometimer_Tick(object sender, EventArgs e)
        {
            if (homeCollaped)
            {
                pan_home.Height += 10;
                if (pan_home.Height == pan_home.MaximumSize.Height)
                {
                    homeCollaped = false;
                    Hometimer.Stop();
                }
            }
            else
            {
                pan_home.Height -= 10;
                if (pan_home.Height == pan_home.MinimumSize.Height)
                {
                    homeCollaped = true;
                    Hometimer.Stop();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (menuOpen)
            {
                Hometimer.Start();
                homeOpen = !homeOpen;
            }

        }
        
        private void loadSongs(List<string> type)
        {
            flowLayoutPanel1.Controls.Clear();
            List<int> rand = ranList(Form1.songs.Name.Count);
            for (int i = 0; i < rand.Count; i++)
            {
                for(int j = 0; j < type.Count; j++)
                {
                    if(type[j] == Form1.songs.Type[rand[i]])
                    {
                        songItem x = new songItem();
                        x.ItemName = Form1.songs.Name[rand[i]];
                        //MessageBox.Show("..//..//img" + "/" + Form1.songs.Type[i] + "/" + Form1.songs.Id[i] + ".png");
                        //x.ItemImage = Image.FromFile(@"..//..//img" + "/" + Form1.songs.Type[rand[i]] + "/" + Form1.songs.Id[rand[i]] + ".png");
                        x.ItemType = Form1.songs.Type[rand[i]];
                        x.ItemImage = Form1.songs.Id[rand[i]];
                        x.ItemAuthor = Form1.songs.Author[rand[i]];
                        x.ItemLove = Form1.songs.Love[rand[i]];
                        x.ItemLyric = Form1.songs.Title[rand[i]];
                        flowLayoutPanel1.Controls.Add(x);
                    }
                }
            }
        }

        private void loadFavorite()
        {
           flowLayoutPanel1.Controls.Clear();
           for(int i = 0; i< Form1.songs.Name.Count; i++)
            {
                if (Form1.songs.Love[i] == "true")
                {
                    songItem x = new songItem();
                    x.ItemName = Form1.songs.Name[i];
                    //MessageBox.Show("..//..//img" + "/" + Form1.songs.Type[i] + "/" + Form1.songs.Id[i] + ".png");
                    x.ItemType = Form1.songs.Type[i];
                    x.ItemImage = Form1.songs.Id[i];
                    x.ItemAuthor = Form1.songs.Author[i];
                    x.ItemLove = Form1.songs.Love[i];
                    x.ItemLyric = Form1.songs.Title[i];
                    //MessageBox.Show(Form1.songs.Id[i], Form1.songs.Type[i]);
                    flowLayoutPanel1.Controls.Add(x);
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var type = new List<string>()
                    {
                        "remix",
                        "acoustic",
                        "rap",
                    };
            loadSongs(type);
        }

        private bool flatRemix = false;

        private void button2_Click(object sender, EventArgs e)
        {
            panHome.Visible = true;

            var type = new List<string>()
                    {
                        "remix",
                    };
            loadSongs(type);
            //if (flatRemix)
            //{
            //    var type = new List<string>()
            //        {
            //            "remix",
            //        };
            //    loadSongs(type);
            //    flatRemix = !flatRemix;
            //}
            //else
            //{
            //    var type = new List<string>()
            //        {
            //            "remix",
            //            "acoustic",
            //            "rap",
            //        };
            //    loadSongs(type);
            //    flatRemix = !flatRemix;
            //}

        }

        private bool flatAcoustic = false;

        private void button3_Click(object sender, EventArgs e)
        {
            panHome.Visible = true;

            var type = new List<string>()
                    {
                        "acoustic",
                    };
            loadSongs(type);
            //flatAcoustic = !flatAcoustic;
            //if (flatAcoustic)
            //{
            //    var type = new List<string>()
            //        {
            //            "acoustic",
            //        };
            //    loadSongs(type);
            //    flatAcoustic = !flatAcoustic;
            //}
            //else
            //{
            //    var type = new List<string>()
            //        {
            //            "remix",
            //            "acoustic",
            //            "rap",
            //        };
            //    loadSongs(type);
            //    flatAcoustic = !flatAcoustic;
            //}
        }

        private bool flatRap = false;

        private void button4_Click(object sender, EventArgs e)
        {

            var type = new List<string>()
                    {
                        "rap",
                    };
            loadSongs(type);
            panHome.Visible = true;


            //if (flatRap)
            //{
            //    var type = new List<string>()
            //        {
            //            "rap",
            //        };
            //    loadSongs(type);
            //    flatRap = !flatRap;
            //}
            //else
            //{
            //    var type = new List<string>()
            //        {
            //            "remix",
            //            "acoustic",
            //            "rap",
            //        };
            //    loadSongs(type);
            //    flatRap = !flatRap;
            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormPlayList page = new FormPlayList() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            foreach (Control item in panMenu.Controls.OfType<Control>().ToList())
            {
                if (item.Name == "FormHistory")
                    panMenu.Controls.Remove(item);
            }
            panHome.Visible = false;
            this.panMenu.Controls.Add(page);
            page.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panHome.Visible = true;
            loadFavorite();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            string txt = search.Text;
            foreach (var item in flowLayoutPanel1.Controls)
            {
                var song = (songItem)item;
                song.Visible = song.ItemName.ToLower().ToLower().Contains(txt.Trim().ToLower());
                if (song.Visible == false)
                {
                    song.Visible = song.ItemAuthor.ToLower().ToLower().Contains(txt.Trim().ToLower());
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormHistory page = new FormHistory() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panHome.Visible = false;
            foreach (Control item in panMenu.Controls.OfType<Control>().ToList())
            {
                if (item.Name == "FormPlayList")
                    panMenu.Controls.Remove(item);
            }
            this.panMenu.Controls.Add(page);
            page.Show();
        }
    }
}
