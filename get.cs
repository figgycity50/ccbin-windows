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
    public partial class get : Form
    {
        public get()
        {
            InitializeComponent();
        }

        public main parent = null;
        public get setParent(main par)
        {
            this.parent = par;
            return this;
        }
       
        private void getPasteButton_Click(object sender, EventArgs e)
        {
            parent.get(textBox1.Text, sender, e);
            this.Close();
        }
    }
}
