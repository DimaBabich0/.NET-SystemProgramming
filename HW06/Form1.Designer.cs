namespace HW06
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
            textBoxFrom = new TextBox();
            textBoxTo = new TextBox();
            label2 = new Label();
            btnStart = new Button();
            progressBar = new ProgressBar();
            btnStop = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(32, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 30);
            label1.TabIndex = 0;
            label1.Text = "From:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxFrom
            // 
            textBoxFrom.Location = new Point(115, 24);
            textBoxFrom.Margin = new Padding(2, 3, 2, 3);
            textBoxFrom.Name = "textBoxFrom";
            textBoxFrom.Size = new Size(306, 32);
            textBoxFrom.TabIndex = 2;
            // 
            // textBoxTo
            // 
            textBoxTo.Location = new Point(115, 69);
            textBoxTo.Margin = new Padding(2, 3, 2, 3);
            textBoxTo.Name = "textBoxTo";
            textBoxTo.Size = new Size(306, 32);
            textBoxTo.TabIndex = 4;
            // 
            // label2
            // 
            label2.Location = new Point(32, 69);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 30);
            label2.TabIndex = 3;
            label2.Text = "To:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(32, 147);
            btnStart.Margin = new Padding(2, 3, 2, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(192, 34);
            btnStart.TabIndex = 5;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(32, 107);
            progressBar.Margin = new Padding(2, 3, 2, 3);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(389, 34);
            progressBar.TabIndex = 6;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(229, 147);
            btnStop.Margin = new Padding(2, 3, 2, 3);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(192, 34);
            btnStop.TabIndex = 7;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 196);
            Controls.Add(btnStop);
            Controls.Add(progressBar);
            Controls.Add(btnStart);
            Controls.Add(textBoxTo);
            Controls.Add(label2);
            Controls.Add(textBoxFrom);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(6, 4, 6, 4);
            Name = "Form1";
            Text = "Transfer file";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxFrom;
        private TextBox textBoxTo;
        private Label label2;
        private Button btnStart;
        private ProgressBar progressBar;
        private Button btnStop;
    }
}
