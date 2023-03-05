
namespace FMCapp
{
    partial class MainAdmin
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
            this.addPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addLabel = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.delPanel = new System.Windows.Forms.Panel();
            this.dPictureBox = new System.Windows.Forms.PictureBox();
            this.DeleteLabel = new System.Windows.Forms.Label();
            this.ediPanel = new System.Windows.Forms.Panel();
            this.ePictureBo = new System.Windows.Forms.PictureBox();
            this.EditLabel = new System.Windows.Forms.Label();
            this.profPanel = new System.Windows.Forms.Panel();
            this.pPictureBox = new System.Windows.Forms.PictureBox();
            this.profileLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.minimeseButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.addPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.delPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dPictureBox)).BeginInit();
            this.ediPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePictureBo)).BeginInit();
            this.profPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPictureBox)).BeginInit();
            this.panel5.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.addPanel);
            this.panel1.Controls.Add(this.LogOutButton);
            this.panel1.Controls.Add(this.delPanel);
            this.panel1.Controls.Add(this.ediPanel);
            this.panel1.Controls.Add(this.profPanel);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 578);
            this.panel1.TabIndex = 0;
            // 
            // addPanel
            // 
            this.addPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.addPanel.Controls.Add(this.pictureBox1);
            this.addPanel.Controls.Add(this.addLabel);
            this.addPanel.Location = new System.Drawing.Point(0, 70);
            this.addPanel.Margin = new System.Windows.Forms.Padding(0);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(221, 67);
            this.addPanel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FMCapp.Properties.Resources.window_add_128;
            this.pictureBox1.Location = new System.Drawing.Point(147, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.BackColor = System.Drawing.Color.Transparent;
            this.addLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addLabel.Location = new System.Drawing.Point(45, 26);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(63, 18);
            this.addLabel.TabIndex = 1;
            this.addLabel.Text = "Додади";
            this.addLabel.Click += new System.EventHandler(this.addLabel_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.LogOutButton.FlatAppearance.BorderSize = 0;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LogOutButton.Location = new System.Drawing.Point(3, 526);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(215, 52);
            this.LogOutButton.TabIndex = 3;
            this.LogOutButton.Text = "Одјави се";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // delPanel
            // 
            this.delPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.delPanel.Controls.Add(this.dPictureBox);
            this.delPanel.Controls.Add(this.DeleteLabel);
            this.delPanel.Location = new System.Drawing.Point(0, 204);
            this.delPanel.Margin = new System.Windows.Forms.Padding(0);
            this.delPanel.Name = "delPanel";
            this.delPanel.Size = new System.Drawing.Size(221, 67);
            this.delPanel.TabIndex = 2;
            // 
            // dPictureBox
            // 
            this.dPictureBox.Image = global::FMCapp.Properties.Resources.trash_9_128;
            this.dPictureBox.Location = new System.Drawing.Point(147, 8);
            this.dPictureBox.Name = "dPictureBox";
            this.dPictureBox.Size = new System.Drawing.Size(37, 34);
            this.dPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dPictureBox.TabIndex = 3;
            this.dPictureBox.TabStop = false;
            // 
            // DeleteLabel
            // 
            this.DeleteLabel.AutoSize = true;
            this.DeleteLabel.BackColor = System.Drawing.Color.Transparent;
            this.DeleteLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteLabel.Location = new System.Drawing.Point(46, 24);
            this.DeleteLabel.Name = "DeleteLabel";
            this.DeleteLabel.Size = new System.Drawing.Size(71, 18);
            this.DeleteLabel.TabIndex = 2;
            this.DeleteLabel.Text = "Избриши";
            this.DeleteLabel.Click += new System.EventHandler(this.DeleteLabel_Click);
            // 
            // ediPanel
            // 
            this.ediPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ediPanel.Controls.Add(this.ePictureBo);
            this.ediPanel.Controls.Add(this.EditLabel);
            this.ediPanel.Location = new System.Drawing.Point(0, 137);
            this.ediPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ediPanel.Name = "ediPanel";
            this.ediPanel.Size = new System.Drawing.Size(221, 67);
            this.ediPanel.TabIndex = 1;
            // 
            // ePictureBo
            // 
            this.ePictureBo.Image = global::FMCapp.Properties.Resources.edit_11_128;
            this.ePictureBo.Location = new System.Drawing.Point(147, 10);
            this.ePictureBo.Name = "ePictureBo";
            this.ePictureBo.Size = new System.Drawing.Size(37, 34);
            this.ePictureBo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ePictureBo.TabIndex = 2;
            this.ePictureBo.TabStop = false;
            // 
            // EditLabel
            // 
            this.EditLabel.AutoSize = true;
            this.EditLabel.BackColor = System.Drawing.Color.Transparent;
            this.EditLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EditLabel.Location = new System.Drawing.Point(46, 26);
            this.EditLabel.Name = "EditLabel";
            this.EditLabel.Size = new System.Drawing.Size(62, 18);
            this.EditLabel.TabIndex = 1;
            this.EditLabel.Text = "Измени";
            this.EditLabel.Click += new System.EventHandler(this.EditLabel_Click);
            // 
            // profPanel
            // 
            this.profPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.profPanel.Controls.Add(this.pPictureBox);
            this.profPanel.Controls.Add(this.profileLabel);
            this.profPanel.Location = new System.Drawing.Point(0, 3);
            this.profPanel.Margin = new System.Windows.Forms.Padding(0);
            this.profPanel.Name = "profPanel";
            this.profPanel.Size = new System.Drawing.Size(221, 67);
            this.profPanel.TabIndex = 0;
            // 
            // pPictureBox
            // 
            this.pPictureBox.Image = global::FMCapp.Properties.Resources.administrator_2_128;
            this.pPictureBox.Location = new System.Drawing.Point(147, 16);
            this.pPictureBox.Name = "pPictureBox";
            this.pPictureBox.Size = new System.Drawing.Size(37, 34);
            this.pPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pPictureBox.TabIndex = 1;
            this.pPictureBox.TabStop = false;
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.BackColor = System.Drawing.Color.Transparent;
            this.profileLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.profileLabel.Location = new System.Drawing.Point(45, 23);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(66, 18);
            this.profileLabel.TabIndex = 0;
            this.profileLabel.Text = "Профил";
            this.profileLabel.Click += new System.EventHandler(this.profileLabel_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.minimeseButton);
            this.panel5.Controls.Add(this.ExitButton);
            this.panel5.Location = new System.Drawing.Point(1, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1008, 24);
            this.panel5.TabIndex = 2;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            // 
            // minimeseButton
            // 
            this.minimeseButton.BackColor = System.Drawing.Color.DarkGray;
            this.minimeseButton.FlatAppearance.BorderSize = 0;
            this.minimeseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimeseButton.Location = new System.Drawing.Point(954, 1);
            this.minimeseButton.Margin = new System.Windows.Forms.Padding(1);
            this.minimeseButton.Name = "minimeseButton";
            this.minimeseButton.Size = new System.Drawing.Size(25, 25);
            this.minimeseButton.TabIndex = 2;
            this.minimeseButton.Text = "_";
            this.minimeseButton.UseVisualStyleBackColor = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitButton.Location = new System.Drawing.Point(981, 0);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2, 0, 1, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(25, 25);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.AutoScroll = true;
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contentPanel.BackgroundImage = global::FMCapp.Properties.Resources.icon_admin_16;
            this.contentPanel.Controls.Add(this.flowLayoutPanel1);
            this.contentPanel.Location = new System.Drawing.Point(221, 27);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(786, 577);
            this.contentPanel.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(809, 571);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // MainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1005, 607);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainAdmin";
            this.panel1.ResumeLayout(false);
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.delPanel.ResumeLayout(false);
            this.delPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dPictureBox)).EndInit();
            this.ediPanel.ResumeLayout(false);
            this.ediPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePictureBo)).EndInit();
            this.profPanel.ResumeLayout(false);
            this.profPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPictureBox)).EndInit();
            this.panel5.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel delPanel;
        private System.Windows.Forms.Panel ediPanel;
        private System.Windows.Forms.Panel profPanel;
        private System.Windows.Forms.Label DeleteLabel;
        private System.Windows.Forms.Label EditLabel;
        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button minimeseButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox dPictureBox;
        private System.Windows.Forms.PictureBox ePictureBo;
        private System.Windows.Forms.PictureBox pPictureBox;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label addLabel;
    }
}