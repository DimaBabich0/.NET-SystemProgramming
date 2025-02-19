namespace HW08
{
    public partial class Form1 : Form
    {
        private List<ThreadInfo> createdThreads = new List<ThreadInfo>();
        private List<ThreadInfo> waitingThreads = new List<ThreadInfo>();
        private List<ThreadInfo> runningThreads = new List<ThreadInfo>();
        private int threadCounter = 0;
        private Semaphore semaphore;

        private void MoveToRunning()
        {
            if (waitingThreads.Count > 0 && semaphore.WaitOne(0))
            {
                ThreadInfo thread = waitingThreads[0];
                waitingThreads.RemoveAt(0);
                listBoxWaiting.Items.Remove(thread);

                runningThreads.Add(thread);
                listBoxRunning.Items.Add(thread);

                thread.Start();
            }
        }

        public Form1()
        {
            InitializeComponent();
            semaphore = new Semaphore(2, 10);
            textBox.Text = "2";
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            threadCounter++;
            ThreadInfo threadInfo = new ThreadInfo(threadCounter);
            createdThreads.Add(threadInfo);
            listBoxCreated.Items.Add(threadInfo);
        }

        private void listBoxCreated_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxCreated.SelectedItem is ThreadInfo thread)
            {
                createdThreads.Remove(thread);
                waitingThreads.Add(thread);
                listBoxCreated.Items.Remove(thread);
                listBoxWaiting.Items.Add(thread);

                MoveToRunning();
            }
        }

        private void listBoxRunning_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxRunning.SelectedItem is ThreadInfo thread)
            {
                thread.Stop();

                runningThreads.Remove(thread);
                listBoxRunning.Items.Remove(thread);
                semaphore.Release();
                MoveToRunning();
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox.Text, out int updLimit) && updLimit > 0)
            {
                int running = runningThreads.Count;
                if (updLimit < running)
                {
                    for (int i = running - 1; i >= updLimit; i--)
                    {
                        runningThreads[i].Stop();
                        listBoxRunning.Items.Remove(runningThreads[i]);
                        runningThreads.RemoveAt(i);
                        semaphore.Release();
                    }
                }

                semaphore = new Semaphore(updLimit, 10);
                MoveToRunning();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var thread in runningThreads)
            {
                thread.Stop();
            }
            foreach (var threadInfo in waitingThreads)
            {
                threadInfo.Stop();
            }
        }
    }
}
