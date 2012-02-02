namespace AdminTool
{
    partial class Convert2Webm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk200 = new System.Windows.Forms.CheckBox();
            this.chk6500 = new System.Windows.Forms.CheckBox();
            this.chk6000 = new System.Windows.Forms.CheckBox();
            this.chk5500 = new System.Windows.Forms.CheckBox();
            this.chk5000 = new System.Windows.Forms.CheckBox();
            this.chk4500 = new System.Windows.Forms.CheckBox();
            this.chk4000 = new System.Windows.Forms.CheckBox();
            this.chk3500 = new System.Windows.Forms.CheckBox();
            this.chk3000 = new System.Windows.Forms.CheckBox();
            this.chk2500 = new System.Windows.Forms.CheckBox();
            this.chk1500 = new System.Windows.Forms.CheckBox();
            this.chk1250 = new System.Windows.Forms.CheckBox();
            this.chk1000 = new System.Windows.Forms.CheckBox();
            this.chk800 = new System.Windows.Forms.CheckBox();
            this.chk500 = new System.Windows.Forms.CheckBox();
            this.btnSelectVideo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVideoBitrateOriginal = new System.Windows.Forms.TextBox();
            this.txtVidesAudioBitrateOriginal = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnConvert = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lstFilePaths = new System.Windows.Forms.ListBox();
            this.btnRemoveVideo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chk200);
            this.groupBox1.Controls.Add(this.chk6500);
            this.groupBox1.Controls.Add(this.chk6000);
            this.groupBox1.Controls.Add(this.chk5500);
            this.groupBox1.Controls.Add(this.chk5000);
            this.groupBox1.Controls.Add(this.chk4500);
            this.groupBox1.Controls.Add(this.chk4000);
            this.groupBox1.Controls.Add(this.chk3500);
            this.groupBox1.Controls.Add(this.chk3000);
            this.groupBox1.Controls.Add(this.chk2500);
            this.groupBox1.Controls.Add(this.chk1500);
            this.groupBox1.Controls.Add(this.chk1250);
            this.groupBox1.Controls.Add(this.chk1000);
            this.groupBox1.Controls.Add(this.chk800);
            this.groupBox1.Controls.Add(this.chk500);
            this.groupBox1.Location = new System.Drawing.Point(340, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 207);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video Output Bitrates (kilobits)";
            // 
            // chk200
            // 
            this.chk200.AutoSize = true;
            this.chk200.Checked = true;
            this.chk200.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk200.Location = new System.Drawing.Point(6, 19);
            this.chk200.Name = "chk200";
            this.chk200.Size = new System.Drawing.Size(44, 17);
            this.chk200.TabIndex = 14;
            this.chk200.Text = "200";
            this.chk200.UseVisualStyleBackColor = true;
            // 
            // chk6500
            // 
            this.chk6500.AutoSize = true;
            this.chk6500.Location = new System.Drawing.Point(94, 155);
            this.chk6500.Name = "chk6500";
            this.chk6500.Size = new System.Drawing.Size(50, 17);
            this.chk6500.TabIndex = 13;
            this.chk6500.Text = "6500";
            this.chk6500.UseVisualStyleBackColor = true;
            // 
            // chk6000
            // 
            this.chk6000.AutoSize = true;
            this.chk6000.Location = new System.Drawing.Point(94, 132);
            this.chk6000.Name = "chk6000";
            this.chk6000.Size = new System.Drawing.Size(50, 17);
            this.chk6000.TabIndex = 12;
            this.chk6000.Text = "6000";
            this.chk6000.UseVisualStyleBackColor = true;
            // 
            // chk5500
            // 
            this.chk5500.AutoSize = true;
            this.chk5500.Location = new System.Drawing.Point(94, 111);
            this.chk5500.Name = "chk5500";
            this.chk5500.Size = new System.Drawing.Size(50, 17);
            this.chk5500.TabIndex = 11;
            this.chk5500.Text = "5500";
            this.chk5500.UseVisualStyleBackColor = true;
            // 
            // chk5000
            // 
            this.chk5000.AutoSize = true;
            this.chk5000.Checked = true;
            this.chk5000.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk5000.Location = new System.Drawing.Point(94, 88);
            this.chk5000.Name = "chk5000";
            this.chk5000.Size = new System.Drawing.Size(50, 17);
            this.chk5000.TabIndex = 10;
            this.chk5000.Text = "5000";
            this.chk5000.UseVisualStyleBackColor = true;
            // 
            // chk4500
            // 
            this.chk4500.AutoSize = true;
            this.chk4500.Location = new System.Drawing.Point(94, 65);
            this.chk4500.Name = "chk4500";
            this.chk4500.Size = new System.Drawing.Size(50, 17);
            this.chk4500.TabIndex = 9;
            this.chk4500.Text = "4500";
            this.chk4500.UseVisualStyleBackColor = true;
            // 
            // chk4000
            // 
            this.chk4000.AutoSize = true;
            this.chk4000.Location = new System.Drawing.Point(94, 42);
            this.chk4000.Name = "chk4000";
            this.chk4000.Size = new System.Drawing.Size(50, 17);
            this.chk4000.TabIndex = 8;
            this.chk4000.Text = "4000";
            this.chk4000.UseVisualStyleBackColor = true;
            // 
            // chk3500
            // 
            this.chk3500.AutoSize = true;
            this.chk3500.Location = new System.Drawing.Point(94, 19);
            this.chk3500.Name = "chk3500";
            this.chk3500.Size = new System.Drawing.Size(50, 17);
            this.chk3500.TabIndex = 7;
            this.chk3500.Text = "3500";
            this.chk3500.UseVisualStyleBackColor = true;
            // 
            // chk3000
            // 
            this.chk3000.AutoSize = true;
            this.chk3000.Checked = true;
            this.chk3000.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk3000.Location = new System.Drawing.Point(6, 180);
            this.chk3000.Name = "chk3000";
            this.chk3000.Size = new System.Drawing.Size(50, 17);
            this.chk3000.TabIndex = 6;
            this.chk3000.Text = "3000";
            this.chk3000.UseVisualStyleBackColor = true;
            // 
            // chk2500
            // 
            this.chk2500.AutoSize = true;
            this.chk2500.Location = new System.Drawing.Point(6, 157);
            this.chk2500.Name = "chk2500";
            this.chk2500.Size = new System.Drawing.Size(50, 17);
            this.chk2500.TabIndex = 5;
            this.chk2500.Text = "2500";
            this.chk2500.UseVisualStyleBackColor = true;
            // 
            // chk1500
            // 
            this.chk1500.AutoSize = true;
            this.chk1500.Checked = true;
            this.chk1500.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk1500.Location = new System.Drawing.Point(6, 134);
            this.chk1500.Name = "chk1500";
            this.chk1500.Size = new System.Drawing.Size(50, 17);
            this.chk1500.TabIndex = 4;
            this.chk1500.Text = "1500";
            this.chk1500.UseVisualStyleBackColor = true;
            // 
            // chk1250
            // 
            this.chk1250.AutoSize = true;
            this.chk1250.Checked = true;
            this.chk1250.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk1250.Location = new System.Drawing.Point(6, 111);
            this.chk1250.Name = "chk1250";
            this.chk1250.Size = new System.Drawing.Size(50, 17);
            this.chk1250.TabIndex = 3;
            this.chk1250.Text = "1250";
            this.chk1250.UseVisualStyleBackColor = true;
            // 
            // chk1000
            // 
            this.chk1000.AutoSize = true;
            this.chk1000.Checked = true;
            this.chk1000.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk1000.Location = new System.Drawing.Point(6, 88);
            this.chk1000.Name = "chk1000";
            this.chk1000.Size = new System.Drawing.Size(50, 17);
            this.chk1000.TabIndex = 2;
            this.chk1000.Text = "1000";
            this.chk1000.UseVisualStyleBackColor = true;
            // 
            // chk800
            // 
            this.chk800.AutoSize = true;
            this.chk800.Checked = true;
            this.chk800.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk800.Location = new System.Drawing.Point(6, 65);
            this.chk800.Name = "chk800";
            this.chk800.Size = new System.Drawing.Size(44, 17);
            this.chk800.TabIndex = 1;
            this.chk800.Text = "800";
            this.chk800.UseVisualStyleBackColor = true;
            // 
            // chk500
            // 
            this.chk500.AutoSize = true;
            this.chk500.Checked = true;
            this.chk500.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk500.Location = new System.Drawing.Point(6, 42);
            this.chk500.Name = "chk500";
            this.chk500.Size = new System.Drawing.Size(44, 17);
            this.chk500.TabIndex = 0;
            this.chk500.Text = "500";
            this.chk500.UseVisualStyleBackColor = true;
            // 
            // btnSelectVideo
            // 
            this.btnSelectVideo.Location = new System.Drawing.Point(122, 9);
            this.btnSelectVideo.Name = "btnSelectVideo";
            this.btnSelectVideo.Size = new System.Drawing.Size(84, 23);
            this.btnSelectVideo.TabIndex = 3;
            this.btnSelectVideo.Text = "Select Video";
            this.btnSelectVideo.UseVisualStyleBackColor = true;
            this.btnSelectVideo.Click += new System.EventHandler(this.btnSelectVideo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Video File to convert";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Video Bitrate (Original)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Videos Audio Bitrate (Original)";
            // 
            // txtVideoBitrateOriginal
            // 
            this.txtVideoBitrateOriginal.Location = new System.Drawing.Point(160, 217);
            this.txtVideoBitrateOriginal.Name = "txtVideoBitrateOriginal";
            this.txtVideoBitrateOriginal.ReadOnly = true;
            this.txtVideoBitrateOriginal.Size = new System.Drawing.Size(137, 20);
            this.txtVideoBitrateOriginal.TabIndex = 8;
            // 
            // txtVidesAudioBitrateOriginal
            // 
            this.txtVidesAudioBitrateOriginal.Location = new System.Drawing.Point(160, 244);
            this.txtVidesAudioBitrateOriginal.Name = "txtVidesAudioBitrateOriginal";
            this.txtVidesAudioBitrateOriginal.ReadOnly = true;
            this.txtVidesAudioBitrateOriginal.Size = new System.Drawing.Size(137, 20);
            this.txtVidesAudioBitrateOriginal.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Video files|*.wmv;*.avi;*.asf;*.flv;*.bin;*.vob;*.es;*.ps;*.pes,.qt;*.mov;*.mp4;*" +
                ".mpg;*.mpeg;*.rm;*.mkv;*.nut;*.nsv;*.vivo;*.fli;*.yuv4mpeg;*.cpk,.ogm;*.asx;*.3g" +
                "p|All files|*.*";
            this.openFileDialog1.Multiselect = true;
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvert.Location = new System.Drawing.Point(418, 349);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(84, 23);
            this.btnConvert.TabIndex = 10;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 380);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(525, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lstFilePaths
            // 
            this.lstFilePaths.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFilePaths.FormattingEnabled = true;
            this.lstFilePaths.HorizontalScrollbar = true;
            this.lstFilePaths.Location = new System.Drawing.Point(15, 38);
            this.lstFilePaths.Name = "lstFilePaths";
            this.lstFilePaths.Size = new System.Drawing.Size(304, 160);
            this.lstFilePaths.TabIndex = 12;
            this.lstFilePaths.SelectedIndexChanged += new System.EventHandler(this.lstFilePaths_SelectedIndexChanged);
            // 
            // btnRemoveVideo
            // 
            this.btnRemoveVideo.Location = new System.Drawing.Point(220, 9);
            this.btnRemoveVideo.Name = "btnRemoveVideo";
            this.btnRemoveVideo.Size = new System.Drawing.Size(99, 23);
            this.btnRemoveVideo.TabIndex = 13;
            this.btnRemoveVideo.Text = "Remove Video";
            this.btnRemoveVideo.UseVisualStyleBackColor = true;
            this.btnRemoveVideo.Click += new System.EventHandler(this.btnRemoveVideo_Click);
            // 
            // Convert2Webm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 402);
            this.Controls.Add(this.btnRemoveVideo);
            this.Controls.Add(this.lstFilePaths);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtVidesAudioBitrateOriginal);
            this.Controls.Add(this.txtVideoBitrateOriginal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectVideo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Convert2Webm";
            this.Text = "Convert2Webm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk1250;
        private System.Windows.Forms.CheckBox chk1000;
        private System.Windows.Forms.CheckBox chk800;
        private System.Windows.Forms.CheckBox chk500;
        private System.Windows.Forms.CheckBox chk4500;
        private System.Windows.Forms.CheckBox chk4000;
        private System.Windows.Forms.CheckBox chk3500;
        private System.Windows.Forms.CheckBox chk3000;
        private System.Windows.Forms.CheckBox chk2500;
        private System.Windows.Forms.CheckBox chk1500;
        private System.Windows.Forms.CheckBox chk6500;
        private System.Windows.Forms.CheckBox chk6000;
        private System.Windows.Forms.CheckBox chk5500;
        private System.Windows.Forms.CheckBox chk5000;
        private System.Windows.Forms.Button btnSelectVideo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVideoBitrateOriginal;
        private System.Windows.Forms.TextBox txtVidesAudioBitrateOriginal;
        private System.Windows.Forms.CheckBox chk200;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox lstFilePaths;
        private System.Windows.Forms.Button btnRemoveVideo;
    }
}