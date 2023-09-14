using System.ComponentModel.DataAnnotations;

namespace DataBaseExt
{
    public class CompanyElement
    {

        [Key]
        public int Id { get; set; }
        [StringLength(10)]
        public string CompanyName { get; set; }
        [StringLength(10)]
        public int SocksId { get; set; }
    }
}