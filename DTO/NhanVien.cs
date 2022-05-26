using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanDongHo.DTO
{
    public class NhanVien
    {
        public NhanVien()
        {
            this.DonNhapHangs = new HashSet<DonNhapHang>(); 
        }
        [Key][StringLength(10)][Required]
        public string IDNhanVien { get; set; }
        public string TuCach { get; set; }
        public string HoTen { get; set; }
        public bool GioiTinh { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public virtual ICollection<DonNhapHang> DonNhapHangs { get; set; }
    }
}
