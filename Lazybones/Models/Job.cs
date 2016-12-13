//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lazybones.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Job
    {
        public string Title { get; set; }
        public string Description { get; set; }
        [Display(Name = "Start")]
        public Nullable<System.DateTime> Start_Time_Date { get; set; }
        [Display(Name = "Ends")]
        public Nullable<System.DateTime> Expirey_Time_Date { get; set; }
        public string Category { get; set; }
        public Nullable<decimal> Pay { get; set; }
        public bool Best_Bid { get; set; }
        public string Picture_Location { get; set; }
        [Display(Name = "Date Completed")]
        public Nullable<System.DateTime> Date_Completed { get; set; }
        public string Poster_Name { get; set; }
        public string Getter_Name { get; set; }
  //      public string Status { get; set; }
        //this holds the actual DB value
        public virtual string Status
        {
            get { return this.GigStatus.ToString(); }
            set
            {
                ;
            }
        }

        //variable for form field
        public GigStatuses GigStatus { get; set; }
        public enum GigStatuses
        {
            Created,
            Assigned,
            Complete,
            Cancelled,
            Expired,
        }

        public virtual string CatDrop
        {
            get { return this.Cats.ToString(); }
            set
            {
                ;
            }
        }
        //variable for form field
        public Categories Cats { get; set; }
        public enum Categories
        {
            Sloth_Giving,
            Dry_Cleaning,
            Test,
            Delivery,
            Other,
        }
        public int ID { get; set; }
        public string Payment_Status { get; set; }
        [Display(Name = "Call")]
        public bool Contact_By_Phone { get; set; }
        [Display(Name = "Email")]
        public bool Contact_By_Email { get; set; }
        [Display(Name = "Text")]
        public bool Contact_By_Text { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string State { get; set; }
        public string Getter { get; set; }
        public string Poster { get; set; }
        public Nullable<decimal> Bid_Amount { get; set; }
        [Display(Name = "Gig location same as home?")]
        public bool Same_as_Home { get; set; }
    }
}
