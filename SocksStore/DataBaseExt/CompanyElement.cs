using System.ComponentModel.DataAnnotations;

namespace DataBaseExt
{
    public class CompanyElement
    {

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string CompanyName { get; set; }
        [StringLength(50)]
        public int SocksId { get; set; }
    }
}