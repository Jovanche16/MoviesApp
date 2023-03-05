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
    public partial class SignUp : Form
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
        public SignUp()
        {
            InitializeComponent();
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
        private void choosePicButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    profilePictureBox.ImageLocation = imageLocation;
                    profilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        string imageLocation = "";
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text=="" || surnameTextBox.Text =="" || usernameTextBox.Text =="" || passTextBox.Text =="" || pass2TextBox.Text =="")
            {
                CustomMessageBox mBox = new CustomMessageBox("Потполнете ги сите полиња!");
                mBox.Show();
            }
            else
            {
                if (passTextBox.Text != pass2TextBox.Text)
                {
                    CustomMessageBox mBox = new CustomMessageBox("Лозинките мора да се совпаѓаат!");
                    mBox.Show();
                }
                else
                {

                    SqlConnection con;
                    SqlCommand cmd;

                    con = new SqlConnection("Data Source=DESKTOP-ACPEQDM\\SQLEXPRESS;Initial Catalog=FMCdata;Integrated Security=True;");
                    cmd = new SqlCommand("select * from Korisnici where KorisnichkoIme = @username ", con);
                    cmd.Parameters.AddWithValue("@username", usernameTextBox.Text);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataSet ds = new DataSet();

                    da.Fill(ds);

                    con.Close();
                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        CustomMessageBox meBox = new CustomMessageBox("Корисничкото име веќе постои!");
                        meBox.Show();
                    }
                    else
                    {
                        try
                        {
                            SqlConnection con2;
                            SqlCommand cmd2;
                            Random rnd = new Random();
                            int id = rnd.Next(1, 999);
                            con2 = new SqlConnection("Data Source=DESKTOP-ACPEQDM\\SQLEXPRESS;Initial Catalog=FMCdata;Integrated Security=True;");
                            cmd2 = new SqlCommand("insert into Korisnici (ID, Ime, Prezime, KorisnichkoIme, Lozinka, ProfilnaSlika) values(@id, @ime, @prezime, @username, @pass, @profilepic)", con2);
                            cmd2.Parameters.AddWithValue("@id", id);
                            cmd2.Parameters.AddWithValue("@ime", nameTextBox.Text);
                            cmd2.Parameters.AddWithValue("@prezime", surnameTextBox.Text);
                            cmd2.Parameters.AddWithValue("@username", usernameTextBox.Text);
                            cmd2.Parameters.AddWithValue("@pass", passTextBox.Text);
                            cmd2.Parameters.AddWithValue("@profilepic", imageLocation);
                            con2.Open();
                            cmd2.ExecuteNonQuery();
                            con2.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        //praznenje na site polinja od formata
                        nameTextBox.Clear();
                        surnameTextBox.Clear();
                        usernameTextBox.Clear();
                        passTextBox.Clear();
                        pass2TextBox.Clear();
                        profilePictureBox.Image = null;

                        //izvestuvanje deka registracijata e uspeshna

                        CustomMessageBox mBox = new CustomMessageBox("Успешно се регистриравте.");
                        mBox.Show();
                    }
                }
            }
        }
        private void logInLabel_Click(object sender, EventArgs e)
        {
            LogIn l = new LogIn();
            this.Hide();
            l.Show();
        }


    }
}
