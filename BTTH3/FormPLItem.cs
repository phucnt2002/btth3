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
    public partial class FormPLItem : Form
    {
        string namePlaylist;
        public FormPLItem(string namePlaylist_)
        {
            InitializeComponent();
            namePlaylist = namePlaylist_;
        }

        private void FormPLItem_Load(object sender, EventArgs e)
        {
            for (int j = 0; j < Form3.songsPlayList.Name.Count; j++)
            {
                if (Form3.songsPlayList.PlayList[j] == namePlaylist)
                {
                    for (int i = 0; i < Form1.songs.Name.Count; i++)
                    {
                        if (Form3.songsPlayList.Name[j] == Form1.songs.Name[i])
                        {
                            songItem x = new songItem();
                            x.ItemName = Form1.songs.Name[i];
                            //MessageBox.Show("..//..//img" + "/" + Form1.songs.Type[i] + "/" + Form1.songs.Id[i] + ".png");
                            //x.ItemImage = Image.FromFile(@"..//..//img" + "/" + Form1.songs.Type[rand[i]] + "/" + Form1.songs.Id[rand[i]] + ".png");
                            x.ItemType = Form1.songs.Type[i];
                            x.ItemImage = Form1.songs.Id[i];
                            x.ItemAuthor = Form1.songs.Author[i];
                            x.ItemLove = Form1.songs.Love[i];
                            x.ItemLyric = Form1.songs.Title[i];
                            //MessageBox.Show(this.Parent.Parent.GetType().ToString());
                            flowLayoutPanel1.Controls.Add(x);
                        }
                    }
                }
            }
        }
    }
}
