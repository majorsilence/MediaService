namespace MediaServiceClient
{
    partial class VerticalList
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
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveDown.BackColor = System.Drawing.Color.Black;
            this.btnMoveDown.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMoveDown.FlatAppearance.BorderSize = 0;
            this.btnMoveDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnMoveDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnMoveDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveDown.Image = global::MediaServiceClient.Properties.Resources.RightLeft;
            this.btnMoveDown.Location = new System.Drawing.Point(0, 528);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(740, 30);
            this.btnMoveDown.TabIndex = 8;
            this.btnMoveDown.UseVisualStyleBackColor = false;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveUp.BackColor = System.Drawing.Color.Black;
            this.btnMoveUp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMoveUp.FlatAppearance.BorderSize = 0;
            this.btnMoveUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnMoveUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnMoveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveUp.Image = global::MediaServiceClient.Properties.Resources.RightLeft;
            this.btnMoveUp.Location = new System.Drawing.Point(6, 3);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(740, 27);
            this.btnMoveUp.TabIndex = 9;
            this.btnMoveUp.UseVisualStyleBackColor = false;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(3, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 486);
            this.panel1.TabIndex = 10;
            // 
            // VerticalList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnMoveDown);
            this.Name = "VerticalList";
            this.Size = new System.Drawing.Size(743, 561);
            this.Load += new System.EventHandler(this.VerticalList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Panel panel1;
    }
}
