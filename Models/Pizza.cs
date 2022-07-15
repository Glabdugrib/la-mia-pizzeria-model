using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{
    [Table("pizza")]
    public class Pizza
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        public string Name { get; set; }
        [Required]
        [Column("image_path")]
        public string ImagePath { get; set; }
        [Required]
        [Column("price")]
        public float Price { get; set; }

        public Pizza(string name, string imagePath, float price)
        {
            Name = name;
            ImagePath = imagePath;
            Price = price;
        }
    }
}
