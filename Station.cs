//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RailwayReservationSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Station
    {
        public string Stn_Name { get; set; }
        public int Stn_Code { get; set; }
        public Nullable<System.TimeSpan> Arrival_Time { get; set; }
        public Nullable<System.TimeSpan> Departure_Time { get; set; }
        public int Train_No { get; set; }
    
        public virtual Train_Details Train_Details { get; set; }
    }
}
