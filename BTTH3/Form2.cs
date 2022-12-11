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
    public partial class Form2 : Form
    {
        string namePlayList;
        public Form2(string namePlayList_)
        {
            InitializeComponent();
            namePlayList = namePlayList_;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for(int i = 0; i< Form1.songs.Name.Count; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = Form1.songs.Name[i];
                dgv.Rows[i].Cells[1].Value = Form1.songs.Author[i];
                dgv.Rows[i].Cells[2].Value = Form1.songs.Type[i];
            }
        }


        private void bunifuButton21_Click(object sender, EventArgs e)
        {

            int rowIdex = dgv.CurrentCell.RowIndex;
            string name = dgv.Rows[rowIdex].Cells[0].Value.ToString();
            int index = Form3.songsPlayList.Name.IndexOf(name);
            if(index == -1|| Form3.songsPlayList.PlayList[index]!= namePlayList)
            {
                Form3.songsPlayList.Name.Add(name);
                Form3.songsPlayList.PlayList.Add(namePlayList);
            }
            else
            {
                MessageBox.Show("Bài hát đã tồn tại trong PlayList " + namePlayList);
            }

        }
    }
}
