//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wikipedia_koveto.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Page
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string WikiPage { get; set; }
        public int Sensitivity { get; set; }
        public int RefreshRate { get; set; }
        public Nullable<System.DateTime> LastNotified { get; set; }
        public Nullable<System.DateTime> LastRefreshed { get; set; }
        public int Notified { get; set; }
        public int LastRevision { get; set; }
    
        public virtual User User { get; set; }
    }
}
