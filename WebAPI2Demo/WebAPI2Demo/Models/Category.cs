using System.ComponentModel.DataAnnotations;

namespace WebAPI2Demo.Models
{
    /// <summary>
    /// Properety from Category Model
    /// </summary>
    public class Category
    {
        public int Id { get; set; }

        [Required] 
        public string Name { get; set; }
    }
}