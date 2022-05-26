using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanDongHo.DTO
{
    public class LoaiDongHo
    {
        public LoaiDongHo()
        {
            this.DongHos = new HashSet<DongHo>();
        }
        [Key][StringLength(10)][Required]
        public string IDLoaiDongHo { get; set; }
        public string TenLoai { get; set; }
        public virtual ICollection<DongHo> DongHos { get; set; }
    }
}
