namespace QuanLyCLB
{
    partial class Form1
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
            this.lbl_QLCLB = new System.Windows.Forms.Label();
            this.dgv_CLB = new System.Windows.Forms.DataGridView();
            this.grp_Thongtin = new System.Windows.Forms.GroupBox();
            this.comboBox_CLB = new System.Windows.Forms.ComboBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_Tong = new System.Windows.Forms.TextBox();
            this.txt_GV = new System.Windows.Forms.TextBox();
            this.txt_SLV = new System.Windows.Forms.TextBox();
            this.txt_SVD = new System.Windows.Forms.TextBox();
            this.txt_QG = new System.Windows.Forms.TextBox();
            this.lbl_Tong = new System.Windows.Forms.Label();
            this.lbl_Gia = new System.Windows.Forms.Label();
            this.lbl_SLV = new System.Windows.Forms.Label();
            this.lbl_SVD = new System.Windows.Forms.Label();
            this.Qgia = new System.Windows.Forms.Label();
            this.lbl_CLB = new System.Windows.Forms.Label();
            this.grp_TK = new System.Windows.Forms.GroupBox();
            this.txt_TenCLB = new System.Windows.Forms.TextBox();
            this.LBL_TKCLB = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CLB)).BeginInit();
            this.grp_Thongtin.SuspendLayout();
            this.grp_TK.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_QLCLB
            // 
            this.lbl_QLCLB.AutoSize = true;
            this.lbl_QLCLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QLCLB.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_QLCLB.Location = new System.Drawing.Point(273, 9);
            this.lbl_QLCLB.Name = "lbl_QLCLB";
            this.lbl_QLCLB.Size = new System.Drawing.Size(282, 31);
            this.lbl_QLCLB.TabIndex = 0;
            this.lbl_QLCLB.Text = "Quản Lý Câu Lạc Bộ";
            // 
            // dgv_CLB
            // 
            this.dgv_CLB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CLB.Location = new System.Drawing.Point(12, 135);
            this.dgv_CLB.Name = "dgv_CLB";
            this.dgv_CLB.Size = new System.Drawing.Size(504, 303);
            this.dgv_CLB.TabIndex = 1;
            this.dgv_CLB.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CLB_CellDoubleClick);
            // 
            // grp_Thongtin
            // 
            this.grp_Thongtin.Controls.Add(this.comboBox_CLB);
            this.grp_Thongtin.Controls.Add(this.btn_Xoa);
            this.grp_Thongtin.Controls.Add(this.btn_Sua);
            this.grp_Thongtin.Controls.Add(this.btn_Them);
            this.grp_Thongtin.Controls.Add(this.txt_Tong);
            this.grp_Thongtin.Controls.Add(this.txt_GV);
            this.grp_Thongtin.Controls.Add(this.txt_SLV);
            this.grp_Thongtin.Controls.Add(this.txt_SVD);
            this.grp_Thongtin.Controls.Add(this.txt_QG);
            this.grp_Thongtin.Controls.Add(this.lbl_Tong);
            this.grp_Thongtin.Controls.Add(this.lbl_Gia);
            this.grp_Thongtin.Controls.Add(this.lbl_SLV);
            this.grp_Thongtin.Controls.Add(this.lbl_SVD);
            this.grp_Thongtin.Controls.Add(this.Qgia);
            this.grp_Thongtin.Controls.Add(this.lbl_CLB);
            this.grp_Thongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Thongtin.Location = new System.Drawing.Point(522, 53);
            this.grp_Thongtin.Name = "grp_Thongtin";
            this.grp_Thongtin.Size = new System.Drawing.Size(307, 385);
            this.grp_Thongtin.TabIndex = 2;
            this.grp_Thongtin.TabStop = false;
            this.grp_Thongtin.Text = "Thông Tin";
            // 
            // comboBox_CLB
            // 
            this.comboBox_CLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_CLB.FormattingEnabled = true;
            this.comboBox_CLB.Items.AddRange(new object[] {
            "Bayern Munich",
            "Manchester Utd",
            "Arsenal",
            "Real Madrid",
            "Inter",
            "Atl. Madrid",
            "Paris SG",
            "Dortmund",
            "Newcastle",
            "AC Milan",
            "Manchester City"});
            this.comboBox_CLB.Location = new System.Drawing.Point(124, 35);
            this.comboBox_CLB.Name = "comboBox_CLB";
            this.comboBox_CLB.Size = new System.Drawing.Size(160, 26);
            this.comboBox_CLB.TabIndex = 14;
            this.comboBox_CLB.SelectedIndexChanged += new System.EventHandler(this.comboBox_CLB_SelectedIndexChanged);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.AutoSize = true;
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Xoa.Location = new System.Drawing.Point(226, 339);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 27);
            this.btn_Xoa.TabIndex = 13;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.AutoSize = true;
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Sua.Location = new System.Drawing.Point(124, 339);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 27);
            this.btn_Sua.TabIndex = 12;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.AutoSize = true;
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Them.Location = new System.Drawing.Point(21, 339);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 27);
            this.btn_Them.TabIndex = 11;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_Tong
            // 
            this.txt_Tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tong.Location = new System.Drawing.Point(124, 257);
            this.txt_Tong.Name = "txt_Tong";
            this.txt_Tong.Size = new System.Drawing.Size(160, 24);
            this.txt_Tong.TabIndex = 10;
            // 
            // txt_GV
            // 
            this.txt_GV.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_GV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GV.Location = new System.Drawing.Point(124, 175);
            this.txt_GV.Name = "txt_GV";
            this.txt_GV.Size = new System.Drawing.Size(160, 24);
            this.txt_GV.TabIndex = 9;
            // 
            // txt_SLV
            // 
            this.txt_SLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SLV.Location = new System.Drawing.Point(124, 217);
            this.txt_SLV.Name = "txt_SLV";
            this.txt_SLV.Size = new System.Drawing.Size(160, 24);
            this.txt_SLV.TabIndex = 8;
            this.txt_SLV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SLV_KeyPress);
            // 
            // txt_SVD
            // 
            this.txt_SVD.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_SVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SVD.Location = new System.Drawing.Point(124, 128);
            this.txt_SVD.Name = "txt_SVD";
            this.txt_SVD.Size = new System.Drawing.Size(160, 24);
            this.txt_SVD.TabIndex = 7;
            // 
            // txt_QG
            // 
            this.txt_QG.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_QG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_QG.ForeColor = System.Drawing.Color.Black;
            this.txt_QG.Location = new System.Drawing.Point(123, 84);
            this.txt_QG.Name = "txt_QG";
            this.txt_QG.Size = new System.Drawing.Size(160, 24);
            this.txt_QG.TabIndex = 6;
            // 
            // lbl_Tong
            // 
            this.lbl_Tong.AutoSize = true;
            this.lbl_Tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tong.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Tong.Location = new System.Drawing.Point(18, 262);
            this.lbl_Tong.Name = "lbl_Tong";
            this.lbl_Tong.Size = new System.Drawing.Size(68, 17);
            this.lbl_Tong.TabIndex = 5;
            this.lbl_Tong.Text = "Tổng tiền";
            // 
            // lbl_Gia
            // 
            this.lbl_Gia.AutoSize = true;
            this.lbl_Gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gia.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Gia.Location = new System.Drawing.Point(18, 180);
            this.lbl_Gia.Name = "lbl_Gia";
            this.lbl_Gia.Size = new System.Drawing.Size(51, 17);
            this.lbl_Gia.TabIndex = 4;
            this.lbl_Gia.Text = "Giá Vé";
            // 
            // lbl_SLV
            // 
            this.lbl_SLV.AutoSize = true;
            this.lbl_SLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SLV.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_SLV.Location = new System.Drawing.Point(18, 222);
            this.lbl_SLV.Name = "lbl_SLV";
            this.lbl_SLV.Size = new System.Drawing.Size(83, 17);
            this.lbl_SLV.TabIndex = 3;
            this.lbl_SLV.Text = "Số lượng vé";
            // 
            // lbl_SVD
            // 
            this.lbl_SVD.AutoSize = true;
            this.lbl_SVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SVD.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_SVD.Location = new System.Drawing.Point(18, 133);
            this.lbl_SVD.Name = "lbl_SVD";
            this.lbl_SVD.Size = new System.Drawing.Size(100, 17);
            this.lbl_SVD.TabIndex = 2;
            this.lbl_SVD.Text = "Sân Vận Động";
            // 
            // Qgia
            // 
            this.Qgia.AutoSize = true;
            this.Qgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qgia.ForeColor = System.Drawing.Color.DarkBlue;
            this.Qgia.Location = new System.Drawing.Point(18, 89);
            this.Qgia.Name = "Qgia";
            this.Qgia.Size = new System.Drawing.Size(68, 17);
            this.Qgia.TabIndex = 1;
            this.Qgia.Text = "Quốc Gia";
            // 
            // lbl_CLB
            // 
            this.lbl_CLB.AutoSize = true;
            this.lbl_CLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CLB.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_CLB.Location = new System.Drawing.Point(18, 40);
            this.lbl_CLB.Name = "lbl_CLB";
            this.lbl_CLB.Size = new System.Drawing.Size(63, 17);
            this.lbl_CLB.TabIndex = 0;
            this.lbl_CLB.Text = "Tên CLB";
            // 
            // grp_TK
            // 
            this.grp_TK.Controls.Add(this.txt_TenCLB);
            this.grp_TK.Controls.Add(this.LBL_TKCLB);
            this.grp_TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_TK.Location = new System.Drawing.Point(14, 53);
            this.grp_TK.Name = "grp_TK";
            this.grp_TK.Size = new System.Drawing.Size(504, 76);
            this.grp_TK.TabIndex = 3;
            this.grp_TK.TabStop = false;
            this.grp_TK.Text = "Tìm Kiếm";
            // 
            // txt_TenCLB
            // 
            this.txt_TenCLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenCLB.Location = new System.Drawing.Point(131, 35);
            this.txt_TenCLB.Name = "txt_TenCLB";
            this.txt_TenCLB.Size = new System.Drawing.Size(160, 24);
            this.txt_TenCLB.TabIndex = 9;
            this.txt_TenCLB.TextChanged += new System.EventHandler(this.txt_TenCLB_TextChanged);
            // 
            // LBL_TKCLB
            // 
            this.LBL_TKCLB.AutoSize = true;
            this.LBL_TKCLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TKCLB.ForeColor = System.Drawing.Color.DarkBlue;
            this.LBL_TKCLB.Location = new System.Drawing.Point(36, 40);
            this.LBL_TKCLB.Name = "LBL_TKCLB";
            this.LBL_TKCLB.Size = new System.Drawing.Size(63, 17);
            this.LBL_TKCLB.TabIndex = 6;
            this.LBL_TKCLB.Text = "Tên CLB";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lưuToolStripMenuItem,
            this.thoToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // lưuToolStripMenuItem
            // 
            this.lưuToolStripMenuItem.Name = "lưuToolStripMenuItem";
            this.lưuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.lưuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lưuToolStripMenuItem.Text = "Lưu";
            this.lưuToolStripMenuItem.Click += new System.EventHandler(this.lưuToolStripMenuItem_Click);
            // 
            // thoToolStripMenuItem
            // 
            this.thoToolStripMenuItem.Name = "thoToolStripMenuItem";
            this.thoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.thoToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.thoToolStripMenuItem.Text = "Thoát";
            this.thoToolStripMenuItem.Click += new System.EventHandler(this.thoToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.viewToolStripMenuItem.Text = "Tính Năng";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.thốngKêToolStripMenuItem.Text = "Thống Kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.grp_TK);
            this.Controls.Add(this.grp_Thongtin);
            this.Controls.Add(this.dgv_CLB);
            this.Controls.Add(this.lbl_QLCLB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Trình Quản Lý CLB";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CLB)).EndInit();
            this.grp_Thongtin.ResumeLayout(false);
            this.grp_Thongtin.PerformLayout();
            this.grp_TK.ResumeLayout(false);
            this.grp_TK.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_QLCLB;
        private System.Windows.Forms.DataGridView dgv_CLB;
        private System.Windows.Forms.GroupBox grp_Thongtin;
        private System.Windows.Forms.GroupBox grp_TK;
        private System.Windows.Forms.Label lbl_SLV;
        private System.Windows.Forms.Label lbl_SVD;
        private System.Windows.Forms.Label Qgia;
        private System.Windows.Forms.Label lbl_CLB;
        private System.Windows.Forms.ComboBox comboBox_CLB;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_Tong;
        private System.Windows.Forms.TextBox txt_GV;
        private System.Windows.Forms.TextBox txt_SLV;
        private System.Windows.Forms.TextBox txt_SVD;
        private System.Windows.Forms.TextBox txt_QG;
        private System.Windows.Forms.Label lbl_Tong;
        private System.Windows.Forms.Label lbl_Gia;
        private System.Windows.Forms.Label LBL_TKCLB;
        private System.Windows.Forms.TextBox txt_TenCLB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

