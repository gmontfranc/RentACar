// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Package
    {
        public Package()
        {
            Bookings = new HashSet<Booking>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int TransferFeeId { get; set; }

        public virtual TransferFee TransferFee { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}