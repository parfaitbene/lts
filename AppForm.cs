using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LTS2.Forms;

namespace LTS2
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void magasinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWarehouse fw = new FormWarehouse();
            fw.Show();
        }
    }
}
