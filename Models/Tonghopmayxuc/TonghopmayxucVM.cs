using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Tonghopmayxuc
{
    public class TonghopmayxucVM
    {

        public int Id { get; set; }
        public string MaQuanLy { get; set; } = string.Empty;
        public string TenMayXuc { get; set; } = string.Empty;
        public int MayxucId { get; set; }
        public string TenPhongBan { get; set; } = string.Empty;
        public int PhongBanId { get; set; }
        public string LoaiThietBi { get; set; } = string.Empty;
        public int LoaiThietBiId { get; set; }
        public string ViTriLapDat { get; set; } = string.Empty;
        public DateTime NgayLap { get; set; }
        public string TinhTrang { get; set; } = string.Empty;
        public int SoLuong { get; set; }
        public string GhiChu { get; set; } = string.Empty;
        public bool DuPhong { get; set; }
        public int TongTB { get; set; }
    }
}
