using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanDongHo.DTO
{
    public class NhaCungCap
    {
        public NhaCungCap()
        {
            this.DongHos = new HashSet<DongHo>();
        }
        [Key][StringLength(10)][Required]
        public string IDNhaCungCap { get; set; }
        public string TenNCC { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public virtual ICollection<DongHo> DongHos { get; set; } 
    }
}
