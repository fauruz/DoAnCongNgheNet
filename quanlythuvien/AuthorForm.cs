using quanlythuvien.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlythuvien
{
    public partial class AuthorForm : Form
    {
        dbThuVienDataContext db = new dbThuVienDataContext();
        public AuthorForm()
        {
            InitializeComponent();
        }
        private void clearForm()
        {
            txtAuthorId.Text = string.Empty;
            txtAuthorName.Text = string.Empty;
        }
        private bool checkValid()
        {
            if (txtAuthorId.Text == string.Empty)
            {
                MessageBox.Show("Nhập mã tác giả");
                return false;
            }
            if (txtAuthorName.Text == string.Empty)
            {
                MessageBox.Show("Nhập tên tác giả");
                return false;
            }
            return true;
        }
        private TACGIA storeTacGia()
        {
            TACGIA tg = new TACGIA();
            tg.MATG = txtAuthorId.Text;
            tg.HOTENTG = txtAuthorName.Text;
            return tg;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkValid())
            {
                TACGIA tg = storeTacGia();
                db.TACGIAs.InsertOnSubmit(tg);
                db.SubmitChanges();
                MessageBox.Show("Thêm thành công!");
                btnReview_Click(sender, e);
                clearForm();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkValid())
            {
                TACGIA tg = db.TACGIAs.Single(s => s.MATG == txtAuthorId.Text);
                tg.HOTENTG = txtAuthorName.Text;
                db.SubmitChanges();
                MessageBox.Show("Sửa thành công!");
                btnReview_Click(sender, e);
                clearForm();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (checkValid())
            {
                TACGIA tg = db.TACGIAs.Single(s => s.MATG == txtAuthorId.Text);
                db.TACGIAs.DeleteOnSubmit(tg);
                db.SubmitChanges();
                MessageBox.Show("Xóa thành công!");
                btnReview_Click(sender, e);
                clearForm();
            }
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            List<TACGIA> ltg = db.TACGIAs.ToList();
            dgvAuthor.DataSource = ltg;
            dgvAuthor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAuthor.Columns[0].HeaderText = "Mã tác giả";
            dgvAuthor.Columns[1].HeaderText = "Tên tác giả";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAuthor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TACGIA tg = db.TACGIAs.First(s => s.MATG == dgvAuthor.Rows[e.RowIndex].Cells[0].Value);
            txtAuthorId.Text = tg.MATG;
            txtAuthorName.Text = tg.HOTENTG;
        }

    }
}
