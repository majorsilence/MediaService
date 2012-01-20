namespace MediaServiceClient
{
    partial class TestForm
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
            this.btnPlayer = new System.Windows.Forms.Button();
            this.btnCarousel = new System.Windows.Forms.Button();
            this.btnUserSetup = new System.Windows.Forms.Button();
            this.mplayerPath = new System.Windows.Forms.TextBox();
            this.SaveMPlayerPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBaseAddress = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSetDownload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlayer
            // 
            this.btnPlayer.Location = new System.Drawing.Point(45, 32);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(75, 23);
            this.btnPlayer.TabIndex = 0;
            this.btnPlayer.Text = "Player";
            this.btnPlayer.UseVisualStyleBackColor = true;
            this.btnPlayer.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // btnCarousel
            // 
            this.btnCarousel.Location = new System.Drawing.Point(155, 32);
            this.btnCarousel.Name = "btnCarousel";
            this.btnCarousel.Size = new System.Drawing.Size(75, 23);
            this.btnCarousel.TabIndex = 1;
            this.btnCarousel.Text = "Carousel";
            this.btnCarousel.UseVisualStyleBackColor = true;
            this.btnCarousel.Click += new System.EventHandler(this.btnCarousel_Click);
            // 
            // btnUserSetup
            // 
            this.btnUserSetup.Location = new System.Drawing.Point(260, 32);
            this.btnUserSetup.Name = "btnUserSetup";
            this.btnUserSetup.Size = new System.Drawing.Size(75, 23);
            this.btnUserSetup.TabIndex = 3;
            this.btnUserSetup.Text = "User Setup";
            this.btnUserSetup.UseVisualStyleBackColor = true;
            this.btnUserSetup.Click += new System.EventHandler(this.userSetup_Click);
            // 
            // mplayerPath
            // 
            this.mplayerPath.Location = new System.Drawing.Point(45, 140);
            this.mplayerPath.Name = "mplayerPath";
            this.mplayerPath.Size = new System.Drawing.Size(580, 20);
            this.mplayerPath.TabIndex = 4;
            // 
            // SaveMPlayerPath
            // 
            this.SaveMPlayerPath.Location = new System.Drawing.Point(639, 137);
            this.SaveMPlayerPath.Name = "SaveMPlayerPath";
            this.SaveMPlayerPath.Size = new System.Drawing.Size(75, 23);
            this.SaveMPlayerPath.TabIndex = 5;
            this.SaveMPlayerPath.Text = "Save";
            this.SaveMPlayerPath.UseVisualStyleBackColor = true;
            this.SaveMPlayerPath.Click += new System.EventHandler(this.SaveMPlayerPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "MPlayer.exe filepath";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Base Address:";
            // 
            // textBaseAddress
            // 
            this.textBaseAddress.Location = new System.Drawing.Point(125, 180);
            this.textBaseAddress.Name = "textBaseAddress";
            this.textBaseAddress.Size = new System.Drawing.Size(488, 20);
            this.textBaseAddress.TabIndex = 8;
            this.textBaseAddress.Text = "http://files.majorsilence.com/mediaservice";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(125, 230);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(488, 20);
            this.textPassword.TabIndex = 14;
            this.textPassword.Text = "testpassword";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Test Password:";
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(125, 204);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(488, 20);
            this.textUserName.TabIndex = 12;
            this.textUserName.Text = "testuser";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Test User:";
            // 
            // buttonSetDownload
            // 
            this.buttonSetDownload.Location = new System.Drawing.Point(42, 260);
            this.buttonSetDownload.Name = "buttonSetDownload";
            this.buttonSetDownload.Size = new System.Drawing.Size(145, 23);
            this.buttonSetDownload.TabIndex = 16;
            this.buttonSetDownload.Text = "Set Download Info";
            this.buttonSetDownload.UseVisualStyleBackColor = true;
            this.buttonSetDownload.Click += new System.EventHandler(this.buttonSetDownload_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 320);
            this.Controls.Add(this.buttonSetDownload);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBaseAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveMPlayerPath);
            this.Controls.Add(this.mplayerPath);
            this.Controls.Add(this.btnUserSetup);
            this.Controls.Add(this.btnCarousel);
            this.Controls.Add(this.btnPlayer);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlayer;
        private System.Windows.Forms.Button btnCarousel;
        private System.Windows.Forms.Button btnUserSetup;
        private System.Windows.Forms.TextBox mplayerPath;
        private System.Windows.Forms.Button SaveMPlayerPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBaseAddress;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSetDownload;
    }
}