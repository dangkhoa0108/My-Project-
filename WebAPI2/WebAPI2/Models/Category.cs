using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPI2.Models
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