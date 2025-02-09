namespace HW04
{
    public partial class Form1 : Form
    {
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
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            string fromPath = textBoxFrom.Text;
            string toPath = textBoxTo.Text;

            bool success = await CopyFile(fromPath, toPath);
            if (success)
            {
                ShowInfo("Copied successfully");
            }
        }

        private async Task<bool> CopyFile(string fromPath, string toPath)
        {
            const int bufSize = 4096;

            try
            {
                using (FileStream fromStream = new FileStream(fromPath, FileMode.Open, FileAccess.Read, FileShare.Read, bufSize, true))
                using (FileStream toStream = new FileStream(toPath, FileMode.Create, FileAccess.Write, FileShare.None, bufSize, true))
                {
                    byte[] buffer = new byte[bufSize];
                    long totalBytes = fromStream.Length;
                    long copiedBytes = 0;
                    int bytesRead;

                    progressBar.Invoke((Action)(() =>
                    {
                        progressBar.Maximum = 100;
                        progressBar.Value = 0;
                    }));

                    while ((bytesRead = await fromStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                    {
                        await toStream.WriteAsync(buffer, 0, bytesRead);
                        copiedBytes += bytesRead;

                        int progress = (int)((copiedBytes * 100) / totalBytes);

                        progressBar.Invoke((Action)(() => progressBar.Value = progress));
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                ShowError($"Eror: {ex.Message}");
                return false;
            }
        }
    }
}
