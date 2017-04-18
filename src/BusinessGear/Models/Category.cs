using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DiagnosticsViewPage.Views;
using Mysqlx.Crud;

namespace BusinessGear.Models 
{
    public class Category 
    {
        [Key]
        [Column("category_id")]
        public int Category_Id { get; set; }

        public string Name { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
