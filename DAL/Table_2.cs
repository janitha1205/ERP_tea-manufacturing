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
    
    public partial class Table_2
    {
        public int ID { get; set; }
        public int MetaID { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public string MetaContent { get; set; }
        public string About { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<int> LastUpdatedUserID { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate { get; set; }
        public Nullable<System.DateTime> AddedDate { get; set; }
    
        public virtual User_list User_list { get; set; }
        public virtual User_list User_list1 { get; set; }
    }
}
