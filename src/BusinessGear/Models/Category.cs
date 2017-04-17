using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DiagnosticsViewPage.Views;
using Mysqlx.Crud;

namespace BusinessGear.Models 
{
    public class Category 
    {
        [Column("category_id")]
        public int Id { get; set; }

        [Column("category")]
        public string Name { get; set; }
    }
}
