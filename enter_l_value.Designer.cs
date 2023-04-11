namespace WinFormsApp1
{
    partial class enter_l_value
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 48);
            label1.Name = "label1";
            label1.Size = new Size(209, 15);
            label1.TabIndex = 0;
            label1.Text = "Введите максимальную длину слова";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(164, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(77, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(152, 179);
            button1.Name = "button1";
            button1.Size = new Size(102, 37);
            button1.TabIndex = 2;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 247);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
    }
}