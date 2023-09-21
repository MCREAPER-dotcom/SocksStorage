using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocksStore.DBModel
{
    public class CompanyTable
    {
        [Key]
        public int Id {get;set; }
        [MaxLength(50)]
        public string CompanyName { get;set; }
        public int SocksId {get;set; }
        [ForeignKey("SocksId")]
        public List<SocksTable> SocksTable { get;set;}
    }
}
