using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0222
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button helloButton = new Button();
            Button saveButton = new Button();
            helloButton.BackColor = Color.LightGray;
            helloButton.ForeColor = Color.DarkGray;
            helloButton.Location = new Point(10, 10);
            helloButton.Text = "Привет";
            this.Controls.Add(helloButton);
            groupBox1.Controls.Add(helloButton);
            saveButton.Text= "11";
            tableLayoutPanel1.Controls.Add(saveButton);
            TabPage newTabPage = new TabPage();
            newTabPage.Text = "Континенты";
            tabControl1.TabPages.Add(newTabPage);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
