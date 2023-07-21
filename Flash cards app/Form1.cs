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

        private void button1_Click(object sender, EventArgs e)
        {
            //these variables check for the allowance to run the flash cards creation screen
            bool check1 = false;
            bool check2 = false;

            //this if checks if there is anything selected in combo box 2
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the amount of your flash cards.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //this says that there is something selected in combo box 2
            else { check1 = true; }

            //this checks if there is anything selected in combo box 1
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the color of your flash cards to proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //this says that there is something eslected in combo box 1
            else { check2 = true; }

            //this says that all the requirements are met to run the flash cards creation screen and runs it
            if (check1 == true && check2 == true)
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

    }
}