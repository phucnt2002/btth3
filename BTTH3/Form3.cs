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
        public static class listFavorite
        {
            private static List<string> name = new List<string>();
            private static List<string> type = new List<string>();
            public static List<string> Name { get => name; set => name = value; }
            public static List<string> Type { get => type; set => type = value; }
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

        private void menuBtn_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
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
            Hometimer.Start();
            //var type = new List<string>()
            //        {
            //            "remix",
            //            "acoustic",
            //            "rap",
            //        };
            //loadSongs(type);
        }
        
        private void loadSongs(List<string> type)
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < Form1.songs.Name.Count; i++)
            {
                for(int j = 0; j < type.Count; j++)
                {
                    if(type[j] == Form1.songs.Type[i])
                    {
                        songItem x = new songItem();
                        x.ItemName = Form1.songs.Name[i];
                        //MessageBox.Show("..//..//img" + "/" + Form1.songs.Type[i] + "/" + Form1.songs.Id[i] + ".png");
                        x.ItemImage = Image.FromFile(@"..//..//img" + "/" + Form1.songs.Type[i] + "/" + Form1.songs.Id[i] + ".png");
                        x.ItemAuthor = Form1.songs.Author[i];
                        x.ItemType = Form1.songs.Type[i];
                        x.ItemLove = Form1.songs.Love[i];
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
                    x.ItemImage = Image.FromFile(@"..//..//img" + "/" + Form1.songs.Type[i] + "/" + Form1.songs.Id[i] + ".png");
                    x.ItemAuthor = Form1.songs.Author[i];
                    x.ItemType = Form1.songs.Type[i];
                    x.ItemLove = Form1.songs.Love[i];
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

        }

        private void button6_Click(object sender, EventArgs e)
        {
            loadFavorite();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
