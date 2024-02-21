using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK01
{
    public class LopHoc
    {
        string hoten;
        string id;
        string diachi;
        DateTime dob;
        public string Hoten { get => hoten; set => hoten = value; }
        public string Id { get => id; set => id = value; }
        public string DiaChi { get => diachi; set => diachi = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public LopHoc(string hoten, string CMND, string diachi, DateTime dob)
        {
            Hoten = hoten;
            Id = CMND;
            DiaChi = diachi;
            Dob = dob;

        }
    }
}
