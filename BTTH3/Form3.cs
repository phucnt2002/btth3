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

        public void loadData()
        {
            var xml = new XmlDocument();
            xml.Load(@"..//..//XML/music.xml");
            var type = new List<string>()
                    {
                        "remix",
                        "acoustic",
                        "lofi",
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
            //            "lofi",
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
                        flowLayoutPanel1.Controls.Add(x);
                    }
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var type = new List<string>()
                    {
                        "remix",
                        "acoustic",
                        "lofi",
                    };
            loadSongs(type);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var type = new List<string>()
                    {
                        "remix",
                    };
            loadSongs(type);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var type = new List<string>()
                    {
                        "acoustic",
                    };
            loadSongs(type);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var type = new List<string>()
                    {
                        "lofi",
                    };
            loadSongs(type);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
