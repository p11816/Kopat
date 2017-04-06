namespace Calculator
{
    partial class mainForm
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
            this.Digit1 = new System.Windows.Forms.Button();
            this.Digit0 = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.EquallyButton = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Digit1
            // 
            this.Digit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Digit1.Location = new System.Drawing.Point(38, 111);
            this.Digit1.Name = "Digit1";
            this.Digit1.Size = new System.Drawing.Size(42, 41);
            this.Digit1.TabIndex = 0;
            this.Digit1.Tag = "1";
            this.Digit1.Text = "1";
            this.Digit1.UseVisualStyleBackColor = true;
            this.Digit1.Click += new System.EventHandler(this.Digit1_Click);
            // 
            // Digit0
            // 
            this.Digit0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Digit0.Location = new System.Drawing.Point(86, 111);
            this.Digit0.Name = "Digit0";
            this.Digit0.Size = new System.Drawing.Size(42, 41);
            this.Digit0.TabIndex = 2;
            this.Digit0.Tag = "0";
            this.Digit0.Text = "0";
            this.Digit0.UseVisualStyleBackColor = true;
            this.Digit0.Click += new System.EventHandler(this.Digit0_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlusButton.Location = new System.Drawing.Point(38, 158);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(42, 41);
            this.PlusButton.TabIndex = 3;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // EquallyButton
            // 
            this.EquallyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EquallyButton.Location = new System.Drawing.Point(86, 158);
            this.EquallyButton.Name = "EquallyButton";
            this.EquallyButton.Size = new System.Drawing.Size(42, 41);
            this.EquallyButton.TabIndex = 4;
            this.EquallyButton.Text = "=";
            this.EquallyButton.UseVisualStyleBackColor = true;
            this.EquallyButton.Click += new System.EventHandler(this.EquallyButton_Click);
            // 
            // Display
            // 
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Display.Location = new System.Drawing.Point(38, 36);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(100, 30);
            this.Display.TabIndex = 5;
            this.Display.TextChanged += new System.EventHandler(this.Display_TextChanged);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.EquallyButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.Digit0);
            this.Controls.Add(this.Digit1);
            this.Name = "mainForm";
            this.Text = "22";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Digit1;
        private System.Windows.Forms.Button Digit0;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button EquallyButton;
        private System.Windows.Forms.TextBox Display;
    }
}

