using CalculatorPrivateAssembly;

namespace FrmBasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BasicComputation mathAssembly = new BasicComputation();

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] operations = new string[] { "+", "-", "*", "/" };

            cboxOperations.Items.AddRange(operations);

            cboxOperations.SelectedIndex = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1 = (float) Convert.ToDouble(tboxNum1.Text);
            float num2 = (float)Convert.ToDouble(tboxNum2.Text);


            switch (cboxOperations.SelectedItem)
            {
                case "+":
                    txtResult.Text = (mathAssembly.Addition(num1, num2)).ToString();
                    break;
                case "-":
                    txtResult.Text = (mathAssembly.Subtraction(num1, num2)).ToString();
                    break;
                case "*":
                    txtResult.Text = (mathAssembly.Multiplication(num1, num2)).ToString();
                    break;
                case "/":
                    txtResult.Text = (mathAssembly.Division(num1, num2)).ToString();
                    break;
            }
        }
    }
}
