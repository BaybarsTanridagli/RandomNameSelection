namespace RandomNameSelection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNameNumber = random.Next(1,listBox1.Items.Count);
            string person = listBox1.Items[randomNameNumber - 1].ToString();
            MessageBox.Show(person);
        }
    }
}