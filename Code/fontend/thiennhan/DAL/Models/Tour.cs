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
    
    public partial class Tour
    {
        public Tour()
        {
            this.BookingDetails = new HashSet<BookingDetail>();
            this.Images = new HashSet<Image>();
            this.TourAttributes = new HashSet<TourAttribute>();
            this.TourPlaces = new HashSet<TourPlace>();
            this.TourTransports = new HashSet<TourTransport>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
        public Nullable<System.DateTime> Adddate { get; set; }
        public string Numberday { get; set; }
        public string Included { get; set; }
        public string NotIncluded { get; set; }
        public string Partnerinfo { get; set; }
        public string Changetour { get; set; }
        public string Canceltour { get; set; }
        public string Notes { get; set; }
        public string Slug { get; set; }
        public string TitleSeo { get; set; }
        public string DesSeo { get; set; }
        public string Keyword { get; set; }
        public Nullable<int> IDCategory { get; set; }
        public Nullable<decimal> Prices { get; set; }
        public Nullable<int> Percentpromotion { get; set; }
        public Nullable<int> Type { get; set; }
    
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<TourAttribute> TourAttributes { get; set; }
        public virtual ICollection<TourPlace> TourPlaces { get; set; }
        public virtual ICollection<TourTransport> TourTransports { get; set; }
    }
}
