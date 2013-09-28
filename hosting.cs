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
    public partial class hosting : Form
    {
        public hosting()
        {
            InitializeComponent();
        }
        public main parent = null;
        public hosting setParent(main par)
        {
            this.parent = par;
            textBox1.Text = parent.sBaseUrl;
            return this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.sBaseUrl = textBox1.Text;
            this.Close();
        }
    }
}
