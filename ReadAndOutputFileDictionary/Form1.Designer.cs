namespace ReadAndOutputFileDictionary
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
            button1 = new Button();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            listBox2 = new ListBox();
            button2 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(572, 1117);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(344, 90);
            button1.TabIndex = 0;
            button1.Text = "Read My File";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Items.AddRange(new object[] { "Information" });
            listBox1.Location = new Point(572, 261);
            listBox1.Margin = new Padding(4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(344, 804);
            listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(572, 189);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(344, 39);
            textBox1.TabIndex = 2;
            textBox1.Text = "File Name";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 32;
            listBox2.Items.AddRange(new object[] { "Information" });
            listBox2.Location = new Point(82, 261);
            listBox2.Margin = new Padding(4);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(428, 804);
            listBox2.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.ForeColor = Color.Snow;
            button2.Location = new Point(82, 1117);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(428, 90);
            button2.TabIndex = 4;
            button2.Text = "Check your own ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(82, 115);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(428, 39);
            textBox2.TabIndex = 5;
            textBox2.Text = "C:\\Users\\Public\\Downloads\\YourFile.txt";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.Font = new Font("Segoe UI", 10.125F, FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(73, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(585, 37);
            label1.TabIndex = 6;
            label1.Text = "Enter your file full path without quotation marks";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(82, 189);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(428, 39);
            textBox3.TabIndex = 7;
            textBox3.Text = "Your File Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(572, 131);
            label2.Name = "label2";
            label2.Size = new Size(199, 37);
            label2.TabIndex = 8;
            label2.Text = "Hard coded file";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1031, 1276);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(listBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "FileReader";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private TextBox textBox1;
        private ListBox listBox2;
        private Button button2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox3;
        private Label label2;
    }
}