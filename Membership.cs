using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RailwayReservationSystem.Models
{
    public class Membership
    {

        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
    }
}