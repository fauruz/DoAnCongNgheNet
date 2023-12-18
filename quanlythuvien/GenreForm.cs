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
    public partial class GenreForm : Form
    {
        dbThuVienDataContext db = new dbThuVienDataContext();
        public GenreForm()
        {
            InitializeComponent();
        }
        private void clearForm()
        {
            txtGenreId.Text = string.Empty;
            txtGenreName.Text = string.Empty;
        }
        private bool checkValid()
        {
            if (txtGenreId.Text == string.Empty)
            {
                MessageBox.Show("Nhập mã thể loại sách");
                return false;
            }
            if (txtGenreName.Text == string.Empty)
            {
                MessageBox.Show("Nhập tên thể loại sách");
                return false;
            }
            return true;
        }
        private THELOAI storeTheLoai()
        {
            THELOAI tl = new THELOAI();
            tl.MATL = txtGenreId.Text;
            tl.TENTL = txtGenreName.Text;
            return tl;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkValid())
            {
                THELOAI tl = storeTheLoai();
                db.THELOAIs.InsertOnSubmit(tl);
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
                THELOAI tl = db.THELOAIs.Single(s => s.MATL == txtGenreId.Text);
                tl.TENTL = txtGenreName.Text;
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
                THELOAI tl = db.THELOAIs.Single(s => s.MATL == txtGenreId.Text);
                db.THELOAIs.DeleteOnSubmit(tl);
                db.SubmitChanges();
                MessageBox.Show("Xóa thành công!");
                btnReview_Click(sender, e);
                clearForm();
            }
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            List<THELOAI> ltl = db.THELOAIs.ToList();
            dgvGenre.DataSource = ltl;
            dgvGenre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGenre.Columns[0].HeaderText = "Mã thể loại sách";
            dgvGenre.Columns[1].HeaderText = "Tên thể loại sách";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvGenre_CellConTENTLtClick(object sender, DataGridViewCellEventArgs e)
        {
            THELOAI tl = db.THELOAIs.First(s => s.MATL == dgvGenre.Rows[e.RowIndex].Cells[0].Value);
            txtGenreId.Text = tl.MATL;
            txtGenreName.Text = tl.TENTL;
        }
    }
}
