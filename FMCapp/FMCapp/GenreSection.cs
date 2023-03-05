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
    public partial class GenreSection : UserControl
    {
        public GenreSection()
        {
            InitializeComponent();
        }

        private string genreTitle;
        private Control moviePic;

        public string setGenre
        {
            get { return genreTitle; }
            set { genreTitle = value; genreLabel.Text = genreTitle; }
        }

        public Control setPic
        {
            get { return moviePic; }
            set { moviePic = value; flowLayoutPanel1.Controls.Add(moviePic); }
        }
    }
}
