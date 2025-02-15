using System.Threading;

namespace HW06
{
    public partial class Form1 : Form
    {
        private SynchronizationContext sC;
        private CancellationTokenSource cTS;
        private long bytes = 0;

        private static void ShowInfo(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private static void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public Form1()
        {
            InitializeComponent();
            sC = SynchronizationContext.Current;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            cTS = new CancellationTokenSource();
            bytes = 0;

            string fromPath = textBoxFrom.Text;
            string toPath = textBoxTo.Text;

            Task.Factory.StartNew(() => CopyFile(fromPath, toPath, cTS.Token), cTS.Token)
                .ContinueWith(t => ShowResult(), TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void ShowResult()
        {
            ShowInfo($"Copied {bytes} bytes");
        }

        private void CopyFile(string fromPath, string toPath, CancellationToken token)
        {
            const int bufSize = 4096;

            using (FileStream sourceStream = new FileStream(fromPath, FileMode.Open, FileAccess.Read))
            using (FileStream destStream = new FileStream(toPath, FileMode.Create, FileAccess.Write))
            {
                byte[] buf = new byte[bufSize];

                long totalBytes = sourceStream.Length;


                while (!token.IsCancellationRequested)
                {
                    int bytesRead = sourceStream.Read(buf, 0, buf.Length);
                    if (bytesRead == 0) break;

                    destStream.Write(buf, 0, bytesRead);
                    bytes += bytesRead;

                    int progress = (int)((bytes * 100) / totalBytes);

                    sC.Send(_ => progressBar.Value = progress, null);
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            cTS?.Cancel();
        }
    }
}
