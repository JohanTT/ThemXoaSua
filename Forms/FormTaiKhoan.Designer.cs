
namespace UITest.Forms
{
    partial class FormTaiKhoan
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
            this.MaKhachHangtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TenKhachHangtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SoDienThoaitxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DiaChitxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NgaySinhtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GioiTinhtxt = new System.Windows.Forms.TextBox();
            this.TimTaiKhoanbt = new System.Windows.Forms.Button();
            this.TaiKhoanpanel = new System.Windows.Forms.Panel();
            this.TaiKhoanpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(134, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // MaKhachHangtxt
            // 
            this.MaKhachHangtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaKhachHangtxt.Location = new System.Drawing.Point(263, 12);
            this.MaKhachHangtxt.Name = "MaKhachHangtxt";
            this.MaKhachHangtxt.Size = new System.Drawing.Size(242, 26);
            this.MaKhachHangtxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // TenKhachHangtxt
            // 
            this.TenKhachHangtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenKhachHangtxt.Location = new System.Drawing.Point(151, 76);
            this.TenKhachHangtxt.Name = "TenKhachHangtxt";
            this.TenKhachHangtxt.ReadOnly = true;
            this.TenKhachHangtxt.Size = new System.Drawing.Size(242, 26);
            this.TenKhachHangtxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số Điện Thoại";
            // 
            // SoDienThoaitxt
            // 
            this.SoDienThoaitxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoDienThoaitxt.Location = new System.Drawing.Point(151, 128);
            this.SoDienThoaitxt.Name = "SoDienThoaitxt";
            this.SoDienThoaitxt.ReadOnly = true;
            this.SoDienThoaitxt.Size = new System.Drawing.Size(242, 26);
            this.SoDienThoaitxt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa Chỉ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // DiaChitxt
            // 
            this.DiaChitxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaChitxt.Location = new System.Drawing.Point(151, 185);
            this.DiaChitxt.Name = "DiaChitxt";
            this.DiaChitxt.ReadOnly = true;
            this.DiaChitxt.Size = new System.Drawing.Size(242, 26);
            this.DiaChitxt.TabIndex = 1;
            this.DiaChitxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày Sinh";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // NgaySinhtxt
            // 
            this.NgaySinhtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgaySinhtxt.Location = new System.Drawing.Point(151, 240);
            this.NgaySinhtxt.Name = "NgaySinhtxt";
            this.NgaySinhtxt.ReadOnly = true;
            this.NgaySinhtxt.Size = new System.Drawing.Size(242, 26);
            this.NgaySinhtxt.TabIndex = 1;
            this.NgaySinhtxt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giới Tính";
            // 
            // GioiTinhtxt
            // 
            this.GioiTinhtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GioiTinhtxt.Location = new System.Drawing.Point(151, 292);
            this.GioiTinhtxt.Name = "GioiTinhtxt";
            this.GioiTinhtxt.ReadOnly = true;
            this.GioiTinhtxt.Size = new System.Drawing.Size(242, 26);
            this.GioiTinhtxt.TabIndex = 1;
            // 
            // TimTaiKhoanbt
            // 
            this.TimTaiKhoanbt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.TimTaiKhoanbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimTaiKhoanbt.Location = new System.Drawing.Point(528, 44);
            this.TimTaiKhoanbt.Name = "TimTaiKhoanbt";
            this.TimTaiKhoanbt.Size = new System.Drawing.Size(71, 31);
            this.TimTaiKhoanbt.TabIndex = 2;
            this.TimTaiKhoanbt.Text = "Tìm";
            this.TimTaiKhoanbt.UseVisualStyleBackColor = false;
            this.TimTaiKhoanbt.Click += new System.EventHandler(this.TimTaiKhoanbt_Click);
            // 
            // TaiKhoanpanel
            // 
            this.TaiKhoanpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TaiKhoanpanel.Controls.Add(this.TimTaiKhoanbt);
            this.TaiKhoanpanel.Controls.Add(this.GioiTinhtxt);
            this.TaiKhoanpanel.Controls.Add(this.label6);
            this.TaiKhoanpanel.Controls.Add(this.NgaySinhtxt);
            this.TaiKhoanpanel.Controls.Add(this.label5);
            this.TaiKhoanpanel.Controls.Add(this.DiaChitxt);
            this.TaiKhoanpanel.Controls.Add(this.label4);
            this.TaiKhoanpanel.Controls.Add(this.SoDienThoaitxt);
            this.TaiKhoanpanel.Controls.Add(this.label3);
            this.TaiKhoanpanel.Controls.Add(this.TenKhachHangtxt);
            this.TaiKhoanpanel.Controls.Add(this.label2);
            this.TaiKhoanpanel.Controls.Add(this.MaKhachHangtxt);
            this.TaiKhoanpanel.Controls.Add(this.label1);
            this.TaiKhoanpanel.Location = new System.Drawing.Point(2, 2);
            this.TaiKhoanpanel.Name = "TaiKhoanpanel";
            this.TaiKhoanpanel.Size = new System.Drawing.Size(703, 409);
            this.TaiKhoanpanel.TabIndex = 3;
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(705, 406);
            this.Controls.Add(this.TaiKhoanpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTaiKhoan";
            this.Text = "Tài khoản";
            this.Load += new System.EventHandler(this.FormTaiKhoan_Load);
            this.TaiKhoanpanel.ResumeLayout(false);
            this.TaiKhoanpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaKhachHangtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TenKhachHangtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SoDienThoaitxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DiaChitxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NgaySinhtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox GioiTinhtxt;
        private System.Windows.Forms.Button TimTaiKhoanbt;
        private System.Windows.Forms.Panel TaiKhoanpanel;
    }
}