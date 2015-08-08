using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simotest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            int x = 0;
            InitializeComponent();
            var c = x -1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("hi there");
        }
    }
}
