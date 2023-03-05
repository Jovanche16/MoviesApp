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
    public partial class MovieWatch : Form
    {
        int mId;
        public MovieWatch()
        {
            InitializeComponent();

            string mName="", mPicture="", mDate="";

            mDate = System.DateTime.Now.ToString();
            try
            {
                SqlConnection con;
                SqlCommand cmd;
                con = new SqlConnection("Data Source=DESKTOP-ACPEQDM\\SQLEXPRESS;Initial Catalog=FMCdata;Integrated Security=True;");
                cmd = new SqlCommand("select * from Filmovi where Id = @movieName", con);
                cmd.Parameters.AddWithValue(@"movieName", Convert.ToInt32(Movies.movieName));
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                mId = Convert.ToInt32(ds.Tables[0].Rows[0]["Id"].ToString());
                mName = ds.Tables[0].Rows[0]["FilmIme"].ToString();
                mPicture = ds.Tables[0].Rows[0]["FilmSlika"].ToString();

                con.Close();
            }
            catch { }
            try 
            {
                SqlConnection con;
                SqlCommand cmd;

                con = new SqlConnection("Data Source=DESKTOP-ACPEQDM\\SQLEXPRESS;Initial Catalog=FMCdata;Integrated Security=True;");
                cmd = new SqlCommand("insert into Gledani(KorisnikId, FilmId, ImeFilm, SlikaFilm, VremeGledanje) VALUES(@userId, @movieId, @movieName, @moviePic, @movieDWatched)", con);
                cmd.Parameters.AddWithValue("@userId", LogIn.userID);
                cmd.Parameters.AddWithValue("@movieId",mId );
                cmd.Parameters.AddWithValue("@movieName", mName);
                cmd.Parameters.AddWithValue("@moviePic", mPicture);
                cmd.Parameters.AddWithValue("@movieDWatched",mDate);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                axWindowsMediaPlayer1.URL = @"C:\Users\Pc4all\Downloads\sample_640x360.asf";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
