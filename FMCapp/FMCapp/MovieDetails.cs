using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMCapp
{
    public partial class MovieDetails : Form
    {
        public MovieDetails()
        {
            InitializeComponent();

            NameSurnamelabel.Text = LogIn.UserNameSurname;
            ProfilePictureBox.ImageLocation = LogIn.UserProfilePic;
            ProfilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            playPictureBox.Parent = moviePictureBox;
            playPictureBox.Anchor = AnchorStyles.None;
            SqlConnection con;
            SqlCommand cmd;
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-ACPEQDM\\SQLEXPRESS;Initial Catalog=FMCdata;Integrated Security=True;");
                cmd = new SqlCommand("select * from Filmovi where Id = @mName", con);
                cmd.Parameters.AddWithValue(@"mName", Movies.movieName);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);
                con.Close();
                moviePictureBox.ImageLocation = ds.Tables[0].Rows[0]["FilmSlika"].ToString();
                moviePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                movieTitleLabel.Text = ds.Tables[0].Rows[0]["FilmIme"].ToString() + " (" + ds.Tables[0].Rows[0]["FilmGodina"].ToString() + ")";
                descriptionLabel.Text = ds.Tables[0].Rows[0]["FilmOpis"].ToString();
                genreLabell.Text = ds.Tables[0].Rows[0]["FilmZhanr"].ToString();
                ActorsLabel.Text = ds.Tables[0].Rows[0]["FilmAkteri"].ToString();
                directorLabel.Text = ds.Tables[0].Rows[0]["FilmRezhiser"].ToString();
                ratingPictureBox.ImageLocation = @"C:\Users\Pc4all\Desktop\c#Exercises\FMCapp\Rating\Star_rating_4_of_5.png";
                ratingPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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

        private void playPictureBox_Click(object sender, EventArgs e)
        {
            MovieWatch mw = new MovieWatch();
            mw.Show();
        }

        private void FavoriteFpictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con;
                SqlCommand cmd;
                con = new SqlConnection("Data Source=DESKTOP-ACPEQDM\\SQLEXPRESS;Initial Catalog=FMCdata;Integrated Security=True;");
                cmd = new SqlCommand("select * from Omileni where KorisnikId = @id and SlikaFilm = @fslika", con);
                cmd.Parameters.AddWithValue("@id", LogIn.userID);
                cmd.Parameters.AddWithValue("@fslika", moviePictureBox.ImageLocation);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);
                con.Close();
                if (ds.Tables[0].Rows.Count == 0)
                {
                    SqlConnection con1;
                    SqlCommand cmd1;
                    con1 = new SqlConnection("Data Source=DESKTOP-ACPEQDM\\SQLEXPRESS;Initial Catalog=FMCdata;Integrated Security=True;");
                    cmd1 = new SqlCommand("insert into Omileni (KorisnikId, FilmId, SlikaFilm, ImeFilm, OpisFilm, RejtingFilm, ZhanrFilm) values (@id, @movieid, @slika, @ime, @opis, @rating, @zhanr)", con1);
                    cmd1.Parameters.AddWithValue("@id", LogIn.userID);
                    cmd1.Parameters.AddWithValue("@movieid", "");
                    cmd1.Parameters.AddWithValue("@slika", moviePictureBox.ImageLocation);
                    cmd1.Parameters.AddWithValue("@ime", movieTitleLabel.Text);
                    cmd1.Parameters.AddWithValue("@opis", descriptionLabel.Text);
                    cmd1.Parameters.AddWithValue("@rating", ratingPictureBox.ImageLocation);
                    cmd1.Parameters.AddWithValue("@zhanr", genreLabell.Text);
                    con1.Open();
                    cmd1.ExecuteNonQuery();
                    con1.Close();
                    CustomMessageBox mBox = new CustomMessageBox($"{movieTitleLabel.Text} е успешно додаден во омилени.");
                    mBox.Show();
                }
                else
                {
                    SqlConnection con1;
                    SqlCommand cmd1;
                    con1 = new SqlConnection("Data Source=DESKTOP-ACPEQDM\\SQLEXPRESS;Initial Catalog=FMCdata;Integrated Security=True;");
                    cmd1 = new SqlCommand("delete from Omileni where KorisnikId = @id and SlikaFilm = @slika", con1);
                    cmd1.Parameters.AddWithValue("@id", LogIn.userID);
                    cmd1.Parameters.AddWithValue("@slika", moviePictureBox.ImageLocation);
                    con1.Open();
                    cmd1.ExecuteNonQuery();
                    con1.Close();

                    CustomMessageBox mBox = new CustomMessageBox($"{movieTitleLabel.Text} е успешно одстранет од омилени.");
                    mBox.Show();
                }
            }
            catch(Exception ex)
            {
                CustomMessageBox cus = new  CustomMessageBox(ex.ToString());
                cus.Show();
            }
        }
        public static string slikaFilm;
        private void label1_Click(object sender, EventArgs e)
        {
            slikaFilm = moviePictureBox.ImageLocation;
            MovieTrailer mt = new MovieTrailer();
            mt.Show();
        }
    }
}