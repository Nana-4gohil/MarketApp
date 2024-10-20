using System.ComponentModel.DataAnnotations;

namespace Switch_and_Shift.Models
{
    public class Categories
    {
        [Key]
        public int categories_id { get; set; }

        [Required]
        public string categories_name { get; set; }
    }
}
