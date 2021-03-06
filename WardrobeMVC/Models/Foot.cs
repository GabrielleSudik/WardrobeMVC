//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WardrobeMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Foot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Foot()
        {
            this.Outfits = new HashSet<Outfit>();
            this.Recommendations = new HashSet<Recommendation>();
        }
    
        //you added a key because you got an error message that there was no key
        //despite the fact that there WAS a key

        //later: you commented out the edits and put them in the FootMetaData class
        //BUT the changes didn't "take" in the buddy class
        //maybe because you initially named it wrong?

        //[Key]
        public int FeetID { get; set; }
        //[Display(Name = "Feet")]
        public string ShoeName { get; set; }
        public string Photo { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string Style { get; set; }
        public string Occasion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Outfit> Outfits { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recommendation> Recommendations { get; set; }
    }
}
