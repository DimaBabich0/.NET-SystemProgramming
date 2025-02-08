using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace HW02
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
            RefreshList();
        }

        private void RefreshList()
        {
            listProcess.Items.Clear();

            var list = Process.GetProcesses()
                .OrderBy(x => x.ProcessName)
                .Select(x => x.ProcessName)
                .Distinct()
                .ToArray();

            foreach (var p in list)
            {
                listProcess.Items.Add(p);
            }
        }

        private void btnLaunchProcess_Click(object sender, EventArgs e)
        {
            string procName = txtboxProcess.Text.Trim();
            if (!string.IsNullOrEmpty(procName))
            {
                Process myProcess = new Process();
                myProcess.StartInfo = new ProcessStartInfo(procName);
                try
                {
                    myProcess.Start();
                    ShowInfo($"Process is started: {procName}");
                    RefreshList();
                }
                catch(Exception ex)
                {
                    ShowError($"Process not started: {procName}\nError message: {ex.Message}");
                }
            }
        }

        private void btnKillProcess_Click(object sender, EventArgs e)
        {
            if (listProcess.SelectedItem != null)
            {
                string selectedProcName = listProcess.SelectedItem.ToString();

                Process[] processes = Process.GetProcessesByName(selectedProcName);

                foreach (Process process in processes)
                {
                    process.Kill();
                }

                ShowInfo($"Killed process: {selectedProcName}");
                RefreshList();
            }
            else
            {
                ShowError("Select process from list");
            }
        }
    }
}
