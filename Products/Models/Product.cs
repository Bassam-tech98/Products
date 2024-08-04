using System.ComponentModel.DataAnnotations.Schema;

namespace Products.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string Img { get; set; }
        public double Price { get; set; }

        public int Rate { get; set; }


        [ForeignKey(nameof(catogeryId))]
        public int catogeryId { get; set; }
        public Catogery catogery { get; set; }



    }
}
