namespace Đồ_Án_1
{
    partial class frmXepThoiKhoaBieu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXepThoiKhoaBieu));
            this.gbrangbuoc = new System.Windows.Forms.GroupBox();
            this.btnXuatThoiKhoaBieu = new System.Windows.Forms.Button();
            this.cmbchonlop = new System.Windows.Forms.ComboBox();
            this.lblChonlop = new System.Windows.Forms.Label();
            this.lbl55 = new System.Windows.Forms.Label();
            this.lbl44 = new System.Windows.Forms.Label();
            this.lbl33 = new System.Windows.Forms.Label();
            this.lbl22 = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.dgvRangBuoc = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblgvmh = new System.Windows.Forms.Label();
            this.lblgvlop = new System.Windows.Forms.Label();
            this.lbllopphong = new System.Windows.Forms.Label();
            this.lbllopmonhoc = new System.Windows.Forms.Label();
            this.lbltietmh = new System.Windows.Forms.Label();
            this.btnXepTKB = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.gbrangbuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRangBuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // gbrangbuoc
            // 
            this.gbrangbuoc.Controls.Add(this.btnXuatThoiKhoaBieu);
            this.gbrangbuoc.Controls.Add(this.cmbchonlop);
            this.gbrangbuoc.Controls.Add(this.lblChonlop);
            this.gbrangbuoc.Controls.Add(this.lbl55);
            this.gbrangbuoc.Controls.Add(this.lbl44);
            this.gbrangbuoc.Controls.Add(this.lbl33);
            this.gbrangbuoc.Controls.Add(this.lbl22);
            this.gbrangbuoc.Controls.Add(this.lbl11);
            this.gbrangbuoc.Controls.Add(this.lbl5);
            this.gbrangbuoc.Controls.Add(this.lbl4);
            this.gbrangbuoc.Controls.Add(this.lbl3);
            this.gbrangbuoc.Controls.Add(this.lbl2);
            this.gbrangbuoc.Controls.Add(this.lbl1);
            this.gbrangbuoc.Controls.Add(this.dgvRangBuoc);
            this.gbrangbuoc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbrangbuoc.Location = new System.Drawing.Point(10, 70);
            this.gbrangbuoc.Name = "gbrangbuoc";
            this.gbrangbuoc.Size = new System.Drawing.Size(1102, 455);
            this.gbrangbuoc.TabIndex = 0;
            this.gbrangbuoc.TabStop = false;
            this.gbrangbuoc.Text = "Ràng Buộc";
            // 
            // btnXuatThoiKhoaBieu
            // 
            this.btnXuatThoiKhoaBieu.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnXuatThoiKhoaBieu.Location = new System.Drawing.Point(890, 372);
            this.btnXuatThoiKhoaBieu.Name = "btnXuatThoiKhoaBieu";
            this.btnXuatThoiKhoaBieu.Size = new System.Drawing.Size(112, 62);
            this.btnXuatThoiKhoaBieu.TabIndex = 14;
            this.btnXuatThoiKhoaBieu.Text = "Xuất Thời Khóa Biểu";
            this.btnXuatThoiKhoaBieu.UseVisualStyleBackColor = false;
            this.btnXuatThoiKhoaBieu.Click += new System.EventHandler(this.btnXuatTKB_Click);
            // 
            // cmbchonlop
            // 
            this.cmbchonlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbchonlop.FormattingEnabled = true;
            this.cmbchonlop.Location = new System.Drawing.Point(742, 306);
            this.cmbchonlop.Name = "cmbchonlop";
            this.cmbchonlop.Size = new System.Drawing.Size(260, 37);
            this.cmbchonlop.TabIndex = 12;
            this.cmbchonlop.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblChonlop
            // 
            this.lblChonlop.AutoSize = true;
            this.lblChonlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonlop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblChonlop.Location = new System.Drawing.Point(597, 309);
            this.lblChonlop.Name = "lblChonlop";
            this.lblChonlop.Size = new System.Drawing.Size(117, 29);
            this.lblChonlop.TabIndex = 11;
            this.lblChonlop.Text = "Chọn Lớp";
            this.lblChonlop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl55
            // 
            this.lbl55.AutoSize = true;
            this.lbl55.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl55.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl55.Location = new System.Drawing.Point(819, 226);
            this.lbl55.Name = "lbl55";
            this.lbl55.Size = new System.Drawing.Size(61, 29);
            this.lbl55.TabIndex = 10;
            this.lbl55.Text = "STT";
            this.lbl55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl44
            // 
            this.lbl44.AutoSize = true;
            this.lbl44.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl44.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl44.Location = new System.Drawing.Point(819, 170);
            this.lbl44.Name = "lbl44";
            this.lbl44.Size = new System.Drawing.Size(61, 29);
            this.lbl44.TabIndex = 9;
            this.lbl44.Text = "STT";
            this.lbl44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl33
            // 
            this.lbl33.AutoSize = true;
            this.lbl33.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl33.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl33.Location = new System.Drawing.Point(819, 113);
            this.lbl33.Name = "lbl33";
            this.lbl33.Size = new System.Drawing.Size(61, 29);
            this.lbl33.TabIndex = 8;
            this.lbl33.Text = "STT";
            this.lbl33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl22
            // 
            this.lbl22.AutoSize = true;
            this.lbl22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl22.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl22.Location = new System.Drawing.Point(819, 64);
            this.lbl22.Name = "lbl22";
            this.lbl22.Size = new System.Drawing.Size(61, 29);
            this.lbl22.TabIndex = 7;
            this.lbl22.Text = "STT";
            this.lbl22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl11.Location = new System.Drawing.Point(819, 18);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(61, 29);
            this.lbl11.TabIndex = 6;
            this.lbl11.Text = "STT";
            this.lbl11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl5.Location = new System.Drawing.Point(597, 226);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(61, 29);
            this.lbl5.TabIndex = 5;
            this.lbl5.Text = "STT";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl4.Location = new System.Drawing.Point(597, 170);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(61, 29);
            this.lbl4.TabIndex = 4;
            this.lbl4.Text = "STT";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl3.Location = new System.Drawing.Point(597, 113);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(61, 29);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "STT";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl2.Location = new System.Drawing.Point(597, 64);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(61, 29);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "STT";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl1.Location = new System.Drawing.Point(597, 18);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(61, 29);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "STT";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvRangBuoc
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRangBuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRangBuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRangBuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Column1,
            this.C1,
            this.C2,
            this.Column5});
            this.dgvRangBuoc.Location = new System.Drawing.Point(6, 21);
            this.dgvRangBuoc.Name = "dgvRangBuoc";
            this.dgvRangBuoc.RowTemplate.Height = 24;
            this.dgvRangBuoc.Size = new System.Drawing.Size(551, 425);
            this.dgvRangBuoc.TabIndex = 0;
            this.dgvRangBuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRangBuoc_CellClick);
            // 
            // STT
            // 
            this.STT.Frozen = true;
            this.STT.HeaderText = "Column1";
            this.STT.Name = "STT";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // C1
            // 
            this.C1.HeaderText = "Column1";
            this.C1.Name = "C1";
            // 
            // C2
            // 
            this.C2.HeaderText = "Column1";
            this.C2.Name = "C2";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column1";
            this.Column5.Name = "Column5";
            // 
            // lblgvmh
            // 
            this.lblgvmh.AutoSize = true;
            this.lblgvmh.BackColor = System.Drawing.Color.Indigo;
            this.lblgvmh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgvmh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblgvmh.Location = new System.Drawing.Point(13, 547);
            this.lblgvmh.Name = "lblgvmh";
            this.lblgvmh.Size = new System.Drawing.Size(140, 29);
            this.lblgvmh.TabIndex = 1;
            this.lblgvmh.Text = "Gv-MonHoc";
            this.lblgvmh.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblGV_MH_MouseClick);
            // 
            // lblgvlop
            // 
            this.lblgvlop.AutoSize = true;
            this.lblgvlop.BackColor = System.Drawing.Color.Indigo;
            this.lblgvlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgvlop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblgvlop.Location = new System.Drawing.Point(187, 547);
            this.lblgvlop.Name = "lblgvlop";
            this.lblgvlop.Size = new System.Drawing.Size(91, 29);
            this.lblgvlop.TabIndex = 2;
            this.lblgvlop.Text = "Gv-Lop";
            this.lblgvlop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblGV_Lop_MouseClick);
            // 
            // lbllopphong
            // 
            this.lbllopphong.AutoSize = true;
            this.lbllopphong.BackColor = System.Drawing.Color.Indigo;
            this.lbllopphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllopphong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbllopphong.Location = new System.Drawing.Point(329, 546);
            this.lbllopphong.Name = "lbllopphong";
            this.lbllopphong.Size = new System.Drawing.Size(132, 29);
            this.lbllopphong.TabIndex = 3;
            this.lbllopphong.Text = "Lop-Phong";
            this.lbllopphong.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblPhongLop_MouseClick);
            // 
            // lbllopmonhoc
            // 
            this.lbllopmonhoc.AutoSize = true;
            this.lbllopmonhoc.BackColor = System.Drawing.Color.Indigo;
            this.lbllopmonhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllopmonhoc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbllopmonhoc.Location = new System.Drawing.Point(525, 546);
            this.lbllopmonhoc.Name = "lbllopmonhoc";
            this.lbllopmonhoc.Size = new System.Drawing.Size(152, 29);
            this.lbllopmonhoc.TabIndex = 4;
            this.lbllopmonhoc.Text = "Lop-MonHoc";
            this.lbllopmonhoc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblLopMH_MouseClick);
            // 
            // lbltietmh
            // 
            this.lbltietmh.AutoSize = true;
            this.lbltietmh.BackColor = System.Drawing.Color.Indigo;
            this.lbltietmh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltietmh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltietmh.Location = new System.Drawing.Point(737, 547);
            this.lbltietmh.Name = "lbltietmh";
            this.lbltietmh.Size = new System.Drawing.Size(153, 29);
            this.lbltietmh.TabIndex = 5;
            this.lbltietmh.Text = "Tiet-MonHoc";
            this.lbltietmh.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblTiet_MH_MouseClick);
            // 
            // btnXepTKB
            // 
            this.btnXepTKB.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnXepTKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXepTKB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXepTKB.Location = new System.Drawing.Point(950, 538);
            this.btnXepTKB.Name = "btnXepTKB";
            this.btnXepTKB.Size = new System.Drawing.Size(162, 38);
            this.btnXepTKB.TabIndex = 6;
            this.btnXepTKB.Text = "XepThoiKhoaBieu";
            this.btnXepTKB.UseVisualStyleBackColor = false;
            this.btnXepTKB.Click += new System.EventHandler(this.btnXepTKB_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(98, 8);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 43);
            this.label10.TabIndex = 67;
            this.label10.Text = "Trở về";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(368, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(300, 36);
            this.label8.TabIndex = 76;
            this.label8.Text = "Xếp Thời Khóa Biểu";
            // 
            // btnTroVe
            // 
            this.btnTroVe.BackColor = System.Drawing.Color.Indigo;
            this.btnTroVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTroVe.ForeColor = System.Drawing.Color.Indigo;
            this.btnTroVe.Image = ((System.Drawing.Image)(resources.GetObject("btnTroVe.Image")));
            this.btnTroVe.Location = new System.Drawing.Point(10, 2);
            this.btnTroVe.Margin = new System.Windows.Forms.Padding(4);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(80, 49);
            this.btnTroVe.TabIndex = 66;
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // frmXepThoiKhoaBieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1124, 597);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnXepTKB);
            this.Controls.Add(this.lbltietmh);
            this.Controls.Add(this.lbllopmonhoc);
            this.Controls.Add(this.lbllopphong);
            this.Controls.Add(this.lblgvlop);
            this.Controls.Add(this.lblgvmh);
            this.Controls.Add(this.gbrangbuoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmXepThoiKhoaBieu";
            this.Text = "frmXepThoiKhoaBieu";
            this.Load += new System.EventHandler(this.frmXepThoiKhoaBieu_Load);
            this.gbrangbuoc.ResumeLayout(false);
            this.gbrangbuoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRangBuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbrangbuoc;
        private System.Windows.Forms.Label lbl55;
        private System.Windows.Forms.Label lbl44;
        private System.Windows.Forms.Label lbl33;
        private System.Windows.Forms.Label lbl22;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridView dgvRangBuoc;
        private System.Windows.Forms.Button btnXuatThoiKhoaBieu;
        private System.Windows.Forms.ComboBox cmbchonlop;
        private System.Windows.Forms.Label lblChonlop;
        private System.Windows.Forms.Label lblgvmh;
        private System.Windows.Forms.Label lblgvlop;
        private System.Windows.Forms.Label lbllopphong;
        private System.Windows.Forms.Label lbllopmonhoc;
        private System.Windows.Forms.Label lbltietmh;
        private System.Windows.Forms.Button btnXepTKB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}