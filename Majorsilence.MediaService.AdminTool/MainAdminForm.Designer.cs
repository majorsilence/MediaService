namespace Majorsilence.MediaService.AdminTool
{
    partial class MainAdminForm
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
            this.btnEditUsers = new System.Windows.Forms.Button();
            this.btnEditRoles = new System.Windows.Forms.Button();
            this.btnCountries = new System.Windows.Forms.Button();
            this.btnMotionPictureRatings = new System.Windows.Forms.Button();
            this.btnMediaInfo = new System.Windows.Forms.Button();
            this.btnMediaCategories = new System.Windows.Forms.Button();
            this.btnConvert2WebM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditUsers
            // 
            this.btnEditUsers.Location = new System.Drawing.Point(26, 25);
            this.btnEditUsers.Name = "btnEditUsers";
            this.btnEditUsers.Size = new System.Drawing.Size(75, 23);
            this.btnEditUsers.TabIndex = 0;
            this.btnEditUsers.Text = "Users";
            this.btnEditUsers.UseVisualStyleBackColor = true;
            // 
            // btnEditRoles
            // 
            this.btnEditRoles.Location = new System.Drawing.Point(135, 25);
            this.btnEditRoles.Name = "btnEditRoles";
            this.btnEditRoles.Size = new System.Drawing.Size(75, 23);
            this.btnEditRoles.TabIndex = 1;
            this.btnEditRoles.Text = "Roles";
            this.btnEditRoles.UseVisualStyleBackColor = true;
            // 
            // btnCountries
            // 
            this.btnCountries.Location = new System.Drawing.Point(260, 25);
            this.btnCountries.Name = "btnCountries";
            this.btnCountries.Size = new System.Drawing.Size(75, 23);
            this.btnCountries.TabIndex = 2;
            this.btnCountries.Text = "Countries";
            this.btnCountries.UseVisualStyleBackColor = true;
            // 
            // btnMotionPictureRatings
            // 
            this.btnMotionPictureRatings.Location = new System.Drawing.Point(396, 25);
            this.btnMotionPictureRatings.Name = "btnMotionPictureRatings";
            this.btnMotionPictureRatings.Size = new System.Drawing.Size(148, 23);
            this.btnMotionPictureRatings.TabIndex = 3;
            this.btnMotionPictureRatings.Text = "Motion Picture Ratings";
            this.btnMotionPictureRatings.UseVisualStyleBackColor = true;
            this.btnMotionPictureRatings.Click += new System.EventHandler(this.btnMotionPictureRatings_Click);
            // 
            // btnMediaInfo
            // 
            this.btnMediaInfo.Location = new System.Drawing.Point(26, 88);
            this.btnMediaInfo.Name = "btnMediaInfo";
            this.btnMediaInfo.Size = new System.Drawing.Size(75, 23);
            this.btnMediaInfo.TabIndex = 4;
            this.btnMediaInfo.Text = "Media Info";
            this.btnMediaInfo.UseVisualStyleBackColor = true;
            this.btnMediaInfo.Click += new System.EventHandler(this.btnMediaInfo_Click);
            // 
            // btnMediaCategories
            // 
            this.btnMediaCategories.Location = new System.Drawing.Point(154, 88);
            this.btnMediaCategories.Name = "btnMediaCategories";
            this.btnMediaCategories.Size = new System.Drawing.Size(75, 23);
            this.btnMediaCategories.TabIndex = 5;
            this.btnMediaCategories.Text = "Media Categories";
            this.btnMediaCategories.UseVisualStyleBackColor = true;
            // 
            // btnConvert2WebM
            // 
            this.btnConvert2WebM.Location = new System.Drawing.Point(396, 88);
            this.btnConvert2WebM.Name = "btnConvert2WebM";
            this.btnConvert2WebM.Size = new System.Drawing.Size(148, 23);
            this.btnConvert2WebM.TabIndex = 6;
            this.btnConvert2WebM.Text = "Convert 2 Webm";
            this.btnConvert2WebM.UseVisualStyleBackColor = true;
            this.btnConvert2WebM.Click += new System.EventHandler(this.btnConvert2WebM_Click);
            // 
            // MainAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 245);
            this.Controls.Add(this.btnConvert2WebM);
            this.Controls.Add(this.btnMediaCategories);
            this.Controls.Add(this.btnMediaInfo);
            this.Controls.Add(this.btnMotionPictureRatings);
            this.Controls.Add(this.btnCountries);
            this.Controls.Add(this.btnEditRoles);
            this.Controls.Add(this.btnEditUsers);
            this.Name = "MainAdminForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditUsers;
        private System.Windows.Forms.Button btnEditRoles;
        private System.Windows.Forms.Button btnCountries;
        private System.Windows.Forms.Button btnMotionPictureRatings;
        private System.Windows.Forms.Button btnMediaInfo;
        private System.Windows.Forms.Button btnMediaCategories;
        private System.Windows.Forms.Button btnConvert2WebM;
    }
}

