using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RailwayReservationSystem.Models
{
    public class Search
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Enter Source")]
        public string Source { get; set; }
        [Required(ErrorMessage = "Enter Destination")]
        public string Destination { get; set; }
        [Required(ErrorMessage = "Enter Date Of Journey")]
        [Display(Name = "Date Of Journey")]
        [DataType(DataType.Date)]
        public System.DateTime Doj { get; set; }
    }
}