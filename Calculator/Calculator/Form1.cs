using System.Reflection.Emit;
using System.Linq;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double final_result = 0;
        string intermediate = "";
        double prev_result = 0;

        public Form1()
        {
            InitializeComponent();
            button1.Click += NumButton_Click;
            button2.Click += NumButton_Click;
            button3.Click += NumButton_Click;
            button8.Click += NumButton_Click;
            button9.Click += NumButton_Click;
            button10.Click += NumButton_Click;
            button13.Click += NumButton_Click;
            button14.Click += NumButton_Click;
            button15.Click += NumButton_Click;
            button19.Click += NumButton_Click;
            button20.Click += NumButton_Click;

            button6.Click += OperatorButton_Click;
            button7.Click += OperatorButton_Click;
            button11.Click += OperatorButton_Click;
            button12.Click += OperatorButton_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NumButton_Click(object? sender, EventArgs e)
        {
            Button b = (Button)sender!;

            textBox2.Text += b.Text;

            intermediate += b.Text;

        }

        private void OperatorButton_Click(object? sender, EventArgs e)
        {
            Button b = (Button)sender!;

            textBox2.Text += b.Text;

            intermediate += " " + b.Text + " ";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Evaluate();
            textBox2.Text = final_result.ToString();
            intermediate = final_result.ToString();
            prev_result = final_result;
        }

        public void Evaluate()
        {
            string[] arr = intermediate.Split(' ');

            List<string> lists = arr.ToList();
            double result = 0;

            if (lists.Count == 1)
            {
                final_result = double.Parse(lists[0]);
                return;
            }




            while (lists.Contains("/") || lists.Contains("*"))
            {
                for (int i = 0; i < lists.Count; i++)
                {
                    if (lists[i] == "*")
                    {
                        result = double.Parse(lists[i - 1]) * double.Parse(lists[i + 1]);
                        lists.RemoveRange(i - 1, 3);
                        lists.Insert(i - 1, result.ToString());
                        break;

                    }
                    if (lists[i] == "/")
                    {
                        result = double.Parse(lists[i - 1]) / double.Parse(lists[i + 1]);
                        lists.RemoveRange(i - 1, 3);
                        lists.Insert(i - 1, result.ToString());
                        break;

                    }
                }
            }
            while (lists.Contains("+") || lists.Contains("-"))
            {
                for (int i = 0; i < lists.Count; i++)
                {
                    if (lists[i] == "+")
                    {
                        result = double.Parse(lists[i - 1]) + double.Parse(lists[i + 1]);
                        lists.RemoveRange(i - 1, 3);
                        lists.Insert(i - 1, result.ToString());
                        break;

                    }
                    if (lists[i] == "-")
                    {
                        result = double.Parse(lists[i - 1]) - double.Parse(lists[i + 1]);
                        lists.RemoveRange(i - 1, 3);
                        lists.Insert(i - 1, result.ToString());
                        break;

                    }
                }
            }

            final_result = result;

        }


        private void button4_Click(object sender, EventArgs e)
        {
            int len = intermediate.Length;

            if (len != 0)
            {
                if (intermediate[len - 1] == ' ')
                    intermediate = intermediate.Remove(len - 2);

                else
                    intermediate = intermediate.Remove(len - 1);

                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            intermediate = "";
            final_result = 0;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox2.Text += prev_result.ToString();

            intermediate += prev_result.ToString();
        }

    }
}
