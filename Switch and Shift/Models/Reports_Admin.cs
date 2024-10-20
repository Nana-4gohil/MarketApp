﻿using System.ComponentModel.DataAnnotations;

namespace Switch_and_Shift.Models
{
    public class Reports_Admin
    {
        [Key]
        public int report_admin_id { get; set; }


        [Required]
        public string reporter_email { get; set; }

        [Required]
        public string reportee_email { get; set; }

        [Required]
        public string reporter_name { get; set; }
        [Required]
        public string reportee_name { get; set; }

        [Required]
        public int report_show { get; set; }
    }

}
