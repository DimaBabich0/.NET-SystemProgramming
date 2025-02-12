namespace Task_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            List<ProgressBar> progressBarList = new List<ProgressBar> {
                progressBar1,
                progressBar2,
                progressBar3,
                progressBar4,
                progressBar5
            };

            var tasks = new List<Task>();
            for (int i = 0; i < progressBarList.Count; i++)
            {
                tasks.Add(FillProgressBar(progressBarList[i]));
            }

            await Task.WhenAll(tasks);
        }

        private async Task FillProgressBar(ProgressBar progressBar)
        {
            Random r = new Random();
            int time = r.Next(20, 100);
            for (int i = 0; i <= progressBar.Maximum; i++)
            {
                progressBar.Value = i;
                await Task.Delay(time);
            }
        }
    }
}
