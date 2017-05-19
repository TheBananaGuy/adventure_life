//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdventureLife
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public partial class activity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public activity()
        {
            this.reservations = new HashSet<reservation>();
            this.employees = new HashSet<employee>();
        }

        [HiddenInput(DisplayValue = false)]
        public int id { get; set; }
        [Display(Name = "Activity name")]
        public string name { get; set; }
        [Display(Name = "Price per person")]
        [Required(ErrorMessage = "Please enter a price")]
        [RegularExpression("^[0-9]([.,][0-9]{8,2})?$", ErrorMessage = "Please enter a valid price")]
        public Nullable<decimal> price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reservation> reservations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<employee> employees { get; set; }
    }
}
