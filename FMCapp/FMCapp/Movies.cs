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
    public partial class Movies : Form
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
        void displayMovies()
        {
            //kreiram pictureBoxes za sekoj film vo bazata i gi dodavam vo flowlayout panel-ot
            SqlConnection con;
            SqlCommand cmd;

            con = new SqlConnection("Data Source=DESKTOP-ACPEQDM\\SQLEXPRESS;Initial Catalog=FMCdata;Integrated Security=True;");
            cmd = new SqlCommand("select Id,FilmIme,FilmSlika from Filmovi", con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds);
            con.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Name = ds.Tables[0].Rows[i]["Id"].ToString();
                pictureBox1.ImageLocation = ds.Tables[0].Rows[i]["FilmSlika"].ToString();
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Size = new Size((flowLayoutPanel1.Width/5)-4, 280);
                pictureBox1.Click += this.PictureClick;
                pictureBox1.Margin = new Padding(0);
                flowLayoutPanel1.Controls.Add(pictureBox1);
            }
        }
        void displayMoviesbyYear()
        {
            //gi prikazhuvam filmovite podredeni po godina
            SqlConnection con;
            SqlCommand cmd;

            con = new SqlConnection("Data Source=DESKTOP-ACPEQDM\\SQLEXPRESS;Initial Catalog=FMCdata;Integrated Security=True;");
            cmd = new SqlCommand("select Id,FilmIme,FilmSlika from Filmovi order by FilmGodina", con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds);
            con.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Name = ds.Tables[0].Rows[i]["Id"].ToString();
                pictureBox1.ImageLocation = ds.Tables[0].Rows[i]["FilmSlika"].ToString();
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Size = new Size((flowLayoutPanel1.Width / 5) - 4, 280);
                pictureBox1.Click += this.PictureClick;
                pictureBox1.Margin = new Padding(0);
                flowLayoutPanel1.Controls.Add(pictureBox1);
            }
        }

        public Movies()
        {
            InitializeComponent();

            ProfilePictureBox.ImageLocation = LogIn.UserProfilePic;
            ProfilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            NameSurnamelabel.Text = LogIn.UserNameSurname;

            displayMovies();
        }
        public static string movieName;
        private void PictureClick(object sender, EventArgs e)
        {
            PictureBox oPictureBox = (PictureBox)sender;
            movieName = oPictureBox.Name;
            MovieDetails m = new MovieDetails();
            this.Hide();
            m.Show();
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

        private void Backbutton_Click(object sender, EventArgs e)
        {
            LogIn l = new LogIn();
            this.Hide();
            l.Show();
        }

        private void GenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(GenreComboBox.SelectedIndex == 0)
            {
                //dokolku od combobox e selektiran " Deafult "
                flowLayoutPanel1.Controls.Clear();
                displayMovies();
            }
            if(GenreComboBox.SelectedIndex == 1)
            {
                //dokolku od combobox e selektiran Азбучен редослед
                flowLayoutPanel1.Controls.Clear();

                //kreiram pictureBoxes za sekoj film vo bazata i gi dodavam
                SqlConnection con;
                SqlCommand cmd;

                con = new SqlConnection("Data Source=DESKTOP-ACPEQDM\\SQLEXPRESS;Initial Catalog=FMCdata;Integrated Security=True;");
                cmd = new SqlCommand("select Id,FilmIme,FilmSlika from Filmovi order by FilmIme asc", con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);
                con.Close();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    PictureBox pictureBox1 = new PictureBox();
                    pictureBox1.Name = ds.Tables[0].Rows[i]["Id"].ToString();
                    pictureBox1.ImageLocation = ds.Tables[0].Rows[i]["FilmSlika"].ToString();
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Size = new Size((flowLayoutPanel1.Width / 5) - 4, 280);
                    pictureBox1.Click += this.PictureClick;
                    pictureBox1.Margin = new Padding(0);
                    flowLayoutPanel1.Controls.Add(pictureBox1);
                }
            }
            if(GenreComboBox.SelectedIndex == 2)
            {
                //dokolku od combobox e Жанр
                flowLayoutPanel1.Controls.Clear();

                //kreiram niza so zhanrovi
                string[] genres = new string[] { "Action", "Adventure", "Comedy", "Drama", "Horror", "Crime", "Fantasy", "Mystery", "Thriler", "War", "Romance" };

                SqlConnection con;
                SqlCommand cmd;

                con = new SqlConnection("Data Source=DESKTOP-ACPEQDM\\SQLEXPRESS;Initial Catalog=FMCdata;Integrated Security=True;");
                cmd = new SqlCommand("select Id,FilmIme,FilmSlika, FilmZhanr from Filmovi ", con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);
                con.Close();
                for (int i = 0; i < genres.Length; i++)
                { 
                    GenreSection gen = new GenreSection();
                    gen.setGenre =genres[i];
                    for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                    {
                        if (ds.Tables[0].Rows[j]["FilmZhanr"].ToString().Contains(genres[i]))
                        {
                            PictureBox pictureBox1 = new PictureBox();
                            pictureBox1.Name = ds.Tables[0].Rows[j]["Id"].ToString();
                            pictureBox1.ImageLocation = ds.Tables[0].Rows[j]["FilmSlika"].ToString();
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox1.Size = new Size((flowLayoutPanel1.Width / 5) - 4, 280);
                            pictureBox1.Click += this.PictureClick;
                            pictureBox1.Margin = new Padding(0);
                            gen.setPic = pictureBox1;
                        }
                        //flowLayoutPanel1.Controls.Add(pictureBox1);
                    }
                    flowLayoutPanel1.Controls.Add(gen);
                }

            }
            
            if(GenreComboBox.SelectedIndex == 3)
            {
                //dokolku od combobox e selektiran Година

                flowLayoutPanel1.Controls.Clear();
                displayMoviesbyYear();
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            try
            {
                SqlConnection con;
                SqlCommand cmd;

                con = new SqlConnection("Data Source=DESKTOP-ACPEQDM\\SQLEXPRESS;Initial Catalog=FMCdata;Integrated Security=True;");
                cmd = new SqlCommand("select Id,FilmIme, FilmSlika from Filmovi", con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);
                con.Close();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    if (searchTextBox.Text != "" && ds.Tables[0].Rows[i]["FilmIme"].ToString().ToLower().Contains(searchTextBox.Text))
                    {
                        PictureBox pic = new PictureBox();
                        pic.ImageLocation = ds.Tables[0].Rows[i]["FilmSlika"].ToString();
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Height = 250;
                        pic.Width = 200;
                        flowLayoutPanel1.Controls.Add(pic);
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            if(searchTextBox.Text=="")
            {
                displayMovies();
            }
        }

        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            displayMovies();
        }

        private void favoritesButton_Click(object sender, EventArgs e)
        {
            Favorites f = new Favorites();
            this.Hide();
            f.Show();
        }

        private void watchhButton_Click(object sender, EventArgs e)
        {
            History m = new History();
            m.Show();
        }

        private void searchTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            searchTextBox.Clear();
        }
    }
}
