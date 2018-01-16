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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Xeste obj3 = new Xeste();
            ListViewItem item = new ListViewItem();
            item.SubItems.Add(obj3.Fullname);
            item.SubItems.Add(obj3.Phone);
            item.SubItems.Add(obj3.Xestelik);
            item.SubItems.Add(obj3.date);
            listView1.Items.Add(item);

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
