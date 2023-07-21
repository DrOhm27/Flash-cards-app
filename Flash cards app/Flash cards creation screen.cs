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
    public partial class Flash_cards_creation_screen : Form
    {
        private Form1 mainForm;

        public Flash_cards_creation_screen(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
            MessageBox.Show("Please enter the questions and answers you like one flash card at a time in order from 1 and onward.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void Flash_cards_creation_screen_Load(object sender, EventArgs e)
        {
            switch (mainForm.combobox1_value)
            {
                case 0:
                    this.BackColor = Color.Blue;
                    break;

                case 1:
                    this.BackColor = Color.Red;
                    break;

                case 2:
                    this.BackColor = Color.Purple;
                    break;

                case 3:
                    this.BackColor = Color.Green;
                    break;

                case 4:
                    this.BackColor = Color.Pink;
                    break;

                case 5:
                    this.BackColor = Color.Yellow;
                    break;

                case 6:
                    this.BackColor = Color.Black;
                    break;

                case 7:
                    this.BackColor = Color.White;
                    break;

                case 8:
                    this.BackColor = Color.Brown;
                    break;

                case 9:
                    this.BackColor = Color.Orange;
                    break;

                case 10:
                    this.BackColor = Color.Gray;
                    break;

                case 11:
                    this.BackColor = Color.Gold;
                    break;

                case 12:
                    this.BackColor = Color.Silver;
                    break;

                case 13:
                    this.BackColor = Color.DarkGray;
                    break;
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (mainForm.combobox1_value == 0)
            {
                groupBox1.BackColor = Color.LightBlue;
                groupBox1.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 1)
            {
                groupBox1.BackColor = Color.IndianRed;
            }
            if (mainForm.combobox1_value == 2)
            {
                groupBox1.BackColor = Color.RebeccaPurple;
                groupBox1.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 3)
            {
                groupBox1.BackColor = Color.LightGreen;
            }
            if (mainForm.combobox1_value == 4)
            {
                groupBox1.BackColor = Color.DeepPink;
                groupBox1.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 5)
            {
                groupBox1.BackColor = Color.LightYellow;
            }
            if (mainForm.combobox1_value == 6)
            {
                groupBox1.BackColor = Color.Gray;
                groupBox1.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 7)
            {
                groupBox1.BackColor = Color.DarkGray;
            }
            if (mainForm.combobox1_value == 8)
            {
                groupBox1.BackColor = Color.SandyBrown;
            }
            if (mainForm.combobox1_value == 9)
            {
                groupBox1.BackColor = Color.OrangeRed;
            }
            if (mainForm.combobox1_value == 10)
            {
                groupBox1.BackColor = Color.LightGray;
            }
            if (mainForm.combobox1_value == 11)
            {
                groupBox1.BackColor = Color.LightGoldenrodYellow;
            }
            if (mainForm.combobox1_value == 12)
            {
                groupBox1.BackColor = Color.LightGray;
            }
            if (mainForm.combobox1_value == 13)
            {
                groupBox1.BackColor = Color.LightGray;
            }


            if (mainForm.combobox2_value == 0)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
                groupBox5.Enabled = false;
                groupBox6.Enabled = false;
                groupBox7.Enabled = false;
                groupBox8.Enabled = false;
                groupBox9.Enabled = false;
                groupBox10.Enabled = false;
                groupBox11.Enabled = false;
                groupBox12.Enabled = false;

                groupBox1.Visible = true;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox5.Visible = false;
                groupBox6.Visible = false;
                groupBox7.Visible = false;
                groupBox8.Visible = false;
                groupBox9.Visible = false;
                groupBox10.Visible = false;
                groupBox11.Visible = false;
                groupBox12.Visible = false;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            if (mainForm.combobox1_value == 0)
            {
                groupBox2.BackColor = Color.LightBlue;
                groupBox2.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 1)
            {
                groupBox2.BackColor = Color.IndianRed;
            }
            if (mainForm.combobox1_value == 2)
            {
                groupBox2.BackColor = Color.RebeccaPurple;
                groupBox2.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 3)
            {
                groupBox2.BackColor = Color.LightGreen;
            }
            if (mainForm.combobox1_value == 4)
            {
                groupBox2.BackColor = Color.DeepPink;
                groupBox2.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 5)
            {
                groupBox2.BackColor = Color.White;
            }
            if (mainForm.combobox1_value == 6)
            {
                groupBox2.BackColor = Color.Gray;
                groupBox2.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 7)
            {
                groupBox2.BackColor = Color.DarkGray;
            }
            if (mainForm.combobox1_value == 8)
            {
                groupBox2.BackColor = Color.SandyBrown;
            }
            if (mainForm.combobox1_value == 9)
            {
                groupBox2.BackColor = Color.OrangeRed;
            }
            if (mainForm.combobox1_value == 10)
            {
                groupBox2.BackColor = Color.LightGray;
            }
            if (mainForm.combobox1_value == 11)
            {
                groupBox2.BackColor = Color.LightGoldenrodYellow;
            }
            if (mainForm.combobox1_value == 12)
            {
                groupBox2.BackColor = Color.LightGray;
            }
            if (mainForm.combobox1_value == 13)
            {
                groupBox2.BackColor = Color.LightGray;
            }

            if (mainForm.combobox2_value < 2)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
                groupBox5.Enabled = false;
                groupBox6.Enabled = false;
                groupBox7.Enabled = false;
                groupBox8.Enabled = false;
                groupBox9.Enabled = false;
                groupBox10.Enabled = false;
                groupBox11.Enabled = false;
                groupBox12.Enabled = false;

                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox5.Visible = false;
                groupBox6.Visible = false;
                groupBox7.Visible = false;
                groupBox8.Visible = false;
                groupBox9.Visible = false;
                groupBox10.Visible = false;
                groupBox11.Visible = false;
                groupBox12.Visible = false;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            if (mainForm.combobox1_value == 0)
            {
                groupBox3.BackColor = Color.LightBlue;
                groupBox3.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 1)
            {
                groupBox3.BackColor = Color.IndianRed;
            }
            if (mainForm.combobox1_value == 2)
            {
                groupBox3.BackColor = Color.RebeccaPurple;
                groupBox2.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 3)
            {
                groupBox3.BackColor = Color.LightGreen;
            }
            if (mainForm.combobox1_value == 4)
            {
                groupBox3.BackColor = Color.DeepPink;
                groupBox3.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 5)
            {
                groupBox3.BackColor = Color.White;
            }
            if (mainForm.combobox1_value == 6)
            {
                groupBox3.BackColor = Color.Gray;
                groupBox3.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 7)
            {
                groupBox3.BackColor = Color.DarkGray;
            }
            if (mainForm.combobox1_value == 8)
            {
                groupBox3.BackColor = Color.SandyBrown;
            }
            if (mainForm.combobox1_value == 9)
            {
                groupBox3.BackColor = Color.OrangeRed;
            }
            if (mainForm.combobox1_value == 10)
            {
                groupBox3.BackColor = Color.LightGray;
            }
            if (mainForm.combobox1_value == 11)
            {
                groupBox3.BackColor = Color.LightGoldenrodYellow;
            }
            if (mainForm.combobox1_value == 12)
            {
                groupBox3.BackColor = Color.LightGray;
            }
            if (mainForm.combobox1_value == 13)
            {
                groupBox3.BackColor = Color.LightGray;
            }

            if (mainForm.combobox2_value < 3)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                groupBox4.Enabled = false;
                groupBox5.Enabled = false;
                groupBox6.Enabled = false;
                groupBox7.Enabled = false;
                groupBox8.Enabled = false;
                groupBox9.Enabled = false;
                groupBox10.Enabled = false;
                groupBox11.Enabled = false;
                groupBox12.Enabled = false;

                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = false;
                groupBox5.Visible = false;
                groupBox6.Visible = false;
                groupBox7.Visible = false;
                groupBox8.Visible = false;
                groupBox9.Visible = false;
                groupBox10.Visible = false;
                groupBox11.Visible = false;
                groupBox12.Visible = false;
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

            if (mainForm.combobox1_value == 0)
            {
                groupBox4.BackColor = Color.LightBlue;
                groupBox4.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 1)
            {
                groupBox4.BackColor = Color.IndianRed;
            }
            if (mainForm.combobox1_value == 2)
            {
                groupBox4.BackColor = Color.RebeccaPurple;
                groupBox4.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 3)
            {
                groupBox4.BackColor = Color.LightGreen;
            }
            if (mainForm.combobox1_value == 4)
            {
                groupBox4.BackColor = Color.DeepPink;
                groupBox4.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 5)
            {
                groupBox4.BackColor = Color.White;
            }
            if (mainForm.combobox1_value == 6)
            {
                groupBox4.BackColor = Color.Gray;
                groupBox4.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 7)
            {
                groupBox4.BackColor = Color.DarkGray;
            }
            if (mainForm.combobox1_value == 8)
            {
                groupBox4.BackColor = Color.SandyBrown;
            }
            if (mainForm.combobox1_value == 9)
            {
                groupBox4.BackColor = Color.OrangeRed;
            }
            if (mainForm.combobox1_value == 10)
            {
                groupBox4.BackColor = Color.LightGray;
            }
            if (mainForm.combobox1_value == 11)
            {
                groupBox4.BackColor = Color.LightGoldenrodYellow;
            }
            if (mainForm.combobox1_value == 12)
            {
                groupBox4.BackColor = Color.LightGray;
            }
            if (mainForm.combobox1_value == 13)
            {
                groupBox4.BackColor = Color.LightGray;
            }
            if (mainForm.combobox2_value < 4)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
                groupBox5.Enabled = false;
                groupBox6.Enabled = false;
                groupBox7.Enabled = false;
                groupBox8.Enabled = false;
                groupBox9.Enabled = false;
                groupBox10.Enabled = false;
                groupBox11.Enabled = false;
                groupBox12.Enabled = false;

                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = false;
                groupBox6.Visible = false;
                groupBox7.Visible = false;
                groupBox8.Visible = false;
                groupBox9.Visible = false;
                groupBox10.Visible = false;
                groupBox11.Visible = false;
                groupBox12.Visible = false;
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {
            if (mainForm.combobox1_value == 0)
            {
                groupBox5.BackColor = Color.LightBlue;
                groupBox5.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 1)
            {
                groupBox5.BackColor = Color.IndianRed;
            }
            if (mainForm.combobox1_value == 2)
            {
                groupBox5.BackColor = Color.RebeccaPurple;
                groupBox5.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 3)
            {
                groupBox5.BackColor = Color.LightGreen;
            }
            if (mainForm.combobox1_value == 4)
            {
                groupBox5.BackColor = Color.DeepPink;
                groupBox5.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 5)
            {
                groupBox5.BackColor = Color.White;
            }
            if (mainForm.combobox1_value == 6)
            {
                groupBox5.BackColor = Color.Gray;
                groupBox5.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 7)
            {
                groupBox5.BackColor = Color.DarkGray;
            }
            if (mainForm.combobox1_value == 8)
            {
                groupBox5.BackColor = Color.SandyBrown;
            }
            if (mainForm.combobox1_value == 9)
            {
                groupBox5.BackColor = Color.OrangeRed;
            }
            if (mainForm.combobox1_value == 10)
            {
                groupBox5.BackColor = Color.LightGray;
            }
            if (mainForm.combobox1_value == 11)
            {
                groupBox5.BackColor = Color.LightGoldenrodYellow;
            }
            if (mainForm.combobox1_value == 12)
            {
                groupBox5.BackColor = Color.LightGray;
            }
            if (mainForm.combobox1_value == 13)
            {
                groupBox5.BackColor = Color.LightGray;
            }

            if (mainForm.combobox2_value < 5)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
                groupBox5.Enabled = true;
                groupBox6.Enabled = false;
                groupBox7.Enabled = false;
                groupBox8.Enabled = false;
                groupBox9.Enabled = false;
                groupBox10.Enabled = false;
                groupBox11.Enabled = false;
                groupBox12.Enabled = false;

                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                groupBox6.Visible = false;
                groupBox7.Visible = false;
                groupBox8.Visible = false;
                groupBox9.Visible = false;
                groupBox10.Visible = false;
                groupBox11.Visible = false;
                groupBox12.Visible = false;
            }
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

            if (mainForm.combobox1_value == 0)
            {
                groupBox6.BackColor = Color.LightBlue;
                groupBox6.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 1)
            {
                groupBox6.BackColor = Color.IndianRed;
            }
            if (mainForm.combobox1_value == 2)
            {
                groupBox6.BackColor = Color.RebeccaPurple;
                groupBox6.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 3)
            {
                groupBox6.BackColor = Color.LightGreen;
            }
            if (mainForm.combobox1_value == 4)
            {
                groupBox6.BackColor = Color.DeepPink;
                groupBox6.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 5)
            {
                groupBox6.BackColor = Color.White;
            }
            if (mainForm.combobox1_value == 6)
            {
                groupBox6.BackColor = Color.Gray;
                groupBox6.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 7)
            {
                groupBox6.BackColor = Color.DarkGray;
            }
            if (mainForm.combobox1_value == 8)
            {
                groupBox6.BackColor = Color.SandyBrown;
            }
            if (mainForm.combobox1_value == 9)
            {
                groupBox6.BackColor = Color.OrangeRed;
            }
            if (mainForm.combobox1_value == 10)
            {
                groupBox6.BackColor = Color.LightGray;
            }
            if (mainForm.combobox1_value == 11)
            {
                groupBox6.BackColor = Color.LightGoldenrodYellow;
            }
            if (mainForm.combobox1_value == 12)
            {
                groupBox6.BackColor = Color.LightGray;
            }
            if (mainForm.combobox1_value == 13)
            {
                groupBox6.BackColor = Color.LightGray;
            }
            if (mainForm.combobox2_value < 6)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
                groupBox5.Enabled = true;
                groupBox6.Enabled = true;
                groupBox7.Enabled = false;
                groupBox8.Enabled = false;
                groupBox9.Enabled = false;
                groupBox10.Enabled = false;
                groupBox11.Enabled = false;
                groupBox12.Enabled = false;

                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                groupBox6.Visible = true;
                groupBox7.Visible = false;
                groupBox8.Visible = false;
                groupBox9.Visible = false;
                groupBox10.Visible = false;
                groupBox11.Visible = false;
                groupBox12.Visible = false;
            }
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {
            if (mainForm.combobox1_value == 0)
            {
                groupBox7.BackColor = Color.LightBlue;
                groupBox7.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 1)
            {
                groupBox7.BackColor = Color.IndianRed;
            }
            if (mainForm.combobox1_value == 2)
            {
                groupBox7.BackColor = Color.RebeccaPurple;
                groupBox7.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 3)
            {
                groupBox7.BackColor = Color.LightGreen;
            }
            if (mainForm.combobox1_value == 4)
            {
                groupBox7.BackColor = Color.DeepPink;
                groupBox7.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 5)
            {
                groupBox7.BackColor = Color.White;
            }
            if (mainForm.combobox1_value == 6)
            {
                groupBox7.BackColor = Color.Gray;
                groupBox7.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 7)
            {
                groupBox7.BackColor = Color.DarkGray;
            }
            if (mainForm.combobox1_value == 8)
            {
                groupBox7.BackColor = Color.SandyBrown;
            }
            if (mainForm.combobox1_value == 9)
            {
                groupBox7.BackColor = Color.OrangeRed;
            }
            if (mainForm.combobox1_value == 10)
            {
                groupBox7.BackColor = Color.LightGray;
            }
            if (mainForm.combobox1_value == 11)
            {
                groupBox7.BackColor = Color.LightGoldenrodYellow;
            }
            if (mainForm.combobox1_value == 12)
            {
                groupBox7.BackColor = Color.LightGray;
            }
            if (mainForm.combobox1_value == 13)
            {
                groupBox7.BackColor = Color.LightGray;
            }

            if (mainForm.combobox2_value < 7)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
                groupBox5.Enabled = true;
                groupBox6.Enabled = true;
                groupBox7.Enabled = true;
                groupBox8.Enabled = false;
                groupBox9.Enabled = false;
                groupBox10.Enabled = false;
                groupBox11.Enabled = false;
                groupBox12.Enabled = false;

                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                groupBox6.Visible = true;
                groupBox7.Visible = true;
                groupBox8.Visible = false;
                groupBox9.Visible = false;
                groupBox10.Visible = false;
                groupBox11.Visible = false;
                groupBox12.Visible = false;
            }
        }
        private void groupBox8_Enter(object sender, EventArgs e)
        {
            if (mainForm.combobox1_value == 0)
            {
                groupBox8.BackColor = Color.LightBlue;
                groupBox8.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 1)
            {
                groupBox8.BackColor = Color.IndianRed;
            }
            if (mainForm.combobox1_value == 2)
            {
                groupBox8.BackColor = Color.RebeccaPurple;
                groupBox8.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 3)
            {
                groupBox8.BackColor = Color.LightGreen;
            }
            if (mainForm.combobox1_value == 4)
            {
                groupBox8.BackColor = Color.DeepPink;
                groupBox8.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 5)
            {
                groupBox8.BackColor = Color.White;
            }
            if (mainForm.combobox1_value == 6)
            {
                groupBox8.BackColor = Color.Gray;
                groupBox8.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 7)
            {
                groupBox8.BackColor = Color.DarkGray;
            }
            if (mainForm.combobox1_value == 8)
            {
                groupBox8.BackColor = Color.SandyBrown;
            }
            if (mainForm.combobox1_value == 9)
            {
                groupBox8.BackColor = Color.OrangeRed;
            }
            if (mainForm.combobox1_value == 10)
            {
                groupBox8.BackColor = Color.LightGray;
            }
            if (mainForm.combobox1_value == 11)
            {
                groupBox8.BackColor = Color.LightGoldenrodYellow;
            }
            if (mainForm.combobox1_value == 12)
            {
                groupBox8.BackColor = Color.LightGray;
            }
            if (mainForm.combobox1_value == 13)
            {
                groupBox8.BackColor = Color.LightGray;
            }

            if (mainForm.combobox2_value < 8)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
                groupBox5.Enabled = true;
                groupBox6.Enabled = true;
                groupBox7.Enabled = true;
                groupBox8.Enabled = true;
                groupBox9.Enabled = false;
                groupBox10.Enabled = false;
                groupBox11.Enabled = false;
                groupBox12.Enabled = false;

                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                groupBox6.Visible = true;
                groupBox7.Visible = true;
                groupBox8.Visible = true;
                groupBox9.Visible = false;
                groupBox10.Visible = false;
                groupBox11.Visible = false;
                groupBox12.Visible = false;
            }
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {
            if (mainForm.combobox1_value == 0)
            {
                groupBox9.BackColor = Color.LightBlue;
                groupBox9.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 1)
            {
                groupBox9.BackColor = Color.IndianRed;
            }
            if (mainForm.combobox1_value == 2)
            {
                groupBox9.BackColor = Color.RebeccaPurple;
                groupBox9.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 3)
            {
                groupBox9.BackColor = Color.LightGreen;
            }
            if (mainForm.combobox1_value == 4)
            {
                groupBox9.BackColor = Color.DeepPink;
                groupBox9.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 5)
            {
                groupBox9.BackColor = Color.White;
            }
            if (mainForm.combobox1_value == 6)
            {
                groupBox9.BackColor = Color.Gray;
                groupBox9.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 7)
            {
                groupBox9.BackColor = Color.DarkGray;
            }
            if (mainForm.combobox1_value == 8)
            {
                groupBox9.BackColor = Color.SandyBrown;
            }
            if (mainForm.combobox1_value == 9)
            {
                groupBox9.BackColor = Color.OrangeRed;
            }
            if (mainForm.combobox1_value == 10)
            {
                groupBox9.BackColor = Color.LightGray;
            }
            if (mainForm.combobox1_value == 11)
            {
                groupBox9.BackColor = Color.LightGoldenrodYellow;
            }
            if (mainForm.combobox1_value == 12)
            {
                groupBox9.BackColor = Color.LightGray;
            }
            if (mainForm.combobox1_value == 13)
            {
                groupBox9.BackColor = Color.LightGray;
            }

            if (mainForm.combobox2_value < 9)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
                groupBox5.Enabled = true;
                groupBox6.Enabled = true;
                groupBox7.Enabled = true;
                groupBox8.Enabled = true;
                groupBox9.Enabled = true;
                groupBox10.Enabled = false;
                groupBox11.Enabled = false;
                groupBox12.Enabled = false;

                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                groupBox6.Visible = true;
                groupBox7.Visible = true;
                groupBox8.Visible = true;
                groupBox9.Visible = true;
                groupBox10.Visible = false;
                groupBox11.Visible = false;
                groupBox12.Visible = false;
            }
        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {
            if (mainForm.combobox1_value == 0)
            {
                groupBox10.BackColor = Color.LightBlue;
                groupBox10.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 1)
            {
                groupBox10.BackColor = Color.IndianRed;
            }
            if (mainForm.combobox1_value == 2)
            {
                groupBox10.BackColor = Color.RebeccaPurple;
                groupBox10.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 3)
            {
                groupBox10.BackColor = Color.LightGreen;
            }
            if (mainForm.combobox1_value == 4)
            {
                groupBox10.BackColor = Color.DeepPink;
                groupBox10.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 5)
            {
                groupBox10.BackColor = Color.White;
            }
            if (mainForm.combobox1_value == 6)
            {
                groupBox10.BackColor = Color.Gray;
                groupBox10.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 7)
            {
                groupBox10.BackColor = Color.DarkGray;
            }
            if (mainForm.combobox1_value == 8)
            {
                groupBox10.BackColor = Color.SandyBrown;
            }
            if (mainForm.combobox1_value == 9)
            {
                groupBox10.BackColor = Color.OrangeRed;
            }
            if (mainForm.combobox1_value == 10)
            {
                groupBox10.BackColor = Color.LightGray;
            }
            if (mainForm.combobox1_value == 11)
            {
                groupBox10.BackColor = Color.LightGoldenrodYellow;
            }
            if (mainForm.combobox1_value == 12)
            {
                groupBox10.BackColor = Color.LightGray;
            }
            if (mainForm.combobox1_value == 13)
            {
                groupBox10.BackColor = Color.LightGray;
            }

            if (mainForm.combobox2_value < 10)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
                groupBox5.Enabled = true;
                groupBox6.Enabled = true;
                groupBox7.Enabled = true;
                groupBox8.Enabled = true;
                groupBox9.Enabled = true;
                groupBox10.Enabled = false;
                groupBox11.Enabled = false;
                groupBox12.Enabled = false;

                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                groupBox6.Visible = true;
                groupBox7.Visible = true;
                groupBox8.Visible = true;
                groupBox9.Visible = true;
                groupBox10.Visible = true;
                groupBox11.Visible = false;
                groupBox12.Visible = false;
            }
        }

        private void groupBox11_Enter(object sender, EventArgs e)
        {
            if (mainForm.combobox1_value == 0)
            {
                groupBox11.BackColor = Color.LightBlue;
                groupBox11.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 1)
            {
                groupBox11.BackColor = Color.IndianRed;
            }
            if (mainForm.combobox1_value == 2)
            {
                groupBox11.BackColor = Color.RebeccaPurple;
                groupBox11.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 3)
            {
                groupBox11.BackColor = Color.LightGreen;
            }
            if (mainForm.combobox1_value == 4)
            {
                groupBox11.BackColor = Color.DeepPink;
                groupBox11.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 5)
            {
                groupBox11.BackColor = Color.White;
            }
            if (mainForm.combobox1_value == 6)
            {
                groupBox11.BackColor = Color.Gray;
                groupBox11.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 7)
            {
                groupBox11.BackColor = Color.DarkGray;
            }
            if (mainForm.combobox1_value == 8)
            {
                groupBox11.BackColor = Color.SandyBrown;
            }
            if (mainForm.combobox1_value == 9)
            {
                groupBox11.BackColor = Color.OrangeRed;
            }
            if (mainForm.combobox1_value == 10)
            {
                groupBox11.BackColor = Color.LightGray;
            }
            if (mainForm.combobox1_value == 11)
            {
                groupBox11.BackColor = Color.LightGoldenrodYellow;
            }
            if (mainForm.combobox1_value == 12)
            {
                groupBox11.BackColor = Color.LightGray;
            }
            if (mainForm.combobox1_value == 13)
            {
                groupBox11.BackColor = Color.LightGray;
            }

            if (mainForm.combobox2_value < 11)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
                groupBox5.Enabled = true;
                groupBox6.Enabled = true;
                groupBox7.Enabled = true;
                groupBox8.Enabled = true;
                groupBox9.Enabled = true;
                groupBox10.Enabled = true;
                groupBox11.Enabled = false;
                groupBox12.Enabled = false;

                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                groupBox6.Visible = true;
                groupBox7.Visible = true;
                groupBox8.Visible = true;
                groupBox9.Visible = true;
                groupBox10.Visible = true;
                groupBox11.Visible = true;
                groupBox12.Visible = false;
            }
        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {
            if (mainForm.combobox1_value == 0)
            {
                groupBox12.BackColor = Color.LightBlue;
                groupBox12.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 1)
            {
                groupBox12.BackColor = Color.IndianRed;
            }
            if (mainForm.combobox1_value == 2)
            {
                groupBox12.BackColor = Color.RebeccaPurple;
                groupBox12.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 3)
            {
                groupBox12.BackColor = Color.LightGreen;
            }
            if (mainForm.combobox1_value == 4)
            {
                groupBox12.BackColor = Color.DeepPink;
                groupBox12.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 5)
            {
                groupBox12.BackColor = Color.White;
            }
            if (mainForm.combobox1_value == 6)
            {
                groupBox12.BackColor = Color.Gray;
                groupBox12.ForeColor = Color.White;
            }
            if (mainForm.combobox1_value == 7)
            {
                groupBox12.BackColor = Color.DarkGray;
            }
            if (mainForm.combobox1_value == 8)
            {
                groupBox12.BackColor = Color.SandyBrown;
            }
            if (mainForm.combobox1_value == 9)
            {
                groupBox12.BackColor = Color.OrangeRed;
            }
            if (mainForm.combobox1_value == 10)
            {
                groupBox12.BackColor = Color.LightGray;
            }
            if (mainForm.combobox1_value == 11)
            {
                groupBox12.BackColor = Color.LightGoldenrodYellow;
            }
            if (mainForm.combobox1_value == 12)
            {
                groupBox12.BackColor = Color.LightGray;
            }
            if (mainForm.combobox1_value == 13)
            {
                groupBox12.BackColor = Color.LightGray;
            }

            if (mainForm.combobox2_value < 12)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
                groupBox5.Enabled = true;
                groupBox6.Enabled = true;
                groupBox7.Enabled = true;
                groupBox8.Enabled = true;
                groupBox9.Enabled = true;
                groupBox10.Enabled = true;
                groupBox11.Enabled = true;
                groupBox12.Enabled = true;

                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                groupBox6.Visible = true;
                groupBox7.Visible = true;
                groupBox8.Visible = true;
                groupBox9.Visible = true;
                groupBox10.Visible = true;
                groupBox11.Visible = true;
                groupBox12.Visible = true;
            }
        }



        //LABELS AND QUESTIONS


        //MEMORY

        public string question1;
        public string answer1;

        public string question2;
        public string answer2;

        public string question3;
        public string answer3;

        public string question4;
        public string answer4;

        public string question5;
        public string answer5;

        public string question6;
        public string answer6;

        public string question7;
        public string answer7;

        public string question8;
        public string answer8;

        public string question9;
        public string answer9;

        public string question10;
        public string answer10;

        public string question11;
        public string answer11;

        public string question12;
        public string answer12;





        //flash card 1
        //1
        //------------------------------------------------------------------

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            question1 = textBox1.Text;
        }

        //2
        //------------------------------------------------------------------

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            answer1 = textBox2.Text;
        }







        //flash card 2
        //3
        //------------------------------------------------------------------


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            question2 = textBox3.Text;
        }

        //4
        //------------------------------------------------------------------

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            answer2 = textBox4.Text;
        }








        //flash card 3
        //5
        //------------------------------------------------------------------

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            question3 = textBox5.Text;
        }

        //6
        //------------------------------------------------------------------

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            answer3 = textBox6.Text;
        }










        //flash card 4
        //7
        //------------------------------------------------------------------

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            question4 = textBox7.Text;
        }

        //8
        //------------------------------------------------------------------

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            answer4 = textBox8.Text;
        }










        //flash card 5
        //9
        //------------------------------------------------------------------

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            question5 = textBox9.Text;
        }

        //10
        //------------------------------------------------------------------
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            answer5 = textBox2.Text;
        }










        //flash card 6
        //11
        //------------------------------------------------------------------

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            question6 = textBox11.Text;
        }


        //12
        //------------------------------------------------------------------

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            answer6 = textBox12.Text;
        }








        //flash card 7
        //13
        //------------------------------------------------------------------

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            question7 = textBox13.Text;
        }

        //14
        //------------------------------------------------------------------

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            answer7 = textBox14.Text;
        }









        //flash card 8
        //15
        //------------------------------------------------------------------

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            question8 = textBox15.Text;
        }

        //16
        //------------------------------------------------------------------

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            answer8 = textBox16.Text;
        }










        //flash card 9
        //17
        //------------------------------------------------------------------

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            question9 = textBox17.Text;
        }

        //18
        //------------------------------------------------------------------

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            answer9 = textBox18.Text;
        }










        //flash card 10
        //19
        //------------------------------------------------------------------

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            question10 = textBox19.Text;
        }

        //20
        //------------------------------------------------------------------

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            answer10 = textBox20.Text;
        }











        //flash card 11
        //21
        //------------------------------------------------------------------

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            question11 = textBox21.Text;
        }

        //22
        //------------------------------------------------------------------

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            answer11 = textBox22.Text;
        }









        //flash card 12
        //23
        //------------------------------------------------------------------

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            question12 = textBox23.Text;
        }

        //24
        //------------------------------------------------------------------

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            answer12 = textBox24.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Quiz third_form = new Quiz(this, mainForm);
            third_form.Show();
        }
    }
}
