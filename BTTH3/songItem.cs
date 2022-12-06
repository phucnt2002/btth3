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

    }
}
