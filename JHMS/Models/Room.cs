//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JHMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Room
    {
        public int Id { get; set; }
        public int roomno { get; set; }
        public string roomtype { get; set; }
        public int noofVisitors { get; set; }
        public double price { get; set; }
        public bool isBooked { get; set; }
        public int BranchId { get; set; }
        public int BookingId { get; set; }
    
        public virtual Booking Booking { get; set; }
        public virtual Branch Branch { get; set; }
    }
}