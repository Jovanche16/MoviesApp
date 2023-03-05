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
    public partial class SignUpAdmin : Form
    {
        public SignUpAdmin()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        string imageLocation;
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
 private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || surnameTextBox.Text == "" || usernameTextBox.Text == "" || crCardTextBox.Text =="" || crDateTextBox.Text =="" || crCvcTextBox.Text=="" || passTextBox.Text == "" || pass2TextBox.Text == "")
            {
                MessageBox.Show("Потполнете ги сите полиња!");
            }
            else
            {
                if (passTextBox.Text != pass2TextBox.Text)
                {
                    MessageBox.Show("Лозинките мора да се совпаѓаат!");
                }
                if(crCvcTextBox.Text.Length > 3 || crCvcTextBox.Text.Length < 3)
                {
                    MessageBox.Show("Неточен CVC!");
                }
                else
                {
                    SqlConnection con;
                    SqlCommand cmd;

                    con = new SqlConnection("Data Source=DESKTOP-ACPEQDM\\SQLEXPRESS;Initial Catalog=FMCdata;Integrated Security=True;");
                    cmd = new SqlCommand("select * from Administratori where KorisnichkoIme = @username ", con);
                    cmd.Parameters.AddWithValue("@username", usernameTextBox.Text);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataSet ds = new DataSet();

                    da.Fill(ds);

                    con.Close();
                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        MessageBox.Show("Корисничкото име веќе постои!");
                    }
                    else
                    {
                        try
                        {
                            SqlConnection con2;
                            SqlCommand cmd2;
                            Random rnd = new Random();
                            int id = rnd.Next(1, 999);
                            string currentDate = DateTime.UtcNow.ToString("MM.dd.yyyy");
                            con2 = new SqlConnection("Data Source=DESKTOP-ACPEQDM\\SQLEXPRESS;Initial Catalog=FMCdata;Integrated Security=True;");
                            cmd2 = new SqlCommand("insert into Administratori (ID, Ime, Prezime, KorisnichkoIme, Lozinka, ProfilnaSlika, DodadeniFilmovi, IzmenetiFilmovi, IzbrisheniFilmovi, BrKartichka, CVC, TrajnostKartichka, PochetokAdmin) values(@id, @ime, @prezime, @username, @pass, @profilepic, @addedNum, @editedNum, @deletedNum, @crCard, @crCvc, @crDate, @adSartDate)", con2);
                            cmd2.Parameters.AddWithValue("@id", id);
                            cmd2.Parameters.AddWithValue("@ime", nameTextBox.Text);
                            cmd2.Parameters.AddWithValue("@prezime", surnameTextBox.Text);
                            cmd2.Parameters.AddWithValue("@username", usernameTextBox.Text);
                            cmd2.Parameters.AddWithValue("@pass", passTextBox.Text);
                            cmd2.Parameters.AddWithValue("@profilepic", imageLocation);
                            cmd2.Parameters.AddWithValue("@addedNum", 0);
                            cmd2.Parameters.AddWithValue("@editedNum", 0);
                            cmd2.Parameters.AddWithValue("@deletedNum", 0);
                            cmd2.Parameters.AddWithValue("@crCard", crCardTextBox.Text);
                            cmd2.Parameters.AddWithValue("@crCvc", crCvcTextBox.Text);
                            cmd2.Parameters.AddWithValue("@crDate", crDateTextBox.Text);
                            cmd2.Parameters.AddWithValue("@adSartDate", currentDate);
                            con2.Open();
                            cmd2.ExecuteNonQuery();
                            con2.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        MessageBox.Show("Успешно се регистриравте");
                        nameTextBox.Clear();
                        surnameTextBox.Clear();
                        usernameTextBox.Clear();
                        passTextBox.Clear();
                        pass2TextBox.Clear();
                        profilePictureBox.Image = null;
                    }
                }

            }
        }
        private void logInLabel_Click(object sender, EventArgs e)
        {
            LogInAdmin l = new LogInAdmin();
            this.Hide();
            l.Show();
        }

       
    }
}
