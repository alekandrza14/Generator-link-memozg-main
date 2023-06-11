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
        public string[] LinkMassive = new string[]
        {
            "https://gamejolt.com/games/Unauticna/682523",
            "https://unauticna.itch.io/unauticna"
        };
        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int i = r.Next(0, LinkMassive.Length);



            webControl1.WebView.LoadUrl(LinkMassive[i]);

            textBox1.Text = LinkMassive[i];

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
