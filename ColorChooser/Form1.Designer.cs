namespace ColorChooser
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
            this.CurrentColorPanel = new System.Windows.Forms.Panel();
            this.RedButton = new System.Windows.Forms.Button();
            this.YellowButton = new System.Windows.Forms.Button();
            this.GreenButton = new System.Windows.Forms.Button();
            this.EnglishButton = new System.Windows.Forms.Button();
            this.RussianButton = new System.Windows.Forms.Button();
            this.trackBarR = new System.Windows.Forms.TrackBar();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.trackBarG = new System.Windows.Forms.TrackBar();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxG = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentColorPanel
            // 
            this.CurrentColorPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CurrentColorPanel.Location = new System.Drawing.Point(39, 35);
            this.CurrentColorPanel.Name = "CurrentColorPanel";
            this.CurrentColorPanel.Size = new System.Drawing.Size(555, 96);
            this.CurrentColorPanel.TabIndex = 0;
            this.CurrentColorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CurrentColorPanel_Paint);
            // 
            // RedButton
            // 
            this.RedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RedButton.Location = new System.Drawing.Point(39, 159);
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(109, 41);
            this.RedButton.TabIndex = 1;
            this.RedButton.Tag = "";
            this.RedButton.Text = "Red";
            this.RedButton.UseVisualStyleBackColor = true;
            this.RedButton.Click += new System.EventHandler(this.RedButton_Click);
            // 
            // YellowButton
            // 
            this.YellowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YellowButton.Location = new System.Drawing.Point(164, 159);
            this.YellowButton.Name = "YellowButton";
            this.YellowButton.Size = new System.Drawing.Size(112, 41);
            this.YellowButton.TabIndex = 2;
            this.YellowButton.Text = "Yellow";
            this.YellowButton.UseVisualStyleBackColor = true;
            this.YellowButton.Click += new System.EventHandler(this.YellowButton_Click);
            // 
            // GreenButton
            // 
            this.GreenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GreenButton.Location = new System.Drawing.Point(291, 159);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(112, 41);
            this.GreenButton.TabIndex = 3;
            this.GreenButton.Text = "Green";
            this.GreenButton.UseVisualStyleBackColor = true;
            this.GreenButton.Click += new System.EventHandler(this.GreenButton_Click);
            // 
            // EnglishButton
            // 
            this.EnglishButton.Location = new System.Drawing.Point(501, 177);
            this.EnglishButton.Name = "EnglishButton";
            this.EnglishButton.Size = new System.Drawing.Size(75, 23);
            this.EnglishButton.TabIndex = 4;
            this.EnglishButton.Text = "English";
            this.EnglishButton.UseVisualStyleBackColor = true;
            this.EnglishButton.Click += new System.EventHandler(this.EnglishButton_Click);
            // 
            // RussianButton
            // 
            this.RussianButton.Location = new System.Drawing.Point(501, 216);
            this.RussianButton.Name = "RussianButton";
            this.RussianButton.Size = new System.Drawing.Size(75, 23);
            this.RussianButton.TabIndex = 5;
            this.RussianButton.Text = "Русский";
            this.RussianButton.UseVisualStyleBackColor = true;
            this.RussianButton.Click += new System.EventHandler(this.RussianButton_Click);
            // 
            // trackBarR
            // 
            this.trackBarR.Location = new System.Drawing.Point(39, 262);
            this.trackBarR.Maximum = 255;
            this.trackBarR.Name = "trackBarR";
            this.trackBarR.Size = new System.Drawing.Size(334, 45);
            this.trackBarR.TabIndex = 6;
            this.trackBarR.Scroll += new System.EventHandler(this.trackBarR_Scroll);
            // 
            // trackBarB
            // 
            this.trackBarB.Location = new System.Drawing.Point(39, 319);
            this.trackBarB.Maximum = 255;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(334, 45);
            this.trackBarB.TabIndex = 7;
            this.trackBarB.Scroll += new System.EventHandler(this.trackBarB_Scroll);
            // 
            // trackBarG
            // 
            this.trackBarG.Location = new System.Drawing.Point(39, 382);
            this.trackBarG.Maximum = 255;
            this.trackBarG.Name = "trackBarG";
            this.trackBarG.Size = new System.Drawing.Size(334, 45);
            this.trackBarG.TabIndex = 8;
            this.trackBarG.Scroll += new System.EventHandler(this.trackBarG_Scroll);
            // 
            // textBoxR
            // 
            this.textBoxR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxR.Location = new System.Drawing.Point(379, 262);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(56, 31);
            this.textBoxR.TabIndex = 10;
            this.textBoxR.TextChanged += new System.EventHandler(this.textBoxR_TextChanged);
            // 
            // textBoxB
            // 
            this.textBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxB.Location = new System.Drawing.Point(379, 319);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(56, 31);
            this.textBoxB.TabIndex = 11;
            this.textBoxB.TextChanged += new System.EventHandler(this.textBoxB_TextChanged);
            // 
            // textBoxG
            // 
            this.textBoxG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxG.Location = new System.Drawing.Point(379, 382);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(56, 31);
            this.textBoxG.TabIndex = 12;
            this.textBoxG.TextChanged += new System.EventHandler(this.textBoxG_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 514);
            this.Controls.Add(this.textBoxG);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.trackBarG);
            this.Controls.Add(this.trackBarB);
            this.Controls.Add(this.trackBarR);
            this.Controls.Add(this.RussianButton);
            this.Controls.Add(this.EnglishButton);
            this.Controls.Add(this.GreenButton);
            this.Controls.Add(this.YellowButton);
            this.Controls.Add(this.RedButton);
            this.Controls.Add(this.CurrentColorPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CurrentColorPanel;
        private System.Windows.Forms.Button RedButton;
        private System.Windows.Forms.Button YellowButton;
        private System.Windows.Forms.Button GreenButton;
        private System.Windows.Forms.Button EnglishButton;
        private System.Windows.Forms.Button RussianButton;
        private System.Windows.Forms.TrackBar trackBarR;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.TrackBar trackBarG;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxG;
    }
}

