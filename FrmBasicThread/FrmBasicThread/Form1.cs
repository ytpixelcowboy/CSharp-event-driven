using System.Diagnostics;
using static System.Diagnostics.Debug;

namespace FrmBasicThread
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
        //PALMA, CARL JORDEE
        //BSIT - 501

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("-Before starting thread-");
            txtState.Text = "-Before starting thread-";
            

            Thread ThreadA = new Thread(MyThreadClass.Thread1);
            Thread ThreadB = new Thread(MyThreadClass.Thread1);
            ThreadA.Name = "Thread A Process";
            ThreadB.Name = "Thread B Process";
            ThreadA.Start();
            ThreadB.Start();
            ThreadA.Join();
            ThreadB.Join();

            Debug.WriteLine("-End of thread-");
            txtState.Text = "End of thread";
        }
    }
}
