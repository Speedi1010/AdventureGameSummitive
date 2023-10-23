namespace AdventureGameSummitive
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.option1Button = new System.Windows.Forms.Button();
            this.option2Button = new System.Windows.Forms.Button();
            this.option3Button = new System.Windows.Forms.Button();
            this.pictureOutput = new System.Windows.Forms.PictureBox();
            this.outputLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // option1Button
            // 
            this.option1Button.FlatAppearance.BorderSize = 0;
            this.option1Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.option1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option1Button.ForeColor = System.Drawing.Color.White;
            this.option1Button.Location = new System.Drawing.Point(12, 357);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(488, 23);
            this.option1Button.TabIndex = 0;
            this.option1Button.UseVisualStyleBackColor = true;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // option2Button
            // 
            this.option2Button.FlatAppearance.BorderSize = 0;
            this.option2Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.option2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option2Button.ForeColor = System.Drawing.Color.White;
            this.option2Button.Location = new System.Drawing.Point(12, 386);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(488, 23);
            this.option2Button.TabIndex = 1;
            this.option2Button.UseVisualStyleBackColor = true;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option3Button
            // 
            this.option3Button.FlatAppearance.BorderSize = 0;
            this.option3Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.option3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option3Button.ForeColor = System.Drawing.Color.White;
            this.option3Button.Location = new System.Drawing.Point(12, 415);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(488, 23);
            this.option3Button.TabIndex = 2;
            this.option3Button.UseVisualStyleBackColor = true;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // pictureOutput
            // 
            this.pictureOutput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureOutput.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureOutput.ErrorImage")));
            this.pictureOutput.Image = ((System.Drawing.Image)(resources.GetObject("pictureOutput.Image")));
            this.pictureOutput.Location = new System.Drawing.Point(12, 75);
            this.pictureOutput.Name = "pictureOutput";
            this.pictureOutput.Size = new System.Drawing.Size(488, 276);
            this.pictureOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOutput.TabIndex = 3;
            this.pictureOutput.TabStop = false;
            this.pictureOutput.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(9, 9);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(491, 63);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(512, 450);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.pictureOutput);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Adventure Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Button option3Button;
        private System.Windows.Forms.PictureBox pictureOutput;
        private System.Windows.Forms.Label outputLabel;
    }
}

