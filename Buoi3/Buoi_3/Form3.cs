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
    public partial class Form3 : Form
    {
        DataSet ds = new DataSet();
        string cnnStr = @"Data Source=LAPTOP-OGPMQMFT\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True;";
        SqlConnection cnn= new SqlConnection();
        SqlCommand cmd;

        SqlDataAdapter da;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            cnn.ConnectionString = cnnStr;
            cnn.Open();
            cmd = new SqlCommand("select * from SanPham", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds, "SP");
            cnn.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "SP";
        }
    }
}
