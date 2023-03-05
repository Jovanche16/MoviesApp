using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMCapp
{
    public partial class Favorites : Form
    {
        //za da mozhi da se pomestuva formata iako nema ramka
        //---------------------------------------------
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        //----------------------------------------------
        public Favorites()
        {
            InitializeComponent();

            ProfilePictureBox.ImageLocation = LogIn.UserProfilePic;
            ProfilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            NameSurnamelabel.Text = LogIn.UserNameSurname;

            MovieTitleLabel.Text = "";
            descriptionLabel.Text = "";

            //gi prikazhuvam site omilenite filmovi
            try
            {
                SqlConnection con;
                SqlCommand cmd;

                con = new SqlConnection("Data Source=DESKTOP-ACPEQDM\\SQLEXPRESS;Initial Catalog=FMCdata;Integrated Security=True;");
                cmd = new SqlCommand("select * from Omileni where KorisnikId = @id", con);
                cmd.Parameters.AddWithValue("@id", LogIn.userID);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds);
                con.Close();

                MovieTitleLabel.Text = ds.Tables[0].Rows[0]["ImeFilm"].ToString();
                descriptionLabel.Text = ds.Tables[0].Rows[0]["OpisFilm"].ToString();
                MoviePictureBox.ImageLocation = ds.Tables[0].Rows[0]["SlikaFilm"].ToString();
                MoviePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                for (int i=0;i< ds.Tables[0].Rows.Count;i++)
                {
                    favoriteMovie wItem = new favoriteMovie();
                    wItem.Name = ds.Tables[0].Rows[i]["SlikaFilm"].ToString();
                    wItem.mTitle = ds.Tables[0].Rows[i]["ImeFilm"].ToString();
                    wItem.mDesc = ds.Tables[0].Rows[i]["OpisFilm"].ToString();
                    wItem.rFavorite = @"C:\Users\Pc4all\Desktop\c#Exercises\Movieteka\Rating\Star_rating_4_of_5.png";
                    wItem.iFavorite = ds.Tables[0].Rows[i]["SlikaFilm"].ToString();
                    wItem.Width = 350;
                   // wItem.Margin = new Padding(0);
                    wItem.Click += this.fItemClick;
                    wItem.remove_buttonClick += this.removeClick;
                    flowLayoutPanel1.Controls.Add(wItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //dokolku nema filmovi vo favorites
            //...
        }
        private void fItemClick(object sender, EventArgs e)
        {
            favoriteMovie ofMovie = (favoriteMovie)sender;
            MovieTitleLabel.Text = ofMovie.mTitle;
            descriptionLabel.Text =ofMovie.mDesc ;
            RatingPictureBox.ImageLocation = ofMovie.rFavorite;
            MoviePictureBox.ImageLocation = ofMovie.Name;
            MoviePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void removeClick(object sender, EventArgs e)
        {
            //ova e za da go odstranam filmot od omileni vo bazata

            try
            {
                SqlConnection con;
                SqlCommand cmd;
                con = new SqlConnection("Data Source=DESKTOP-ACPEQDM\\SQLEXPRESS;Initial Catalog=FMCdata;Integrated Security=True;");
                cmd = new SqlCommand("delete from Omileni where KorisnikId = @id and slikaFilm = @fslika", con);
                cmd.Parameters.AddWithValue("@id", LogIn.userID);
                cmd.Parameters.AddWithValue("@fslika", favoriteMovie.moviePicPath);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        private void minimezeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Movies m = new Movies();
            this.Hide();
            m.Show();
        }


    }
}
