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
    
    public partial class Job
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> Start_Time_Date { get; set; }
        public Nullable<System.DateTime> Expirey_Time_Date { get; set; }
        public string Category { get; set; }
        public Nullable<decimal> Pay { get; set; }
        public bool Best_Bid { get; set; }
        public string Picture_Location { get; set; }
        public Nullable<System.DateTime> Date_Completed { get; set; }
        public string Poster_Name { get; set; }
        public string Getter_Name { get; set; }
        public string Status { get; set; }
        public int ID { get; set; }
        public bool Contact_By_Phone { get; set; }
        public bool Contact_By_Email { get; set; }
        public bool Contact_By_Text { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string State { get; set; }
        public string Getter { get; set; }
        public string Poster { get; set; }
        public Nullable<decimal> Bid_Amount { get; set; }
        public bool Same_as_Home { get; set; }
        public bool Payment_Complete { get; set; }
        public string Comments { get; set; }
        public int Getter_Badges { get; set; }
        public string Comment_History { get; set; }
        public string Poster_Phone { get; set; }
        public string Getter_Phone { get; set; }
    }
}
