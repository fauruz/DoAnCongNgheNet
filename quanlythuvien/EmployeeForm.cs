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
using quanlythuvien.Objects;

namespace quanlythuvien
{
    public partial class EmployeeForm : Form
    {
        dbThuVienDataContext db = new dbThuVienDataContext();
        public EmployeeForm()
        {
            InitializeComponent();
        }
        private void clearForm()
        {
            txtEmployeeId.Text = string.Empty;
            txtEmployeeName.Text = string.Empty;
            dtpEmployeeDOB.Value = DateTime.Now;
            cbbGender.SelectedIndex = -1;
        }
        private bool checkValid()
        {
            if (txtEmployeeId.Text == string.Empty)
            {
                MessageBox.Show("Nhập mã nhân viên");
                return false;
            }
            if (txtEmployeeName.Text == string.Empty)
            {
                MessageBox.Show("Nhập tên nhân viên");
                return false;
            }
            if (dtpEmployeeDOB.Value == DateTime.Now)
            {
                MessageBox.Show("Nhập ngày sinh nhân viên");
                return false;
            }
            if (cbbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Nhập giới tính nhân viên");
                return false;
            }
            return true;
        }
        private NHANVIEN storeNhanVien()
        {
            NHANVIEN nv = new NHANVIEN();
            nv.MANV = txtEmployeeId.Text;
            nv.HOTENNV = txtEmployeeName.Text;
            nv.NGAYSINH = dtpEmployeeDOB.Value;
            nv.GIOITINH = cbbGender.Text;
            return nv;
        }
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            dtpEmployeeDOB.Value = DateTime.Now;
            cbbGender.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkValid())
            {
                NHANVIEN nv = storeNhanVien();
                db.NHANVIENs.InsertOnSubmit(nv);
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
                NHANVIEN nv = db.NHANVIENs.Single(s => s.MANV == txtEmployeeId.Text);
                nv.HOTENNV = txtEmployeeName.Text;
                nv.NGAYSINH = dtpEmployeeDOB.Value;
                nv.GIOITINH = cbbGender.Text;
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
                NHANVIEN nv = db.NHANVIENs.Single(s => s.MANV == txtEmployeeId.Text);
                db.NHANVIENs.DeleteOnSubmit(nv);
                db.SubmitChanges();
                MessageBox.Show("Xóa thành công!");
                btnReview_Click(sender, e);
                clearForm();
            }
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            List<NHANVIEN> lnv = db.NHANVIENs.ToList();
            dgvEmployee.DataSource = lnv;
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployee.Columns[0].HeaderText = "Mã nhân viên";
            dgvEmployee.Columns[1].HeaderText = "Tên nhân viên";
            dgvEmployee.Columns[2].HeaderText = "Ngày sinh";
            dgvEmployee.Columns[3].HeaderText = "Giới tính";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NHANVIEN nv = db.NHANVIENs.First(s => s.MANV == dgvEmployee.Rows[e.RowIndex].Cells[0].Value);
            txtEmployeeId.Text = nv.MANV;
            txtEmployeeName.Text = nv.HOTENNV;
            dtpEmployeeDOB.Value = nv.NGAYSINH.Value;
            cbbGender.Text = nv.GIOITINH;
        }
    }
}
