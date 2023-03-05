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
    public partial class favoriteMovie : UserControl
    {
        public favoriteMovie()
        {
            InitializeComponent();
        }
        private string movieTitle;
        private string ratingFavorite;
        private string imgFavorite;
        private string movieDesc;
        public string mTitle
        {
            get { return movieTitle; }
            set { movieTitle = value; MovieTitleLabel.Text = value; }
        }
        public string rFavorite
        {
            get { return ratingFavorite; }
            set { ratingFavorite = value; ratingPictureBox.ImageLocation = value;ratingPictureBox.SizeMode = PictureBoxSizeMode.StretchImage; }
        }
        public string iFavorite
        {
            get { return imgFavorite; }
            set { imgFavorite = value; MoviPictureBox.ImageLocation = value; MoviPictureBox.SizeMode = PictureBoxSizeMode.StretchImage; }
        }

        public string mDesc
        {
            get { return movieDesc; }
            set { movieDesc = value; }
        }

        public event EventHandler remove_buttonClick;
        public static string moviePicPath;
        private void removeButton_Click(object sender, EventArgs e)
        {
            moviePicPath = this.Name;
            remove_buttonClick(sender, e);
            this.Hide();
        }
    }
}
