using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Example_6_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //---------------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.Black;
            this.FormBorderStyle = FormBorderStyle.None;
            timer1.Interval = 1;
            timer1.Start();
        }
        //---------------------------------------------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            Label l = new Label();
            Random r = new Random(DateTime.Now.Millisecond);
            int x, y;
            l.AutoSize = true;
            l.ForeColor = Color.White;
            l.Text = ".";
            l.Font = new System.Drawing.Font(l.Font.FontFamily, 30);
            x = r.Next(this.Width);
            y = r.Next(this.Height);
            l.Location = new Point(x,y);
            l.Click += new EventHandler(this.Form1_Click);
            this.Controls.Add(l);
        }
        //---------------------------------------------------------------------
        private void Form1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
