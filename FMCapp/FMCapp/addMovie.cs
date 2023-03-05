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
    public partial class addMovie : UserControl
    {
        public addMovie()
        {
            InitializeComponent();
        }
        private void selectPicButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dial = new OpenFileDialog();
            dial.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
            if (dial.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                moviePictureBox.ImageLocation = dial.FileName;
                moviePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void moviePathButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dial = new OpenFileDialog();
            dial.Filter = "mp4 files(.*mp4)|*.mp4| All Files(*.*)|*.*";
            if (dial.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                moviePathTextBox.Text = dial.FileName;
            }
        }
        private string movieName;
        private string movieYear;
        private string movieGenre;
        private string movieRating;
        private string movieActors;
        private string movieDirector;
        private string movieDescr;
        private string moviePath;
        private string moviePic;

        //public event EventHandler add_ButtonClick;
        public string setMovieName
        {
            get { return mNameTextBox.Text; }
            set { movieName = value; mNameTextBox.Text = movieName;}
        }
        public string setMovieYear
        {
            get { return mYearTextBox.Text; }
            set { movieYear = value; mYearTextBox.Text = movieYear; }
        }
        public string setMovieGenre
        {
            get { return mGenreTextBox.Text; }
            set { movieGenre = value; mGenreTextBox.Text = movieGenre; }
        }
        public string setMovieRating
        {
            get { return mratingTextBox.Text; }
            set { movieRating = value; mratingTextBox.Text= movieRating; }
        }
        public string setMovieActors
        {
            get { return mActorsTextBox.Text; }
            set { movieActors = value; mActorsTextBox.Text = movieActors; }
        }
        public string setMovieDirector
        {
            get { return mDirectTextBox.Text; }
            set { movieDirector = value; mDirectTextBox.Text = movieDirector; }
        }
        public string setMovieDescr
        {
            get { return mDescTextBox.Text; }
            set { movieDescr= value; mDescTextBox.Text = movieDescr; }
        }
        public string setMoviePath
        {
            get { return moviePathTextBox.Text; }
            set { moviePath = value; moviePathTextBox.Text = moviePath; }
        }
        public string setMoviePic
        {
            get { return moviePictureBox.ImageLocation; }
            set { moviePic = value; moviePictureBox.ImageLocation = moviePic; moviePictureBox.SizeMode = PictureBoxSizeMode.StretchImage; }
        }
        public string changeImg
        {
            set { addMpictureBox.ImageLocation = value; }
        }

        private void addMpictureBox_Click(object sender, EventArgs e)
        {

            if (mNameTextBox.Text == "" || mYearTextBox.Text == "" || mGenreTextBox.Text == "" || mratingTextBox.Text == "" || mActorsTextBox.Text == "" || mDirectTextBox.Text == "" || moviePathTextBox.Text == "" || mDescTextBox.Text == "" || moviePictureBox.ImageLocation == "")
            {
                MessageBox.Show("Потполнете ги сите полиња!");
            }
            else
            {
                if (MainAdmin.mId == 0)
                {
                    SqlConnection con;
                    SqlCommand cmd;

                    con = new SqlConnection("Data Source=DESKTOP-ACPEQDM\\SQLEXPRESS;Initial Catalog=FMCdata;Integrated Security=True;");
                    cmd = new SqlCommand("select * from Filmovi where FilmIme = @moviename", con);
                    cmd.Parameters.AddWithValue(@"moviename", mNameTextBox.Text);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    da.Fill(ds);
                    con.Close();
                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        MessageBox.Show("Филмот веќе постои!");
                    }
                    else
                    {
                        Random r = new Random();
                        int n = r.Next(31, 200);
                        try
                        {
                            SqlConnection con1;
                            SqlCommand cmd1;

                            con1 = new SqlConnection("Data Source=DESKTOP-ACPEQDM\\SQLEXPRESS;Initial Catalog=FMCdata;Integrated Security=True;");
                            cmd1 = new SqlCommand("insert into Filmovi (Id, FilmIme, FilmGodina, FilmSlika, FilmZhanr, FilmOpis, FilmRejting, FilmAkteri, FilmRezhiser, FilmVideo) " +
                                "values (@mId, @moviename, @movieyear, @movieimage, @moviegenre, @moviedesc, @movierating,  @movieactors, @moviedirec, @movievideo)", con1);
                            cmd1.Parameters.AddWithValue(@"mId", n);
                            cmd1.Parameters.AddWithValue(@"moviename", mNameTextBox.Text);
                            cmd1.Parameters.AddWithValue(@"movieyear", mYearTextBox.Text);
                            cmd1.Parameters.AddWithValue(@"movieimage", moviePictureBox.ImageLocation);
                            cmd1.Parameters.AddWithValue(@"moviegenre", mGenreTextBox.Text);
                            cmd1.Parameters.AddWithValue(@"moviedesc", mDescTextBox.Text);
                            cmd1.Parameters.AddWithValue(@"movierating", mratingTextBox.Text);
                            cmd1.Parameters.AddWithValue(@"movieactors", mActorsTextBox.Text);
                            cmd1.Parameters.AddWithValue(@"moviedirec", mDirectTextBox.Text);
                            cmd1.Parameters.AddWithValue(@"movievideo", moviePathTextBox.Text);
                            con1.Open();
                            cmd1.ExecuteNonQuery();
                            con1.Close();
                            MessageBox.Show($"Успешно го додадовте {mNameTextBox.Text}");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    //pravam konekcija do bazata i da gi zemam vrednosta za dodadeni filmovi od administratorot i da go zgolemam za 1
                    //gi update-nam podatocite od administratorot
                    try
                    {
                        con = new SqlConnection("Data Source=DESKTOP-ACPEQDM\\SQLEXPRESS;Initial Catalog=FMCdata;Integrated Security=True;");
                        cmd = new SqlCommand("select DodadeniFilmovi from Administratori where Id = @adminId", con);
                        cmd.Parameters.AddWithValue("@adminId", LogInAdmin.adminID);
                        con.Open();
                        da = new SqlDataAdapter(cmd);
                        ds = new DataSet();

                        da.Fill(ds);
                        int added = Convert.ToInt32(ds.Tables[0].Rows[0]["DodadeniFilmovi"].ToString());
                        added++;

                        cmd = new SqlCommand("update Administratori set DodadeniFilmovi = @addedNum where Id = @adminId", con);
                        cmd.Parameters.AddWithValue("@adminId", LogInAdmin.adminID);
                        cmd.Parameters.AddWithValue("@addedNum", added);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    //gi chistam polinjata od prethodnite informacii
                    mNameTextBox.Clear();
                    mYearTextBox.Clear();
                    moviePictureBox.Image = null;
                    mGenreTextBox.Clear();
                    mDescTextBox.Clear();
                    mratingTextBox.Clear();
                    mActorsTextBox.Clear();
                    mDirectTextBox.Clear();
                    moviePathTextBox.Clear();
                }
                else
                {
                    SqlConnection con;
                    SqlCommand cmd;

                    con = new SqlConnection("Data Source=DESKTOP-ACPEQDM\\SQLEXPRESS;Initial Catalog=FMCdata;Integrated Security=True;");
                    cmd = new SqlCommand("select * from Filmovi where FilmIme = @moviename", con);
                    cmd.Parameters.AddWithValue(@"moviename", mNameTextBox.Text);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        MessageBox.Show("Филмот веќе постои!");
                    }
                    else
                    {
                        try
                        {
                            SqlConnection con1;
                            SqlCommand cmd1;

                            con1 = new SqlConnection("Data Source=DESKTOP-ACPEQDM\\SQLEXPRESS;Initial Catalog=FMCdata;Integrated Security=True;");
                            cmd1 = new SqlCommand("update Filmovi  set FilmIme = @moviename, FilmGodina = @movieyear, FilmSlika = @movieimage, FilmZhanr = @moviegenre, FilmOpis = @moviedesc , FilmRejting = @movierating, FilmAkteri = @movieactors," +
                                " FilmRezhiser = @moviedirec, FilmVideo = @movievideo where Id = @mId", con1);
                            cmd1.Parameters.AddWithValue(@"mId", MainAdmin.mId);
                            cmd1.Parameters.AddWithValue(@"moviename", mNameTextBox.Text);
                            cmd1.Parameters.AddWithValue(@"movieyear", mYearTextBox.Text);
                            cmd1.Parameters.AddWithValue(@"movieimage", moviePictureBox.ImageLocation);
                            cmd1.Parameters.AddWithValue(@"moviegenre", mGenreTextBox.Text);
                            cmd1.Parameters.AddWithValue(@"moviedesc", mDescTextBox.Text);
                            cmd1.Parameters.AddWithValue(@"movierating", mratingTextBox.Text);
                            cmd1.Parameters.AddWithValue(@"movieactors", mActorsTextBox.Text);
                            cmd1.Parameters.AddWithValue(@"moviedirec", mDirectTextBox.Text);
                            cmd1.Parameters.AddWithValue(@"movievideo", moviePathTextBox.Text);
                            con1.Open();
                            cmd1.ExecuteNonQuery();
                            con1.Close();
                            MessageBox.Show($"Успешно го изменевте {mNameTextBox.Text}");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        try
                        {
                            cmd = new SqlCommand("select IzmenetiFilmovi from Administratori where Id = @adminId", con);
                            cmd.Parameters.AddWithValue("@adminId", LogInAdmin.adminID);
                            da = new SqlDataAdapter(cmd);
                            ds = new DataSet();

                            da.Fill(ds);
                            int edited = Convert.ToInt32(ds.Tables[0].Rows[0]["IzmenetiFilmovi"].ToString());
                            edited++;

                            cmd = new SqlCommand("update Administratori set IzmenetiFilmovi = @addedNum where Id = @adminId", con);
                            cmd.Parameters.AddWithValue("@adminId", LogInAdmin.adminID);
                            cmd.Parameters.AddWithValue("@addedNum", edited);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        //gi chistam polinjata od prethodnite informacii
                        mNameTextBox.Clear();
                        mYearTextBox.Clear();
                        moviePictureBox.Image = null;
                        mGenreTextBox.Clear();
                        mDescTextBox.Clear();
                        mratingTextBox.Clear();
                        mActorsTextBox.Clear();
                        mDirectTextBox.Clear();
                        moviePathTextBox.Clear();
                    }
                }
            }
        }


    }
}
