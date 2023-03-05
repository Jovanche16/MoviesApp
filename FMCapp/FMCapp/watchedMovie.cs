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
    public partial class watchedMovie : UserControl
    {
        public watchedMovie()
        {
            InitializeComponent();
        }
        private string movieTitle;
        private string dateWatched;
        private string imgWatched;
        public string mTitle
        {
            get { return movieTitle; }
            set { movieTitle = value;MovieTitleLabel.Text = value; }
        }
        public string dWatched
        {
            get { return dateWatched; }
            set { dateWatched = value; MovieTimeWatchedLabel.Text = value; }
        }
        public string iWatched
        {
            get { return imgWatched; }
            set { imgWatched = value; pictureBox1.ImageLocation = value; pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; }
        }
    }
}
