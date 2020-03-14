using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParameterShower
{
    public partial class Form1 : Form
    {
        private string[] args;

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 230);
            this.textBox1.TabIndex = 0;
            this.textBox1.Multiline = true;
            foreach (string arg in args) {
                this.textBox1.Text += arg + Environment.NewLine;
            }
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public Form1(string[] args)
        {
            this.args = args;
            InitializeComponent();
        }
    }
}
