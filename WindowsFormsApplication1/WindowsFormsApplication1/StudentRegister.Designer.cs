namespace WindowsFormsApplication1
{
    partial class StudentRegister
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.regLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.regTextBox2 = new System.Windows.Forms.TextBox();
            this.searchRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(100, 111);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(181, 111);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(42, 28);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // regLabel
            // 
            this.regLabel.AutoSize = true;
            this.regLabel.Location = new System.Drawing.Point(45, 59);
            this.regLabel.Name = "regLabel";
            this.regLabel.Size = new System.Drawing.Size(44, 13);
            this.regLabel.TabIndex = 3;
            this.regLabel.Text = "Reg No";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(123, 20);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(112, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // regTextBox2
            // 
            this.regTextBox2.Location = new System.Drawing.Point(123, 59);
            this.regTextBox2.Name = "regTextBox2";
            this.regTextBox2.Size = new System.Drawing.Size(112, 20);
            this.regTextBox2.TabIndex = 5;
            // 
            // searchRichTextBox
            // 
            this.searchRichTextBox.Location = new System.Drawing.Point(100, 165);
            this.searchRichTextBox.Name = "searchRichTextBox";
            this.searchRichTextBox.Size = new System.Drawing.Size(142, 60);
            this.searchRichTextBox.TabIndex = 6;
            this.searchRichTextBox.Text = "";
            // 
            // StudentRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.searchRichTextBox);
            this.Controls.Add(this.regTextBox2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.regLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.SaveButton);
            this.Name = "StudentRegister";
            this.Text = "Student Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label regLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox regTextBox2;
        private System.Windows.Forms.RichTextBox searchRichTextBox;
    }
}

