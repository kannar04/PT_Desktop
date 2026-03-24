using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormTong : Form
    {
        public FormTong()
        {
            InitializeComponent();
            label3.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int number = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);

            label3.Text = number.ToString();
            label3.Visible = true; 

        }

        private void FormTong_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you really want to close?", "Demo Form",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void FormTong_Load(object sender, EventArgs e)
        {

        }


    }
}
