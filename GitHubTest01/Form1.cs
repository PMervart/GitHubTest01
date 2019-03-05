using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GitHubTest01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Test1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test 1");
        }

        private void button2_Test2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test 2");
        }
    }
}
