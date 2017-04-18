using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessGear.Models
{
    public class Product
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }

        public int category_id { get; set; }

        [ForeignKey("category_id")]
        public Category Category { get; set; }
    }
}
