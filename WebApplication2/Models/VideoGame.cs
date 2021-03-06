//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VideoGame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime ReleasedDate { get; set; }
        public string Description { get; set; }
        public bool Rented { get; set; }
        public string UPC { get; set; }
        public int PlatformId { get; set; }
        public int RatingId { get; set; }
    
        public virtual Platform Platform { get; set; }
        public virtual Rating Rating { get; set; }
    }
}
