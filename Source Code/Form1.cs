using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTAOpener
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OpenFileDialog x = new OpenFileDialog();
            x.Title = "Open HTML Files";
            x.Filter = "html files (*.html)|*.html";
            if (x.ShowDialog() == DialogResult.OK)
            {
                Process.Start("mshta", x.FileName);
            }
            Environment.Exit(0);
        }
    }
}
