using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module2BaiSo1_NguyenThanhTung
{
    public partial class ClickMeForm : Form
    {
        public ClickMeForm()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Button was clicked.");
        }

        private void ClickMeForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hi , Welcome to C# 2010 programming!");
        }

        private void ClickMeForm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form was clicked.");
        }
    }
}
