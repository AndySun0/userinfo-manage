namespace userinfo_manage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string timestr = DateTime.Now.ToString();
            time.Text = timestr;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            time.Text = "gg";
        }
    }
}
