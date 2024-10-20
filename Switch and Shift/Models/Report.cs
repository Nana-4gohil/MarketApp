using System.ComponentModel.DataAnnotations;

namespace Switch_and_Shift.Models
{
    public class Report
    {
        [Key]
        public int report_Id { get; set; }


        [Required]
        public string product_model { get; set; }

        [Required]
        public string product_brand { get; set; }

        [Required]
        public int product_price { get; set; }

        [Required]
        public string buyer_email { get; set; }


        [Required]
        public string seller_email { get; set; }

        [Required]
        public string seller_name { get; set; }

        [Required]
        public string buyer_name { get; set; }

        [Required]
        public string image_name { get; set; }

    }

}
