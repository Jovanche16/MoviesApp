
namespace FMCapp
{
    partial class watchedMovie
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MovieTitleLabel = new System.Windows.Forms.Label();
            this.MovieTimeWatchedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 70);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MovieTitleLabel
            // 
            this.MovieTitleLabel.AutoSize = true;
            this.MovieTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTitleLabel.Location = new System.Drawing.Point(95, 3);
            this.MovieTitleLabel.Name = "MovieTitleLabel";
            this.MovieTitleLabel.Size = new System.Drawing.Size(107, 20);
            this.MovieTitleLabel.TabIndex = 1;
            this.MovieTitleLabel.Text = "Ime na Film";
            // 
            // MovieTimeWatchedLabel
            // 
            this.MovieTimeWatchedLabel.AutoSize = true;
            this.MovieTimeWatchedLabel.Location = new System.Drawing.Point(436, 56);
            this.MovieTimeWatchedLabel.Name = "MovieTimeWatchedLabel";
            this.MovieTimeWatchedLabel.Size = new System.Drawing.Size(127, 17);
            this.MovieTimeWatchedLabel.TabIndex = 2;
            this.MovieTimeWatchedLabel.Text = "Vreme na gledanje";
            // 
            // watchedMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.MovieTimeWatchedLabel);
            this.Controls.Add(this.MovieTitleLabel);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Name = "watchedMovie";
            this.Size = new System.Drawing.Size(590, 80);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MovieTitleLabel;
        private System.Windows.Forms.Label MovieTimeWatchedLabel;
    }
}
