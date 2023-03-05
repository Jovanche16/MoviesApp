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
    public partial class MovieTrailer : Form
    {
        public MovieTrailer()
        {
            InitializeComponent();
            try
            {
                SqlConnection con;
                SqlCommand cmd;
                con = new SqlConnection("Data Source=DESKTOP-ACPEQDM\\SQLEXPRESS;Initial Catalog=FMCdata;Integrated Security=True;");
                cmd = new SqlCommand("select FilmURL from Filmovi where FilmSlika = @fslika", con);
                cmd.Parameters.AddWithValue("@fslika", MovieDetails.slikaFilm);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);
                con.Close();
                string html = "<html><head>";
                html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
                html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}'width='780' height='450' frameborder='0' allowfullscreen></iframe>";
                html += "</body></html>";
                this.webBrowser1.DocumentText = string.Format(html, ds.Tables[0].Rows[0]["FilmURL"].ToString().Split('=')[1]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
