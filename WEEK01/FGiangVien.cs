using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEEK01
{
    public partial class FGiangVien : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        GiangVienDAO gvDAO = new GiangVienDAO();
        public FGiangVien()
        {
            InitializeComponent();
        }

        private void FGiangVien_Load(object sender, EventArgs e)
        {
            gvHsinh2.DataSource = gvDAO.GVLoad();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GiangVien hs = new GiangVien(txtName.Text, txtAdress.Text, txtID.Text, dtpDoB.Value);
            gvDAO.Them(hs);
            FGiangVien_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            GiangVien hs = new GiangVien(txtName.Text, txtAdress.Text, txtID.Text, dtpDoB.Value);
            gvDAO.Xoa(hs);
            FGiangVien_Load(sender, e);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            GiangVien hs = new GiangVien(txtName.Text, txtAdress.Text, txtID.Text, dtpDoB.Value);
            gvDAO.Sua(hs);
            FGiangVien_Load(sender, e);
        }
    }
}
