namespace quanlythuvien
{
    partial class BorrowForm
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
            this.tab2 = new System.Windows.Forms.TabPage();
            this.cbbState = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnExtend = new System.Windows.Forms.Button();
            this.btnStAdd = new System.Windows.Forms.Button();
            this.dgvDetailBr = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DTBr = new System.Windows.Forms.DateTimePicker();
            this.CbbBook = new System.Windows.Forms.ComboBox();
            this.cbbBrId = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tpBorrow = new System.Windows.Forms.TabPage();
            this.dgvBr = new System.Windows.Forms.DataGridView();
            this.txtBrId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReview = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.cbbReader = new System.Windows.Forms.ComboBox();
            this.cbbEmployee = new System.Windows.Forms.ComboBox();
            this.cbbDay = new System.Windows.Forms.ComboBox();
            this.btnStReview = new System.Windows.Forms.Button();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailBr)).BeginInit();
            this.tpBorrow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBr)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.btnStReview);
            this.tab2.Controls.Add(this.cbbDay);
            this.tab2.Controls.Add(this.cbbState);
            this.tab2.Controls.Add(this.label5);
            this.tab2.Controls.Add(this.btnReturn);
            this.tab2.Controls.Add(this.btnExtend);
            this.tab2.Controls.Add(this.btnStAdd);
            this.tab2.Controls.Add(this.dgvDetailBr);
            this.tab2.Controls.Add(this.label11);
            this.tab2.Controls.Add(this.label6);
            this.tab2.Controls.Add(this.DTBr);
            this.tab2.Controls.Add(this.CbbBook);
            this.tab2.Controls.Add(this.cbbBrId);
            this.tab2.Controls.Add(this.label8);
            this.tab2.Controls.Add(this.label9);
            this.tab2.Controls.Add(this.label10);
            this.tab2.Location = new System.Drawing.Point(4, 25);
            this.tab2.Margin = new System.Windows.Forms.Padding(4);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(4);
            this.tab2.Size = new System.Drawing.Size(799, 700);
            this.tab2.TabIndex = 2;
            this.tab2.Text = "State";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // cbbState
            // 
            this.cbbState.Enabled = false;
            this.cbbState.FormattingEnabled = true;
            this.cbbState.Items.AddRange(new object[] {
            "Đang mượn",
            "Hết hạn mượn"});
            this.cbbState.Location = new System.Drawing.Point(220, 232);
            this.cbbState.Margin = new System.Windows.Forms.Padding(4);
            this.cbbState.Name = "cbbState";
            this.cbbState.Size = new System.Drawing.Size(160, 24);
            this.cbbState.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(264, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 29);
            this.label5.TabIndex = 51;
            this.label5.Text = "Chi tiết phiếu mượn";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(560, 303);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 39);
            this.btnReturn.TabIndex = 21;
            this.btnReturn.Text = "Trả sách";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnExtend
            // 
            this.btnExtend.Location = new System.Drawing.Point(410, 303);
            this.btnExtend.Margin = new System.Windows.Forms.Padding(4);
            this.btnExtend.Name = "btnExtend";
            this.btnExtend.Size = new System.Drawing.Size(100, 39);
            this.btnExtend.TabIndex = 20;
            this.btnExtend.Text = "Gia hạn";
            this.btnExtend.UseVisualStyleBackColor = true;
            this.btnExtend.Click += new System.EventHandler(this.btnExtend_Click);
            // 
            // btnStAdd
            // 
            this.btnStAdd.Location = new System.Drawing.Point(110, 303);
            this.btnStAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnStAdd.Name = "btnStAdd";
            this.btnStAdd.Size = new System.Drawing.Size(100, 39);
            this.btnStAdd.TabIndex = 19;
            this.btnStAdd.Text = "Thêm ";
            this.btnStAdd.UseVisualStyleBackColor = true;
            this.btnStAdd.Click += new System.EventHandler(this.btnStAdd_Click);
            // 
            // dgvDetailBr
            // 
            this.dgvDetailBr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailBr.Location = new System.Drawing.Point(24, 362);
            this.dgvDetailBr.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetailBr.Name = "dgvDetailBr";
            this.dgvDetailBr.RowHeadersWidth = 51;
            this.dgvDetailBr.Size = new System.Drawing.Size(737, 240);
            this.dgvDetailBr.TabIndex = 18;
            this.dgvDetailBr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetailBr_CellContentClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(8, 225);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 29);
            this.label11.TabIndex = 16;
            this.label11.Text = "Tình trạng sách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(424, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Số ngày mượn";
            // 
            // DTBr
            // 
            this.DTBr.Enabled = false;
            this.DTBr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTBr.Location = new System.Drawing.Point(219, 170);
            this.DTBr.Margin = new System.Windows.Forms.Padding(4);
            this.DTBr.Name = "DTBr";
            this.DTBr.Size = new System.Drawing.Size(160, 22);
            this.DTBr.TabIndex = 13;
            this.DTBr.Value = new System.DateTime(2020, 8, 11, 23, 36, 38, 0);
            // 
            // CbbBook
            // 
            this.CbbBook.FormattingEnabled = true;
            this.CbbBook.Location = new System.Drawing.Point(601, 106);
            this.CbbBook.Margin = new System.Windows.Forms.Padding(4);
            this.CbbBook.Name = "CbbBook";
            this.CbbBook.Size = new System.Drawing.Size(160, 24);
            this.CbbBook.TabIndex = 12;
            // 
            // cbbBrId
            // 
            this.cbbBrId.FormattingEnabled = true;
            this.cbbBrId.Location = new System.Drawing.Point(220, 108);
            this.cbbBrId.Margin = new System.Windows.Forms.Padding(4);
            this.cbbBrId.Name = "cbbBrId";
            this.cbbBrId.Size = new System.Drawing.Size(160, 24);
            this.cbbBrId.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(8, 167);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 29);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ngày mượn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(424, 108);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 29);
            this.label9.TabIndex = 9;
            this.label9.Text = "Sách";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(4, 102);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 29);
            this.label10.TabIndex = 8;
            this.label10.Text = "Mã phiếu mượn";
            // 
            // tpBorrow
            // 
            this.tpBorrow.Controls.Add(this.cbbEmployee);
            this.tpBorrow.Controls.Add(this.cbbReader);
            this.tpBorrow.Controls.Add(this.dgvBr);
            this.tpBorrow.Controls.Add(this.txtBrId);
            this.tpBorrow.Controls.Add(this.label4);
            this.tpBorrow.Controls.Add(this.btnReview);
            this.tpBorrow.Controls.Add(this.btnExit);
            this.tpBorrow.Controls.Add(this.btnAdd);
            this.tpBorrow.Controls.Add(this.label3);
            this.tpBorrow.Controls.Add(this.label1);
            this.tpBorrow.Controls.Add(this.label2);
            this.tpBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpBorrow.Location = new System.Drawing.Point(4, 25);
            this.tpBorrow.Name = "tpBorrow";
            this.tpBorrow.Padding = new System.Windows.Forms.Padding(3);
            this.tpBorrow.Size = new System.Drawing.Size(799, 700);
            this.tpBorrow.TabIndex = 0;
            this.tpBorrow.Text = "Borrowing";
            this.tpBorrow.UseVisualStyleBackColor = true;
            // 
            // dgvBr
            // 
            this.dgvBr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBr.Location = new System.Drawing.Point(28, 254);
            this.dgvBr.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBr.Name = "dgvBr";
            this.dgvBr.RowHeadersWidth = 51;
            this.dgvBr.Size = new System.Drawing.Size(731, 430);
            this.dgvBr.TabIndex = 63;
            this.dgvBr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBr_CellContentClick);
            // 
            // txtBrId
            // 
            this.txtBrId.Location = new System.Drawing.Point(280, 90);
            this.txtBrId.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrId.Name = "txtBrId";
            this.txtBrId.Size = new System.Drawing.Size(231, 26);
            this.txtBrId.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(70, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 60;
            this.label4.Text = "Người lập phiếu";
            // 
            // btnReview
            // 
            this.btnReview.Location = new System.Drawing.Point(600, 115);
            this.btnReview.Margin = new System.Windows.Forms.Padding(4);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(100, 38);
            this.btnReview.TabIndex = 59;
            this.btnReview.Text = "Xem";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(600, 186);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 38);
            this.btnExit.TabIndex = 58;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(603, 47);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 36);
            this.btnAdd.TabIndex = 55;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(70, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "Mã độc giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(320, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 50;
            this.label1.Text = "Phiếu mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(70, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 50;
            this.label2.Text = "Mã phiếu";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpBorrow);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Location = new System.Drawing.Point(0, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(807, 729);
            this.tabControl1.TabIndex = 1;
            // 
            // cbbReader
            // 
            this.cbbReader.FormattingEnabled = true;
            this.cbbReader.Location = new System.Drawing.Point(280, 141);
            this.cbbReader.Name = "cbbReader";
            this.cbbReader.Size = new System.Drawing.Size(231, 28);
            this.cbbReader.TabIndex = 64;
            // 
            // cbbEmployee
            // 
            this.cbbEmployee.FormattingEnabled = true;
            this.cbbEmployee.Location = new System.Drawing.Point(280, 187);
            this.cbbEmployee.Name = "cbbEmployee";
            this.cbbEmployee.Size = new System.Drawing.Size(231, 28);
            this.cbbEmployee.TabIndex = 64;
            // 
            // cbbDay
            // 
            this.cbbDay.FormattingEnabled = true;
            this.cbbDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbbDay.Location = new System.Drawing.Point(601, 170);
            this.cbbDay.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDay.Name = "cbbDay";
            this.cbbDay.Size = new System.Drawing.Size(160, 24);
            this.cbbDay.TabIndex = 53;
            // 
            // btnStReview
            // 
            this.btnStReview.Location = new System.Drawing.Point(260, 303);
            this.btnStReview.Margin = new System.Windows.Forms.Padding(4);
            this.btnStReview.Name = "btnStReview";
            this.btnStReview.Size = new System.Drawing.Size(100, 39);
            this.btnStReview.TabIndex = 54;
            this.btnStReview.Text = "Xem";
            this.btnStReview.UseVisualStyleBackColor = true;
            this.btnStReview.Click += new System.EventHandler(this.btnStReview_Click);
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 676);
            this.Controls.Add(this.tabControl1);
            this.Name = "BorrowForm";
            this.Text = "BorrowForm";
            this.Load += new System.EventHandler(this.BorrowForm_Load);
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailBr)).EndInit();
            this.tpBorrow.ResumeLayout(false);
            this.tpBorrow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBr)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnExtend;
        private System.Windows.Forms.Button btnStAdd;
        private System.Windows.Forms.DataGridView dgvDetailBr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DTBr;
        private System.Windows.Forms.ComboBox CbbBook;
        private System.Windows.Forms.ComboBox cbbBrId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tpBorrow;
        private System.Windows.Forms.DataGridView dgvBr;
        private System.Windows.Forms.TextBox txtBrId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbState;
        private System.Windows.Forms.ComboBox cbbEmployee;
        private System.Windows.Forms.ComboBox cbbReader;
        private System.Windows.Forms.ComboBox cbbDay;
        private System.Windows.Forms.Button btnStReview;
    }
}