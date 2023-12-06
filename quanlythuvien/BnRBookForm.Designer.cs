namespace quanlythuvien
{
    partial class Borrow_ReturnBook
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpBorrow = new System.Windows.Forms.TabPage();
            this.tpReturn = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpBorrow);
            this.tabControl1.Controls.Add(this.tpReturn);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(807, 729);
            this.tabControl1.TabIndex = 0;
            // 
            // tpBorrow
            // 
            this.tpBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpBorrow.Location = new System.Drawing.Point(4, 25);
            this.tpBorrow.Name = "tpBorrow";
            this.tpBorrow.Padding = new System.Windows.Forms.Padding(3);
            this.tpBorrow.Size = new System.Drawing.Size(799, 700);
            this.tpBorrow.TabIndex = 0;
            this.tpBorrow.Text = "Borrowing";
            this.tpBorrow.UseVisualStyleBackColor = true;
            // 
            // tpReturn
            // 
            this.tpReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpReturn.Location = new System.Drawing.Point(4, 25);
            this.tpReturn.Name = "tpReturn";
            this.tpReturn.Padding = new System.Windows.Forms.Padding(3);
            this.tpReturn.Size = new System.Drawing.Size(799, 700);
            this.tpReturn.TabIndex = 1;
            this.tpReturn.Text = "Returning";
            this.tpReturn.UseVisualStyleBackColor = true;
            // 
            // Borrow_ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 725);
            this.Controls.Add(this.tabControl1);
            this.Name = "Borrow_ReturnBook";
            this.Text = "Borrowing and Returning";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpBorrow;
        private System.Windows.Forms.TabPage tpReturn;
    }
}