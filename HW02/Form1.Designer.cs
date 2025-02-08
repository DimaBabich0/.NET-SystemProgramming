namespace HW02
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLaunchProcess = new System.Windows.Forms.Button();
            this.txtboxProcess = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKillProcess = new System.Windows.Forms.Button();
            this.listProcess = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnLaunchProcess
            // 
            this.btnLaunchProcess.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLaunchProcess.Location = new System.Drawing.Point(268, 12);
            this.btnLaunchProcess.Name = "btnLaunchProcess";
            this.btnLaunchProcess.Size = new System.Drawing.Size(154, 40);
            this.btnLaunchProcess.TabIndex = 0;
            this.btnLaunchProcess.Text = "Launch";
            this.btnLaunchProcess.UseVisualStyleBackColor = true;
            this.btnLaunchProcess.Click += new System.EventHandler(this.btnLaunchProcess_Click);
            // 
            // txtboxProcess
            // 
            this.txtboxProcess.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F);
            this.txtboxProcess.Location = new System.Drawing.Point(12, 15);
            this.txtboxProcess.Name = "txtboxProcess";
            this.txtboxProcess.Size = new System.Drawing.Size(250, 35);
            this.txtboxProcess.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F);
            this.label1.Location = new System.Drawing.Point(90, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "List of running processes:";
            // 
            // btnKillProcess
            // 
            this.btnKillProcess.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F);
            this.btnKillProcess.Location = new System.Drawing.Point(12, 487);
            this.btnKillProcess.Name = "btnKillProcess";
            this.btnKillProcess.Size = new System.Drawing.Size(410, 48);
            this.btnKillProcess.TabIndex = 5;
            this.btnKillProcess.Text = "Kill process";
            this.btnKillProcess.UseVisualStyleBackColor = true;
            this.btnKillProcess.Click += new System.EventHandler(this.btnKillProcess_Click);
            // 
            // listProcess
            // 
            this.listProcess.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F);
            this.listProcess.FormattingEnabled = true;
            this.listProcess.ItemHeight = 28;
            this.listProcess.Location = new System.Drawing.Point(12, 85);
            this.listProcess.Name = "listProcess";
            this.listProcess.Size = new System.Drawing.Size(410, 396);
            this.listProcess.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 561);
            this.Controls.Add(this.listProcess);
            this.Controls.Add(this.btnKillProcess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxProcess);
            this.Controls.Add(this.btnLaunchProcess);
            this.Name = "Form1";
            this.Text = "Process manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLaunchProcess;
        private System.Windows.Forms.TextBox txtboxProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKillProcess;
        private System.Windows.Forms.ListBox listProcess;
    }
}

