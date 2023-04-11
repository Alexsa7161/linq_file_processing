namespace WinFormsApp1
{
    partial class Res_first_task
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 159);
            label1.Name = "label1";
            label1.Size = new Size(205, 15);
            label1.TabIndex = 0;
            label1.Text = "Скорость выполнения без LINQ(мс)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(504, 159);
            label2.Name = "label2";
            label2.Size = new Size(193, 15);
            label2.TabIndex = 1;
            label2.Text = "Скорость выполнения с LINQ(мс)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(199, 192);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 2;
            label3.Text = l1.ToString();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(602, 192);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 3;
            label4.Text = l2.ToString();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(310, 56);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 4;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            label5.Text = "Самое длинное слово в папке\n"+s;
            // 
            // button1
            // 
            button1.Location = new Point(349, 323);
            button1.Name = "button1";
            button1.Size = new Size(104, 44);
            button1.TabIndex = 5;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}