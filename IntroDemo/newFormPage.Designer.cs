namespace IntroDemo
{
    partial class newFormPage
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
            this.newFormAvatarImage = new System.Windows.Forms.PictureBox();
            this.avatarNameLabel = new System.Windows.Forms.Label();
            this.closeNewFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.newFormAvatarImage)).BeginInit();
            this.SuspendLayout();
            // 
            // newFormAvatarImage
            // 
            this.newFormAvatarImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newFormAvatarImage.Location = new System.Drawing.Point(25, 27);
            this.newFormAvatarImage.Name = "newFormAvatarImage";
            this.newFormAvatarImage.Size = new System.Drawing.Size(120, 125);
            this.newFormAvatarImage.TabIndex = 0;
            this.newFormAvatarImage.TabStop = false;
            // 
            // avatarNameLabel
            // 
            this.avatarNameLabel.AutoSize = true;
            this.avatarNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avatarNameLabel.Location = new System.Drawing.Point(228, 83);
            this.avatarNameLabel.Name = "avatarNameLabel";
            this.avatarNameLabel.Size = new System.Drawing.Size(57, 20);
            this.avatarNameLabel.TabIndex = 1;
            this.avatarNameLabel.Text = "label1";
            // 
            // closeNewFormButton
            // 
            this.closeNewFormButton.BackColor = System.Drawing.Color.White;
            this.closeNewFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeNewFormButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeNewFormButton.Location = new System.Drawing.Point(105, 228);
            this.closeNewFormButton.Name = "closeNewFormButton";
            this.closeNewFormButton.Size = new System.Drawing.Size(202, 50);
            this.closeNewFormButton.TabIndex = 2;
            this.closeNewFormButton.Text = "Close New Form";
            this.closeNewFormButton.UseVisualStyleBackColor = false;
            this.closeNewFormButton.Click += new System.EventHandler(this.closeNewFormButton_Click);
            // 
            // newFormPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 344);
            this.Controls.Add(this.closeNewFormButton);
            this.Controls.Add(this.avatarNameLabel);
            this.Controls.Add(this.newFormAvatarImage);
            this.Name = "newFormPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "newFormPage";
            this.Load += new System.EventHandler(this.newFormPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newFormAvatarImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox newFormAvatarImage;
        private System.Windows.Forms.Label avatarNameLabel;
        private System.Windows.Forms.Button closeNewFormButton;
    }
}