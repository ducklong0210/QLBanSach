namespace GUI.FormMaster
{
    partial class tkNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tkNhapHang));
            this.rpvNhapHang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvNhapHang
            // 
            this.rpvNhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvNhapHang.Location = new System.Drawing.Point(0, 0);
            this.rpvNhapHang.Name = "rpvNhapHang";
            this.rpvNhapHang.ServerReport.BearerToken = null;
            this.rpvNhapHang.Size = new System.Drawing.Size(1067, 554);
            this.rpvNhapHang.TabIndex = 2;
            // 
            // tkNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.rpvNhapHang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "tkNhapHang";
            this.Text = "Thống Kê Nhập Hàng";
            this.Load += new System.EventHandler(this.tkNhapHang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvNhapHang;
    }
}