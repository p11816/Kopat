namespace abw
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
            this.Mark = new System.Windows.Forms.ComboBox();
            this.Model = new System.Windows.Forms.ComboBox();
            this.Model2 = new System.Windows.Forms.ComboBox();
            this.Mark2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Mark
            // 
            this.Mark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Mark.FormattingEnabled = true;
            this.Mark.Location = new System.Drawing.Point(13, 13);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(151, 21);
            this.Mark.TabIndex = 0;
            this.Mark.SelectedIndexChanged += new System.EventHandler(this.Mark_SelectedIndexChanged);
            // 
            // Model
            // 
            this.Model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Model.FormattingEnabled = true;
            this.Model.Location = new System.Drawing.Point(196, 13);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(151, 21);
            this.Model.TabIndex = 1;
            // 
            // Model2
            // 
            this.Model2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Model2.FormattingEnabled = true;
            this.Model2.Location = new System.Drawing.Point(196, 134);
            this.Model2.Name = "Model2";
            this.Model2.Size = new System.Drawing.Size(151, 21);
            this.Model2.TabIndex = 3;
            // 
            // Mark2
            // 
            this.Mark2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Mark2.FormattingEnabled = true;
            this.Mark2.Location = new System.Drawing.Point(13, 134);
            this.Mark2.Name = "Mark2";
            this.Mark2.Size = new System.Drawing.Size(151, 21);
            this.Mark2.TabIndex = 2;
            this.Mark2.SelectedIndexChanged += new System.EventHandler(this.Mark2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 453);
            this.Controls.Add(this.Model2);
            this.Controls.Add(this.Mark2);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Mark);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Mark;
        private System.Windows.Forms.ComboBox Model;
        private System.Windows.Forms.ComboBox Model2;
        private System.Windows.Forms.ComboBox Mark2;
    }
}

