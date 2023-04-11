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
    public partial class Res_first_task : Form
    {
        public long l1;
        public long l2;
        public string s;
        public Res_first_task(long l1, long l2, string s)
        {
            this.l1 = l1;
            this.l2 = l2;
            this.s = s;
            InitializeComponent();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
