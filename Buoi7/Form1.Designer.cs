namespace Buoi_5_C__Advance
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.rtxKQ = new System.Windows.Forms.RichTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnDelegate_Adv = new System.Windows.Forms.Button();
            this.btnCallback = new System.Windows.Forms.Button();
            this.btnLinQ = new System.Windows.Forms.Button();
            this.dataGridViewSP = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSP)).BeginInit();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(17, 16);
            this.txtA.Margin = new System.Windows.Forms.Padding(4);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(88, 22);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(115, 16);
            this.txtB.Margin = new System.Windows.Forms.Padding(4);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(88, 22);
            this.txtB.TabIndex = 1;
            // 
            // rtxKQ
            // 
            this.rtxKQ.Location = new System.Drawing.Point(17, 75);
            this.rtxKQ.Margin = new System.Windows.Forms.Padding(4);
            this.rtxKQ.Name = "rtxKQ";
            this.rtxKQ.Size = new System.Drawing.Size(349, 413);
            this.rtxKQ.TabIndex = 2;
            this.rtxKQ.Text = "";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(247, 16);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Case 1";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnDelegate_Adv
            // 
            this.btnDelegate_Adv.Location = new System.Drawing.Point(355, 16);
            this.btnDelegate_Adv.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelegate_Adv.Name = "btnDelegate_Adv";
            this.btnDelegate_Adv.Size = new System.Drawing.Size(100, 28);
            this.btnDelegate_Adv.TabIndex = 4;
            this.btnDelegate_Adv.Text = "Case 2";
            this.btnDelegate_Adv.UseVisualStyleBackColor = true;
            this.btnDelegate_Adv.Click += new System.EventHandler(this.btnDelegate_Adv_Click);
            // 
            // btnCallback
            // 
            this.btnCallback.Location = new System.Drawing.Point(463, 16);
            this.btnCallback.Margin = new System.Windows.Forms.Padding(4);
            this.btnCallback.Name = "btnCallback";
            this.btnCallback.Size = new System.Drawing.Size(100, 28);
            this.btnCallback.TabIndex = 5;
            this.btnCallback.Text = "Callback";
            this.btnCallback.UseVisualStyleBackColor = true;
            this.btnCallback.Click += new System.EventHandler(this.btnCallback_Click);
            // 
            // btnLinQ
            // 
            this.btnLinQ.Location = new System.Drawing.Point(205, 528);
            this.btnLinQ.Margin = new System.Windows.Forms.Padding(4);
            this.btnLinQ.Name = "btnLinQ";
            this.btnLinQ.Size = new System.Drawing.Size(161, 39);
            this.btnLinQ.TabIndex = 6;
            this.btnLinQ.Text = "Test LinQ";
            this.btnLinQ.UseVisualStyleBackColor = true;
            this.btnLinQ.Click += new System.EventHandler(this.btnLinQ_Click);
            // 
            // dataGridViewSP
            // 
            this.dataGridViewSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSP.Location = new System.Drawing.Point(405, 75);
            this.dataGridViewSP.Name = "dataGridViewSP";
            this.dataGridViewSP.RowHeadersWidth = 51;
            this.dataGridViewSP.RowTemplate.Height = 24;
            this.dataGridViewSP.Size = new System.Drawing.Size(331, 413);
            this.dataGridViewSP.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "TestLinQ2SQL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 601);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewSP);
            this.Controls.Add(this.btnLinQ);
            this.Controls.Add(this.btnCallback);
            this.Controls.Add(this.btnDelegate_Adv);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rtxKQ);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.RichTextBox rtxKQ;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnDelegate_Adv;
        private System.Windows.Forms.Button btnCallback;
        private System.Windows.Forms.Button btnLinQ;
        private System.Windows.Forms.DataGridView dataGridViewSP;
        private System.Windows.Forms.Button button1;
    }
}

