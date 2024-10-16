using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Diagnostics.Debug;

namespace FrmTrackThread
{
    class MyThreadClass
    {
        public static void Thread1()
        {
            for (int loopCount = 0; loopCount < 2; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Debug.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);
                Thread.Sleep(1500);
            }
        }

        public static void Thread2()
        {
            for (int loopCount = 0; loopCount < 6; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Debug.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);
                Thread.Sleep(500);
            }
        }
    }
}
