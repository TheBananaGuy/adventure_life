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

    public partial class reservation
    {

        [HiddenInput(DisplayValue = false)]
        public int id { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please enter a name")]
        [RegularExpression("^[a-zA-Z\\s]+$", ErrorMessage = "Please enter a valid name")]
        public string name { get; set; }
        [Display(Name = "Phone")]
        [Required(ErrorMessage = "Please enter a phone number")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Please enter a valid phone number")]
        public Nullable<int> phone { get; set; }
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Please enter an e-mail")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter a valid email")]
        public string email { get; set; }
        [Display(Name = "Group size")]
        [Required(ErrorMessage = "Please state the amount of participants")]
        public Nullable<byte> people { get; set; }
        [Display(Name = "Day")]
        [Required(ErrorMessage = "Please select a date")]
        [DataType(DataType.Date, ErrorMessage = "Please enter a valid date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> eventDate { get; set; }
        [Display(Name = "Time")]
        [Required(ErrorMessage = "Please select a time slot")]
        public Nullable<int> eventTimeID { get; set; }
        [Display(Name = "Activity")]
        [Required(ErrorMessage = "Please select an activity")]
        public Nullable<int> activityID { get; set; }
        [Display(Name = "Instructor")]
        public Nullable<int> employeeID { get; set; }
    
        public virtual activity activity { get; set; }
        public virtual employee employee { get; set; }
        public virtual eventTime eventTime { get; set; }
    }
}
