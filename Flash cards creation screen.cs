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
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
