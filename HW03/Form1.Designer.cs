namespace HW03
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            btnStart = new Button();
            btnStop = new Button();
            listFiles = new ListView();
            textFilesFormat = new TextBox();
            textWordFiles = new TextBox();
            labelResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(124, 27);
            label1.TabIndex = 0;
            label1.Text = "Files format";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(142, 9);
            label2.Name = "label2";
            label2.Size = new Size(186, 27);
            label2.TabIndex = 1;
            label2.Text = "Word in files name";
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Trebuchet MS", 15.75F);
            btnStart.Location = new Point(358, 37);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(100, 40);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Font = new Font("Trebuchet MS", 15.75F);
            btnStop.Location = new Point(464, 37);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(100, 40);
            btnStop.TabIndex = 3;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // listFiles
            // 
            listFiles.Location = new Point(12, 117);
            listFiles.Name = "listFiles";
            listFiles.Size = new Size(552, 463);
            listFiles.TabIndex = 4;
            listFiles.UseCompatibleStateImageBehavior = false;
            // 
            // textFilesFormat
            // 
            textFilesFormat.Font = new Font("Trebuchet MS", 15.75F);
            textFilesFormat.Location = new Point(16, 41);
            textFilesFormat.Name = "textFilesFormat";
            textFilesFormat.Size = new Size(116, 32);
            textFilesFormat.TabIndex = 5;
            // 
            // textWordFiles
            // 
            textWordFiles.Font = new Font("Trebuchet MS", 15.75F);
            textWordFiles.Location = new Point(143, 41);
            textWordFiles.Name = "textWordFiles";
            textWordFiles.Size = new Size(184, 32);
            textWordFiles.TabIndex = 6;
            // 
            // labelResult
            // 
            labelResult.Font = new Font("Trebuchet MS", 15.75F);
            labelResult.Location = new Point(12, 79);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(552, 23);
            labelResult.TabIndex = 7;
            labelResult.Text = "Result of search: 0";
            labelResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 592);
            Controls.Add(labelResult);
            Controls.Add(textWordFiles);
            Controls.Add(textFilesFormat);
            Controls.Add(listFiles);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Finder files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnStart;
        private Button btnStop;
        private ListView listFiles;
        private TextBox textFilesFormat;
        private TextBox textWordFiles;
        private Label labelResult;
    }
}
