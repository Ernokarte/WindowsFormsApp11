using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form3 obj2 = new Form3();
            obj2.ShowDialog();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="Admin" && textBox2.Text == "12345")
            {
                menuStrip1.Items[0].Visible = true;
                
            }
            else
            {
                MessageBox.Show("Login ve ya sifre duzgun yigilmayib!!");
            }
        }

        
    }
    class Xeste
    {
        public string Fullname { get; set; }
        public string Phone { get; set; }
        public string Xestelik { get; set; }
        public string date { get; set; }
    }
    class Siyahi
    {
        public static List<Xeste> siyahi = new List<Xeste>();
        public static List<Xeste> getlist()
        {
            return siyahi;
        }
    }
}
