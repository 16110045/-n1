namespace Đồ_Án_1
{
    partial class frmBoMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBoMon));
            this.gpBoMon = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenBM = new System.Windows.Forms.TextBox();
            this.txtMaBM = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.dgvBoMon = new System.Windows.Forms.DataGridView();
            this.MaBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpBoMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoMon)).BeginInit();
            this.SuspendLayout();
            // 
            // gpBoMon
            // 
            this.gpBoMon.Controls.Add(this.label2);
            this.gpBoMon.Controls.Add(this.label1);
            this.gpBoMon.Controls.Add(this.txtTenBM);
            this.gpBoMon.Controls.Add(this.txtMaBM);
            this.gpBoMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBoMon.ForeColor = System.Drawing.Color.White;
            this.gpBoMon.Location = new System.Drawing.Point(22, 63);
            this.gpBoMon.Margin = new System.Windows.Forms.Padding(4);
            this.gpBoMon.Name = "gpBoMon";
            this.gpBoMon.Padding = new System.Windows.Forms.Padding(4);
            this.gpBoMon.Size = new System.Drawing.Size(405, 105);
            this.gpBoMon.TabIndex = 87;
            this.gpBoMon.TabStop = false;
            this.gpBoMon.Text = "Thông tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Bộ Môn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Bộ Môn:";
            // 
            // txtTenBM
            // 
            this.txtTenBM.Location = new System.Drawing.Point(164, 59);
            this.txtTenBM.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenBM.Name = "txtTenBM";
            this.txtTenBM.Size = new System.Drawing.Size(232, 30);
            this.txtTenBM.TabIndex = 1;
            // 
            // txtMaBM
            // 
            this.txtMaBM.Location = new System.Drawing.Point(164, 23);
            this.txtMaBM.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaBM.Name = "txtMaBM";
            this.txtMaBM.Size = new System.Drawing.Size(232, 30);
            this.txtMaBM.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(539, 256);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 84);
            this.btnThoat.TabIndex = 86;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.BackgroundImage")));
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(539, 165);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(96, 84);
            this.btnHuy.TabIndex = 85;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.BackgroundImage")));
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(435, 256);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(96, 84);
            this.btnLuu.TabIndex = 84;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Brown;
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(435, 165);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 84);
            this.btnXoa.TabIndex = 83;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Blue;
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(539, 74);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 84);
            this.btnSua.TabIndex = 82;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Green;
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(435, 74);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 84);
            this.btnThem.TabIndex = 81;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(235, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(318, 36);
            this.label8.TabIndex = 78;
            this.label8.Text = "DANH MỤC BỘ MÔN";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(94, 13);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 43);
            this.label10.TabIndex = 80;
            this.label10.Text = "Trở về";
            // 
            // btnTroVe
            // 
            this.btnTroVe.BackColor = System.Drawing.Color.Indigo;
            this.btnTroVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTroVe.ForeColor = System.Drawing.Color.Indigo;
            this.btnTroVe.Image = ((System.Drawing.Image)(resources.GetObject("btnTroVe.Image")));
            this.btnTroVe.Location = new System.Drawing.Point(6, 6);
            this.btnTroVe.Margin = new System.Windows.Forms.Padding(4);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(80, 49);
            this.btnTroVe.TabIndex = 79;
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // dgvBoMon
            // 
            this.dgvBoMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBM,
            this.TenBM});
            this.dgvBoMon.Location = new System.Drawing.Point(22, 175);
            this.dgvBoMon.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBoMon.Name = "dgvBoMon";
            this.dgvBoMon.Size = new System.Drawing.Size(405, 165);
            this.dgvBoMon.TabIndex = 77;
            this.dgvBoMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoMon_CellClick);
            // 
            // MaBM
            // 
            this.MaBM.DataPropertyName = "MaBM";
            this.MaBM.FillWeight = 120F;
            this.MaBM.HeaderText = "Mã Bộ Môn";
            this.MaBM.Name = "MaBM";
            this.MaBM.Width = 130;
            // 
            // TenBM
            // 
            this.TenBM.DataPropertyName = "TenBM";
            this.TenBM.FillWeight = 120F;
            this.TenBM.HeaderText = "Tên Bộ Môn";
            this.TenBM.Name = "TenBM";
            this.TenBM.Width = 130;
            // 
            // frmBoMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(704, 348);
            this.Controls.Add(this.gpBoMon);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.dgvBoMon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBoMon";
            this.Text = "frmBoMon";
            this.Load += new System.EventHandler(this.frmBoMon_Load);
            this.gpBoMon.ResumeLayout(false);
            this.gpBoMon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpBoMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenBM;
        private System.Windows.Forms.TextBox txtMaBM;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.DataGridView dgvBoMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBM;
    }
}