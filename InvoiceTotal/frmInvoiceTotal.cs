namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal subtotal = Decimal.Parse(txtSubtotal.Text);

                if (subtotal <= 0 || subtotal >= 10000)
                {
                    throw new Exception("Please enter a value greater than zero and less than 10,000.");
                }

                decimal discountPct = .25m;
                decimal discountAmt = Math.Round(subtotal * discountPct, 2);
                decimal invoiceTotal = Math.Round(subtotal - discountAmt, 2);

                txtDiscountPct.Text = discountPct.ToString("p1");
                txtDiscountAmt.Text = discountAmt.ToString("c");
                txtTotal.Text = invoiceTotal.ToString("c");
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Entry Error");

            }

            txtSubtotal.Focus();

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}