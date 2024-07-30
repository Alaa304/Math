using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int answer;
        int totalQuestion = 0;
        int totalCorrect = 0;

        public Form1()
        {
            InitializeComponent();
            GenerateQuestion();
        }

        private void GenerateQuestion()
        {
            textBoxUserAnswer.Clear();
            int a = random.Next(11);
            int b = random.Next(11);
            int mathOperator = random.Next(4);

            switch (mathOperator)
            {
                case 0:
                    answer = a + b;
                    labelMathQuestion.Text = a.ToString() + " + " + b.ToString() + " = ?";
                    break;
                case 1:
                    answer = a - b;
                    labelMathQuestion.Text = a.ToString() + " - " + b.ToString() + " = ?";
                    break;
                case 2:
                    answer = a * b;
                    labelMathQuestion.Text = a.ToString() + " * " + b.ToString() + " = ?";
                    break;
                case 3:
                    if (b == 0)
                        b = random.Next(1, 11);
                    answer = a / b;
                    labelMathQuestion.Text = a.ToString() + " / " + b.ToString() + " = ?";
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void buttonCheckAnswer_Click(object sender, EventArgs e)
        {
            totalQuestion += 1;
            int userAnswer;
            if (int.TryParse(textBoxUserAnswer.Text, out userAnswer) && userAnswer == answer)
            {
                labelGradedAnswer.Text = "Correct";
                totalCorrect++;
            }
            else
            {
                labelGradedAnswer.Text = "Wrong";
            }
            GenerateQuestion();
            labelStatistics.Text = totalCorrect.ToString() + " Correct from " + totalQuestion.ToString() + " total asked";
        }

        private void textBoxUserAnswer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonCheckAnswer_Click(sender, e);
        }

        private void labelStatistics_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void labelMathQuestion_Click(object sender, EventArgs e)
        {
        }

        private void labelGradedAnswer_Click(object sender, EventArgs e)
        {
        }
    }
}