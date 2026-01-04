using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1.Infrastructure.Data
{
    internal class Product
    {
        [Key]
        public int? ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }




    }
}
