//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transport
    {
        public Transport()
        {
            this.TourTransports = new HashSet<TourTransport>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public Nullable<System.DateTime> Adddate { get; set; }
    
        public virtual ICollection<TourTransport> TourTransports { get; set; }
    }
}
