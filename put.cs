using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCBin
{
    public partial class put : Form
    {
        public put()
        {
            InitializeComponent();
        }

        public main parent = null;
        public put setParent(main par)
        {
            this.parent = par;
            return this;
        }
       
        private void putFileButton_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader sr = new System.IO.StreamReader(filePath.Text);
            parent.put(titleTextBox.Text, sr.ReadToEnd(), sender, e);
            sr.Close();
            this.Close();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath.Text = openFileDialog1.FileName;
            }
        }
    }
}
