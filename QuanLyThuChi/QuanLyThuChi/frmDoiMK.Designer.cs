namespace QuanLyThuChi
{
    partial class frmDoiMK
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TenDN = new System.Windows.Forms.TextBox();
            this.txt_MKcu = new System.Windows.Forms.TextBox();
            this.txt_MKmoi = new System.Windows.Forms.TextBox();
            this.txt_xacnhanMK = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_showPass = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Thoát = new DevExpress.XtraEditors.SimpleButton();
            this.btn_nhaplai = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Luu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(202, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Xác nhận lại mật khẩu";
            // 
            // txt_TenDN
            // 
            this.txt_TenDN.Enabled = false;
            this.txt_TenDN.Location = new System.Drawing.Point(309, 12);
            this.txt_TenDN.Name = "txt_TenDN";
            this.txt_TenDN.Size = new System.Drawing.Size(169, 21);
            this.txt_TenDN.TabIndex = 0;
            // 
            // txt_MKcu
            // 
            this.txt_MKcu.Location = new System.Drawing.Point(309, 47);
            this.txt_MKcu.Name = "txt_MKcu";
            this.txt_MKcu.Size = new System.Drawing.Size(169, 21);
            this.txt_MKcu.TabIndex = 1;
            this.txt_MKcu.UseSystemPasswordChar = true;
            // 
            // txt_MKmoi
            // 
            this.txt_MKmoi.Location = new System.Drawing.Point(309, 80);
            this.txt_MKmoi.Name = "txt_MKmoi";
            this.txt_MKmoi.Size = new System.Drawing.Size(169, 21);
            this.txt_MKmoi.TabIndex = 2;
            this.txt_MKmoi.UseSystemPasswordChar = true;
            // 
            // txt_xacnhanMK
            // 
            this.txt_xacnhanMK.Location = new System.Drawing.Point(309, 116);
            this.txt_xacnhanMK.Name = "txt_xacnhanMK";
            this.txt_xacnhanMK.Size = new System.Drawing.Size(169, 21);
            this.txt_xacnhanMK.TabIndex = 3;
            this.txt_xacnhanMK.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyThuChi.Properties.Resources.key;
            this.pictureBox1.Location = new System.Drawing.Point(12, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 146);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = global::QuanLyThuChi.Properties.Resources.eye;
            this.simpleButton2.Location = new System.Drawing.Point(484, 116);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(22, 18);
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::QuanLyThuChi.Properties.Resources.eye;
            this.simpleButton1.Location = new System.Drawing.Point(484, 80);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(22, 18);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_showPass
            // 
            this.btn_showPass.ImageOptions.Image = global::QuanLyThuChi.Properties.Resources.eye;
            this.btn_showPass.Location = new System.Drawing.Point(484, 47);
            this.btn_showPass.Name = "btn_showPass";
            this.btn_showPass.Size = new System.Drawing.Size(22, 18);
            this.btn_showPass.TabIndex = 8;
            this.btn_showPass.Click += new System.EventHandler(this.btn_showPass_Click);
            // 
            // btn_Thoát
            // 
            this.btn_Thoát.ImageOptions.Image = global::QuanLyThuChi.Properties.Resources.exit1;
            this.btn_Thoát.Location = new System.Drawing.Point(403, 153);
            this.btn_Thoát.Name = "btn_Thoát";
            this.btn_Thoát.Size = new System.Drawing.Size(84, 36);
            this.btn_Thoát.TabIndex = 7;
            this.btn_Thoát.Text = "Thoát";
            this.btn_Thoát.Click += new System.EventHandler(this.btn_Thoát_Click);
            // 
            // btn_nhaplai
            // 
            this.btn_nhaplai.ImageOptions.Image = global::QuanLyThuChi.Properties.Resources.revert;
            this.btn_nhaplai.Location = new System.Drawing.Point(309, 153);
            this.btn_nhaplai.Name = "btn_nhaplai";
            this.btn_nhaplai.Size = new System.Drawing.Size(86, 36);
            this.btn_nhaplai.TabIndex = 6;
            this.btn_nhaplai.Text = "Nhập lại";
            this.btn_nhaplai.Click += new System.EventHandler(this.btn_nhaplai_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.ImageOptions.Image = global::QuanLyThuChi.Properties.Resources.luu;
            this.btn_Luu.Location = new System.Drawing.Point(213, 153);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(89, 36);
            this.btn_Luu.TabIndex = 5;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // frmDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 201);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btn_showPass);
            this.Controls.Add(this.btn_Thoát);
            this.Controls.Add(this.btn_nhaplai);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.txt_xacnhanMK);
            this.Controls.Add(this.txt_MKmoi);
            this.Controls.Add(this.txt_MKcu);
            this.Controls.Add(this.txt_TenDN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDoiMK";
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmDoiMK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TenDN;
        private System.Windows.Forms.TextBox txt_MKcu;
        private System.Windows.Forms.TextBox txt_MKmoi;
        private System.Windows.Forms.TextBox txt_xacnhanMK;
        private DevExpress.XtraEditors.SimpleButton btn_Luu;
        private DevExpress.XtraEditors.SimpleButton btn_nhaplai;
        private DevExpress.XtraEditors.SimpleButton btn_Thoát;
        private DevExpress.XtraEditors.SimpleButton btn_showPass;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}