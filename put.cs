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
            //TODO: Code for reading file//
            //parent.put(title, contents, sender, e)
            this.Close();
        }
    }
}
