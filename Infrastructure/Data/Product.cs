using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp1.Data
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
