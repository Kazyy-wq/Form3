namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int balance = Convert.ToInt32(label3.Text);

            balance += Convert.ToInt32(textBox1.Text);

            label3.Text = balance.ToString();
            textBox1.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int balance = Convert.ToInt32(textBox2.Text);

            balance += Convert.ToInt32(label17.Text);

            textBox2.Text = balance.ToString();

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int balance = Convert.ToInt32(textBox2.Text);

            balance += Convert.ToInt32(label18.Text);

            textBox2.Text = balance.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int balance = Convert.ToInt32(textBox2.Text);

            balance += Convert.ToInt32(label19.Text);

            textBox2.Text = balance.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int balance = Convert.ToInt32(textBox2.Text);

            balance += Convert.ToInt32(label20.Text);

            textBox2.Text = balance.ToString();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
