using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMCapp
{
    public partial class dellMovie : UserControl
    {
        public dellMovie()
        {
            InitializeComponent();
        }
        private string imgLoc;

        public string setImg
        {
            get { return imgLoc; }
            set { imgLoc = value; imgPctureBox.ImageLocation = imgLoc;imgPctureBox.SizeMode = PictureBoxSizeMode.StretchImage; }
        }

        public event EventHandler dellMovie_buttonClick;
        public static string moviePicPath;
        private void delbutton_Click(object sender, EventArgs e)
        {
            moviePicPath = imgPctureBox.ImageLocation;
            dellMovie_buttonClick(sender, e);
            this.Hide();
        }
    }
}
