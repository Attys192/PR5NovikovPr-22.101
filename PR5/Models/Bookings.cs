//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PR5.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bookings
    {
        public int BookingID { get; set; }
        public int OrderID { get; set; }
        public int RideID { get; set; }
        public System.DateTime BookingDate { get; set; }
        public int NumberOfSeats { get; set; }
        public decimal TotalPrice { get; set; }
    
        public virtual Orders Orders { get; set; }
        public virtual Rides Rides { get; set; }
    }
}
