using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi_3
{
    public partial class Form1 : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string ConnectionString = @"Data Source=LAPTOP-OGPMQMFT\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT COUNT(*) FROM HoaDon";
            cmd.CommandType = CommandType.Text;
            cnn.Open();
            //Đếm số hóa đơn 
            int count = (int)cmd.ExecuteScalar();
            txtKetQua.Text = count.ToString();
            cnn.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //cmd.CommandText = "INSERT INTO LoaiSanPham(MaLoai, TenLoai) " +
            //        "VALUES(N'" + txtMaLoai.Text + "', N'" + txtTenLoai.Text + "')";

            //cmd.Parameters.Add("@maLoai", SqlDbType.NVarChar);
            //cmd.Parameters.Add("@tenLoai", SqlDbType.NVarChar);

            //cmd.Parameters[@"maLoai"] = txtMaLoai.Text;
            //cmd.Parameters[@"tenLoai"] = txtTenLoai.Text;

            cmd.Parameters.AddWithValue("@maLoai", txtMaLoai.Text);
            cmd.Parameters.AddWithValue("@tenLoai", txtTenLoai.Text);

            cmd.CommandText = "INSERT INTO LoaiSanPham(MaLoai, TenLoai) " +
                    "VALUES(@maLoai, @tenLoai)";
            cmd.CommandType = CommandType.Text;

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }

        private void btnLoadLoaiSP_Click(object sender, EventArgs e)
        {
            cmd.CommandText ="Select MaSP, TenSP From SanPham";
            cmd.CommandType = CommandType.Text;
            cnn.Open();
            // Thực thi câu truy vấn Select
            SqlDataReader reader = cmd.ExecuteReader();
            //Duyệt trên kết quả reader
            while (reader.Read())
            {
                //Console.WriteLine("San pham: { 0} – { 1}",	 reader.getString(0), reader.getString(1));
                //listLoaiSP.Items.Add(reader.GetString(0) + " - " + reader.GetString(1));
                
            }
            cnn.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cnn.ConnectionString = ConnectionString;
            cmd.Connection = cnn;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable("SanPham");
            table.Columns.Add(new DataColumn("MaSP", Type.GetType("System.String")));
            table.Columns.Add(new DataColumn("TenSP", Type.GetType("System.String")));
            table.PrimaryKey = new DataColumn[] { table.Columns["MaSP"] };
        }
    }
}
