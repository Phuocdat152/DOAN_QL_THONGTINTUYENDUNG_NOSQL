namespace QL_ThongTinTuyenDung_NoSQL
{
    partial class Frm_Main
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
            this.btn_DSCty = new System.Windows.Forms.Button();
            this.btn_ViecCanTuyen = new System.Windows.Forms.Button();
            this.btn_UngVien = new System.Windows.Forms.Button();
            this.btn_QuanLyTK = new System.Windows.Forms.Button();
            this.btn_SaoLuuPhucHoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_DSCty
            // 
            this.btn_DSCty.Location = new System.Drawing.Point(73, 46);
            this.btn_DSCty.Name = "btn_DSCty";
            this.btn_DSCty.Size = new System.Drawing.Size(127, 55);
            this.btn_DSCty.TabIndex = 0;
            this.btn_DSCty.Text = "Danh sách công ty cần tuyển";
            this.btn_DSCty.UseVisualStyleBackColor = true;
            this.btn_DSCty.Click += new System.EventHandler(this.btn_DSCty_Click);
            // 
            // btn_ViecCanTuyen
            // 
            this.btn_ViecCanTuyen.Location = new System.Drawing.Point(296, 46);
            this.btn_ViecCanTuyen.Name = "btn_ViecCanTuyen";
            this.btn_ViecCanTuyen.Size = new System.Drawing.Size(127, 55);
            this.btn_ViecCanTuyen.TabIndex = 1;
            this.btn_ViecCanTuyen.Text = "Việc cần tuyển";
            this.btn_ViecCanTuyen.UseVisualStyleBackColor = true;
            this.btn_ViecCanTuyen.Click += new System.EventHandler(this.btn_ViecCanTuyen_Click);
            // 
            // btn_UngVien
            // 
            this.btn_UngVien.Location = new System.Drawing.Point(541, 46);
            this.btn_UngVien.Name = "btn_UngVien";
            this.btn_UngVien.Size = new System.Drawing.Size(127, 55);
            this.btn_UngVien.TabIndex = 2;
            this.btn_UngVien.Text = "Ứng viên";
            this.btn_UngVien.UseVisualStyleBackColor = true;
            // 
            // btn_QuanLyTK
            // 
            this.btn_QuanLyTK.Location = new System.Drawing.Point(73, 166);
            this.btn_QuanLyTK.Name = "btn_QuanLyTK";
            this.btn_QuanLyTK.Size = new System.Drawing.Size(127, 55);
            this.btn_QuanLyTK.TabIndex = 3;
            this.btn_QuanLyTK.Text = "Quản lý tài khoản";
            this.btn_QuanLyTK.UseVisualStyleBackColor = true;
            this.btn_QuanLyTK.Click += new System.EventHandler(this.btn_QuanLyTK_Click);
            // 
            // btn_SaoLuuPhucHoi
            // 
            this.btn_SaoLuuPhucHoi.Location = new System.Drawing.Point(296, 166);
            this.btn_SaoLuuPhucHoi.Name = "btn_SaoLuuPhucHoi";
            this.btn_SaoLuuPhucHoi.Size = new System.Drawing.Size(127, 55);
            this.btn_SaoLuuPhucHoi.TabIndex = 4;
            this.btn_SaoLuuPhucHoi.Text = "Sao lưu  Phục hồi";
            this.btn_SaoLuuPhucHoi.UseVisualStyleBackColor = true;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 456);
            this.Controls.Add(this.btn_SaoLuuPhucHoi);
            this.Controls.Add(this.btn_QuanLyTK);
            this.Controls.Add(this.btn_UngVien);
            this.Controls.Add(this.btn_ViecCanTuyen);
            this.Controls.Add(this.btn_DSCty);
            this.Name = "Frm_Main";
            this.Text = "Frm_Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_DSCty;
        private System.Windows.Forms.Button btn_ViecCanTuyen;
        private System.Windows.Forms.Button btn_UngVien;
        private System.Windows.Forms.Button btn_QuanLyTK;
        private System.Windows.Forms.Button btn_SaoLuuPhucHoi;
    }
}