using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RailwayReservationSystem.Models
{
    public class Station_DetailsResults
    {

        [Key]
        public string Stn_Name { get; set; }
        public TimeSpan? Arrival_Time { get; set; }
        public TimeSpan? Departure_Time { get; set; }
    }
}