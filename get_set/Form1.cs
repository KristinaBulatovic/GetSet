using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace get_set
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            //var r = form2.ShowDialog();
            //if (r == DialogResult.OK)
            //{ }

            form2.ShowDialog();

            string s = form2.a;
            label1.Text = s;
            textBox1.Text = s;
            button1.Text = s;
        }
    }
}
