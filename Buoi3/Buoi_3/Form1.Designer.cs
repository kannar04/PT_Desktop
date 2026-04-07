namespace Buoi_3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.listLoaiSP = new System.Windows.Forms.ListView();
            this.btnLoadLoaiSP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(24, 44);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(103, 22);
            this.txtKetQua.TabIndex = 0;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(184, 43);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 1;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Location = new System.Drawing.Point(24, 99);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(100, 22);
            this.txtMaLoai.TabIndex = 2;
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(159, 99);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(100, 22);
            this.txtTenLoai.TabIndex = 3;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(311, 98);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // listLoaiSP
            // 
            this.listLoaiSP.HideSelection = false;
            this.listLoaiSP.Location = new System.Drawing.Point(38, 177);
            this.listLoaiSP.Name = "listLoaiSP";
            this.listLoaiSP.Size = new System.Drawing.Size(377, 125);
            this.listLoaiSP.TabIndex = 5;
            this.listLoaiSP.UseCompatibleStateImageBehavior = false;
            // 
            // btnLoadLoaiSP
            // 
            this.btnLoadLoaiSP.Location = new System.Drawing.Point(143, 148);
            this.btnLoadLoaiSP.Name = "btnLoadLoaiSP";
            this.btnLoadLoaiSP.Size = new System.Drawing.Size(185, 23);
            this.btnLoadLoaiSP.TabIndex = 6;
            this.btnLoadLoaiSP.Text = "Load Loai San Pham";
            this.btnLoadLoaiSP.UseVisualStyleBackColor = true;
            this.btnLoadLoaiSP.Click += new System.EventHandler(this.btnLoadLoaiSP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 314);
            this.Controls.Add(this.btnLoadLoaiSP);
            this.Controls.Add(this.listLoaiSP);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtTenLoai);
            this.Controls.Add(this.txtMaLoai);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txtKetQua);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ListView listLoaiSP;
        private System.Windows.Forms.Button btnLoadLoaiSP;
    }
}

