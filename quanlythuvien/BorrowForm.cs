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
    public partial class BorrowForm : Form
    {
        dbThuVienDataContext db = new dbThuVienDataContext();
        public BorrowForm()
        {
            InitializeComponent();
        }
        private void clearForm()
        {
            txtBrId.Text = string.Empty;
            cbbReader.SelectedIndex = -1;
            cbbEmployee.SelectedIndex = -1;
        }
        private bool checkValid()
        {
            if (txtBrId.Text == string.Empty)
            {
                MessageBox.Show("Nhập mã phiếu mượn");
                return false;
            }
            if (cbbReader.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn độc giả");
                return false;
            }
            if (cbbEmployee.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn nhân viên");
                return false;
            }
            return true;
        }
        private PHIEUMUON storePhieMuon()
        {
            PHIEUMUON pm = new PHIEUMUON();
            pm.MAPM = txtBrId.Text;
            pm.MADG = db.DOCGIAs.Single(o => o.HOTENDG == cbbReader.Text).MADG;
            pm.MANV = db.NHANVIENs.Single(t => t.HOTENNV == cbbEmployee.Text).MANV;
            return pm;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkValid())
            {
                PHIEUMUON pm = storePhieMuon();
                db.PHIEUMUONs.InsertOnSubmit(pm);
                db.SubmitChanges();
                MessageBox.Show("Thêm thành công!");
                btnReview_Click(sender, e);
                clearForm();
            }
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            dgvBr.Rows.Clear();
            dgvBr.Visible = true;
            foreach (var pm in db.PHIEUMUONs.ToList())
            {
                dgvBr.Rows.Add(pm.MAPM,pm.DOCGIA.HOTENDG,pm.NHANVIEN.HOTENNV);
            }
            dgvBr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {
            dgvBr.Visible = false;
            dgvBr.Columns.Add("cl1", "Mã phiếu mượn");
            dgvBr.Columns.Add("cl2", "Độc giả");
            dgvBr.Columns.Add("cl3", "Người lập phiếu");
            foreach (var dg in db.DOCGIAs.ToList())
            {
                cbbReader.Items.Add(dg.HOTENDG);
            }
            foreach(var nv in db.NHANVIENs.ToList())
            {
                cbbEmployee.Items.Add(nv.HOTENNV);
            }
        }

        private void dgvBr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PHIEUMUON pm = db.PHIEUMUONs.First(n => n.MAPM == dgvBr.Rows[e.RowIndex].Cells[0].Value);
            txtBrId.Text = pm.MAPM;
            cbbReader.Text = pm.DOCGIA.HOTENDG;
            cbbEmployee.Text = pm.NHANVIEN.HOTENNV;
        }
    }
}
