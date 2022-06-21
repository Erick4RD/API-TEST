using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PK_API.Models
{
    [Table("Tbl_Catalog")]
    public class Catalog
    {
        [Required]
        [Column("Id"), Key]
        public int? Id { get; set; }

        [Required]
        [Column("Name")]
        [StringLength(25)]
        public string? Name { get; set; }

        [Column("Description")]
        [StringLength(50)]
        public string? Description { get; set; }

        [Column("Price")]
        [DataType(DataType.Currency)]
        public float? Price { get; set; }

        [Column("CreatedDate")]
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
    }
}
