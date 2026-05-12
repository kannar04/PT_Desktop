using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi8
{
    public partial class Form1 : Form
    {
        QLBHEntities db;
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadSanPham()
        {
            QLBHEntities db = new QLBHEntities();
            var listSP = (from sp in db.SanPhams
                          select new
                          {
                              MaSP = sp.MaSP,
                              TenSP = sp.TenSP,
                              DVT = sp.DVTinh,
                              DonGia = sp.DonGia,
                              MaLoai = sp.MaLoai,
                              TenLoai = sp.LoaiSanPham.TenLoai,
                          }).ToList();

            DGV_SP.DataSource = listSP;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadSanPham();
            DataBiding();
        }

        internal void DataBiding()
        {
            txtMaSP.DataBindings.Add(new Binding("Text", DGV_SP.DataSource, "MaSP", true, DataSourceUpdateMode.Never));
            txtTenSP.DataBindings.Add(new Binding("Text", DGV_SP.DataSource, "TenSP", true, DataSourceUpdateMode.Never));
            txtDVT.DataBindings.Add(new Binding("Text", DGV_SP.DataSource, "DVT", true, DataSourceUpdateMode.Never));
            txtDGiA.DataBindings.Add(new Binding("Text", DGV_SP.DataSource, "DonGia", true, DataSourceUpdateMode.Never));
            cboLoaiSP.DataBindings.Add(new Binding("SelectedValue", DGV_SP.DataSource, "MaLoai", true, DataSourceUpdateMode.Never));
        }

        private void InsertSanPham()
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                SanPham sp = new SanPham();
                sp.MaSP = txtMaSP.Text;
                sp.TenSP = txtTenSP.Text;
                sp.DVTinh = txtDVT.Text;
                sp.DonGia = int.Parse(txtDGiA.Text);
                sp.MaLoai = cboLoaiSP.SelectedValue.ToString();

                db.SanPhams.Add(sp);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Khong Insert được", "Insert Error", MessageBoxButtons.OK);
                }
            }    
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            InsertSanPham();
            LoadSanPham();
        }

        private void LoadLoaiSPCombox()
        {
            QLBHEntities db = new QLBHEntities();
            var listLoaiSP = (from lsp in db.LoaiSanPhams
                              select new
                              {
                                  MaLoai = lsp.MaLoai,
                                  TenLoai = lsp.TenLoai,
                              }).ToList();
            cboLoaiSP.DataSource = listLoaiSP;
            cboLoaiSP.DisplayMember = "TenLoai";
            cboLoaiSP.ValueMember = "MaLoai";
        }

        private void UpdateSanPham()
        {
            QLBHEntities db = new QLBHEntities();

            SanPham sp = db.SanPhams.Find(txtMaSP.Text);
            if (sp != null)
            {
                sp.TenSP = txtTenSP.Text;
                sp.DVTinh = txtDVT.Text;
                sp.DonGia = int.Parse(txtDGiA.Text);
                sp.MaLoai = cboLoaiSP.SelectedValue.ToString();
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Khong Update được", "Update Error", MessageBoxButtons.OK);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateSanPham();
            LoadSanPham();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadLoaiSPCombox();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            QLBHEntities db = new QLBHEntities();
            db.Dispose();
        }

        private void XoaSanPham()
        {
            QLBHEntities db = new QLBHEntities();
            
            var sp = db.SanPhams.Find(txtMaSP.Text);
            if (sp != null)
            {
                db.SanPhams.Remove(sp);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Khong Xoa được", "Delete Error", MessageBoxButtons.OK);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            XoaSanPham();
            LoadSanPham();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string input = txtTim.Text.Trim().ToLower();

            QLBHEntities db = new QLBHEntities();
            var listSP = (from sp in db.SanPhams
                          where sp.TenSP.ToLower().Contains(input)
                          select new
                          {
                              MaSP = sp.MaSP,
                              TenSP = sp.TenSP,
                              DVT = sp.DVTinh,
                              DonGia = sp.DonGia,
                              MaLoai = sp.MaLoai,
                              TenLoai = sp.LoaiSanPham.TenLoai,
                          }).ToList();

            DGV_SP.DataSource = listSP;
        }
    }
}
