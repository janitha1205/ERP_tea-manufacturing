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
    
    public partial class SocialLog
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string ImagePath { get; set; }
        public System.DateTime AddDate { get; set; }
        public int LastUpdateUserID { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        public virtual User_list User_list { get; set; }
    }
}
