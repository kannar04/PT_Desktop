using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi_5_C__Advance
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void LoadSP()
        {
            QLBH_DBDataContext data = new QLBH_DBDataContext();
            var listsanpham = from sp in data.SanPhams
                              select new
                              {
                                  MaSP = sp.MaSP,
                                  TenSP = sp.TenSP,
                                  DVT = sp.DVTinh,
                                  DonGia = sp.DonGia,
                                  MaLoai = sp.MaLoai,
                              };

            dataGridViewSP.DataSource = listsanpham;

        }

        private void InsertSP(SanPham sp)
        {
            QLBH_DBDataContext dbQLBH = new QLBH_DBDataContext();

            dbQLBH.SanPhams.InsertOnSubmit(sp);
            dbQLBH.SubmitChanges();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadLaiSPComboBox();
            LoadSP();
            
        }

        private void LoadLaiSPComboBox()
        {
            QLBH_DBDataContext dbQLBH = new QLBH_DBDataContext();
            var listSp = from sp in dbQLBH.LoaiSanPhams
                         select new
                         {
                             MaLoai = sp.MaLoai,
                             TenLoai = sp.TenLoai
                         };
            cbLoaiSP.DataSource = listSp;
            cbLoaiSP.DisplayMember = "TenLoai";
            cbLoaiSP.ValueMember = "MaLoai";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Bỏ qua kiểm tra trùng mã
            SanPham sp = new SanPham();
            sp.MaSP = txtMaSP.Text;
            sp.TenSP = txtTenSP.Text;
            sp.DVTinh = txtDVT.Text;
            sp.DonGia = int.Parse(txtDonGia.Text);
            sp.MaLoai = cbLoaiSP.SelectedValue.ToString();

            InsertSP(sp);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadSP();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtDVT.Text = "";
            txtDonGia.Text = "";
            cbLoaiSP.SelectedIndex = -1;
        }

        private void dataGridViewSP_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = dataGridViewSP.Rows[dataGridViewSP.CurrentRow.Index].Cells[0].Value.ToString();
            txtTenSP.Text = dataGridViewSP.Rows[dataGridViewSP.CurrentRow.Index].Cells[1].Value.ToString();
            txtDVT.Text = dataGridViewSP.Rows[dataGridViewSP.CurrentRow.Index].Cells[2].Value.ToString();
            txtDonGia.Text = dataGridViewSP.Rows[dataGridViewSP.CurrentRow.Index].Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            QLBH_DBDataContext dbQLBH = new QLBH_DBDataContext();

            var sp = dbQLBH.SanPhams.Where(x => x.MaSP == txtMaSP.Text).FirstOrDefault();
            if (sp != null)
            {
                sp.TenSP = txtTenSP.Text;
                sp.DVTinh = txtDVT.Text;
                sp.DonGia = int.Parse(txtDonGia.Text);
                sp.MaLoai = cbLoaiSP.SelectedValue.ToString();
            }

            dbQLBH.SubmitChanges();
            LoadSP();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu khỏi dataGridView
            QLBH_DBDataContext dbQLBH = new QLBH_DBDataContext();

            var sp = dbQLBH.SanPhams.Where(x => x.MaSP == txtMaSP.Text).FirstOrDefault();
            if (sp != null)
            {
                dbQLBH.SanPhams.DeleteOnSubmit(sp);
                dbQLBH.SubmitChanges();

                LoadSP();

                // Reset form sau khi xóa
                txtMaSP.Text = "";
                txtTenSP.Text = "";
                txtDVT.Text = "";
                txtDonGia.Text = "";
                cbLoaiSP.SelectedIndex = -1;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Tìm sản phẩm dựa vào tên sản phẩm và kết quả trả về là datagridview
            string keyword = txtSearch.Text.Trim().ToLower();

            QLBH_DBDataContext dbQLBH = new QLBH_DBDataContext();

            var listSanPham = from sp in dbQLBH.SanPhams
                              where sp.TenSP.ToLower().Contains(keyword)
                              select new
                              {
                                  MaSP = sp.MaSP,
                                  TenSP = sp.TenSP,
                                  DVT = sp.DVTinh,
                                  DonGia = sp.DonGia,
                                  MaLoai = sp.MaLoai,
                              };

            if (listSanPham.Any())
            {
                dataGridViewSP.DataSource = listSanPham;
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSP(); 
            }
        }
    }
}
