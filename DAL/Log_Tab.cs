//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Log_Tab
    {
        public int ID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> ProcessType { get; set; }
        public Nullable<int> ProcessID { get; set; }
        public string ProcessCatType { get; set; }
        public Nullable<System.DateTime> ProcessDate { get; set; }
        public string ProcessIPAddress { get; set; }
    
        public virtual process_type process_type { get; set; }
        public virtual processID processID1 { get; set; }
        public virtual User_list User_list { get; set; }
    }
}
