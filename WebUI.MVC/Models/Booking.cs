using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebUI.MVC.Models
{
    [Serializable]
    public class Booking
    {
        public int Id { get; set; }
        public DateTime FromDateTime { get; set; }
        public DateTime ReturnDateTime { get; set; }
        public int PickUpLocationId { get; set; }
        public int DropOffLocationId { get; set; }
        public string Status { get; set; }
        public double Amount { get; set; }
        public int CustomerId { get; set; }
        public int CarId { get; set; }
        public int? InvoiceId { get; set; }
        public int? PackageId { get; set; }
    }

    
    public class Bookings
    {
        [JsonProperty("bookings")]
        public List<Booking> BookingList { get; set; }
    }
}
