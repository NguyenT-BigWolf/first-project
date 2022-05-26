using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanDongHo.DTO
{
    public class DonNhapHang
    {
        [Key][StringLength(10)][Required]
        public string IDDonNhapHang { get; set; }
        public string IDNhanVien { get; set; }
        public string IDDongHo { get; set; }
        [Column(TypeName="date")]
        public DateTime? NgayNhapHang { get; set; }
        [ForeignKey("IDNhanVien")]
        public virtual NhanVien NhanVien { get; set; }
        [ForeignKey("IDDongHo")]
        public virtual DongHo DongHo { get; set; }
    }
}
