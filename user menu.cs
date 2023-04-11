using System.Diagnostics;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Practice3";
            MaximumSize = new System.Drawing.Size(2000, 1000);
            MinimumSize = new System.Drawing.Size(1000, 700);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.White;
            Width = 250;
            Height = 250;
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
            {
                string path = folderBrowserDialog1.SelectedPath;
                Stopwatch stopWatch1 = new Stopwatch();
                stopWatch1.Start();
                NOWithLINQ n = new NOWithLINQ();
                n.LongestWord(path);
                stopWatch1.Stop();
                Stopwatch stopWatch2 = new Stopwatch();
                stopWatch2.Start();
                WithLINQ w = new WithLINQ();
                string res = w.LongestWord(path);
                stopWatch2.Stop();
                Res_first_task f = new Res_first_task(stopWatch1.ElapsedMilliseconds, stopWatch2.ElapsedMilliseconds, res);
                f.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 th = new Form3();
            th.ShowDialog();
            int N = Form3.NForm3_Return();
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
            {
                string path = folderBrowserDialog1.SelectedPath;
                Stopwatch stopWatch1 = new Stopwatch();
                stopWatch1.Start();
                NOWithLINQ n = new NOWithLINQ();
                n.Frequently_words(path, N);
                stopWatch1.Stop();
                Stopwatch stopWatch2 = new Stopwatch();
                stopWatch2.Start();
                WithLINQ w = new WithLINQ();
                Dictionary<string, int> res =  w.Frequently_words(path, N);
                stopWatch2.Stop();
                Res_second_task f = new Res_second_task(stopWatch1.ElapsedMilliseconds, stopWatch2.ElapsedMilliseconds, res);
                f.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
            {
                string path = folderBrowserDialog1.SelectedPath;
                string res1;
                string res2;
                Stopwatch stopWatch1 = new Stopwatch();
                stopWatch1.Start();
                NOWithLINQ n = new NOWithLINQ();
                n.SpecificFile(path);
                stopWatch1.Stop();
                Stopwatch stopWatch2 = new Stopwatch();
                stopWatch2.Start();
                WithLINQ w = new WithLINQ();
                (res1, res2) = w.SpecificFile(path);
                stopWatch2.Stop();
                Res_third_task f = new Res_third_task(stopWatch1.ElapsedMilliseconds, stopWatch2.ElapsedMilliseconds, res1, res2);
                f.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            enter_l_value th = new enter_l_value();
            th.ShowDialog();
            int L = enter_l_value.Form6_Return();
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
            {
                string path = folderBrowserDialog1.SelectedPath;
                Stopwatch stopWatch1 = new Stopwatch();
                stopWatch1.Start();
                NOWithLINQ n = new NOWithLINQ();
                n.Frequently_Short_words(path, L);
                stopWatch1.Stop();
                Stopwatch stopWatch2 = new Stopwatch();
                stopWatch2.Start();
                WithLINQ w = new WithLINQ();
                Dictionary<string, int> res = w.Frequently_Short_words(path, L);
                stopWatch2.Stop();
                Res_fourth_task f = new Res_fourth_task(stopWatch1.ElapsedMilliseconds, stopWatch2.ElapsedMilliseconds, res);
                f.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}