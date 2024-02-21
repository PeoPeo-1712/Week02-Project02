using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK01
{
    internal class GiangVienDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        DBConnection dbCon = new DBConnection();
        public DataTable GVLoad()
        {
            DataTable dtGiangVien = new DataTable();
            string sqlStr = string.Format("SELECT * FROM GiangVien");
            return dbCon.Load(dtGiangVien, sqlStr);
        }
        public void Them(GiangVien gv)
        {
            string sqlStr = string.Format("INSERT INTO GiangVien(Ten,DiaChi,CMND,dob) VALUES ('{0}','{1}','{2}','{3}')", gv.Hoten, gv.DiaChi, gv.Id, gv.Dob);
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            dbCon.Excute(cmd);
        }

        public void Xoa(GiangVien gv)
        {
            string sqlStr = string.Format("DELETE FROM GiangVien WHERE CMND = '{0}'", gv.Id);
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            dbCon.Excute(cmd);
        }

        public void Sua(GiangVien gv)
        {
            string sqlStr = string.Format("UPDATE GiangVien SET Ten = '{0}', DiaChi = '{1}', dob = '{3}' WHERE CMND = '{2}'", gv.Hoten, gv.DiaChi, gv.Id, gv.Dob.ToString("MM-dd-yyyy"));
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            dbCon.Excute(cmd);
        }
    }
}
