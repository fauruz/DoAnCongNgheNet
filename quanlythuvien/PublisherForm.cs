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
    public partial class PublisherForm : Form
    {
        dbThuVienDataContext db = new dbThuVienDataContext();
        public PublisherForm()
        {
            InitializeComponent();
        }
        private void clearForm()
        {
            txtPublisherId.Text = string.Empty;
            txtPublisherName.Text = string.Empty;
        }
        private bool checkValid()
        {
            if (txtPublisherId.Text == string.Empty)
            {
                MessageBox.Show("Nhập mã nhà xuất bản");
                return false;
            }
            if (txtPublisherName.Text == string.Empty)
            {
                MessageBox.Show("Nhập tên nhà xuất bản");
                return false;
            }
            return true;
        }
        private NHAXUATBAN storeNhaXuatBan()
        {
            NHAXUATBAN nxb = new NHAXUATBAN();
            nxb.MANXB = txtPublisherId.Text;
            nxb.TEN = txtPublisherName.Text;
            return nxb;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkValid())
            {
                NHAXUATBAN nxb = storeNhaXuatBan();
                db.NHAXUATBANs.InsertOnSubmit(nxb);
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
                NHAXUATBAN nxb = db.NHAXUATBANs.Single(s => s.MANXB == txtPublisherId.Text);
                nxb.TEN = txtPublisherName.Text;
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
                NHAXUATBAN nxb = db.NHAXUATBANs.Single(s => s.MANXB == txtPublisherId.Text);
                db.NHAXUATBANs.DeleteOnSubmit(nxb);
                db.SubmitChanges();
                MessageBox.Show("Xóa thành công!");
                btnReview_Click(sender, e);
                clearForm();
            }
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            List<NHAXUATBAN> lnxb = db.NHAXUATBANs.ToList();
            dgvPublisher.DataSource = lnxb;
            dgvPublisher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPublisher.Columns[0].HeaderText = "Mã nhà xuất bản";
            dgvPublisher.Columns[1].HeaderText = "Tên nhà xuất bản";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPublisher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NHAXUATBAN nxb = db.NHAXUATBANs.First(s => s.MANXB == dgvPublisher.Rows[e.RowIndex].Cells[0].Value);
            txtPublisherId.Text = nxb.MANXB;
            txtPublisherName.Text = nxb.TEN;
        }
    }
}
