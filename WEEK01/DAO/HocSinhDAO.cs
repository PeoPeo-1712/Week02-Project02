using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WEEK01
{
    internal class HocSinhDAO : DAO
    {
        public DataTable SVLoad()
        {
            DataTable dtSinhVien = new DataTable();
            string sqlStr = string.Format("SELECT * FROM HocSinh");
            return dbCon.Load(dtSinhVien, sqlStr);
        }
         
        public void Them(HocSinh hs)
        {
            string sqlStr = string.Format("INSERT INTO HocSinh(Ten,DiaChi,CMND,dob) VALUES ('{0}','{1}','{2}','{3}')", hs.Hoten, hs.DiaChi, hs.Id, hs.Dob);
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            dbCon.Excute(cmd);
        }

        public void Xoa(HocSinh hs)
        {
            string sqlStr = string.Format("DELETE FROM HocSinh WHERE CMND = '{0}'", hs.Id);
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            dbCon.Excute(cmd);
        }

        public void Sua(HocSinh hs)
        {
            string sqlStr = string.Format("UPDATE HocSinh SET Ten = '{0}', DiaChi = '{1}', dob = '{3}' WHERE CMND = '{2}'", hs.Hoten, hs.DiaChi, hs.Id, hs.Dob.ToString("MM-dd-yyyy"));
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            dbCon.Excute(cmd);
        }
    }
}
