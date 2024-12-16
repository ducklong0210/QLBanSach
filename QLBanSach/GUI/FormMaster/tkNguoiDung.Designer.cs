namespace GUI.FormMaster
{
    partial class tkNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tkNguoiDung));
            this.rpvNguoiDung = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvNguoiDung
            // 
            this.rpvNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvNguoiDung.Location = new System.Drawing.Point(0, 0);
            this.rpvNguoiDung.Name = "rpvNguoiDung";
            this.rpvNguoiDung.ServerReport.BearerToken = null;
            this.rpvNguoiDung.Size = new System.Drawing.Size(800, 450);
            this.rpvNguoiDung.TabIndex = 1;
            // 
            // tkNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvNguoiDung);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tkNguoiDung";
            this.Text = "Thống Kê Tài Khoản Người Dùng";
            this.Load += new System.EventHandler(this.tkNguoiDung_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvNguoiDung;
    }
}