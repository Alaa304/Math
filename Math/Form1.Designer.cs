namespace Math
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
            this.labelMathQuestion = new System.Windows.Forms.Label();
            this.textBoxUserAnswer = new System.Windows.Forms.TextBox();
            this.buttonCheckAnswer = new System.Windows.Forms.Button();
            this.labelGradedAnswer = new System.Windows.Forms.Label();
            this.labelStatistics = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMathQuestion
            // 
            this.labelMathQuestion.AutoSize = true;
            this.labelMathQuestion.Location = new System.Drawing.Point(257, 30);
            this.labelMathQuestion.Name = "labelMathQuestion";
            this.labelMathQuestion.Size = new System.Drawing.Size(35, 13);
            this.labelMathQuestion.TabIndex = 0;
            this.labelMathQuestion.Text = "label1";
            // 
            // textBoxUserAnswer
            // 
            this.textBoxUserAnswer.Location = new System.Drawing.Point(217, 61);
            this.textBoxUserAnswer.Name = "textBoxUserAnswer";
            this.textBoxUserAnswer.Size = new System.Drawing.Size(121, 20);
            this.textBoxUserAnswer.TabIndex = 1;
            this.textBoxUserAnswer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxUserAnswer_KeyUp);
            // 
            // buttonCheckAnswer
            // 
            this.buttonCheckAnswer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCheckAnswer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCheckAnswer.Location = new System.Drawing.Point(239, 106);
            this.buttonCheckAnswer.Name = "buttonCheckAnswer";
            this.buttonCheckAnswer.Size = new System.Drawing.Size(75, 23);
            this.buttonCheckAnswer.TabIndex = 2;
            this.buttonCheckAnswer.Text = "Check Answer";
            this.buttonCheckAnswer.UseVisualStyleBackColor = false;
            this.buttonCheckAnswer.Click += new System.EventHandler(this.buttonCheckAnswer_Click);
            // 
            // labelGradedAnswer
            // 
            this.labelGradedAnswer.AutoSize = true;
            this.labelGradedAnswer.Location = new System.Drawing.Point(257, 152);
            this.labelGradedAnswer.Name = "labelGradedAnswer";
            this.labelGradedAnswer.Size = new System.Drawing.Size(35, 13);
            this.labelGradedAnswer.TabIndex = 3;
            this.labelGradedAnswer.Text = "label2";
            // 
            // labelStatistics
            // 
            this.labelStatistics.AutoSize = true;
            this.labelStatistics.Location = new System.Drawing.Point(257, 196);
            this.labelStatistics.Name = "labelStatistics";
            this.labelStatistics.Size = new System.Drawing.Size(35, 13);
            this.labelStatistics.TabIndex = 4;
            this.labelStatistics.Text = "label3";
            this.labelStatistics.Click += new System.EventHandler(this.labelStatistics_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(521, 271);
            this.Controls.Add(this.labelStatistics);
            this.Controls.Add(this.labelGradedAnswer);
            this.Controls.Add(this.buttonCheckAnswer);
            this.Controls.Add(this.textBoxUserAnswer);
            this.Controls.Add(this.labelMathQuestion);
            this.Name = "Form1";
            this.Text = "Math Quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMathQuestion;
        private System.Windows.Forms.TextBox textBoxUserAnswer;
        private System.Windows.Forms.Button buttonCheckAnswer;
        private System.Windows.Forms.Label labelGradedAnswer;
        private System.Windows.Forms.Label labelStatistics;
    }
}