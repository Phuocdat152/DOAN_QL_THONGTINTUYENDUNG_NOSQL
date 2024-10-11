namespace QL_ThongTinTuyenDung_NoSQL
{
    partial class Frm_TaiKhoan
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
            this.gB_DSTaiKhoan = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gB_TaiKhoan = new System.Windows.Forms.GroupBox();
            this.lb_ID = new System.Windows.Forms.Label();
            this.lb_TaiKhoan = new System.Windows.Forms.Label();
            this.lb_MatKhau = new System.Windows.Forms.Label();
            this.lb_Quyen = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cb_Quyen = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gb_ChucNangTK = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.gB_DSTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gB_TaiKhoan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_ChucNangTK.SuspendLayout();
            this.SuspendLayout();
            // 
            // gB_DSTaiKhoan
            // 
            this.gB_DSTaiKhoan.Controls.Add(this.dataGridView1);
            this.gB_DSTaiKhoan.Location = new System.Drawing.Point(321, 68);
            this.gB_DSTaiKhoan.Name = "gB_DSTaiKhoan";
            this.gB_DSTaiKhoan.Size = new System.Drawing.Size(477, 187);
            this.gB_DSTaiKhoan.TabIndex = 0;
            this.gB_DSTaiKhoan.TabStop = false;
            this.gB_DSTaiKhoan.Text = "Danh sách tài khoản";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(244, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(304, 31);
            this.label.TabIndex = 1;
            this.label.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(465, 162);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gB_TaiKhoan
            // 
            this.gB_TaiKhoan.Controls.Add(this.cb_Quyen);
            this.gB_TaiKhoan.Controls.Add(this.textBox3);
            this.gB_TaiKhoan.Controls.Add(this.textBox2);
            this.gB_TaiKhoan.Controls.Add(this.textBox1);
            this.gB_TaiKhoan.Controls.Add(this.lb_Quyen);
            this.gB_TaiKhoan.Controls.Add(this.lb_MatKhau);
            this.gB_TaiKhoan.Controls.Add(this.lb_TaiKhoan);
            this.gB_TaiKhoan.Controls.Add(this.lb_ID);
            this.gB_TaiKhoan.Location = new System.Drawing.Point(12, 68);
            this.gB_TaiKhoan.Name = "gB_TaiKhoan";
            this.gB_TaiKhoan.Size = new System.Drawing.Size(258, 187);
            this.gB_TaiKhoan.TabIndex = 2;
            this.gB_TaiKhoan.TabStop = false;
            this.gB_TaiKhoan.Text = "Tài khoản";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Location = new System.Drawing.Point(17, 42);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(21, 13);
            this.lb_ID.TabIndex = 0;
            this.lb_ID.Text = "ID:";
            // 
            // lb_TaiKhoan
            // 
            this.lb_TaiKhoan.AutoSize = true;
            this.lb_TaiKhoan.Location = new System.Drawing.Point(17, 85);
            this.lb_TaiKhoan.Name = "lb_TaiKhoan";
            this.lb_TaiKhoan.Size = new System.Drawing.Size(58, 13);
            this.lb_TaiKhoan.TabIndex = 1;
            this.lb_TaiKhoan.Text = "Tài khoản:";
            // 
            // lb_MatKhau
            // 
            this.lb_MatKhau.AutoSize = true;
            this.lb_MatKhau.Location = new System.Drawing.Point(17, 125);
            this.lb_MatKhau.Name = "lb_MatKhau";
            this.lb_MatKhau.Size = new System.Drawing.Size(55, 13);
            this.lb_MatKhau.TabIndex = 2;
            this.lb_MatKhau.Text = "Mật khẩu:";
            // 
            // lb_Quyen
            // 
            this.lb_Quyen.AutoSize = true;
            this.lb_Quyen.Location = new System.Drawing.Point(17, 168);
            this.lb_Quyen.Name = "lb_Quyen";
            this.lb_Quyen.Size = new System.Drawing.Size(38, 13);
            this.lb_Quyen.TabIndex = 3;
            this.lb_Quyen.Text = "Quyền";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 26);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 72);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 26);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(85, 112);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(167, 26);
            this.textBox3.TabIndex = 6;
            // 
            // cb_Quyen
            // 
            this.cb_Quyen.FormattingEnabled = true;
            this.cb_Quyen.Location = new System.Drawing.Point(85, 160);
            this.cb_Quyen.Name = "cb_Quyen";
            this.cb_Quyen.Size = new System.Drawing.Size(167, 21);
            this.cb_Quyen.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_TimKiem);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // gb_ChucNangTK
            // 
            this.gb_ChucNangTK.Controls.Add(this.btn_LamMoi);
            this.gb_ChucNangTK.Controls.Add(this.btn_Xoa);
            this.gb_ChucNangTK.Controls.Add(this.btn_Sua);
            this.gb_ChucNangTK.Controls.Add(this.btn_Them);
            this.gb_ChucNangTK.Location = new System.Drawing.Point(358, 276);
            this.gb_ChucNangTK.Name = "gb_ChucNangTK";
            this.gb_ChucNangTK.Size = new System.Drawing.Size(405, 77);
            this.gb_ChucNangTK.TabIndex = 4;
            this.gb_ChucNangTK.TabStop = false;
            this.gb_ChucNangTK.Text = "Chức năng tài khoản";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(30, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(85, 68);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(84, 26);
            this.btn_TimKiem.TabIndex = 1;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(15, 35);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(115, 35);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(216, 35);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Location = new System.Drawing.Point(314, 35);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(75, 23);
            this.btn_LamMoi.TabIndex = 3;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            // 
            // Frm_TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(820, 401);
            this.Controls.Add(this.gb_ChucNangTK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gB_TaiKhoan);
            this.Controls.Add(this.label);
            this.Controls.Add(this.gB_DSTaiKhoan);
            this.Name = "Frm_TaiKhoan";
            this.Text = "Frm_TaiKhoan";
            this.gB_DSTaiKhoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gB_TaiKhoan.ResumeLayout(false);
            this.gB_TaiKhoan.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gb_ChucNangTK.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gB_DSTaiKhoan;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gB_TaiKhoan;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_Quyen;
        private System.Windows.Forms.Label lb_MatKhau;
        private System.Windows.Forms.Label lb_TaiKhoan;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.ComboBox cb_Quyen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gb_ChucNangTK;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
    }
}