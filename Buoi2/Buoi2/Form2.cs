using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox2.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            if (listBox1.Items.IndexOf(txtInput.Text) < 0 && txtInput.Text.Length > 0)
            {
                listBox1.Items.Insert(0, input);
                txtInput.Clear();
                txtInput.Focus();
            }
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            int count = listBox1.SelectedIndices.Count;

            for (int i = count - 1; i >= 0; i--)
            {
                int index = listBox1.SelectedIndices[i];
                listBox1.Items.RemoveAt(index);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                txtInput.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
            }
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            int count = listBox1.SelectedIndices.Count;

            for (int i = count - 1; i >= 0; i--)
            {
                int selectedIndex = listBox1.SelectedIndices[i];
                object selectedItem = listBox1.Items[selectedIndex];

                listBox2.Items.Add(selectedItem);
                listBox1.Items.RemoveAt(selectedIndex);
            }

            xoaTrung();
        }

        private void btnMoveAllRight_Click(object sender, EventArgs e)
        {
            int totalItems = listBox1.Items.Count;

            for (int i = 0; i < totalItems; i++)
            {
                object item = listBox1.Items[i];
                listBox2.Items.Add(item);
            }

            listBox1.Items.Clear();

            xoaTrung();
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            int count = listBox2.SelectedIndices.Count;

            for (int i = count - 1; i >= 0; i--)
            {
                int selectedIndex = listBox2.SelectedIndices[i];
                object selectedItem = listBox2.Items[selectedIndex];

                listBox1.Items.Add(selectedItem);
                listBox2.Items.RemoveAt(selectedIndex);
            }
        }

        private void btnMoveAllLeft_Click(object sender, EventArgs e)
        {
            int totalItems = listBox2.Items.Count;

            for (int i = 0; i < totalItems; i++)
            {
                object item = listBox2.Items[i];
                listBox1.Items.Add(item);
            }

            listBox2.Items.Clear();
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            int count = listBox2.SelectedIndices.Count;

            for (int i = count - 1; i >= 0; i--)
            {
                int index = listBox2.SelectedIndices[i];
                listBox2.Items.RemoveAt(index);
            }
        }

        private void xoaTrung()
        {
            for (int i = 1; i < listBox2.Items.Count; i++)
            {
                if (listBox2.Items.IndexOf(listBox2.Items[i]) < i
                    && listBox2.Items.IndexOf(listBox2.Items[i]) > -1)
                {
                    listBox2.Items.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}