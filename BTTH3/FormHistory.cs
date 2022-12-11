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

namespace BTTH3
{
    public partial class FormHistory : Form
    {
        public XmlDocument doc = new XmlDocument();
        public XmlElement root;
        private string fileName = @"..//..//xml/history.xml";
        public FormHistory()
        {
            InitializeComponent();
            doc.Load(fileName);
            root = doc.DocumentElement;
        }

        private void FormHistory_Load(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            dgv.ColumnCount = 7;
            XmlNodeList ds = root.SelectNodes("song");
            int sd = 0;//lưu chỉ số dòng
            foreach (XmlNode item in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = item.SelectSingleNode("name").InnerText;
                dgv.Rows[sd].Cells[1].Value = item.SelectSingleNode("author").InnerText;
                dgv.Rows[sd].Cells[2].Value = item.SelectSingleNode("type").InnerText;
                dgv.Rows[sd].Cells[3].Value = item.SelectSingleNode("time").InnerText;
                dgv.Rows[sd].Cells[4].Value = item.SelectSingleNode("image").InnerText;
                dgv.Rows[sd].Cells[5].Value = item.SelectSingleNode("lyric").InnerText;
                dgv.Rows[sd].Cells[6].Value = item.SelectSingleNode("love").InnerText;
                sd++;
            }
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            int rowIdex = dgv.CurrentCell.RowIndex;
            string name = dgv.Rows[rowIdex].Cells[0].Value.ToString();
            string author = dgv.Rows[rowIdex].Cells[1].Value.ToString();
            string type = dgv.Rows[rowIdex].Cells[2].Value.ToString();
            string image = dgv.Rows[rowIdex].Cells[4].Value.ToString();
            string lyric = dgv.Rows[rowIdex].Cells[5].Value.ToString();
            string love = dgv.Rows[rowIdex].Cells[6].Value.ToString();


            Form4 page = new Form4(name, author, type, image, lyric, love);
            page.Show();
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            root.RemoveAll();
            dgv.Rows.Clear();
            doc.Save(@"..//..//XML/history.xml");
        }
    }
}
