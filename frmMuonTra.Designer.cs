namespace QuanLyThuVien
{
    partial class frmMuonTra
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.dtMuon = new System.Windows.Forms.DateTimePicker();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.dgvMuonTra = new System.Windows.Forms.DataGridView();
            this.dtTra = new System.Windows.Forms.DateTimePicker();
            this.dtDK = new System.Windows.Forms.DateTimePicker();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuonTra)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày mượn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày trả dự kiến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày trả";
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(165, 36);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(324, 31);
            this.tbMa.TabIndex = 4;
            // 
            // dtMuon
            // 
            this.dtMuon.Location = new System.Drawing.Point(165, 103);
            this.dtMuon.Name = "dtMuon";
            this.dtMuon.Size = new System.Drawing.Size(324, 31);
            this.dtMuon.TabIndex = 5;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(261, 168);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(119, 59);
            this.btThem.TabIndex = 8;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(533, 168);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(119, 59);
            this.btSua.TabIndex = 9;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(817, 168);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(119, 59);
            this.btThoat.TabIndex = 10;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // dgvMuonTra
            // 
            this.dgvMuonTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuonTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvMuonTra.Location = new System.Drawing.Point(-4, 252);
            this.dgvMuonTra.Name = "dgvMuonTra";
            this.dgvMuonTra.RowHeadersWidth = 82;
            this.dgvMuonTra.RowTemplate.Height = 33;
            this.dgvMuonTra.Size = new System.Drawing.Size(1080, 346);
            this.dgvMuonTra.TabIndex = 11;
            this.dgvMuonTra.SelectionChanged += new System.EventHandler(this.selectionChanged);
            // 
            // dtTra
            // 
            this.dtTra.Location = new System.Drawing.Point(726, 30);
            this.dtTra.Name = "dtTra";
            this.dtTra.Size = new System.Drawing.Size(324, 31);
            this.dtTra.TabIndex = 12;
            // 
            // dtDK
            // 
            this.dtDK.Location = new System.Drawing.Point(726, 103);
            this.dtDK.Name = "dtDK";
            this.dtDK.Size = new System.Drawing.Size(324, 31);
            this.dtDK.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaPhieu";
            this.Column1.HeaderText = "Mã phiếu";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NgayMuon";
            this.Column2.HeaderText = "Ngày mượn";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayTra";
            this.Column3.HeaderText = "Ngày trả";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgayTraDuKien";
            this.Column4.HeaderText = "Ngày trả dự kiến";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TienPhat";
            this.Column5.HeaderText = "Tiền phạt";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // frmMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 610);
            this.Controls.Add(this.dtDK);
            this.Controls.Add(this.dtTra);
            this.Controls.Add(this.dgvMuonTra);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dtMuon);
            this.Controls.Add(this.tbMa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMuonTra";
            this.Text = "frmMuonTra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuonTra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.DateTimePicker dtMuon;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.DataGridView dgvMuonTra;
        private System.Windows.Forms.DateTimePicker dtTra;
        private System.Windows.Forms.DateTimePicker dtDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}