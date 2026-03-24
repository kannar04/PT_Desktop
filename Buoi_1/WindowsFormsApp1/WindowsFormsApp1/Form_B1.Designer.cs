namespace WindowsFormsApp1
{
    partial class Form_B1
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
            this.components = new System.ComponentModel.Container();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbListHoTen = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(12, 12);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(115, 20);
            this.txtHoTen.TabIndex = 0;
            this.txtHoTen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(146, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbListHoTen
            // 
            this.lbListHoTen.FormattingEnabled = true;
            this.lbListHoTen.Location = new System.Drawing.Point(12, 65);
            this.lbListHoTen.Name = "lbListHoTen";
            this.lbListHoTen.Size = new System.Drawing.Size(209, 108);
            this.lbListHoTen.TabIndex = 3;
            this.lbListHoTen.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form_B1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 193);
            this.Controls.Add(this.lbListHoTen);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtHoTen);
            this.Name = "Form_B1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_B1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_B1_FormClosing);
        }

        #endregion

        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbListHoTen;
    }
}

