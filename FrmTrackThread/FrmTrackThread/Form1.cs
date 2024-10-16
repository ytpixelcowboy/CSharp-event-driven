using System.Diagnostics;
using static System.Diagnostics.Debug;

namespace FrmTrackThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("-Before starting thread-");
            txtState.Text = "-Before starting thread-";


            Thread ThreadA = new Thread(MyThreadClass.Thread1);
            Thread ThreadB = new Thread(MyThreadClass.Thread1);
            Thread ThreadC = new Thread(MyThreadClass.Thread2);
            Thread ThreadD = new Thread(MyThreadClass.Thread2);

            ThreadA.Name = "Thread A Process";
            ThreadB.Name = "Thread B Process";
            ThreadC.Name = "Thread C Process";
            ThreadD.Name = "Thread D Process";

            ThreadA.Priority = ThreadPriority.Highest;
            ThreadB.Priority = ThreadPriority.Normal;
            ThreadC.Priority = ThreadPriority.AboveNormal;
            ThreadD.Priority = ThreadPriority.BelowNormal;

            ThreadA.Start();
            ThreadB.Start();
            ThreadC.Start();
            ThreadD.Start();

            ThreadA.Join();
            ThreadB.Join();
            ThreadC.Join();
            ThreadD.Join();

            Debug.WriteLine("-End of thread-");
            txtState.Text = "End of thread";
        }
    }
}
