using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace WEEK01
{
    public partial class FHocsinh : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        HocSinhDAO hsDAO = new HocSinhDAO();
        public FHocsinh()
        {
            InitializeComponent();
        }

        private void FHocsinh_Load(object sender, EventArgs e)
        {
            gvHsinh.DataSource = hsDAO.SVLoad();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtName.Text, txtAdress.Text, txtID.Text, dtpDoB.Value);
            hsDAO.Them(hs);
            FHocsinh_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtName.Text, txtAdress.Text, txtID.Text, dtpDoB.Value);
            hsDAO.Xoa(hs);
            FHocsinh_Load(sender, e);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtName.Text, txtAdress.Text, txtID.Text, dtpDoB.Value);
            hsDAO.Sua(hs);
            FHocsinh_Load(sender, e);
        }

        private void gvHsinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* if (gvHsinh.SelectedRows.Count > 0)
            {
                txtID.Text = gvHsinh.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = gvHsinh.SelectedRows[0].Cells[1].Value.ToString();
                txtAdress.Text = gvHsinh.SelectedRows[0].Cells[2].Value.ToString();
                dtpDoB.Value = (DateTime)gvHsinh.SelectedRows[0].Cells[3].Value;
            }*/

        }
        private void gvHsinh_SelectionChanged(object sender, EventArgs e)
        {
           /*if (gvHsinh.SelectedRows.Count > 0)
            {
                txtID.Text = gvHsinh.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = gvHsinh.SelectedRows[0].Cells[1].Value.ToString();
                txtAdress.Text = gvHsinh.SelectedRows[0].Cells[2].Value.ToString();
                dtpDoB.Value = (DateTime)gvHsinh.SelectedRows[0].Cells[3].Value;
            }*/
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FGiangVien Gvien = new FGiangVien();
            Gvien.Show();
        }


    }
}