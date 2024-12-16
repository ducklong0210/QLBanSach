namespace GUI.FormMaster
{
    partial class tkNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tkNhanVien));
            this.rpvNhanVien = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvNhanVien
            // 
            this.rpvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvNhanVien.Location = new System.Drawing.Point(0, 0);
            this.rpvNhanVien.Name = "rpvNhanVien";
            this.rpvNhanVien.ServerReport.BearerToken = null;
            this.rpvNhanVien.Size = new System.Drawing.Size(1067, 554);
            this.rpvNhanVien.TabIndex = 2;
            // 
            // tkNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.rpvNhanVien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "tkNhanVien";
            this.Text = "Thống Kê Tài Khoản Nhân Viên";
            this.Load += new System.EventHandler(this.tkNhanVien_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvNhanVien;
    }
}