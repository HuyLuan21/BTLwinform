namespace Phone_Store
{
    partial class Product
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpDate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.dgSanPham = new System.Windows.Forms.DataGridView();
            this.cboBoNho = new System.Windows.Forms.ComboBox();
            this.cboRam = new System.Windows.Forms.ComboBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(30, 90);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 30);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(216, 87);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(47, 35);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "button1";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(139, 258);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpDate
            // 
            this.btnUpDate.Location = new System.Drawing.Point(343, 258);
            this.btnUpDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpDate.Name = "btnUpDate";
            this.btnUpDate.Size = new System.Drawing.Size(91, 32);
            this.btnUpDate.TabIndex = 2;
            this.btnUpDate.Text = "UPDATE";
            this.btnUpDate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(589, 258);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 32);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên Sản Phẩm:";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSanPham.Location = new System.Drawing.Point(161, 157);
            this.txtTenSanPham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(190, 30);
            this.txtTenSanPham.TabIndex = 4;
            this.txtTenSanPham.TextChanged += new System.EventHandler(this.txtTenSanPham_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tình Trạng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(585, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bộ Nhớ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(434, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Gía Nhập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(250, 217);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ram:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(649, 217);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Gía Bán:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(677, 153);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(190, 30);
            this.txtSoLuong.TabIndex = 4;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaNhap.Location = new System.Drawing.Point(532, 215);
            this.txtGiaNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(105, 30);
            this.txtGiaNhap.TabIndex = 4;
            // 
            // dgSanPham
            // 
            this.dgSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgSanPham.Location = new System.Drawing.Point(0, 315);
            this.dgSanPham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgSanPham.Name = "dgSanPham";
            this.dgSanPham.RowHeadersWidth = 92;
            this.dgSanPham.RowTemplate.Height = 37;
            this.dgSanPham.Size = new System.Drawing.Size(880, 203);
            this.dgSanPham.TabIndex = 5;
            this.dgSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSanPham_CellClick);
            this.dgSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSanPham_CellContentClick);
            // 
            // cboBoNho
            // 
            this.cboBoNho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBoNho.FormattingEnabled = true;
            this.cboBoNho.Location = new System.Drawing.Point(110, 215);
            this.cboBoNho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboBoNho.Name = "cboBoNho";
            this.cboBoNho.Size = new System.Drawing.Size(108, 30);
            this.cboBoNho.TabIndex = 0;
            // 
            // cboRam
            // 
            this.cboRam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRam.FormattingEnabled = true;
            this.cboRam.Location = new System.Drawing.Point(307, 215);
            this.cboRam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboRam.Name = "cboRam";
            this.cboRam.Size = new System.Drawing.Size(108, 30);
            this.cboRam.TabIndex = 0;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.Location = new System.Drawing.Point(739, 215);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(105, 30);
            this.txtGiaBan.TabIndex = 4;
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Location = new System.Drawing.Point(474, 155);
            this.cboTinhTrang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(108, 30);
            this.cboTinhTrang.TabIndex = 0;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(880, 76);
            this.label8.TabIndex = 6;
            this.label8.Text = "Thông Tin Sản Phẩm";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 518);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgSanPham);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpDate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cboTinhTrang);
            this.Controls.Add(this.cboRam);
            this.Controls.Add(this.cboBoNho);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produst";
            ((System.ComponentModel.ISupportInitialize)(this.dgSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpDate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.DataGridView dgSanPham;
        private System.Windows.Forms.ComboBox cboBoNho;
        private System.Windows.Forms.ComboBox cboRam;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label8;
    }
}