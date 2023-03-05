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
    public partial class MainAdmin : Form
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
        public MainAdmin()
        {
            InitializeComponent();
            contentPanel.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void profileLabel_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();  //go chistam panelot od predhodnite kontroli
            profPanel.BackColor = Color.FromArgb(23, 23, 23);   //selektiranata opcija da ima potemna boja
            addPanel.BackColor = Color.FromArgb(34, 34, 34);
            ediPanel.BackColor = Color.FromArgb(34, 34, 34);
            delPanel.BackColor = Color.FromArgb(34, 34, 34);
            AdminProfile a = new AdminProfile();
            flowLayoutPanel1.Controls.Add(a);

            //gi zemam informaciite za adminot
            SqlConnection con;
            SqlCommand cmd;

            con = new SqlConnection("Data Source=DESKTOP-ACPEQDM\\SQLEXPRESS;Initial Catalog=FMCdata;Integrated Security=True;");
            cmd = new SqlCommand("select * from Administratori where Id = @adminId", con);
            cmd.Parameters.AddWithValue(@"adminId",LogInAdmin.adminID);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds);
            con.Close();
            a.setProfilePic = ds.Tables[0].Rows[0]["ProfilnaSlika"].ToString();
            a.setNameSurn = ds.Tables[0].Rows[0]["Ime"].ToString()+" "+ ds.Tables[0].Rows[0]["Prezime"].ToString();
            a.setaddnum = Convert.ToInt32(ds.Tables[0].Rows[0]["DodadeniFilmovi"].ToString());
            a.setdelnum = Convert.ToInt32(ds.Tables[0].Rows[0]["IzbrisheniFilmovi"].ToString());
            a.setEdiNum = Convert.ToInt32(ds.Tables[0].Rows[0]["IzmenetiFilmovi"].ToString());
            a.setadminDate = ds.Tables[0].Rows[0]["PochetokAdmin"].ToString();
            a.setcrCardNum = ds.Tables[0].Rows[0]["BrKartichka"].ToString();
            a.setcrCardDate = ds.Tables[0].Rows[0]["TrajnostKartichka"].ToString();
            a.setcrCardCvc = ds.Tables[0].Rows[0]["CVC"].ToString();
        }
        public static int mId;
        private void addLabel_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            profPanel.BackColor = Color.FromArgb(34, 34, 34);
            ediPanel.BackColor = Color.FromArgb(34, 34, 34);
            addPanel.BackColor = Color.FromArgb(23, 23, 23);    //selektiranata opcija da ima potemna boja
            delPanel.BackColor = Color.FromArgb(34, 34, 34);

            mId = 0;
            addMovie a = new addMovie();
            flowLayoutPanel1.Controls.Add(a);
            
        }

        private void EditLabel_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            profPanel.BackColor = Color.FromArgb(34, 34, 34);
            addPanel.BackColor = Color.FromArgb(34, 34, 34);
            ediPanel.BackColor = Color.FromArgb(23, 23, 23);    //selektiranata opcija da ima potemna boja
            delPanel.BackColor = Color.FromArgb(34, 34, 34);

            //gi prikazhuvam filmovite so mozhnost da se editiraat nivinite podatoci
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
                pictureBox1.Size = new Size(140, 230);
                pictureBox1.Click += this.editMovie_Click;
                pictureBox1.Margin = new Padding(3);
                flowLayoutPanel1.Controls.Add(pictureBox1);
            }

        }
        private void editMovie_Click(object sender, EventArgs e)
        {
            PictureBox oPictureBox = (PictureBox)sender;
            flowLayoutPanel1.Controls.Clear();

            SqlConnection con;
            SqlCommand cmd;

            con = new SqlConnection("Data Source=DESKTOP-ACPEQDM\\SQLEXPRESS;Initial Catalog=FMCdata;Integrated Security=True;");
            cmd = new SqlCommand("select * from Filmovi where FilmSlika = @moviePic", con);
            cmd.Parameters.AddWithValue("@moviePic",oPictureBox.ImageLocation);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds);
            con.Close();

            mId = Convert.ToInt32(ds.Tables[0].Rows[0]["Id"].ToString());
            addMovie edit = new addMovie();
            edit.setMovieName = ds.Tables[0].Rows[0]["FilmIme"].ToString();
            edit.setMovieYear = ds.Tables[0].Rows[0]["FilmGodina"].ToString();
            edit.setMoviePic = ds.Tables[0].Rows[0]["FilmSlika"].ToString();
            edit.setMovieGenre = ds.Tables[0].Rows[0]["FilmZhanr"].ToString();
            edit.setMovieDescr = ds.Tables[0].Rows[0]["FilmOpis"].ToString();
            edit.setMovieRating = ds.Tables[0].Rows[0]["FilmRejting"].ToString();
            edit.setMovieActors = ds.Tables[0].Rows[0]["FilmAkteri"].ToString();
            edit.setMovieDirector = ds.Tables[0].Rows[0]["FilmRezhiser"].ToString();
            edit.setMoviePath = ds.Tables[0].Rows[0]["FilmVideo"].ToString();
            edit.changeImg = @"C:\Users\Pc4all\Desktop\c#Exercises\FMCapp\FMCapp\Resources\send-file-128.png";
            flowLayoutPanel1.Controls.Add(edit);
        }
        private void DeleteLabel_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            profPanel.BackColor = Color.FromArgb(34, 34, 34);
            addPanel.BackColor = Color.FromArgb(34, 34, 34);
            ediPanel.BackColor = Color.FromArgb(34, 34, 34);
            delPanel.BackColor = Color.FromArgb(23, 23, 23);    //selektiranata opcija da ima potemna boja

            //zemanje na site filmovi so mozhnost da se izbrishat
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
                dellMovie d = new dellMovie();
                d.setImg = ds.Tables[0].Rows[i]["FilmSlika"].ToString();
                d.dellMovie_buttonClick += this.removeMovie_Click;
                flowLayoutPanel1.Controls.Add(d);
            }

        }
        private void removeMovie_Click(Object sender, EventArgs e)
        {
            try
            {
                SqlConnection con;
                SqlCommand cmd;
                con = new SqlConnection("Data Source=DESKTOP-ACPEQDM\\SQLEXPRESS;Initial Catalog=FMCdata;Integrated Security=True;");
                cmd = new SqlCommand("delete from Filmovi where FilmSlika = @fslika", con);
                cmd.Parameters.AddWithValue("@fslika", dellMovie.moviePicPath);
                con.Open();
                cmd.ExecuteNonQuery();

                //pravam konekcija do bazata i da gi zemam vrednosta za izbrishani filmovi od administratorot i da go zgolemam za 1
                //gi update-nam podatocite od administratorot
                cmd = new SqlCommand("select IzbrisheniFilmovi from Administratori where Id = @adminId", con);
                cmd.Parameters.AddWithValue("@adminId", LogInAdmin.adminID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);
                int deleted = Convert.ToInt32(ds.Tables[0].Rows[0]["IzbrisheniFilmovi"].ToString());
                deleted++;

                cmd = new SqlCommand("update Administratori set IzbrisheniFilmovi = @deletedNum where Id = @adminId", con);
                cmd.Parameters.AddWithValue("@adminId", LogInAdmin.adminID);
                cmd.Parameters.AddWithValue("@deletedNum", deleted);
                cmd.ExecuteNonQuery();
                con.Close();

                //izvestuvam deka filmot e uspeshno izbrishan
                MessageBox.Show($"Успешно го избришавте филмот.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void LogOutButton_Click(object sender, EventArgs e)
        {
            LogInAdmin l = new LogInAdmin();
            this.Hide();
            l.Show();
        }

    }
}
