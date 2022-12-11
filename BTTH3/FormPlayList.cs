using Microsoft.VisualBasic;
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
    public partial class FormPlayList : Form
    {
        public FormPlayList()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            string content = Interaction.InputBox("Enter Your Playlist Name", "Name Playlist","", 500, 300);
            if(content != "")
            {
                playlist x = new playlist();
                x.NamePlayList = content;
                flowLayoutPanel1.Controls.Add(x);
            }
            else
            {
                MessageBox.Show("Enter Name PlayList!! Please!!");
            }
        }

        private void FormPlayList_Load(object sender, EventArgs e)
        {
            try
            {
                flowLayoutPanel1.Visible = true;
            }
            catch
            {

            }
        }
    }
}
