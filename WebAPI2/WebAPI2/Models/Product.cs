using System.ComponentModel.DataAnnotations;

namespace WebAPI2.Models
{
    /// <summary>
    /// Property from Product class
    /// </summary>
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        //Dung phuong thuc virtual de turn on Lazy Loading
    }
}