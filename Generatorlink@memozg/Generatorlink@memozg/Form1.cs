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

namespace Generatorlink_memozg
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int i = r.Next(0,2);
            if (i == 0)
            {


                webControl1.WebView.LoadUrl("https://gamejolt.com/games/Unauticna/682523");
            }
            if (i == 1)
            {


                webControl1.WebView.LoadUrl("https://unauticna.itch.io/unauticna");
            }
            textBox1.Text = "+";
            
        }

        private void webView2_CertificateError(object sender, EO.WebBrowser.CertificateErrorEventArgs e)
        {
            /*
            Process p = new Process();
            p.StartInfo.FileName="Generatorlink@memozg.exe";
            p.Start();
            Application.Exit();
            */
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
