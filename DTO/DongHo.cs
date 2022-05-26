using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanDongHo.DTO
{
    public class DongHo
    {
        public DongHo()
        {
            this.DonNhapHangs = new HashSet<DonNhapHang>(); 
        }
        [Key][StringLength(10)][Required]
        public string IDDongHo { get; set; }
        public string IDLoaiDongHo { get; set; }
        public string IDHangDongHo { get; set; }
        public string IDNhaCungCap { get; set; }
        public string TenDH { get; set; }
        public int Gia { get; set; }
        public string MoTa { get; set; }
        public bool TrangThai { get; set; }
        //public string HinhAnh { get; set; }
        [ForeignKey("IDLoaiDongHo")]
        public virtual LoaiDongHo LoaiDongHo { get; set;}
        [ForeignKey("IDHangDongHo")]
        public virtual HangDongHo HangDongHo { get; set; }
        [ForeignKey("IDNhaCungCap")]
        public virtual NhaCungCap NhaCungCap { get; set; }
        public virtual ICollection<DonNhapHang> DonNhapHangs { get; set; }
    }
}
