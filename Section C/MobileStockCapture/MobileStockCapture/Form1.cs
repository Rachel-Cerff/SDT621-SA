namespace MobileStockCapture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> tblMobilePhones = new List<string>();
        string mobile;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*int Code = int.Parse(txtCode.Text);
            string Make = txtMake.Text;
            int Quantity = int.Parse(txtQuantity.Text);

            tblMobilePhones.Add(Convert.ToString(Code));
            tblMobilePhones.Add(Make);
            tblMobilePhones.Add(Convert.ToString(Quantity));*/

            mobile = $"{txtCode}, {txtMake}, {txtQuantity}";
            tblMobilePhones.Add(mobile);

            //success message
            lblOutput.Text = "Record Added";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            mobile = txtCode.Text;
            if (string.IsNullOrEmpty(mobile))
            {
                MessageBox.Show("Please enter a code");
            }

            for (int i = 0; i < tblMobilePhones.Count; i++)
            {
                if(tblMobilePhones[i] == mobile)
                {
                    tblMobilePhones.RemoveAt(i);
                    MessageBox.Show($"{mobile}\n Deleted Successfully.");

                    lblOutput.Text = "Record Deleted.";
                }
                else
                {
                    lblOutput.Text = "Record Not Found.";
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            mobile = txtCode.Text;
            if (string.IsNullOrEmpty(mobile))
            {
                MessageBox.Show("Please enter a code");
            }

            if(mobile == txtCode.Text)
            {
                lblOutput.Text = "Record Found.";
            }
        }
    }
}
