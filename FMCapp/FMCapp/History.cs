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
    public partial class History : Form
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
        public History()
        {
            InitializeComponent();

            //zemanje na podatoci za korisnikot i prikazhuvane
            SqlConnection con;
            SqlCommand cmd;

            con = new SqlConnection("Data Source=DESKTOP-ACPEQDM\\SQLEXPRESS;Initial Catalog=FMCdata;Integrated Security=True;");
            cmd = new SqlCommand("select * from Gledani where KorisnikId = @userID", con);
            cmd.Parameters.AddWithValue("@userID", LogIn.userID);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ds = new DataSet();
            da.Fill(ds);
            con.Close();
            for (int i=0;i<ds.Tables[0].Rows.Count;i++)
            {
                watchedMovie wItem = new watchedMovie();
                wItem.mTitle = ds.Tables[0].Rows[i]["ImeFilm"].ToString();
                wItem.iWatched = ds.Tables[0].Rows[i]["SlikaFilm"].ToString();
                wItem.dWatched = ds.Tables[0].Rows[i]["VremeGledanje"].ToString();
                flowLayoutPanel1.Controls.Add(wItem);
            }
        }

        private void minimeseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
           this.Close();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        private void LogOutbutton_Click(object sender, EventArgs e)
        {
            LogIn l = new LogIn();
            this.Hide();
            l.Show();
        }

    }
}
