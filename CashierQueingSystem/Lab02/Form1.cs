namespace Lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CashierClass cashier = new CashierClass();

        private void btnCashier_Click(object sender, EventArgs e)
        {
            CashierWindowQueueForm cashier = new CashierWindowQueueForm();
            cashier.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }
    }
}