namespace pop_app
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
            this.annualTotalChangeListBox = new System.Windows.Forms.ListBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.programmerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.avAnChangelabel = new System.Windows.Forms.Label();
            this.greatestIncreaseLabel = new System.Windows.Forms.Label();
            this.leastIncreaseLabel = new System.Windows.Forms.Label();
            this.avAnChangeOutputLabel = new System.Windows.Forms.Label();
            this.greatestIncreaseOutputLlabel = new System.Windows.Forms.Label();
            this.lestIncreaseOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // annualTotalChangeListBox
            // 
            this.annualTotalChangeListBox.FormattingEnabled = true;
            this.annualTotalChangeListBox.Location = new System.Drawing.Point(15, 30);
            this.annualTotalChangeListBox.Name = "annualTotalChangeListBox";
            this.annualTotalChangeListBox.Size = new System.Drawing.Size(247, 199);
            this.annualTotalChangeListBox.TabIndex = 0;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(329, 188);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 1;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // programmerLabel
            // 
            this.programmerLabel.AutoSize = true;
            this.programmerLabel.Location = new System.Drawing.Point(447, 240);
            this.programmerLabel.Name = "programmerLabel";
            this.programmerLabel.Size = new System.Drawing.Size(165, 13);
            this.programmerLabel.TabIndex = 2;
            this.programmerLabel.Text = "Programmed by Merlin Bierekofen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Increase in Irish population from 1950 to 1990";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(410, 188);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(491, 188);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // avAnChangelabel
            // 
            this.avAnChangelabel.AutoSize = true;
            this.avAnChangelabel.Location = new System.Drawing.Point(300, 42);
            this.avAnChangelabel.Name = "avAnChangelabel";
            this.avAnChangelabel.Size = new System.Drawing.Size(184, 13);
            this.avAnChangelabel.TabIndex = 6;
            this.avAnChangelabel.Text = "Average annual change in population";
            // 
            // greatestIncreaseLabel
            // 
            this.greatestIncreaseLabel.AutoSize = true;
            this.greatestIncreaseLabel.Location = new System.Drawing.Point(300, 91);
            this.greatestIncreaseLabel.Name = "greatestIncreaseLabel";
            this.greatestIncreaseLabel.Size = new System.Drawing.Size(198, 13);
            this.greatestIncreaseLabel.TabIndex = 7;
            this.greatestIncreaseLabel.Text = "Year with greatest increase in population";
            // 
            // leastIncreaseLabel
            // 
            this.leastIncreaseLabel.AutoSize = true;
            this.leastIncreaseLabel.Location = new System.Drawing.Point(300, 141);
            this.leastIncreaseLabel.Name = "leastIncreaseLabel";
            this.leastIncreaseLabel.Size = new System.Drawing.Size(182, 13);
            this.leastIncreaseLabel.TabIndex = 8;
            this.leastIncreaseLabel.Text = "Year with least increase in population";
            // 
            // avAnChangeOutputLabel
            // 
            this.avAnChangeOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.avAnChangeOutputLabel.Location = new System.Drawing.Point(505, 37);
            this.avAnChangeOutputLabel.Name = "avAnChangeOutputLabel";
            this.avAnChangeOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.avAnChangeOutputLabel.TabIndex = 9;
            // 
            // greatestIncreaseOutputLlabel
            // 
            this.greatestIncreaseOutputLlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.greatestIncreaseOutputLlabel.Location = new System.Drawing.Point(505, 87);
            this.greatestIncreaseOutputLlabel.Name = "greatestIncreaseOutputLlabel";
            this.greatestIncreaseOutputLlabel.Size = new System.Drawing.Size(100, 23);
            this.greatestIncreaseOutputLlabel.TabIndex = 10;
            // 
            // lestIncreaseOutputLabel
            // 
            this.lestIncreaseOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lestIncreaseOutputLabel.Location = new System.Drawing.Point(505, 137);
            this.lestIncreaseOutputLabel.Name = "lestIncreaseOutputLabel";
            this.lestIncreaseOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.lestIncreaseOutputLabel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 262);
            this.Controls.Add(this.lestIncreaseOutputLabel);
            this.Controls.Add(this.greatestIncreaseOutputLlabel);
            this.Controls.Add(this.avAnChangeOutputLabel);
            this.Controls.Add(this.leastIncreaseLabel);
            this.Controls.Add(this.greatestIncreaseLabel);
            this.Controls.Add(this.avAnChangelabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.programmerLabel);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.annualTotalChangeListBox);
            this.Name = "Form1";
            this.Text = "Population Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox annualTotalChangeListBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label programmerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label avAnChangelabel;
        private System.Windows.Forms.Label greatestIncreaseLabel;
        private System.Windows.Forms.Label leastIncreaseLabel;
        private System.Windows.Forms.Label avAnChangeOutputLabel;
        private System.Windows.Forms.Label greatestIncreaseOutputLlabel;
        private System.Windows.Forms.Label lestIncreaseOutputLabel;
    }
}

