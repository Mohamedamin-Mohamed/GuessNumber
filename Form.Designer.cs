namespace Guess_Number_Game
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
            this.GuessTextBox = new System.Windows.Forms.TextBox();
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.GuessButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your first Guess";
            // 
            // GuessTextBox
            // 
            this.GuessTextBox.Location = new System.Drawing.Point(383, 78);
            this.GuessTextBox.Name = "GuessTextBox";
            this.GuessTextBox.Size = new System.Drawing.Size(100, 31);
            this.GuessTextBox.TabIndex = 1;
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.AutoSize = true;
            this.DisplayLabel.Location = new System.Drawing.Point(436, 123);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(0, 25);
            this.DisplayLabel.TabIndex = 2;
            // 
            // GuessButton
            // 
            this.GuessButton.Location = new System.Drawing.Point(317, 185);
            this.GuessButton.Name = "GuessButton";
            this.GuessButton.Size = new System.Drawing.Size(255, 54);
            this.GuessButton.TabIndex = 3;
            this.GuessButton.Text = "Guess Number";
            this.GuessButton.UseVisualStyleBackColor = true;
            this.GuessButton.Click += new System.EventHandler(this.GuessButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(317, 295);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(245, 46);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start game";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.GuessButton);
            this.Controls.Add(this.DisplayLabel);
            this.Controls.Add(this.GuessTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GuessTextBox;
        private System.Windows.Forms.Label DisplayLabel;
        private System.Windows.Forms.Button GuessButton;
        private System.Windows.Forms.Button StartButton;
    }
}

