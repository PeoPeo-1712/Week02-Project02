using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK01
{
    internal class DAO
    {
        public SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        public DBConnection dbCon = new DBConnection();
        public void Command(string sql)
        public void Them(LopHoc lh)
        {
            string sqlStr = string.Format("INSERT INTO HocSinh(Ten,DiaChi,CMND,dob) VALUES ('{0}','{1}','{2}','{3}')", lh.Hoten, lh.DiaChi, lh.Id, lh.Dob);
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            dbCon.Excute(cmd);
        }

        public void Xoa(LopHoc lh)
        {
            string sqlStr = string.Format("DELETE ƯFROM HocSinh WHERE CMND = '{0}'", lh.Id);
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            dbCon.Excute(cmd);
        }

        public void Sua(LopHoc lh)
        {
            string sqlStr = string.Format("UPDATE HocSinh SET Ten = '{0}', DiaChi = '{1}', dob = '{3}' WHERE CMND = '{2}'", lh.Hoten, lh.DiaChi, lh.Id, lh.Dob.ToString("MM-dd-yyyy"));
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            dbCon.Excute(cmd);
        }
    }
}
