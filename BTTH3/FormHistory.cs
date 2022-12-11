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
            dgv.ColumnCount = 4;
            XmlNodeList ds = root.SelectNodes("song");
            int sd = 0;//lưu chỉ số dòng
            foreach (XmlNode item in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = item.SelectSingleNode("name").InnerText;
                dgv.Rows[sd].Cells[1].Value = item.SelectSingleNode("author").InnerText;
                dgv.Rows[sd].Cells[2].Value = item.SelectSingleNode("type").InnerText;
                dgv.Rows[sd].Cells[3].Value = item.SelectSingleNode("time").InnerText;
                sd++;
            }
        }
    }
}
