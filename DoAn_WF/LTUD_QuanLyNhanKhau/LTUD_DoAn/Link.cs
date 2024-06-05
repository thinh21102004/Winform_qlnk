using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTUD_DoAn
{
    internal class Link
    {
        string link;

        public Link()
        {
            link= "Data Source=LAPTOP-THANHPHO\\TESTDB;Initial Catalog=QuanLyNhanKhau;Integrated Security=True";

            //của tuấn
            //link = "Data Source=LAPTOP-KOJHVS2P;Initial Catalog=QuanLyNhanKhau;Integrated Security=True;Encrypt=False";

            //của phong
            //"Data Source=LAPTOP-THANHPHO\\TESTDB;Initial Catalog=QuanLyNhanKhau;Integrated Security=True";

            //của thịnh
            //"Data Source=ADMIN-PC\\HOANGTHINH;Initial Catalog=QuanLyNhanKhau;Integrated Security=True";
        }

        public string _Link { get => link; set => link = value; }
    }
}
