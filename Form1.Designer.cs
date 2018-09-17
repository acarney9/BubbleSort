namespace BubbleSortExample
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
            this.label1 = new System.Windows.Forms.Label();
            this.nonSortedButton = new System.Windows.Forms.Button();
            this.sortedButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nonSortedLabel = new System.Windows.Forms.Label();
            this.sortedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Non Sorted";
            // 
            // nonSortedButton
            // 
            this.nonSortedButton.Location = new System.Drawing.Point(302, 432);
            this.nonSortedButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nonSortedButton.Name = "nonSortedButton";
            this.nonSortedButton.Size = new System.Drawing.Size(161, 30);
            this.nonSortedButton.TabIndex = 2;
            this.nonSortedButton.Text = "Non-Sorted";
            this.nonSortedButton.UseVisualStyleBackColor = true;
            this.nonSortedButton.Click += new System.EventHandler(this.nonSortedButton_Click);
            // 
            // sortedButton
            // 
            this.sortedButton.Location = new System.Drawing.Point(800, 432);
            this.sortedButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sortedButton.Name = "sortedButton";
            this.sortedButton.Size = new System.Drawing.Size(155, 30);
            this.sortedButton.TabIndex = 5;
            this.sortedButton.Text = "Sorted";
            this.sortedButton.UseVisualStyleBackColor = true;
            this.sortedButton.Click += new System.EventHandler(this.sortedButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(661, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sorted";
            // 
            // nonSortedLabel
            // 
            this.nonSortedLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.nonSortedLabel.Location = new System.Drawing.Point(75, 29);
            this.nonSortedLabel.Name = "nonSortedLabel";
            this.nonSortedLabel.Size = new System.Drawing.Size(204, 1055);
            this.nonSortedLabel.TabIndex = 6;
            // 
            // sortedLabel
            // 
            this.sortedLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.sortedLabel.Location = new System.Drawing.Point(589, 29);
            this.sortedLabel.Name = "sortedLabel";
            this.sortedLabel.Size = new System.Drawing.Size(204, 1027);
            this.sortedLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 1050);
            this.Controls.Add(this.sortedLabel);
            this.Controls.Add(this.nonSortedLabel);
            this.Controls.Add(this.sortedButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nonSortedButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nonSortedButton;
        private System.Windows.Forms.Button sortedButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nonSortedLabel;
        private System.Windows.Forms.Label sortedLabel;
    }
}

