namespace QL_ThongTinTuyenDung_NoSQL
{
    partial class Frm_SaoLuuPhucHoi
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
            this.gB_SaoLuuPhucHoi = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_SaoLuu = new System.Windows.Forms.Button();
            this.btn_PhucHoi = new System.Windows.Forms.Button();
            this.txt_SaoLuu = new System.Windows.Forms.TextBox();
            this.txt_PhucHoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gB_SaoLuuPhucHoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // gB_SaoLuuPhucHoi
            // 
            this.gB_SaoLuuPhucHoi.Controls.Add(this.txt_PhucHoi);
            this.gB_SaoLuuPhucHoi.Controls.Add(this.txt_SaoLuu);
            this.gB_SaoLuuPhucHoi.Controls.Add(this.btn_PhucHoi);
            this.gB_SaoLuuPhucHoi.Controls.Add(this.btn_SaoLuu);
            this.gB_SaoLuuPhucHoi.Location = new System.Drawing.Point(86, 116);
            this.gB_SaoLuuPhucHoi.Name = "gB_SaoLuuPhucHoi";
            this.gB_SaoLuuPhucHoi.Size = new System.Drawing.Size(660, 369);
            this.gB_SaoLuuPhucHoi.TabIndex = 0;
            this.gB_SaoLuuPhucHoi.TabStop = false;
            this.gB_SaoLuuPhucHoi.Text = "Sao lưu phục hồi";
            // 
            // btn_SaoLuu
            // 
            this.btn_SaoLuu.Location = new System.Drawing.Point(54, 66);
            this.btn_SaoLuu.Name = "btn_SaoLuu";
            this.btn_SaoLuu.Size = new System.Drawing.Size(92, 29);
            this.btn_SaoLuu.TabIndex = 0;
            this.btn_SaoLuu.Text = "Sao lưu";
            this.btn_SaoLuu.UseVisualStyleBackColor = true;
            // 
            // btn_PhucHoi
            // 
            this.btn_PhucHoi.Location = new System.Drawing.Point(54, 257);
            this.btn_PhucHoi.Name = "btn_PhucHoi";
            this.btn_PhucHoi.Size = new System.Drawing.Size(92, 29);
            this.btn_PhucHoi.TabIndex = 1;
            this.btn_PhucHoi.Text = "Phục hồi";
            this.btn_PhucHoi.UseVisualStyleBackColor = true;
            // 
            // txt_SaoLuu
            // 
            this.txt_SaoLuu.Location = new System.Drawing.Point(241, 28);
            this.txt_SaoLuu.Multiline = true;
            this.txt_SaoLuu.Name = "txt_SaoLuu";
            this.txt_SaoLuu.Size = new System.Drawing.Size(358, 113);
            this.txt_SaoLuu.TabIndex = 2;
            // 
            // txt_PhucHoi
            // 
            this.txt_PhucHoi.Location = new System.Drawing.Point(241, 217);
            this.txt_PhucHoi.Multiline = true;
            this.txt_PhucHoi.Name = "txt_PhucHoi";
            this.txt_PhucHoi.Size = new System.Drawing.Size(358, 113);
            this.txt_PhucHoi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "SAO LƯU PHỤC HỒI";
            // 
            // Frm_SaoLuuPhucHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gB_SaoLuuPhucHoi);
            this.Name = "Frm_SaoLuuPhucHoi";
            this.Text = "Frm_SaoLuuPhucHoi";
            this.gB_SaoLuuPhucHoi.ResumeLayout(false);
            this.gB_SaoLuuPhucHoi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gB_SaoLuuPhucHoi;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txt_PhucHoi;
        private System.Windows.Forms.TextBox txt_SaoLuu;
        private System.Windows.Forms.Button btn_PhucHoi;
        private System.Windows.Forms.Button btn_SaoLuu;
        private System.Windows.Forms.Label label1;
    }
}