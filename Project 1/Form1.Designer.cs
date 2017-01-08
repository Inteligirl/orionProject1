namespace Project_1
{
    partial class orionStarsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orionStarsForm));
            this.orionPictureBox = new System.Windows.Forms.PictureBox();
            this.showStarsButton = new System.Windows.Forms.Button();
            this.hideStarsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.star1 = new System.Windows.Forms.Label();
            this.star2 = new System.Windows.Forms.Label();
            this.star3 = new System.Windows.Forms.Label();
            this.star4 = new System.Windows.Forms.Label();
            this.star5 = new System.Windows.Forms.Label();
            this.star6 = new System.Windows.Forms.Label();
            this.star7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // orionPictureBox
            // 
            this.orionPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("orionPictureBox.Image")));
            this.orionPictureBox.Location = new System.Drawing.Point(12, 12);
            this.orionPictureBox.Name = "orionPictureBox";
            this.orionPictureBox.Size = new System.Drawing.Size(400, 470);
            this.orionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.orionPictureBox.TabIndex = 0;
            this.orionPictureBox.TabStop = false;
            // 
            // showStarsButton
            // 
            this.showStarsButton.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showStarsButton.Location = new System.Drawing.Point(63, 506);
            this.showStarsButton.Name = "showStarsButton";
            this.showStarsButton.Size = new System.Drawing.Size(93, 52);
            this.showStarsButton.TabIndex = 1;
            this.showStarsButton.Text = "Show Star Names";
            this.showStarsButton.UseVisualStyleBackColor = true;
            this.showStarsButton.Click += new System.EventHandler(this.showStarsButton_Click);
            // 
            // hideStarsButton
            // 
            this.hideStarsButton.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideStarsButton.Location = new System.Drawing.Point(162, 506);
            this.hideStarsButton.Name = "hideStarsButton";
            this.hideStarsButton.Size = new System.Drawing.Size(93, 52);
            this.hideStarsButton.TabIndex = 2;
            this.hideStarsButton.Text = "Hide Star Names";
            this.hideStarsButton.UseVisualStyleBackColor = true;
            this.hideStarsButton.Click += new System.EventHandler(this.hideStarsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(261, 506);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(93, 52);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // star1
            // 
            this.star1.AutoSize = true;
            this.star1.Location = new System.Drawing.Point(60, 43);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(60, 13);
            this.star1.TabIndex = 4;
            this.star1.Text = "Betelgeuse";
            this.star1.Visible = false;
            // 
            // star2
            // 
            this.star2.AutoSize = true;
            this.star2.Location = new System.Drawing.Point(274, 74);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(40, 13);
            this.star2.TabIndex = 5;
            this.star2.Text = "Meissa";
            this.star2.Visible = false;
            // 
            // star3
            // 
            this.star3.AutoSize = true;
            this.star3.Location = new System.Drawing.Point(91, 247);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(39, 13);
            this.star3.TabIndex = 6;
            this.star3.Text = "Alnitak";
            this.star3.Visible = false;
            // 
            // star4
            // 
            this.star4.AutoSize = true;
            this.star4.Location = new System.Drawing.Point(177, 247);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(40, 13);
            this.star4.TabIndex = 7;
            this.star4.Text = "Alnilam";
            this.star4.Visible = false;
            // 
            // star5
            // 
            this.star5.AutoSize = true;
            this.star5.Location = new System.Drawing.Point(252, 215);
            this.star5.Name = "star5";
            this.star5.Size = new System.Drawing.Size(45, 13);
            this.star5.TabIndex = 8;
            this.star5.Text = "Mintaka";
            this.star5.Visible = false;
            // 
            // star6
            // 
            this.star6.AutoSize = true;
            this.star6.Location = new System.Drawing.Point(86, 403);
            this.star6.Name = "star6";
            this.star6.Size = new System.Drawing.Size(34, 13);
            this.star6.TabIndex = 9;
            this.star6.Text = "Saiph";
            this.star6.Visible = false;
            // 
            // star7
            // 
            this.star7.AutoSize = true;
            this.star7.Location = new System.Drawing.Point(274, 374);
            this.star7.Name = "star7";
            this.star7.Size = new System.Drawing.Size(31, 13);
            this.star7.TabIndex = 10;
            this.star7.Text = "Rigel";
            this.star7.Visible = false;
            // 
            // orionStarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 578);
            this.Controls.Add(this.star7);
            this.Controls.Add(this.star6);
            this.Controls.Add(this.star5);
            this.Controls.Add(this.star4);
            this.Controls.Add(this.star3);
            this.Controls.Add(this.star2);
            this.Controls.Add(this.star1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.hideStarsButton);
            this.Controls.Add(this.showStarsButton);
            this.Controls.Add(this.orionPictureBox);
            this.Name = "orionStarsForm";
            this.Text = "Orion Constellation";
            ((System.ComponentModel.ISupportInitialize)(this.orionPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox orionPictureBox;
        private System.Windows.Forms.Button showStarsButton;
        private System.Windows.Forms.Button hideStarsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label star1;
        private System.Windows.Forms.Label star2;
        private System.Windows.Forms.Label star3;
        private System.Windows.Forms.Label star4;
        private System.Windows.Forms.Label star5;
        private System.Windows.Forms.Label star6;
        private System.Windows.Forms.Label star7;
    }
}

