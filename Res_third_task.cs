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
    public partial class Res_third_task : Form
    {
        public static long l1;
        public static long l2;
        public static string s1;
        public static string s2;
        public Res_third_task(long l1, long l2, string s1, string s2)
        {
            Res_third_task.l1 = l1;
            Res_third_task.l2 = l2;
            Res_third_task.s1 = s1;
            Res_third_task.s2 = s2;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
