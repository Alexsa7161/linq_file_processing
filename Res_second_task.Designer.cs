namespace WinFormsApp1
{
    partial class Res_second_task
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(275, 133);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(260, 150);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(69, 177);
            button1.Name = "button1";
            button1.Size = new Size(93, 38);
            button1.TabIndex = 1;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 27);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Text = "Скорость выполнения без LINQ(мс)\n" + l1.ToString();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(550, 27);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Text = "Скорость выполнения с LINQ(мс)\n" + l2.ToString();
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}