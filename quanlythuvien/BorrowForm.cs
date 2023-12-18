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
        private void dgvBr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PHIEUMUON pm = db.PHIEUMUONs.First(n => n.MAPM == dgvBr.Rows[e.RowIndex].Cells[0].Value);
            txtBrId.Text = pm.MAPM;
            cbbReader.Text = pm.DOCGIA.HOTENDG;
            cbbEmployee.Text = pm.NHANVIEN.HOTENNV;
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

            dgvDetailBr.Visible = false;
            dgvDetailBr.Columns.Add("cl1", "Mã Phiếu mượn");
            dgvDetailBr.Columns.Add("cl2", "Sách");
            dgvDetailBr.Columns.Add("cl3", "Ngày mượn");
            dgvDetailBr.Columns.Add("cl4", "Hạn trả");
            dgvDetailBr.Columns.Add("cl5", "Tình trạng sách");
            foreach (var pm in db.PHIEUMUONs.ToList())
            {
                cbbBrId.Items.Add(pm.MAPM);
            }
            foreach (var s in db.SACHes.ToList())
            {
                CbbBook.Items.Add(s.TENSACH);
            }
            CbbBook.SelectedIndex = 0;
            cbbDay.SelectedIndex = 0;
            DTBr.Value = DateTime.Now;
        }
        private void clearStForm()
        {
            cbbBrId.SelectedIndex = -1;
            CbbBook.SelectedIndex = -1;
            DTBr.Value = DateTime.Now;
            cbbDay.SelectedIndex = 0;
            cbbState.SelectedIndex = -1;
        }
        private bool checkStValid()
        {
            if (cbbBrId.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn phiếu mượn");
                return false;
            }
            return true;
        }
        private CHITIETPHIEUMUON storeChiTietPhieuMuon()
        {
            CHITIETPHIEUMUON ctpm = new CHITIETPHIEUMUON();
            ctpm.MAPM = cbbBrId.Text;
            ctpm.MASACH = db.SACHes.Single(s => s.TENSACH == CbbBook.Text).MASACH;
            ctpm.NGAYMUON = DTBr.Value;
            ctpm.NGAYTRA = DTBr.Value.AddDays(int.Parse(cbbDay.Text));
            ctpm.STATE = "Đang mượn";
            return ctpm;
        }
        private void btnStAdd_Click(object sender, EventArgs e)
        {
            if (checkStValid())
            {
                CHITIETPHIEUMUON ctpm = storeChiTietPhieuMuon();
                db.CHITIETPHIEUMUONs.InsertOnSubmit(ctpm);
                db.SubmitChanges();
                MessageBox.Show("Thêm thành công!");
                btnStReview_Click(sender, e);
                clearStForm();
            }
        }

        private void dgvDetailBr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CHITIETPHIEUMUON ctpm = db.CHITIETPHIEUMUONs.First(n => n.MAPM == dgvDetailBr.Rows[e.RowIndex].Cells[0].Value);
            cbbBrId.Text = ctpm.MAPM;
            CbbBook.Text = db.SACHes.Single(s => s.MASACH == ctpm.MASACH).TENSACH;
            DTBr.Value = ctpm.NGAYMUON;
            cbbState.Text = ctpm.STATE;
        }

        private void btnExtend_Click(object sender, EventArgs e)
        {
            CHITIETPHIEUMUON ctpm = db.CHITIETPHIEUMUONs.FirstOrDefault(s => s.MAPM == cbbBrId.Text && s.MASACH == db.SACHes.Single(n => n.TENSACH == CbbBook.Text).MASACH && s.NGAYMUON == DTBr.Value);
            if (ctpm.STATE == "Hết hạn mượn")
            {
                ctpm.NGAYTRA.Value.AddDays(int.Parse(cbbDay.Text));
                ctpm.STATE = "Đang mượn";
                db.SubmitChanges();
                btnStReview_Click(sender, e);
                clearStForm();
            }
            else
                MessageBox.Show("Vẫn còn hạn mượn");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            CHITIETPHIEUMUON ctpm = db.CHITIETPHIEUMUONs.Single(s => s.MAPM == cbbBrId.Text);
            db.CHITIETPHIEUMUONs.DeleteOnSubmit(ctpm);
            db.SubmitChanges();
            btnStReview_Click(sender, e);
            clearStForm();
        }

        private void btnStReview_Click(object sender, EventArgs e)
        {
            string a;
            dgvDetailBr.Rows.Clear();
            dgvDetailBr.Visible = true;
            foreach (var ctpm in db.CHITIETPHIEUMUONs.ToList())
            {
                a = db.SACHes.Single(s => s.MASACH == ctpm.MASACH).TENSACH;
                dgvDetailBr.Rows.Add(ctpm.MAPM, a, ctpm.NGAYMUON, ctpm.NGAYTRA, ctpm.STATE);
            }
        }
    }
}
