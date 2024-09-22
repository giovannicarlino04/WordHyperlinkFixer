namespace WordHyperlinkFixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0)
            {
                if (textBox2.Text.Contains(" "))
                {
                    textBox1.Text = textBox2.Text.Replace(" ", "%20");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
            textBox1.Copy();
        }
    }
}
