using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW08
{
    internal class ThreadInfo
    {
        public int Id { get; }
        private Thread thread;
        private bool isRunning;
        private int Counter = 0;

        public ThreadInfo(int id)
        {
            Id = id;
            thread = new Thread(Run);
        }

        public void Start()
        {
            isRunning = true;
            thread = new Thread(Run);
            thread.Start();
        }

        public void Stop()
        {
            isRunning = false;
            if (thread.IsAlive)
            {
                thread.Join(1000);
                if (thread.IsAlive) thread.Interrupt();
            }
        }

        private void Run()
        {
            try
            {
                while (isRunning)
                {
                    Counter++;
                    Thread.Sleep(1000);
                }
            }
            catch (Exception) { }
        }

        public override string ToString()
        {
            return $"Thread #{Id}";
        }
    }
}
