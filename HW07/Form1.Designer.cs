namespace HW07
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
            textBox = new TextBox();
            checkBoxAll = new CheckBox();
            checkBoxSentence = new CheckBox();
            checkBoxCharacter = new CheckBox();
            checkBoxWord = new CheckBox();
            checkBoxExclamation = new CheckBox();
            checkBoxQuestion = new CheckBox();
            buttonStart = new Button();
            checkBoxSaveFile = new CheckBox();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Location = new Point(12, 12);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(330, 437);
            textBox.TabIndex = 0;
            // 
            // checkBoxAll
            // 
            checkBoxAll.AutoSize = true;
            checkBoxAll.Location = new Point(348, 14);
            checkBoxAll.Name = "checkBoxAll";
            checkBoxAll.Size = new Size(102, 25);
            checkBoxAll.TabIndex = 1;
            checkBoxAll.Text = "Check All";
            checkBoxAll.UseVisualStyleBackColor = true;
            checkBoxAll.CheckedChanged += checkBoxAll_CheckedChanged;
            // 
            // checkBoxSentence
            // 
            checkBoxSentence.AutoSize = true;
            checkBoxSentence.Location = new Point(348, 45);
            checkBoxSentence.Name = "checkBoxSentence";
            checkBoxSentence.Size = new Size(157, 25);
            checkBoxSentence.TabIndex = 2;
            checkBoxSentence.Text = "Sentence counter";
            checkBoxSentence.UseVisualStyleBackColor = true;
            // 
            // checkBoxCharacter
            // 
            checkBoxCharacter.AutoSize = true;
            checkBoxCharacter.Location = new Point(348, 107);
            checkBoxCharacter.Name = "checkBoxCharacter";
            checkBoxCharacter.Size = new Size(162, 25);
            checkBoxCharacter.TabIndex = 3;
            checkBoxCharacter.Text = "Character counter";
            checkBoxCharacter.UseVisualStyleBackColor = true;
            // 
            // checkBoxWord
            // 
            checkBoxWord.AutoSize = true;
            checkBoxWord.Location = new Point(348, 76);
            checkBoxWord.Name = "checkBoxWord";
            checkBoxWord.Size = new Size(132, 25);
            checkBoxWord.TabIndex = 4;
            checkBoxWord.Text = "Word counter";
            checkBoxWord.UseVisualStyleBackColor = true;
            // 
            // checkBoxExclamation
            // 
            checkBoxExclamation.AutoSize = true;
            checkBoxExclamation.Location = new Point(348, 169);
            checkBoxExclamation.Name = "checkBoxExclamation";
            checkBoxExclamation.Size = new Size(250, 25);
            checkBoxExclamation.TabIndex = 6;
            checkBoxExclamation.Text = "Exclamation sentence counter";
            checkBoxExclamation.UseVisualStyleBackColor = true;
            // 
            // checkBoxQuestion
            // 
            checkBoxQuestion.AutoSize = true;
            checkBoxQuestion.Location = new Point(348, 138);
            checkBoxQuestion.Name = "checkBoxQuestion";
            checkBoxQuestion.Size = new Size(226, 25);
            checkBoxQuestion.TabIndex = 7;
            checkBoxQuestion.Text = "Question sentence counter";
            checkBoxQuestion.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(348, 200);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(274, 35);
            buttonStart.TabIndex = 8;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // checkBoxSaveFile
            // 
            checkBoxSaveFile.AutoSize = true;
            checkBoxSaveFile.Location = new Point(404, 241);
            checkBoxSaveFile.Name = "checkBoxSaveFile";
            checkBoxSaveFile.Size = new Size(162, 25);
            checkBoxSaveFile.TabIndex = 9;
            checkBoxSaveFile.Text = "Save report to file";
            checkBoxSaveFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 461);
            Controls.Add(checkBoxSaveFile);
            Controls.Add(buttonStart);
            Controls.Add(checkBoxQuestion);
            Controls.Add(checkBoxExclamation);
            Controls.Add(checkBoxWord);
            Controls.Add(checkBoxCharacter);
            Controls.Add(checkBoxSentence);
            Controls.Add(checkBoxAll);
            Controls.Add(textBox);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private CheckBox checkBoxAll;
        private CheckBox checkBoxSentence;
        private CheckBox checkBoxCharacter;
        private CheckBox checkBox3;
        private CheckBox checkBoxWord;
        private CheckBox checkBox5;
        private CheckBox checkBoxExclamation;
        private CheckBox checkBoxQuestion;
        private Button buttonStart;
        private CheckBox checkBoxSaveFile;
    }
}
