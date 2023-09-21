using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocksStore.DBModel
{
    public class SocksTable
    {
        [Key]
        public int SocksId {get;set; }
        [MaxLength(50)]
        public string Size {get;set; }
        [MaxLength(50)]
        public string Material {get;set; }
        [MaxLength(50)]
        public string Color {get;set;}
        public CompanyTable CompanyTable { get;set;}

    }
}
