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
    
    public partial class Place
    {
        public Place()
        {
            this.TourPlaces = new HashSet<TourPlace>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> Adddate { get; set; }
        public Nullable<int> Type { get; set; }
        public string Images { get; set; }
        public Nullable<int> Istop { get; set; }
    
        public virtual ICollection<TourPlace> TourPlaces { get; set; }
    }
}
