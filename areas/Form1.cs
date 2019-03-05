using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace areas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double width = 0.0;
            try
            {
                width = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show(textBox1.Text + "ah ah jidey");
                width = 0.0;
            }
            double height = 0.0;
             try
            {
                height = double.Parse(textBox2.Text);
            }
             catch
            {
                MessageBox.Show(textBox2.Text + "lad it NOT SUPOSED TO BE A NUMBER");
                height = 0.0;
            }
            
            double area = width * height;
            textBox3.AppendText(area.ToString());


        }
    }
}
