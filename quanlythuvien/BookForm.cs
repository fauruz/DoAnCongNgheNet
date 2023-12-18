using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanlythuvien.Objects;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace quanlythuvien
{
    public partial class BookForm : Form
    {
        dbThuVienDataContext db = new dbThuVienDataContext();
        public BookForm()
        {
            InitializeComponent();
        }
        private void clearForm()
        {
            txtBookId.Text = string.Empty;
            txtBookName.Text = string.Empty;
            txtPublishTime.Text = string.Empty;
        }
        private bool checkValid()
        {
            if (txtBookId.Text == string.Empty)
            {
                MessageBox.Show("Nhập mã sách");
                return false;
            }
            if (txtBookName.Text == string.Empty)
            {
                MessageBox.Show("Nhập tên sách");
                return false;
            }
            if(txtPublishTime.Text == string.Empty)
            {
                MessageBox.Show("Nhập năm xuất bản");
                return false;
            }
            return true;
        }
        private SACH storeSach()
        {
            SACH s = new SACH();
            s.MASACH = txtBookId.Text;
            s.TENSACH = txtBookName.Text;
            s.NGAYXUATBAN = DateTime.Parse("1/1/" + txtPublishTime.Text);
            s.MATL = db.THELOAIs.Single(n => n.TENTL == cbbGenre.Text).MATL;
            s.MATG = db.TACGIAs.Single(t => t.HOTENTG == cbbAuthor.Text).MATG;
            s.MANXB = db.NHAXUATBANs.Single(o => o.TEN == cbbPublisher.Text).MANXB;
            return s;
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            foreach (var tl in db.THELOAIs.ToList())
            {
                cbbGenre.Items.Add(tl.TENTL);
            }
            cbbGenre.SelectedIndex = 0;
            foreach (var tg in db.TACGIAs.ToList())
            {
                cbbAuthor.Items.Add(tg.HOTENTG);
            }
            cbbAuthor.SelectedIndex = 0;
            foreach (var nxb in db.NHAXUATBANs.ToList())
            {
                cbbPublisher.Items.Add(nxb.TEN);
            }    
            cbbPublisher.SelectedIndex = 0;
            dgvBook.Columns.Add("cl1", "Mã sách");
            dgvBook.Columns.Add("cl2", "Tên sách");
            dgvBook.Columns.Add("cl3", "Năm xuất bản");
            dgvBook.Columns.Add("cl4", "Thể loại");
            dgvBook.Columns.Add("cl5", "Tác giả");
            dgvBook.Columns.Add("cl6", "Nhà xuất bản");
            dgvBook.Visible = false;
        }

        private void txtPublishTime_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(txtPublishTime.Text, out parsedValue))
            {
                MessageBox.Show("Chỉ được nhập số năm!");
                txtPublishTime.Text = string.Empty;
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkValid())
            {
                SACH s = storeSach();
                db.SACHes.InsertOnSubmit(s);
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
                SACH s = db.SACHes.Single(n => n.MASACH == txtBookId.Text);
                s.TENSACH = txtBookName.Text;
                s.NGAYXUATBAN = DateTime.Parse("1/1/" + txtPublishTime.Text);
                s.MATL = db.THELOAIs.Single(t => t.TENTL == cbbGenre.Text).MATL;
                s.MATG = db.TACGIAs.Single(o => o.HOTENTG == cbbAuthor.Text).MATG;
                s.MANXB = db.NHAXUATBANs.Single(l => l.TEN == cbbPublisher.Text).MANXB;
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
                SACH s = db.SACHes.Single(n => n.MASACH == txtBookId.Text);
                db.SACHes.DeleteOnSubmit(s);
                db.SubmitChanges();
                MessageBox.Show("Xóa thành công!");
                btnReview_Click(sender, e);
                clearForm();
            }
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            dgvBook.Rows.Clear();
            dgvBook.Visible = true;
            foreach (var item in db.SACHes.ToList())
            {
                dgvBook.Rows.Add(item.MASACH,item.TENSACH,item.NGAYXUATBAN.Value.Year,item.THELOAI.TENTL,item.TACGIA.HOTENTG,item.NHAXUATBAN.TEN);
            }    
            dgvBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SACH s = db.SACHes.First(n => n.MASACH == dgvBook.Rows[e.RowIndex].Cells[0].Value);
            txtBookId.Text = s.MASACH;
            txtBookName.Text = s.TENSACH;
            txtPublishTime.Text = s.NGAYXUATBAN.Value.Year.ToString();
            cbbGenre.Text = s.THELOAI.TENTL;
            cbbAuthor.Text = s.TACGIA.HOTENTG;
            cbbPublisher.Text = s.NHAXUATBAN.TEN;
        }
    }
}
