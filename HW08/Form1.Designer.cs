namespace HW08
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
            label3 = new Label();
            listBoxRunning = new ListBox();
            listBoxWaiting = new ListBox();
            listBoxCreated = new ListBox();
            label4 = new Label();
            textBox = new TextBox();
            buttonCreate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 12);
            label1.Name = "label1";
            label1.Size = new Size(62, 19);
            label1.TabIndex = 0;
            label1.Text = "Running";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 12);
            label2.Name = "label2";
            label2.Size = new Size(59, 19);
            label2.TabIndex = 1;
            label2.Text = "Waiting";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(294, 12);
            label3.Name = "label3";
            label3.Size = new Size(60, 19);
            label3.TabIndex = 2;
            label3.Text = "Created";
            // 
            // listBoxRunning
            // 
            listBoxRunning.FormattingEnabled = true;
            listBoxRunning.ItemHeight = 19;
            listBoxRunning.Location = new Point(12, 34);
            listBoxRunning.Name = "listBoxRunning";
            listBoxRunning.Size = new Size(120, 80);
            listBoxRunning.TabIndex = 3;
            listBoxRunning.DoubleClick += listBoxRunning_DoubleClick;
            // 
            // listBoxWaiting
            // 
            listBoxWaiting.FormattingEnabled = true;
            listBoxWaiting.ItemHeight = 19;
            listBoxWaiting.Location = new Point(138, 34);
            listBoxWaiting.Name = "listBoxWaiting";
            listBoxWaiting.Size = new Size(120, 80);
            listBoxWaiting.TabIndex = 4;
            // 
            // listBoxCreated
            // 
            listBoxCreated.FormattingEnabled = true;
            listBoxCreated.ItemHeight = 19;
            listBoxCreated.Location = new Point(264, 34);
            listBoxCreated.Name = "listBoxCreated";
            listBoxCreated.Size = new Size(120, 80);
            listBoxCreated.TabIndex = 5;
            listBoxCreated.DoubleClick += listBoxCreated_DoubleClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 117);
            label4.Name = "label4";
            label4.Size = new Size(218, 19);
            label4.TabIndex = 6;
            label4.Text = "Number of spaces in semaphore";
            // 
            // textBox
            // 
            textBox.Location = new Point(12, 139);
            textBox.Name = "textBox";
            textBox.Size = new Size(218, 27);
            textBox.TabIndex = 7;
            textBox.TextChanged += textBox_TextChanged;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(264, 120);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(120, 45);
            buttonCreate.TabIndex = 8;
            buttonCreate.Text = "Create thread";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 189);
            Controls.Add(buttonCreate);
            Controls.Add(textBox);
            Controls.Add(label4);
            Controls.Add(listBoxCreated);
            Controls.Add(listBoxWaiting);
            Controls.Add(listBoxRunning);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBoxRunning;
        private ListBox listBoxWaiting;
        private ListBox listBoxCreated;
        private Label label4;
        private TextBox textBox;
        private Button buttonCreate;
    }
}
