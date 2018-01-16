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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Xeste> listt = Siyahi.getlist();
            foreach (var obj1 in listt)
            {
                obj1.Fullname = textBox1.Text;
                obj1.Phone = textBox2.Text;
                obj1.Xestelik = richTextBox1.Text;
                obj1.date = dateTimePicker1.Text;
                Siyahi.siyahi.Add(obj1);
            }
                 Close();
            
           
        }
    }
}
