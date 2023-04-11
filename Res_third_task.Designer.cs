namespace WinFormsApp1
{
    partial class Res_third_task
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(352, 332);
            button1.Name = "button1";
            button1.Size = new Size(109, 38);
            button1.TabIndex = 0;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 65);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Text = "Скорость выполнения без LINQ(мс)\n"+l1.ToString();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(400, 65);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 2;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Text = "Скорость выполнения с LINQ(мс)\n" + l2.ToString();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 192);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 3;
            
            label3.Text = "Имя первого файла:\n" + s1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 242);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 4;
            
            label4.Text = "имя второго файла:\n" + s2;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}