using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseExt
{
    public class SockElement
    {
        [Key]
        public int SocksId { get; set; }
        [StringLength(50)]
        public string Size { get; set; }
        [StringLength(50)]
        public string Material { get; set; }
        [StringLength(50)]
        public string Color { get; set; }
    }
}

