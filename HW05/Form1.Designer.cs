namespace HW05
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
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            label2 = new Label();
            textBoxGroup = new TextBox();
            label3 = new Label();
            textBoxAge = new TextBox();
            label4 = new Label();
            btnSave = new Button();
            listView = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(69, 27);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 50);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(266, 29);
            textBoxName.TabIndex = 1;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(12, 138);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(266, 29);
            textBoxSurname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 100);
            label2.Name = "label2";
            label2.Size = new Size(96, 27);
            label2.TabIndex = 2;
            label2.Text = "Surname";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxGroup
            // 
            textBoxGroup.Location = new Point(12, 314);
            textBoxGroup.Name = "textBoxGroup";
            textBoxGroup.Size = new Size(266, 29);
            textBoxGroup.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 276);
            label3.Name = "label3";
            label3.Size = new Size(73, 27);
            label3.TabIndex = 6;
            label3.Text = "Group";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(12, 226);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(266, 29);
            textBoxAge.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 188);
            label4.Name = "label4";
            label4.Size = new Size(51, 27);
            label4.TabIndex = 4;
            label4.Text = "Age";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSave.Location = new Point(12, 386);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(266, 62);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // listView
            // 
            listView.Location = new Point(284, 12);
            listView.Name = "listView";
            listView.Size = new Size(538, 437);
            listView.TabIndex = 9;
            listView.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(834, 461);
            Controls.Add(listView);
            Controls.Add(btnSave);
            Controls.Add(textBoxGroup);
            Controls.Add(label3);
            Controls.Add(textBoxAge);
            Controls.Add(label4);
            Controls.Add(textBoxSurname);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private Label label2;
        private TextBox textBoxGroup;
        private Label label3;
        private TextBox textBoxAge;
        private Label label4;
        private Button btnSave;
        private ListView listView;
    }
}
