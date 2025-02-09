using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HW03
{
    public partial class Form1 : Form
    {
        private bool isSearching = false;
        private bool stopSearch = false;

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
            listFiles.View = View.Details;
            listFiles.GridLines = true;
            listFiles.Columns.Add("Name", 150, HorizontalAlignment.Center);
            listFiles.Columns.Add("Location", 280, HorizontalAlignment.Center);
            listFiles.Columns.Add("Size", -2, HorizontalAlignment.Center);
        }

        public void AddItemToList(string name, string location, long size)
        {
            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(location);
            item.SubItems.Add($"{(size / 1024.0):F2} MB");
            listFiles.Items.Add(item);
        }

        private async Task StartSearch()
        {
            isSearching = true;
            try
            {
                string dirPath = @"C:\";
                string searchFormat = textFilesFormat.Text;
                string searchWord = textWordFiles.Text;

                if (string.IsNullOrWhiteSpace(searchFormat))
                {
                    ShowError("File format cannot be empty");
                    return;
                }

                listFiles.Items.Clear();

                await SearchDirectory(dirPath, searchFormat, searchWord);
            }
            catch (Exception ex)
            {
                ShowError($"An error occurred: {ex.Message}");
            }
            finally
            {
                isSearching = false;
            }
        }

        private async Task SearchDirectory(string dirPath, string searchFormat, string searchWord)
        {
            try
            {
                if (stopSearch)
                    return;

                string[] dataToCheck = Directory.GetFiles(dirPath, searchFormat);

                foreach (var item in dataToCheck)
                {
                    if (stopSearch)
                        return;

                    if (File.Exists(item))
                    {
                        if (searchWord.Length == 0 || item.ToLower().Contains(searchWord.ToLower()))
                        {
                            AddItemToList(Path.GetFileName(item), item, item.Length);
                        }
                    }
                }

                var subdirs = Directory.GetDirectories(dirPath);
                var tasks = new List<Task>();

                foreach (var subdir in subdirs)
                {
                    tasks.Add(Task.Run(async () =>
                    {
                        await SearchDirectory(subdir, searchFormat, searchWord);
                    }));
                }

                await Task.WhenAll(tasks);
            }
            catch (UnauthorizedAccessException)
            {
                return;
            }
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (isSearching)
            {
                ShowInfo("Search is in progress");
                return;
            }

            labelResult.Text = "Scanning...";

            stopSearch = false;
            await StartSearch();

            labelResult.Text = "Search complete";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (isSearching)
            {
                stopSearch = true;
                labelResult.Text = "Stopping search";
            }
        }
    }
}
