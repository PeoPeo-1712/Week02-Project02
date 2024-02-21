using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK01
{
    public class GiangVien : LopHoc
    {
        public GiangVien(string hoten, string CMND, string diachi, DateTime dob)
        : base(hoten,CMND, diachi, dob) { }
    }
}
