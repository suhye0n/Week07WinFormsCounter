namespace Week07WinFormsCounter
{
    public partial class Form1 : Form
    {
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void OmPress(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OnPress(object sender, EventArgs e)
        {
            // btnPress.Enabled = false;
            label1.Text = "" + ++count;
        }

        private void OnPress2(object sender, EventArgs e)
        {
            // btnPress.Enabled = false;
            label1.Text = "" + --count;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}