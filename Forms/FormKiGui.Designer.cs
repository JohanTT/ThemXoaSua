
namespace UITest.Forms
{
    partial class FormKiGui
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
            this.KiGuiGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.KiGuiGV)).BeginInit();
            this.SuspendLayout();
            // 
            // KiGuiGV
            // 
            this.KiGuiGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(193)))));
            this.KiGuiGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KiGuiGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KiGuiGV.Location = new System.Drawing.Point(0, 0);
            this.KiGuiGV.Name = "KiGuiGV";
            this.KiGuiGV.Size = new System.Drawing.Size(705, 406);
            this.KiGuiGV.TabIndex = 0;
            // 
            // FormKiGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(705, 406);
            this.Controls.Add(this.KiGuiGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKiGui";
            this.Text = "Kí gửi";
            this.Load += new System.EventHandler(this.FormKiGui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KiGuiGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView KiGuiGV;
    }
}