using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace CCBin
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            
        }

        private string readURL(object sender, EventArgs e, string sURL) //returns contents of sURL
        {
            WebRequest wrGETURL = WebRequest.Create(sURL);
            return new StreamReader( wrGETURL.GetResponse().GetResponseStream() ).ReadToEnd();
        }

        private void getPaste(object sender, EventArgs e)
        {
            string sURL = "http://figgycity50.kd.io/ccbin/raw.php?id=" + pasteID.Text;
            richTextBox1.Text = readURL(sender, e, sURL);
            pasteIDLabel.Text = "Title";
            /*NotGoodTimes:
            string title = readURL(sender, e, sURL + "&mode=title");
            if (title == richTextBox1.Text) pasteID.Text = "Outdated Server: figgycity didn't merged Egor's pull request.";
            else pasteID.Text = title;
            /**/

            /*GoodTimes:*/
            pasteID.Text = readURL(sender, e, sURL + "&mode=title");
            /**/
        }

        public void get(string id, object sender, EventArgs e)
        {
            comboBoxMode.Text = "GET";
            comboBoxMode_TextUpdate(sender, e);
            pasteID.Text = id;
            doSomething(sender, e);
        }

        private void newPaste(object sender, EventArgs e)
        {
            // Create a request using a URL that can receive a post. 
            WebRequest request = WebRequest.Create("http://figgycity50.kd.io/ccbin/api.php");
            // Set the Method property of the request to POST.
            request.Method = "POST";
            // Create POST data and convert it to a byte array.
            string postData = "type=make&title="+ pasteID.Text +"&paste=" + richTextBox1.Text;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            // Set the ContentType property of the WebRequest.
            request.ContentType = "application/x-www-form-urlencoded";
            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;
            // Get the request stream.
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.
            dataStream.Close();
            // Get the response.
            WebResponse response = request.GetResponse();
            dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            pasteIDLabel.Text = "Paste ID";
            pasteID.Text = responseFromServer;
        }

        public void put(string title, string contents, object sender, EventArgs e)
        {
            comboBoxMode.Text = "GET";
            comboBoxMode_TextUpdate(sender, e);
            pasteID.Text = title;
            richTextBox1.Text = contents;
            doSomething(sender, e);
        }

        private void doSomething(object sender, EventArgs e)
        {
            if (comboBoxMode.Text.ToLower() == "get") getPaste(sender, e);
            else if (comboBoxMode.Text.ToLower() == "put") newPaste(sender, e);
            else MessageBox.Show("Wrong Mode!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void comboBoxMode_TextUpdate(object sender, EventArgs e)
        {
            if (comboBoxMode.Text.ToLower() == "get")
            {
                pasteIDLabel.Text = "Paste ID";
                pasteID.MaxLength = 6;
            }
            else if (comboBoxMode.Text.ToLower() == "put")
            {
                pasteIDLabel.Text = "Title";
                pasteID.MaxLength = 0;
            }
            else
            {
                pasteIDLabel.Text = "?????";
                pasteID.MaxLength = 0;
            }
        }

        private void main_Resize(object sender, EventArgs e)
        {
            pasteID.Width = 630 + this.Width - 800;
        }

        /*menuHelp*/
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Not yet implemented!", "NYI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            new links().setParent(this, "Help", 155, 65).Show();
        }

        private void linksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new links().setParent(this, "Links", 300, 300).Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CCBin for Windows by figgycity50 and Egor305", "About CCBin for Windows", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /*menuFile*/
        private void getToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new get().setParent(this).Show();
        }
        
        private void putToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new put().setParent(this).Show();
        }

        private void modeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBoxMode.Text.ToLower() == "put")
            {
                comboBoxMode.Text = "GET";
                comboBoxMode_TextUpdate(sender, e);
            }
            else if (comboBoxMode.Text.ToLower() == "get")
            {
                comboBoxMode.Text = "PUT";
                comboBoxMode_TextUpdate(sender, e);
            }
            else
            {
                comboBoxMode.Text = "PUT";
                comboBoxMode_TextUpdate(sender, e);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }
    }
}
