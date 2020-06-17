using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        [Display(Name = "Default Number Of Days")]
        [Range(1,30, ErrorMessage = "Please Enter A Valid Number")]
        public int DefaultDays { get; set; }
        [Display(Name="Default Days")]
        public DateTime? DateCreated { get; set; }
    }


 

}
