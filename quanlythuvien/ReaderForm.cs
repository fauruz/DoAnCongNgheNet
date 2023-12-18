using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using quanlythuvien.Objects;

namespace quanlythuvien
{
    public partial class ReaderForm : Form
    {
        dbThuVienDataContext db = new dbThuVienDataContext();
        public ReaderForm()
        {
            InitializeComponent();
        }
        private void clearForm()
        {
            txtReaderId.Text = string.Empty;
            txtReaderName.Text = string.Empty;
            dtpReaderDOB.Value = DateTime.Now;
            cbbGender.SelectedIndex = -1;
        }
        private bool checkValid()
        {
            if (txtReaderId.Text == string.Empty)
            {
                MessageBox.Show("Nhập mã độc giả");
                return false;
            }
            if (txtReaderName.Text == string.Empty)
            {
                MessageBox.Show("Nhập tên độc giả");
                return false;
            }
            if (dtpReaderDOB.Value == DateTime.Now)
            {
                MessageBox.Show("Nhập ngày sinh độc giả");
                return false;
            }
            if (cbbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Nhập giới tính độc giả");
                return false;
            }
            return true;
        }
        private DOCGIA storeDocGia()
        {
            DOCGIA rd = new DOCGIA();
            rd.MADG = txtReaderId.Text;
            rd.HOTENDG = txtReaderName.Text;
            rd.NGAYSINH = dtpReaderDOB.Value;
            rd.GIOITINH = cbbGender.Text;
            return rd;
        }
        private void ReadersForm_Load(object sender, EventArgs e)
        {
            dtpReaderDOB.Value = DateTime.Now;
            cbbGender.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(checkValid())
            {
                DOCGIA rd = storeDocGia();
                db.DOCGIAs.InsertOnSubmit(rd);
                db.SubmitChanges();
                MessageBox.Show("Thêm thành công!");
                btnReview_Click(sender, e);
                clearForm();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(checkValid())
            {
                DOCGIA rd = db.DOCGIAs.Single(s => s.MADG == txtReaderId.Text);
                rd.HOTENDG = txtReaderName.Text;
                rd.NGAYSINH = dtpReaderDOB.Value;
                rd.GIOITINH = cbbGender.Text;
                db.SubmitChanges();
                MessageBox.Show("Sửa thành công!");
                btnReview_Click(sender, e);
                clearForm();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(checkValid())
            {
                DOCGIA rd = db.DOCGIAs.Single(s => s.MADG == txtReaderId.Text);
                db.DOCGIAs.DeleteOnSubmit(rd);
                db.SubmitChanges();
                MessageBox.Show("Xóa thành công!");
                btnReview_Click(sender, e);
                clearForm();
            }
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            List<DOCGIA> lrd = db.DOCGIAs.ToList();
            dgvReader.DataSource = lrd;
            dgvReader.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReader.Columns[0].HeaderText = "Mã độc giả";
            dgvReader.Columns[1].HeaderText = "Tên độc giả";
            dgvReader.Columns[2].HeaderText = "Ngày sinh";
            dgvReader.Columns[3].HeaderText = "Giới tính";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvReader_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DOCGIA rd = db.DOCGIAs.First(s => s.MADG == dgvReader.Rows[e.RowIndex].Cells[0].Value);
            txtReaderId.Text = rd.MADG;
            txtReaderName.Text = rd.HOTENDG;
            dtpReaderDOB.Value = rd.NGAYSINH.Value;
            cbbGender.Text = rd.GIOITINH;
        }
    }
}
