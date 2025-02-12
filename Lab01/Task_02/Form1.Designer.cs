namespace Task_02
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
            btnStart = new Button();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            progressBar3 = new ProgressBar();
            progressBar4 = new ProgressBar();
            progressBar5 = new ProgressBar();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(12, 13);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(360, 46);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = SystemColors.Control;
            progressBar1.Location = new Point(12, 66);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(360, 34);
            progressBar1.TabIndex = 1;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(12, 122);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(360, 34);
            progressBar2.TabIndex = 2;
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(12, 178);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(360, 34);
            progressBar3.TabIndex = 3;
            // 
            // progressBar4
            // 
            progressBar4.Location = new Point(12, 234);
            progressBar4.Name = "progressBar4";
            progressBar4.Size = new Size(360, 34);
            progressBar4.TabIndex = 4;
            // 
            // progressBar5
            // 
            progressBar5.Location = new Point(12, 290);
            progressBar5.Name = "progressBar5";
            progressBar5.Size = new Size(360, 34);
            progressBar5.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 346);
            Controls.Add(progressBar5);
            Controls.Add(progressBar4);
            Controls.Add(progressBar3);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(btnStart);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private ProgressBar progressBar3;
        private ProgressBar progressBar4;
        private ProgressBar progressBar5;
    }
}
