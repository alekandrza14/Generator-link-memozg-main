
namespace Generatorlink_memozg
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.webControl1 = new EO.WinForm.WebControl();
            this.webView2 = new EO.WebBrowser.WebView();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(510, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 17000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // webControl1
            // 
            this.webControl1.AllowDrop = true;
            this.webControl1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.webControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.webControl1.Location = new System.Drawing.Point(0, 0);
            this.webControl1.Name = "webControl1";
            this.webControl1.Size = new System.Drawing.Size(689, 503);
            this.webControl1.TabIndex = 5;
            this.webControl1.Text = "webControl1";
            this.webControl1.WebView = this.webView2;
            // 
            // webView2
            // 
            this.webView2.AllowDropLoad = false;
            this.webView2.InputMsgFilter = null;
            this.webView2.JSInitCode = "";
            this.webView2.ObjectForScripting = null;
            this.webView2.Title = null;
            this.webView2.CertificateError += new EO.WebBrowser.CertificateErrorHandler(this.webView2_CertificateError);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(689, 503);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.webControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ViewMiner";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private EO.WinForm.WebControl webControl1;
        private EO.WebBrowser.WebView webView2;
    }
}

