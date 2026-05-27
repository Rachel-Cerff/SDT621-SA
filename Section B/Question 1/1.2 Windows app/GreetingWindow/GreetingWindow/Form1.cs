namespace GreetingWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGreeting_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;

            MessageBox.Show("Hello " + Name + "!");
        }
    }
}
