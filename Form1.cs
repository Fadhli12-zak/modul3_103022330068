namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num1, num2, num3;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Output.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Output.Text += "8";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Output.Text += "5";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Output.Text += "+";
            
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            num1 = Int32.Parse(Output.Text.Split('+')[0]);
            num2 = Int32.Parse(Output.Text.Split('+')[1]);
            int result = num1+num2;
            if (Output.Text.Split('+').Length > 2) {
                num3 = Int32.Parse(Output.Text.Split('+')[2]);
                result += num3; 
            }
      
            Output.Text = result.ToString(); 
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Output.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Output.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Output.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Output.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Output.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Output.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Output.Text += "9";
        }
    }
}
