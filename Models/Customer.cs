using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int CuisineId { get; set; }
        [ForeignKey("CuisineId")]
        public virtual Cuisine? Cuisine { get; set; }

        public int AddressId { get; set; }
        [ForeignKey("AddressId")]
        public virtual Address? Address { get; set; }
    }
}