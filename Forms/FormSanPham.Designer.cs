
namespace UITest.Forms
{
    partial class FormSanPham
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
            this.SanPhamGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamGV)).BeginInit();
            this.SuspendLayout();
            // 
            // SanPhamGV
            // 
            this.SanPhamGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(193)))));
            this.SanPhamGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SanPhamGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SanPhamGV.Location = new System.Drawing.Point(0, 0);
            this.SanPhamGV.Name = "SanPhamGV";
            this.SanPhamGV.Size = new System.Drawing.Size(721, 445);
            this.SanPhamGV.TabIndex = 0;
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(721, 445);
            this.Controls.Add(this.SanPhamGV);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSanPham";
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.FormSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SanPhamGV;
    }
}