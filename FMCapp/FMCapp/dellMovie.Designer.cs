
namespace FMCapp
{
    partial class dellMovie
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
            this.imgPctureBox = new System.Windows.Forms.PictureBox();
            this.delbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgPctureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPctureBox
            // 
            this.imgPctureBox.Location = new System.Drawing.Point(0, 0);
            this.imgPctureBox.Name = "imgPctureBox";
            this.imgPctureBox.Size = new System.Drawing.Size(190, 280);
            this.imgPctureBox.TabIndex = 1;
            this.imgPctureBox.TabStop = false;
            // 
            // delbutton
            // 
            this.delbutton.Location = new System.Drawing.Point(165, 0);
            this.delbutton.Name = "delbutton";
            this.delbutton.Size = new System.Drawing.Size(25, 25);
            this.delbutton.TabIndex = 2;
            this.delbutton.Text = "-";
            this.delbutton.UseVisualStyleBackColor = true;
            this.delbutton.Click += new System.EventHandler(this.delbutton_Click);
            // 
            // dellMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.delbutton);
            this.Controls.Add(this.imgPctureBox);
            this.Name = "dellMovie";
            this.Size = new System.Drawing.Size(190, 280);
            ((System.ComponentModel.ISupportInitialize)(this.imgPctureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPctureBox;
        private System.Windows.Forms.Button delbutton;
    }
}
