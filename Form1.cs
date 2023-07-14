namespace Flash_cards_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //variables
        public int combobox1_value;
        public int combobox2_value;
        public bool radiobutton1_value = false;
        public bool radiobutton2_value = false;

        private void button1_Click(object sender, EventArgs e)
        {
            //these variables check for the allowance to run the flash cards creation screen
            bool check1 = false;
            bool check2 = false;
            bool check3 = false;
            
            //this if checks if there is anything selected in combo box 2
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the amount of your flash cards.");
            }
            
            //this says that there is something selected in combo box 2
            else { check1 = true; }

            //this checks if there is anything selected in combo box 1
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the color of your flash cards to proceed.");
            }

            //this says that there is something eslected in combo box 1
            else { check2 = true; }

            //this checks if any of the radio buttons are selected
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Please select one of the two options.");

            }

            //this says that at least one radio button is selected
            else { check3 = true; }

            //this says that all the requirements are met to run the flash cards creation screen and runs it
            if (check1 == true && check2 == true && check3 == true)
            {
                Flash_cards_creation_screen second_form = new Flash_cards_creation_screen(this);
                second_form.Show();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            combobox2_value = comboBox2.SelectedIndex;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this stores the value of the combo box into combobox1_value
            combobox1_value = comboBox1.SelectedIndex;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //this checks if the radio button 1 is checked or not
            if (radioButton1.Checked)
            {
                radiobutton1_value = true;
                radiobutton2_value = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //this checks if the radio button 2 is checked or not
            if (radioButton2.Checked)
            {
                radiobutton2_value = true;
                radiobutton1_value = false;
            }
        }
    }
}