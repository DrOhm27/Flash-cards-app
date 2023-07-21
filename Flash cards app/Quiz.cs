using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flash_cards_app
{
    public partial class Quiz : Form
    {
        private Flash_cards_creation_screen secondaryForm;
        private Form1 mainForm;

        public Quiz(Flash_cards_creation_screen form2, Form1 form1)
        {
            InitializeComponent();
            secondaryForm = form2;
            mainForm = form1;
            label1.Text = "Question: " + i.ToString();
            label2.Text = secondaryForm.question1;
        }

        string user_answer = string.Empty;
        int i = 1;


        private void Quiz_Load(object sender, EventArgs e)
        {
            if (mainForm.combobox1_value == 0) { this.BackColor = Color.Blue; this.ForeColor = Color.White; button1.BackColor = Color.LightBlue; }
            if (mainForm.combobox1_value == 1) { this.BackColor = Color.Red; button1.BackColor = Color.IndianRed; }
            if (mainForm.combobox1_value == 2) { this.BackColor = Color.Purple; this.ForeColor = Color.White; button1.BackColor = Color.RebeccaPurple; }
            if (mainForm.combobox1_value == 3) { this.BackColor = Color.Green; button1.BackColor = Color.LightGreen; }
            if (mainForm.combobox1_value == 4) { this.BackColor = Color.Pink; this.ForeColor = Color.White; button1.BackColor = Color.DeepPink; }
            if (mainForm.combobox1_value == 5) { this.BackColor = Color.Yellow; button1.BackColor = Color.LightYellow; }
            if (mainForm.combobox1_value == 6) { this.BackColor = Color.Black; this.ForeColor = Color.White; button1.BackColor = Color.Gray; }
            if (mainForm.combobox1_value == 7) { this.BackColor = Color.White; button1.BackColor = Color.DarkGray; }
            if (mainForm.combobox1_value == 8) { this.BackColor = Color.Brown; button1.BackColor = Color.SandyBrown; }
            if (mainForm.combobox1_value == 9) { this.BackColor = Color.Orange; button1.BackColor = Color.OrangeRed; }
            if (mainForm.combobox1_value == 10) { this.BackColor = Color.Gray; button1.BackColor = Color.LightGray; }
            if (mainForm.combobox1_value == 11) { this.BackColor = Color.Gold; button1.BackColor = Color.LightGoldenrodYellow; }
            if (mainForm.combobox1_value == 12) { this.BackColor = Color.Silver; button1.BackColor = Color.LightGray; }
            if (mainForm.combobox1_value == 13) { this.BackColor = Color.DarkGray; button1.BackColor = Color.LightGray; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (i == 1)
            {
                if (user_answer == secondaryForm.answer1)
                {
                    MessageBox.Show("Correct!");
                }


                if (user_answer != secondaryForm.answer1)
                {
                    MessageBox.Show("Incorrect!");
                }
            }



            if (i == 2)
            {
                if (user_answer == secondaryForm.answer2)
                {
                    MessageBox.Show("Correct!");
                }


                if (user_answer != secondaryForm.answer2)
                {
                    MessageBox.Show("Incorrect!");
                }
            }


            if (i == 3)
            {
                if (user_answer == secondaryForm.answer3)
                {
                    MessageBox.Show("Correct!");
                }


                if (user_answer != secondaryForm.answer3)
                {
                    MessageBox.Show("Incorrect!");
                }
            }


            if (i == 4)
            {
                if (user_answer == secondaryForm.answer4)
                {
                    MessageBox.Show("Correct!");
                }


                if (user_answer != secondaryForm.answer4)
                {
                    MessageBox.Show("Incorrect!");
                }
            }


            if (i == 5)
            {
                if (user_answer == secondaryForm.answer5)
                {
                    MessageBox.Show("Correct!");
                }


                if (user_answer != secondaryForm.answer5)
                {
                    MessageBox.Show("Incorrect!");
                }
            }


            if (i == 6)
            {
                if (user_answer == secondaryForm.answer6)
                {
                    MessageBox.Show("Correct!");
                }


                if (user_answer != secondaryForm.answer6)
                {
                    MessageBox.Show("Incorrect!");
                }
            }


            if (i == 7)
            {
                if (user_answer == secondaryForm.answer7)
                {
                    MessageBox.Show("Correct!");
                }


                if (user_answer != secondaryForm.answer7)
                {
                    MessageBox.Show("Incorrect!");
                }
            }


            if (i == 8)
            {
                if (user_answer == secondaryForm.answer8)
                {
                    MessageBox.Show("Correct!");
                }


                if (user_answer != secondaryForm.answer8)
                {
                    MessageBox.Show("Incorrect!");
                }
            }


            if (i == 9)
            {
                if (user_answer == secondaryForm.answer9)
                {
                    MessageBox.Show("Correct!");
                }


                if (user_answer != secondaryForm.answer9)
                {
                    MessageBox.Show("Incorrect!");
                }
            }


            if (i == 10)
            {
                if (user_answer == secondaryForm.answer10)
                {
                    MessageBox.Show("Correct!");
                }


                if (user_answer != secondaryForm.answer10)
                {
                    MessageBox.Show("Incorrect!");
                }
            }


            if (i == 11)
            {
                if (user_answer == secondaryForm.answer11)
                {
                    MessageBox.Show("Correct!");
                }


                if (user_answer != secondaryForm.answer11)
                {
                    MessageBox.Show("Incorrect!");
                }
            }


            if (i == 12)
            {
                if (user_answer == secondaryForm.answer12)
                {
                    MessageBox.Show("Correct!");
                }


                if (user_answer != secondaryForm.answer12)
                {
                    MessageBox.Show("Incorrect!");
                }
            }

            i = i + 1;

            if (i == mainForm.combobox2_value + 2)
            {
                MessageBox.Show("Quiz is finished! Thanks for playing!");
                this.Close();
            }

            label1.Text = "Question: " + i.ToString();

            if (i == 1) { label2.Text = secondaryForm.question1; }
            if (i == 2) { label2.Text = secondaryForm.question2; }
            if (i == 3) { label2.Text = secondaryForm.question3; }
            if (i == 4) { label2.Text = secondaryForm.question4; }
            if (i == 5) { label2.Text = secondaryForm.question5; }
            if (i == 6) { label2.Text = secondaryForm.question6; }
            if (i == 7) { label2.Text = secondaryForm.question7; }
            if (i == 8) { label2.Text = secondaryForm.question8; }
            if (i == 9) { label2.Text = secondaryForm.question9; }
            if (i == 10) { label2.Text = secondaryForm.question10; }
            if (i == 11) { label2.Text = secondaryForm.question11; }
            if (i == 12) { label2.Text = secondaryForm.question12; }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            user_answer = textBox1.Text;
        }
    }
}
