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



        string a = "";
        public string ItemImage
        {
            get
            {
                return a;
            }
            set
            {
                //MessageBox.Show(ItemType);
                ptr_Item.BackgroundImage = Image.FromFile(@"..//..//img" + "/" + ItemType + "/" + value + ".png");
                a = value;
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

        public string ItemLyric;

        public string ItemStar;


        string aflat = "false";
        public string ItemLove
        {
            get
            {
                return aflat;
            }
            set
            {
                if(value == "true")
                {
                    picLove.BackgroundImage = Image.FromFile(@"..//..//img/icon/redheart.png");
                    aflat = value;
                }
                else
                {
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
                        aflat = "false";
                    }
                    else
                    {
                        picLove.BackgroundImage = Image.FromFile(@"..//..//img/icon/redheart.png");
                        Form1.songs.Love[i] = "true";
                        aflat = "true";
                    }
                }
            }
        }

        private void ptr_Item_Click(object sender, EventArgs e)
        {
            Form4 page = new Form4(ItemName, ItemAuthor, ItemType, ItemImage, ItemLyric, ItemLove);
            page.Show();
        }

        public void loadFeeadbacks(int star)
        {
            switch (star)
            {
                case 1:
                    pb_str2.Image = Image.FromFile(@"..//..//img/icon/white_star.png");
                    pb_str3.Image = Image.FromFile(@"..//..//img/icon/white_star.png");
                    pb_str4.Image = Image.FromFile(@"..//..//img/icon/white_star.png");
                    pb_str5.Image = Image.FromFile(@"..//..//img/icon/white_star.png");

                    pb_str1.Image = Image.FromFile(@"..//..//img/icon/yellow_star.png");
                    lbl_core.Text = "1/5";
                    break;
                case 2:
                    //change yellow stars to white
                    pb_str3.Image = Image.FromFile(@"..//..//img/icon/white_star.png");
                    pb_str4.Image = Image.FromFile(@"..//..//img/icon/white_star.png");
                    pb_str5.Image = Image.FromFile(@"..//..//img/icon/white_star.png");

                    pb_str1.Image = Image.FromFile(@"..//..//img/icon/yellow_star.png");
                    pb_str2.Image = Image.FromFile(@"..//..//img/icon/yellow_star.png");
                    lbl_core.Text = "2/5";
                    break;
                case 3:
                    //change yellow stars to white
                    pb_str4.Image = Image.FromFile(@"..//..//img/icon/white_star.png");
                    pb_str5.Image = Image.FromFile(@"..//..//img/icon/white_star.png");

                    pb_str1.Image = Image.FromFile(@"..//..//img/icon/yellow_star.png");
                    pb_str2.Image = Image.FromFile(@"..//..//img/icon/yellow_star.png");
                    pb_str3.Image = Image.FromFile(@"..//..//img/icon/yellow_star.png");
                    lbl_core.Text = "3/5";
                    break;
                case 4:
                    //change yellow star to white
                    pb_str5.Image = Image.FromFile(@"..//..//img/icon/white_star.png");

                    pb_str1.Image = Image.FromFile(@"..//..//img/icon/yellow_star.png");
                    pb_str2.Image = Image.FromFile(@"..//..//img/icon/yellow_star.png");
                    pb_str3.Image = Image.FromFile(@"..//..//img/icon/yellow_star.png");
                    pb_str4.Image = Image.FromFile(@"..//..//img/icon/yellow_star.png");
                    lbl_core.Text = "4/5";
                    break;
                case 5:
                    pb_str1.Image = Image.FromFile(@"..//..//img/icon/yellow_star.png");
                    pb_str2.Image = Image.FromFile(@"..//..//img/icon/yellow_star.png");
                    pb_str3.Image = Image.FromFile(@"..//..//img/icon/yellow_star.png");
                    pb_str4.Image = Image.FromFile(@"..//..//img/icon/yellow_star.png");
                    pb_str5.Image = Image.FromFile(@"..//..//img/icon/yellow_star.png");
                    lbl_core.Text = "5/5";
                    break;
                default:
                    break;
            }
            if(star!= 0)
                lbl_core.Visible = true;
        }


        private void songItem_Load(object sender, EventArgs e)
        {
            loadFeeadbacks(Convert.ToInt32(ItemStar));
        }
    }
}
