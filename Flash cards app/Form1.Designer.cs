namespace Flash_cards_app
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.PaleGreen;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(640, 52);
            label1.TabIndex = 0;
            label1.Text = "Welcome to flash cards!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(381, 31);
            label2.TabIndex = 1;
            label2.Text = "Pick the number of your flash cards:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 153);
            label3.Name = "label3";
            label3.Size = new Size(359, 31);
            label3.TabIndex = 2;
            label3.Text = "Pick the color of your flash cards:";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.YellowGreen;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Blue", "Red", "Purple", "Green", "Pink", "Yellow", "Black", "White", "Brown", "Orange", "Gray", "Gold", "Silver", "System (Windows color)" });
            comboBox1.Location = new Point(415, 161);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(168, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.YellowGreen;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox2.Location = new Point(415, 89);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(168, 23);
            comboBox2.TabIndex = 7;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(223, 219);
            button1.Name = "button1";
            button1.Size = new Size(228, 92);
            button1.TabIndex = 8;
            button1.Text = "Create!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(664, 349);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Flash cards!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        public ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
    }
}