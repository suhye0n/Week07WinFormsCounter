namespace Week07WinFormsCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OmPress(object sender, EventArgs e)
        {
            btnPress.Enabled = false;
            label1.Text = "눌렸습니다";
        }
    }
}