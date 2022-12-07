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
    public partial class songItem : UserControl
    {
        public songItem()
        {
            InitializeComponent();
        }

        public Image ItemImage
        {
            get
            {
                return ptr_Item.Image;
            }
            set
            {
                ptr_Item.BackgroundImage = value;
            }
        }

        public string ItemName { get
            {
                return labName.Text;
            } set
            {
                labName.Text = value;
            } 
        }

        public string ItemType
        {
            get
            {
                return labType.Text;
            }
            set
            {
                labType.Text = value;
            }
        }

        public string ItemAuthor
        {
            get
            {
                return lab_author.Text;
            }
            set
            {
                lab_author.Text = value;
            }
        }

        public string ItemLove
        {
            get
            {
                return picLove.Text;
            }
            set
            {
                if(value == "true")
                {
                    picLove.BackgroundImage = Image.FromFile(@"..//..//img/icon/redheart.png");
                }
            }
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
        }

        private void picLove_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < Form1.songs.Name.Count; i++)
            {
                if (Form1.songs.Name[i] == ItemName)
                {
                    if(Form1.songs.Love[i] != "false")
                    {
                        picLove.BackgroundImage = Image.FromFile(@"..//..//img/icon/heart (1).png");
                        Form1.songs.Love[i] = "false";
                    }
                    else
                    {
                        picLove.BackgroundImage = Image.FromFile(@"..//..//img/icon/redheart.png");
                        Form1.songs.Love[i] = "true";
                    }
                }
            }

        }
    }
}
