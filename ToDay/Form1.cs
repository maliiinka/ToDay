namespace ToDay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.ShowDialog();
        }
    }
}