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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Mainpanel.Controls.Add(childForm);
            childForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //Form m = new Formchinh();
            //m.Hide();
            Form f = new SignInForm();
            f.Show();
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void danhMụcSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmployeesForm());
        }

        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReadersForm());
        }

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tìmSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tìmĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
