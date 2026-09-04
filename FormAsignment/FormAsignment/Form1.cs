using System.Text.RegularExpressions;

namespace FormAsignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Male.Checked = false;
            Female.Checked = false;
            Others.Checked = false;
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            bool is_validated = Validate_Input();
            string gender = "";

            if (is_validated)
            {
                if (Male.Checked)
                    gender = Male.Text;
                else if (Female.Checked)
                    gender = Female.Text;
                else
                    gender = Others.Text;

                using (StreamWriter sw = new StreamWriter(@"C:\\Users\\Dell\\OneDrive\\Desktop\\.net\Details.txt", true))
                {
                    sw.WriteLine(new string('*', 20));
                    sw.WriteLine($"Name: {FullName_Box.Text}");
                    sw.WriteLine($"Roll No: {Roll_Box.Text}");
                    sw.WriteLine($"Address: {Address_Box.Text}");
                    sw.WriteLine($"Email: {Email_Box.Text}");
                    sw.WriteLine($"Phone No: {Phone_Box.Text}");
                    sw.WriteLine($"Gender: {gender}");
                    sw.WriteLine($"Faculty: {Faculty_Box.Text}");
                    sw.WriteLine(new string('*', 20));
                }

                FullName_Box.Clear();
                Roll_Box.Clear();
                Address_Box.Clear();
                Email_Box.Clear();
                Phone_Box.Clear();
                Faculty_Box.SelectedIndex = -1;
                Male.Checked = false;
                Female.Checked = false;
                Others.Checked = false;

                MessageBox.Show("Form Submittted Successfully!!");

            }
            else
            {
                MessageBox.Show("Unable to Submit your form.");
            }
        }

        public bool Validate_Input()
        {
            string name = FullName_Box.Text;
            string roll = Roll_Box.Text;
            string address = Address_Box.Text;
            string email = Email_Box.Text;
            string phone = Phone_Box.Text;
            bool is_checked = Male.Checked || Female.Checked || Others.Checked;
            string faculty = Faculty_Box.Text;

            string email_pattern = @"^[a-zA-Z0-9][\w\-.+]+@[a-zA-Z]+\.[a-zA-Z.]+$";
            string phone_pattern = @"^9[78]\d{8}$";

            if (name == "" || roll == "" || address == "" || email == "" || phone == "" || !is_checked || faculty == "")
            {
                MessageBox.Show("Please fill out the entire form.");
                return false;
            }
            else if (!Regex.IsMatch(email, email_pattern))
            {
                MessageBox.Show("Invalid Email");
                return false;
            }
            else if (!Regex.IsMatch(phone, phone_pattern))
            {
                MessageBox.Show("Invalid Phone Number.");
                return false;
            }
            return true;
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            FullName_Box.Clear();
            Roll_Box.Clear();
            Address_Box.Clear();
            Email_Box.Clear();
            Phone_Box.Clear();
            Faculty_Box.SelectedIndex = -1;
            Male.Checked = false;
            Female.Checked = false;
            Others.Checked = false;

            MessageBox.Show("Form Reset Successful.");
        }
    }
}
