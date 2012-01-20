namespace MediaServiceClient
{
    partial class Carousel
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.panelItems = new System.Windows.Forms.Panel();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(2, 146);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(744, 87);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Hello World";
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveLeft.BackColor = System.Drawing.Color.Black;
            this.btnMoveLeft.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMoveLeft.FlatAppearance.BorderSize = 0;
            this.btnMoveLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnMoveLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnMoveLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveLeft.Image = global::MediaServiceClient.Properties.Resources.RightLeft;
            this.btnMoveLeft.Location = new System.Drawing.Point(714, 21);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(35, 119);
            this.btnMoveLeft.TabIndex = 7;
            this.btnMoveLeft.UseVisualStyleBackColor = false;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // panelItems
            // 
            this.panelItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelItems.Location = new System.Drawing.Point(34, 24);
            this.panelItems.Name = "panelItems";
            this.panelItems.Size = new System.Drawing.Size(683, 116);
            this.panelItems.TabIndex = 10;
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.BackColor = System.Drawing.Color.Black;
            this.btnMoveRight.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMoveRight.FlatAppearance.BorderSize = 0;
            this.btnMoveRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveRight.Image = global::MediaServiceClient.Properties.Resources.RightLeft;
            this.btnMoveRight.Location = new System.Drawing.Point(-1, 21);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(35, 119);
            this.btnMoveRight.TabIndex = 6;
            this.btnMoveRight.UseVisualStyleBackColor = false;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.Red;
            this.lblCategory.Location = new System.Drawing.Point(3, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(0, 24);
            this.lblCategory.TabIndex = 11;
            // 
            // Carousel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panelItems);
            this.Name = "Carousel";
            this.Size = new System.Drawing.Size(750, 231);
            this.Load += new System.EventHandler(this.Carousel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelItems;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Label lblCategory;
    }
}
