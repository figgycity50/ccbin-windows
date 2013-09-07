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
    public partial class links : Form
    {
        public links()
        {
            InitializeComponent();
        }
        
        public main parent = null;
        public links setParent(main par, string str, int w, int h)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(links));
            this.parent = par;
            richTextBox1.Text = resources.GetString(str);
            this.Size = new System.Drawing.Size(w, h);
            this.Text = str;
            this.MaximumSize = new System.Drawing.Size(w, h);
            this.MinimumSize = new System.Drawing.Size(w, h);
            return this;
        }
    }
}
