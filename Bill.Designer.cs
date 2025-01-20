namespace Phone_Store
{
    partial class Bill
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
            this.dtNgayBD = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtNgayKT = new System.Windows.Forms.DateTimePicker();
            this.dgHoaDon = new System.Windows.Forms.DataGridView();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnChiTietHD = new System.Windows.Forms.Button();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Kiếm Hóa Đơn";
            // 
            // dtNgayBD
            // 
            this.dtNgayBD.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayBD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayBD.Location = new System.Drawing.Point(129, 66);
            this.dtNgayBD.Margin = new System.Windows.Forms.Padding(2);
            this.dtNgayBD.Name = "dtNgayBD";
            this.dtNgayBD.Size = new System.Drawing.Size(168, 30);
            this.dtNgayBD.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(333, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Từ ngày:";
            // 
            // dtNgayKT
            // 
            this.dtNgayKT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayKT.Location = new System.Drawing.Point(419, 66);
            this.dtNgayKT.Margin = new System.Windows.Forms.Padding(2);
            this.dtNgayKT.Name = "dtNgayKT";
            this.dtNgayKT.Size = new System.Drawing.Size(168, 30);
            this.dtNgayKT.TabIndex = 2;
            this.dtNgayKT.ValueChanged += new System.EventHandler(this.dtNgayKT_ValueChanged);
            // 
            // dgHoaDon
            // 
            this.dgHoaDon.AllowUserToAddRows = false;
            this.dgHoaDon.AllowUserToDeleteRows = false;
            this.dgHoaDon.AllowUserToResizeColumns = false;
            this.dgHoaDon.AllowUserToResizeRows = false;
            this.dgHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgHoaDon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgHoaDon.ColumnHeadersHeight = 29;
            this.dgHoaDon.Location = new System.Drawing.Point(25, 168);
            this.dgHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.dgHoaDon.Name = "dgHoaDon";
            this.dgHoaDon.ReadOnly = true;
            this.dgHoaDon.RowHeadersVisible = false;
            this.dgHoaDon.RowHeadersWidth = 92;
            this.dgHoaDon.RowTemplate.Height = 37;
            this.dgHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgHoaDon.Size = new System.Drawing.Size(767, 328);
            this.dgHoaDon.TabIndex = 3;
            this.dgHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHoaDon_CellClick);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Image = global::Phone_Store.Properties.Resources.loop__2_;
            this.btnQuayLai.Location = new System.Drawing.Point(743, 49);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(33, 34);
            this.btnQuayLai.TabIndex = 1;
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnChiTietHD
            // 
            this.btnChiTietHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietHD.Image = global::Phone_Store.Properties.Resources.chi_tiet;
            this.btnChiTietHD.Location = new System.Drawing.Point(569, 108);
            this.btnChiTietHD.Margin = new System.Windows.Forms.Padding(2);
            this.btnChiTietHD.Name = "btnChiTietHD";
            this.btnChiTietHD.Size = new System.Drawing.Size(207, 56);
            this.btnChiTietHD.TabIndex = 1;
            this.btnChiTietHD.Text = "Chi Tiết Hoá Đơn";
            this.btnChiTietHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChiTietHD.UseVisualStyleBackColor = true;
            this.btnChiTietHD.Click += new System.EventHandler(this.btnChiTietHD_Click);
            // 
            // btnThemHD
            // 
            this.btnThemHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHD.Image = global::Phone_Store.Properties.Resources.them_hoa_don;
            this.btnThemHD.Location = new System.Drawing.Point(44, 108);
            this.btnThemHD.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(213, 56);
            this.btnThemHD.TabIndex = 1;
            this.btnThemHD.Text = "Thêm Hóa Đơn";
            this.btnThemHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemHD.UseVisualStyleBackColor = true;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Phone_Store.Properties.Resources.search__3___1_;
            this.btnSearch.Location = new System.Drawing.Point(698, 49);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(33, 34);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 521);
            this.Controls.Add(this.dgHoaDon);
            this.Controls.Add(this.dtNgayKT);
            this.Controls.Add(this.dtNgayBD);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnChiTietHD);
            this.Controls.Add(this.btnThemHD);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Bill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtNgayBD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtNgayKT;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.Button btnChiTietHD;
        private System.Windows.Forms.DataGridView dgHoaDon;
    }
}