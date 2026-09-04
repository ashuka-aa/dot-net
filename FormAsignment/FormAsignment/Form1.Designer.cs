namespace FormAsignment
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
            FullName = new Label();
            Male = new RadioButton();
            Female = new RadioButton();
            FullName_Box = new TextBox();
            Roll_No = new Label();
            Faculty = new Label();
            Roll_Box = new TextBox();
            Phone_No = new Label();
            Others = new RadioButton();
            Faculty_Box = new ComboBox();
            submit_button = new Button();
            reset_button = new Button();
            Email_Box = new TextBox();
            Email = new Label();
            Address_Box = new TextBox();
            Address = new Label();
            Phone_Box = new TextBox();
            Gender = new Label();
            SuspendLayout();
            // 
            // FullName
            // 
            FullName.Location = new Point(12, 16);
            FullName.Name = "FullName";
            FullName.Size = new Size(62, 29);
            FullName.TabIndex = 0;
            FullName.Text = "FullName";
            FullName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Male
            // 
            Male.AutoSize = true;
            Male.Location = new Point(89, 216);
            Male.Name = "Male";
            Male.Size = new Size(51, 19);
            Male.TabIndex = 2;
            Male.Text = "Male";
            Male.TextAlign = ContentAlignment.TopCenter;
            Male.UseVisualStyleBackColor = true;
            // 
            // Female
            // 
            Female.AutoSize = true;
            Female.Location = new Point(206, 216);
            Female.Name = "Female";
            Female.Size = new Size(63, 19);
            Female.TabIndex = 3;
            Female.TabStop = true;
            Female.Text = "Female";
            Female.TextAlign = ContentAlignment.TopCenter;
            Female.UseVisualStyleBackColor = true;
            // 
            // FullName_Box
            // 
            FullName_Box.Location = new Point(89, 19);
            FullName_Box.Multiline = true;
            FullName_Box.Name = "FullName_Box";
            FullName_Box.Size = new Size(140, 27);
            FullName_Box.TabIndex = 4;
            // 
            // Roll_No
            // 
            Roll_No.AutoSize = true;
            Roll_No.Location = new Point(253, 29);
            Roll_No.Name = "Roll_No";
            Roll_No.Size = new Size(48, 15);
            Roll_No.TabIndex = 5;
            Roll_No.Text = "Roll_No";
            Roll_No.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Faculty
            // 
            Faculty.AutoSize = true;
            Faculty.Location = new Point(253, 145);
            Faculty.Name = "Faculty";
            Faculty.Size = new Size(45, 15);
            Faculty.TabIndex = 7;
            Faculty.Text = "Faculty";
            Faculty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Roll_Box
            // 
            Roll_Box.Location = new Point(320, 20);
            Roll_Box.Multiline = true;
            Roll_Box.Name = "Roll_Box";
            Roll_Box.Size = new Size(140, 27);
            Roll_Box.TabIndex = 8;
            // 
            // Phone_No
            // 
            Phone_No.AutoSize = true;
            Phone_No.Location = new Point(21, 141);
            Phone_No.Name = "Phone_No";
            Phone_No.Size = new Size(62, 15);
            Phone_No.TabIndex = 9;
            Phone_No.Text = "Phone_No";
            Phone_No.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Others
            // 
            Others.AutoSize = true;
            Others.Location = new Point(320, 216);
            Others.Name = "Others";
            Others.Size = new Size(60, 19);
            Others.TabIndex = 13;
            Others.TabStop = true;
            Others.Text = "Others";
            Others.TextAlign = ContentAlignment.TopCenter;
            Others.UseVisualStyleBackColor = true;
            // 
            // Faculty_Box
            // 
            Faculty_Box.FormattingEnabled = true;
            Faculty_Box.Items.AddRange(new object[] { "Bsc. CSIT", "BIT", "BIM", "BCA", "BBA", "BBS" });
            Faculty_Box.Location = new Point(320, 142);
            Faculty_Box.Name = "Faculty_Box";
            Faculty_Box.Size = new Size(140, 23);
            Faculty_Box.TabIndex = 15;
            // 
            // submit_button
            // 
            submit_button.Location = new Point(21, 276);
            submit_button.Name = "submit_button";
            submit_button.Size = new Size(75, 23);
            submit_button.TabIndex = 16;
            submit_button.Text = "Submit";
            submit_button.UseVisualStyleBackColor = true;
            submit_button.Click += submit_button_Click;
            // 
            // reset_button
            // 
            reset_button.Location = new Point(122, 276);
            reset_button.Name = "reset_button";
            reset_button.Size = new Size(75, 23);
            reset_button.TabIndex = 17;
            reset_button.Text = "Reset";
            reset_button.UseVisualStyleBackColor = true;
            reset_button.Click += reset_button_Click;
            // 
            // Email_Box
            // 
            Email_Box.Location = new Point(320, 77);
            Email_Box.Multiline = true;
            Email_Box.Name = "Email_Box";
            Email_Box.Size = new Size(140, 27);
            Email_Box.TabIndex = 21;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(253, 86);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 20;
            Email.Text = "Email";
            Email.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Address_Box
            // 
            Address_Box.Location = new Point(89, 77);
            Address_Box.Multiline = true;
            Address_Box.Name = "Address_Box";
            Address_Box.Size = new Size(140, 27);
            Address_Box.TabIndex = 19;
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Location = new Point(21, 77);
            Address.Name = "Address";
            Address.Size = new Size(49, 15);
            Address.TabIndex = 18;
            Address.Text = "Address";
            Address.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Phone_Box
            // 
            Phone_Box.Location = new Point(89, 138);
            Phone_Box.Multiline = true;
            Phone_Box.Name = "Phone_Box";
            Phone_Box.Size = new Size(140, 27);
            Phone_Box.TabIndex = 22;
            // 
            // Gender
            // 
            Gender.AutoSize = true;
            Gender.Location = new Point(21, 216);
            Gender.Name = "Gender";
            Gender.Size = new Size(45, 15);
            Gender.TabIndex = 23;
            Gender.Text = "Gender";
            Gender.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 335);
            Controls.Add(Gender);
            Controls.Add(Phone_Box);
            Controls.Add(Email_Box);
            Controls.Add(Email);
            Controls.Add(Address_Box);
            Controls.Add(Address);
            Controls.Add(reset_button);
            Controls.Add(submit_button);
            Controls.Add(Faculty_Box);
            Controls.Add(Others);
            Controls.Add(Phone_No);
            Controls.Add(Roll_Box);
            Controls.Add(Faculty);
            Controls.Add(Roll_No);
            Controls.Add(FullName_Box);
            Controls.Add(Female);
            Controls.Add(Male);
            Controls.Add(FullName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FullName;
        private RadioButton Male;
        private RadioButton Female;
        private TextBox FullName_Box;
        private Label Roll_No;
        private Label Faculty;
        private TextBox Roll_Box;
        private Label Phone_No;
        private RadioButton Others;
        private ComboBox Faculty_Box;
        private Button submit_button;
        private Button reset_button;
        private TextBox Email_Box;
        private Label Email;
        private TextBox Address_Box;
        private Label Address;
        private TextBox Phone_Box;
        private Label Gender;
    }
}
