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
        // first messageBox was deleted
        int a1=10;
        int a2=20;
        int a3=30;
            MessageBox.Show("Test 10");
            MessageBox.Show("Line1                " + a1.ToString() + "\nLine2                " + a2.ToString() + "\nLine3                " + a3.ToString());
        }

        private void button2_Test2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test 2");
            MessageBox.Show("pokus psat na nekolik radku\ntoto je druhy radek\ntoto je treti radek");
            // uvidime zda nove radky funguji
        }
    }
}
