using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Res_fourth_task : Form
    {
        public static long l1;
        public static long l2;
        public static Dictionary<string, int> res;
        public Res_fourth_task(long l1, long l2, Dictionary<string,int> res)
        {
            Res_fourth_task.l1 = l1;
            Res_fourth_task.l2 = l2;
            Res_fourth_task.res = res;
            InitializeComponent();
            MaximumSize = new System.Drawing.Size(1000, 500);
            MinimumSize = new System.Drawing.Size(500, 350);
            dataGridView1.Columns.Add("слово", "слово");
            dataGridView1.Columns.Add("частота появления", "частота появления");
            foreach (var r in res)
            {
                dataGridView1.Rows.Add(r.Key, r.Value);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
