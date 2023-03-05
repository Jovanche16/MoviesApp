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
    public partial class LogInAdmin : Form
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
        public LogInAdmin()
        {
            InitializeComponent();
            errorLabel.Text = "";

        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (APassTextBox.PasswordChar == '*')
            {
                APassTextBox.PasswordChar = '\0';
            }
            else
            {
                APassTextBox.PasswordChar = '*';
            }
        }
        private void AdminLabel_Click(object sender, EventArgs e)
        {
            LogIn l = new LogIn();
            this.Hide();
            l.Show();
        }
        public static int adminID;
        private void ALogInbutton_Click(object sender, EventArgs e)
        {
            
            if (AUsernTextBox.Text == "" || APassTextBox.Text == "")
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
                    cmd = new SqlCommand("select * from Administratori where KorisnichkoIme = @username and Lozinka = @password ", con);
                    cmd.Parameters.AddWithValue("@username", AUsernTextBox.Text);
                    cmd.Parameters.AddWithValue("@password", APassTextBox.Text);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataSet ds = new DataSet();

                    da.Fill(ds);
                    con.Close();
                    if (ds.Tables[0].Rows.Count == 1)
                    {
                        adminID = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"].ToString());
                        //Anamesurn = ds.Tables[0].Rows[0]["Ime"].ToString() + " " + ds.Tables[0].Rows[0]["Prezime"].ToString();
                        //UserProfilePic = ds.Tables[0].Rows[0]["ProfilnaSlika"].ToString();
                        MainAdmin m = new MainAdmin();
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

        private void AUsernTextBox_TextChanged(object sender, EventArgs e)
        {
            if (errorLabel.Text != "")
            {
                errorLabel.Text = "";
            }
        }

        private void APassTextBox_TextChanged(object sender, EventArgs e)
        {
            if (errorLabel.Text != "")
            {
                errorLabel.Text = "";
            }
        }

        private void AsignUplabel_Click(object sender, EventArgs e)
        {
            SignUpAdmin s = new SignUpAdmin();
            this.Hide();
            s.Show();
        }
    }
}
