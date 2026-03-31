using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBoxNhapTen_TextChanged(object sender, EventArgs e)
        {
            txtKetQua.Text = txtNhapTen.Text;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked & chkAuto.Checked)
                txtKetQua.ForeColor = Color.Red;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if(radGreen.Checked & chkAuto.Checked)
                txtKetQua.ForeColor = Color.Green;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if(radBlue.Checked & chkAuto.Checked)
                txtKetQua.ForeColor = Color.Blue;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if(radBlack.Checked & chkAuto.Checked)
                txtKetQua.ForeColor = Color.Black;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBold.Checked & chkAuto.Checked)
                txtKetQua.Font = new Font(txtKetQua.Font, FontStyle.Bold);
            else
                txtKetQua.Font = new Font(txtKetQua.Font, FontStyle.Regular);
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            if(chkItalic.Checked & chkAuto.Checked)
                txtKetQua.Font = new Font(txtKetQua.Font, FontStyle.Italic);
            else
                txtKetQua.Font = new Font(txtKetQua.Font, FontStyle.Regular);
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            if(chkUnderline.Checked & chkAuto.Checked)
                txtKetQua.Font = new Font(txtKetQua.Font, FontStyle.Underline);
            else
                txtKetQua.Font = new Font(txtKetQua.Font, FontStyle.Regular);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = txtNhapTen.Text;

            if (radRed.Checked) txtKetQua.ForeColor = Color.Red;
            if (radGreen.Checked) txtKetQua.ForeColor = Color.Green;
            if (radBlue.Checked) txtKetQua.ForeColor = Color.Blue;
            if (radBlack.Checked) txtKetQua.ForeColor = Color.Black;

            if (chkBold.Checked) txtKetQua.Font = new Font(txtKetQua.Font, FontStyle.Bold);
            else txtKetQua.Font = new Font(txtKetQua.Font, FontStyle.Regular);

            if (chkItalic.Checked) txtKetQua.Font = new Font(txtKetQua.Font, FontStyle.Italic);
            else txtKetQua.Font = new Font(txtKetQua.Font, FontStyle.Regular);

            if (chkUnderline.Checked) txtKetQua.Font = new Font(txtKetQua.Font, FontStyle.Underline);
            else txtKetQua.Font = new Font(txtKetQua.Font, FontStyle.Regular);
        }

        private void chkAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAuto.Checked)
            {
                btnApply_Click(sender, e);
            }
        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {
            txtNhapTen.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }
    }
}

