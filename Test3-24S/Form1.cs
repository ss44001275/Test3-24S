namespace Test3_24S
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float Sum = int.Parse(textBox1.Text);
            Sum = Sum + int.Parse(textBox2.Text);
            textBox2.Text = Sum.ToString();
            float count = 1;
            count = count + int.Parse(textBox3.Text);
            textBox3.Text = (count).ToString();
           float Average = Sum / count;
            textBox4.Text = Average.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }
    }
}

