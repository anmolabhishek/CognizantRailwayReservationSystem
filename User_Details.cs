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
    
    public partial class User_Details
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User_Details()
        {
            this.Payment_Details = new HashSet<Payment_Details>();
        }
    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public System.DateTime Dob { get; set; }
        public string Email { get; set; }
        public long ContactNo { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string User_Type { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment_Details> Payment_Details { get; set; }
    }
}