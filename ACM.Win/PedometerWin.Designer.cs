namespace ACM.Win
{
    partial class PedometerWin
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GoalTextBox = new System.Windows.Forms.TextBox();
            this.StepsTextBox = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(327, 36);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(127, 72);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Steps Goal for Today:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Steps Today:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // GoalTextBox
            // 
            this.GoalTextBox.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoalTextBox.Location = new System.Drawing.Point(232, 37);
            this.GoalTextBox.Name = "GoalTextBox";
            this.GoalTextBox.Size = new System.Drawing.Size(78, 27);
            this.GoalTextBox.TabIndex = 3;
            // 
            // StepsTextBox
            // 
            this.StepsTextBox.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StepsTextBox.Location = new System.Drawing.Point(232, 86);
            this.StepsTextBox.Name = "StepsTextBox";
            this.StepsTextBox.Size = new System.Drawing.Size(78, 27);
            this.StepsTextBox.TabIndex = 4;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.ForeColor = System.Drawing.Color.Red;
            this.ResultLabel.Location = new System.Drawing.Point(107, 133);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 19);
            this.ResultLabel.TabIndex = 5;
            // 
            // PedometerWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 166);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.StepsTextBox);
            this.Controls.Add(this.GoalTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalculateButton);
            this.Name = "PedometerWin";
            this.Text = "Pedometer Metrics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GoalTextBox;
        private System.Windows.Forms.TextBox StepsTextBox;
        private System.Windows.Forms.Label ResultLabel;
    }
}