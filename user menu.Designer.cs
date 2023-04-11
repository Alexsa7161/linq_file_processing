namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(247, 396);
            button1.Name = "button1";
            button1.Size = new Size(210, 123);
            button1.TabIndex = 0;
            button1.Text = "Longest word";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(247, 224);
            button2.Name = "button2";
            button2.Size = new Size(210, 123);
            button2.TabIndex = 1;
            button2.Text = "Most common N character pairs";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(571, 396);
            button3.Name = "button3";
            button3.Size = new Size(210, 123);
            button3.TabIndex = 2;
            button3.Text = "Duplicate files";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(571, 224);
            button4.Name = "button4";
            button4.Size = new Size(210, 123);
            button4.TabIndex = 3;
            button4.Text = "Distribution of short words";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(1198, 603);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}