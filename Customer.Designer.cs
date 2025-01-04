namespace Phone_Store
{
    partial class Customer
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpDate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.dgKhachHang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(980, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Khách Hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(54, 93);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(223, 30);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(306, 92);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(43, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "button1";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(233, 202);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(244, 30);
            this.txtSDT.TabIndex = 1;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(233, 148);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(244, 30);
            this.txtTenKH.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(622, 202);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(265, 30);
            this.txtDiaChi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Khách Hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số Điện Thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(501, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa Chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(501, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giới Tính:";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Location = new System.Drawing.Point(622, 148);
            this.cboGioiTinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(265, 30);
            this.cboGioiTinh.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(124, 255);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 34);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpDate
            // 
            this.btnUpDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpDate.Location = new System.Drawing.Point(339, 256);
            this.btnUpDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpDate.Name = "btnUpDate";
            this.btnUpDate.Size = new System.Drawing.Size(135, 34);
            this.btnUpDate.TabIndex = 5;
            this.btnUpDate.Text = "UPDATE";
            this.btnUpDate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(622, 255);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 34);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(390, 92);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(43, 32);
            this.btnQuayLai.TabIndex = 2;
            this.btnQuayLai.Text = "button1";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // dgKhachHang
            // 
            this.dgKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKhachHang.Location = new System.Drawing.Point(35, 307);
            this.dgKhachHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgKhachHang.Name = "dgKhachHang";
            this.dgKhachHang.RowHeadersWidth = 92;
            this.dgKhachHang.RowTemplate.Height = 37;
            this.dgKhachHang.Size = new System.Drawing.Size(914, 253);
            this.dgKhachHang.TabIndex = 6;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 589);
            this.Controls.Add(this.dgKhachHang);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpDate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboGioiTinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Customer";
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpDate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.DataGridView dgKhachHang;
    }
}