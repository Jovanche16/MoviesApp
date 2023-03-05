
namespace FMCapp
{
    partial class favoriteMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(favoriteMovie));
            this.MovieTitleLabel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.ratingPictureBox = new System.Windows.Forms.PictureBox();
            this.MoviPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ratingPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoviPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieTitleLabel
            // 
            this.MovieTitleLabel.AutoSize = true;
            this.MovieTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTitleLabel.Location = new System.Drawing.Point(123, 13);
            this.MovieTitleLabel.Name = "MovieTitleLabel";
            this.MovieTitleLabel.Size = new System.Drawing.Size(107, 20);
            this.MovieTitleLabel.TabIndex = 3;
            this.MovieTitleLabel.Text = "Ime na Film";
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.removeButton.FlatAppearance.BorderSize = 0;
            this.removeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Location = new System.Drawing.Point(361, 0);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(126, 128);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "Одстрани";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // ratingPictureBox
            // 
            this.ratingPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ratingPictureBox.Image")));
            this.ratingPictureBox.Location = new System.Drawing.Point(127, 85);
            this.ratingPictureBox.Name = "ratingPictureBox";
            this.ratingPictureBox.Size = new System.Drawing.Size(125, 27);
            this.ratingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ratingPictureBox.TabIndex = 4;
            this.ratingPictureBox.TabStop = false;
            // 
            // MoviPictureBox
            // 
            this.MoviPictureBox.Location = new System.Drawing.Point(12, 3);
            this.MoviPictureBox.Name = "MoviPictureBox";
            this.MoviPictureBox.Size = new System.Drawing.Size(90, 122);
            this.MoviPictureBox.TabIndex = 2;
            this.MoviPictureBox.TabStop = false;
            // 
            // favoriteMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.ratingPictureBox);
            this.Controls.Add(this.MovieTitleLabel);
            this.Controls.Add(this.MoviPictureBox);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "favoriteMovie";
            this.Size = new System.Drawing.Size(505, 128);
            ((System.ComponentModel.ISupportInitialize)(this.ratingPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoviPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MovieTitleLabel;
        private System.Windows.Forms.PictureBox MoviPictureBox;
        private System.Windows.Forms.PictureBox ratingPictureBox;
        private System.Windows.Forms.Button removeButton;
    }
}
