//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Application.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblNotification
    {
        public int NotificationID { get; set; }
        public string NotificationDescription { get; set; }
        public bool IsSee { get; set; }
        public int PersonID { get; set; }
    
        public virtual tblPerson tblPerson { get; set; }
    }
}
