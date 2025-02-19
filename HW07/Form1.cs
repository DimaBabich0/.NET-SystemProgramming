using System.Text.RegularExpressions;

namespace HW07
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

        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = checkBoxAll.Checked;

            checkBoxSentence.Checked = isChecked;
            checkBoxWord.Checked = isChecked;
            checkBoxCharacter.Checked = isChecked;
            checkBoxQuestion.Checked = isChecked;
            checkBoxExclamation.Checked = isChecked;
        }

        private async Task<int> CountSentence(string text)
        {
            return await Task.Run(() => Regex.Matches(text, @"[.!?](\s|$)").Count);
        }

        private async Task<int> CountWord(string text)
        {
            return await Task.Run(() => Regex.Matches(text, @"\b\w+\b").Count);
        }

        private async Task<int> CountCharacter(string text)
        {
            return await Task.Run(() => text.Count());
        }

        private async Task<int> CountQuestion(string text)
        {
            return await Task.Run(() => Regex.Matches(text, @"\?+(\s|$)").Count);
        }

        private async Task<int> CountExclamation(string text)
        {
            return await Task.Run(() => Regex.Matches(text, @"!+(\s|$)").Count);
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            string text = textBox.Text.Trim();

            if (text.Length == 0)
            {
                ShowError("Text box is empty");
                return;
            }

            string message = "\tReport:\n";

            if (checkBoxSentence.Checked)
            {
                message += $"Total Sentences: {await CountSentence(text)}\n";
            }

            if (checkBoxWord.Checked)
            {
                message += $"Total Words: {await CountWord(text)}\n";
            }

            if (checkBoxCharacter.Checked)
            {
                message += $"Total Symbols: {await CountCharacter(text)}\n";
            }

            if (checkBoxQuestion.Checked)
            {
                message += $"Question sentences: {await CountQuestion(text)}\n";
            }

            if (checkBoxExclamation.Checked)
            {
                message += $"Exclamation sentences: {await CountExclamation(text)}\n";
            }

            if (checkBoxSaveFile.Checked)
            {
                string path = "Report.txt";
                using (StreamWriter sw = new StreamWriter(path))
                {
                    await sw.WriteAsync(message);
                }

                message += $"Report saved to file: {path}";
            }

            ShowInfo(message);
        }
    }
}
