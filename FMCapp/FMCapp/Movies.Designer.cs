
namespace FMCapp
{
    partial class Movies
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimezeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.watchhButton = new System.Windows.Forms.Button();
            this.favoritesButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.ProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.AboutLabel = new System.Windows.Forms.Label();
            this.NameSurnamelabel = new System.Windows.Forms.Label();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.LogOutbutton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.minimezeButton);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1272, 24);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // minimezeButton
            // 
            this.minimezeButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.minimezeButton.FlatAppearance.BorderSize = 0;
            this.minimezeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimezeButton.Location = new System.Drawing.Point(1220, 2);
            this.minimezeButton.Margin = new System.Windows.Forms.Padding(1);
            this.minimezeButton.Name = "minimezeButton";
            this.minimezeButton.Size = new System.Drawing.Size(25, 25);
            this.minimezeButton.TabIndex = 2;
            this.minimezeButton.Text = "_";
            this.minimezeButton.UseVisualStyleBackColor = false;
            this.minimezeButton.Click += new System.EventHandler(this.minimezeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(1247, 2);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(1);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(25, 25);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.searchTextBox);
            this.panel2.Controls.Add(this.GenreComboBox);
            this.panel2.Controls.Add(this.ProfilePictureBox);
            this.panel2.Controls.Add(this.AboutLabel);
            this.panel2.Controls.Add(this.NameSurnamelabel);
            this.panel2.Controls.Add(this.LogoLabel);
            this.panel2.Controls.Add(this.LogOutbutton);
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1278, 70);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(11)))), ((int)(((byte)(72)))));
            this.panel3.Controls.Add(this.watchhButton);
            this.panel3.Controls.Add(this.favoritesButton);
            this.panel3.Location = new System.Drawing.Point(879, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(186, 64);
            this.panel3.TabIndex = 8;
            // 
            // watchhButton
            // 
            this.watchhButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.watchhButton.FlatAppearance.BorderSize = 0;
            this.watchhButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watchhButton.Location = new System.Drawing.Point(96, 1);
            this.watchhButton.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.watchhButton.Name = "watchhButton";
            this.watchhButton.Size = new System.Drawing.Size(90, 62);
            this.watchhButton.TabIndex = 11;
            this.watchhButton.Text = "Историја";
            this.watchhButton.UseVisualStyleBackColor = false;
            this.watchhButton.Click += new System.EventHandler(this.watchhButton_Click);
            // 
            // favoritesButton
            // 
            this.favoritesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.favoritesButton.FlatAppearance.BorderSize = 0;
            this.favoritesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.favoritesButton.Location = new System.Drawing.Point(0, 1);
            this.favoritesButton.Margin = new System.Windows.Forms.Padding(0, 1, 3, 1);
            this.favoritesButton.Name = "favoritesButton";
            this.favoritesButton.Size = new System.Drawing.Size(92, 62);
            this.favoritesButton.TabIndex = 10;
            this.favoritesButton.Text = "Омилени";
            this.favoritesButton.UseVisualStyleBackColor = false;
            this.favoritesButton.Click += new System.EventHandler(this.favoritesButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox1.Image = global::FMCapp.Properties.Resources.PikPng_com_searchicon_png_772672;
            this.pictureBox1.Location = new System.Drawing.Point(610, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchTextBox.Location = new System.Drawing.Point(447, 21);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(174, 34);
            this.searchTextBox.TabIndex = 6;
            this.searchTextBox.Text = "Пребарувај";
            this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchTextBox_MouseClick);
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.searchTextBox.Leave += new System.EventHandler(this.searchTextBox_Leave);
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GenreComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenreComboBox.ForeColor = System.Drawing.SystemColors.Info;
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Items.AddRange(new object[] {
            " ",
            "Азбучен редослед",
            "Жанр",
            "Година"});
            this.GenreComboBox.Location = new System.Drawing.Point(672, 26);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(187, 24);
            this.GenreComboBox.TabIndex = 5;
            this.GenreComboBox.SelectedIndexChanged += new System.EventHandler(this.GenreComboBox_SelectedIndexChanged);
            // 
            // ProfilePictureBox
            // 
            this.ProfilePictureBox.Location = new System.Drawing.Point(152, 4);
            this.ProfilePictureBox.Name = "ProfilePictureBox";
            this.ProfilePictureBox.Size = new System.Drawing.Size(61, 64);
            this.ProfilePictureBox.TabIndex = 4;
            this.ProfilePictureBox.TabStop = false;
            // 
            // AboutLabel
            // 
            this.AboutLabel.AutoSize = true;
            this.AboutLabel.Location = new System.Drawing.Point(1081, 28);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(54, 17);
            this.AboutLabel.TabIndex = 3;
            this.AboutLabel.Text = "За Нас";
            // 
            // NameSurnamelabel
            // 
            this.NameSurnamelabel.AutoSize = true;
            this.NameSurnamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameSurnamelabel.ForeColor = System.Drawing.SystemColors.Info;
            this.NameSurnamelabel.Location = new System.Drawing.Point(238, 21);
            this.NameSurnamelabel.Name = "NameSurnamelabel";
            this.NameSurnamelabel.Size = new System.Drawing.Size(180, 29);
            this.NameSurnamelabel.TabIndex = 2;
            this.NameSurnamelabel.Text = "Име  Презиме";
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.BackColor = System.Drawing.Color.Transparent;
            this.LogoLabel.Font = new System.Drawing.Font("Snap ITC", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LogoLabel.Location = new System.Drawing.Point(2, 0);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(144, 57);
            this.LogoLabel.TabIndex = 1;
            this.LogoLabel.Text = "FMC";
            // 
            // LogOutbutton
            // 
            this.LogOutbutton.BackColor = System.Drawing.Color.DodgerBlue;
            this.LogOutbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogOutbutton.Location = new System.Drawing.Point(1158, 7);
            this.LogOutbutton.Name = "LogOutbutton";
            this.LogOutbutton.Size = new System.Drawing.Size(120, 64);
            this.LogOutbutton.TabIndex = 0;
            this.LogOutbutton.Text = "Одјави се";
            this.LogOutbutton.UseVisualStyleBackColor = false;
            this.LogOutbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 97);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1301, 652);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1278, 755);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Movies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movies";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minimezeButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ProfilePictureBox;
        private System.Windows.Forms.Label AboutLabel;
        private System.Windows.Forms.Label NameSurnamelabel;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.Button LogOutbutton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox GenreComboBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button watchhButton;
        private System.Windows.Forms.Button favoritesButton;
    }
}