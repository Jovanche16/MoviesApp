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
    public partial class LogIn : Form
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
        
        public static int userID;   //promenliva koja ni go chuva id-to na najaveniot korisnik
        public static string UserNameSurname; //promenliva koja ni pamti ime i prezime na najaveniot
        public static string UserProfilePic; //promenliva koja ni pamti patot do Profilnata slika na najaveniot
        public LogIn()
        {
            InitializeComponent();

            this.AcceptButton = LogInbutton; //da mozhi da se najauva na enter

            errorLabel.Text = "";
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(PassTextBox.PasswordChar =='*')
            {
                PassTextBox.PasswordChar = '\0';
            }
            else
            {
                PassTextBox.PasswordChar = '*';
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        private void LogInbutton_Click(object sender, EventArgs e)
        {
            if (UsernTextBox.Text == "" || PassTextBox.Text == "")
            {

                CustomMessageBox mBox = new CustomMessageBox("Ве молам внесете Корисничко име и лозинка");
                mBox.Show();
            }
            else
            {
                try
                {
                    SqlConnection con;
                    SqlCommand cmd;

                    con = new SqlConnection("Data Source=DESKTOP-ACPEQDM\\SQLEXPRESS;Initial Catalog=FMCdata;Integrated Security=True;");
                    cmd = new SqlCommand("select * from Korisnici where KorisnichkoIme = @username and Lozinka = @password ", con);
                    cmd.Parameters.AddWithValue("@username", UsernTextBox.Text);
                    cmd.Parameters.AddWithValue("@password", PassTextBox.Text);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataSet ds = new DataSet();

                    da.Fill(ds);
                    con.Close();
                    if (ds.Tables[0].Rows.Count == 1)
                    {
                        userID = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"].ToString());
                        UserNameSurname = ds.Tables[0].Rows[0]["Ime"].ToString() +" "+ ds.Tables[0].Rows[0]["Prezime"].ToString().Substring(0,1)+".";
                        UserProfilePic = ds.Tables[0].Rows[0]["ProfilnaSlika"].ToString();
                        Movies m = new Movies();
                        this.Hide();
                        m.ShowDialog();
                    }
                    else
                    {
                        // MessageBox.Show("Wrong username or password");
                        errorLabel.Text = "Погрешно корисничко име или лозинка!";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void UsernTextBox_TextChanged(object sender, EventArgs e)
        {
            if(errorLabel.Text!="")
            {
                errorLabel.Text = "";
            }
        }
        private void PassTextBox_TextChanged(object sender, EventArgs e)
        {
            if (errorLabel.Text != "")
            {
                errorLabel.Text = "";
            }
        }
        private void signUplabel_Click(object sender, EventArgs e)
        {
            SignUp s = new SignUp();
            this.Hide();
            s.Show();
        }

        private void AdminLabel_Click(object sender, EventArgs e)
        {
            LogInAdmin l = new LogInAdmin();
            this.Hide();
            l.Show();
        }
    }
}
