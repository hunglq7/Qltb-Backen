using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.GiaCot
{
    public class CapnhatgiacotVm
    {
        public int CapNhatId { get; set; }
        public string TenDonVi { get; set; }
        public int DonViId { get; set; }
        public string TenLoaiThietBi { get; set; }
        public int LoaiThietBiId { get; set; }
        public int SoLuongDangQuanLy { get; set; }
        public int SoLuongHuyDong { get; set; }
        public int SoLuongHong { get; set; }
        public int SoLuongDuPhong { get; set; }
        public DateTime NgayCapNhat { get; set; }
    }
}