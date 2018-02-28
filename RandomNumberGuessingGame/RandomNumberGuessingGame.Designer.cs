namespace RandomNumberGuessingGame
{
    partial class RandomNumberGuessingGame
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
            this.guessButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.guessLabel = new System.Windows.Forms.Label();
            this.guessTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(18, 217);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(103, 24);
            this.guessButton.TabIndex = 0;
            this.guessButton.Text = "&Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(216, 217);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(103, 24);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // guessLabel
            // 
            this.guessLabel.AutoSize = true;
            this.guessLabel.Location = new System.Drawing.Point(11, 28);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(182, 13);
            this.guessLabel.TabIndex = 3;
            this.guessLabel.Text = "Guess a number between 1 and 100:";
            // 
            // guessTextBox
            // 
            this.guessTextBox.Location = new System.Drawing.Point(231, 30);
            this.guessTextBox.Name = "guessTextBox";
            this.guessTextBox.Size = new System.Drawing.Size(88, 20);
            this.guessTextBox.TabIndex = 4;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(29, 132);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RandomNumberGuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 261);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.guessTextBox);
            this.Controls.Add(this.guessLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.guessButton);
            this.Name = "RandomNumberGuessingGame";
            this.Text = "Random Number Guessing Game";
            this.Load += new System.EventHandler(this.RandomNumberGuessingGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label guessLabel;
        private System.Windows.Forms.TextBox guessTextBox;
        private System.Windows.Forms.Label resultLabel;
    }
}

