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
    
    public partial class tblInOut
    {
        public int StoreID { get; set; }
        public int BookNumber { get; set; }
        public System.TimeSpan InOutTime { get; set; }
        public System.DateTime InOutDate { get; set; }
        public int OwnerID { get; set; }
        public int DestStoreID { get; set; }
        public int BookID { get; set; }
        public int OrderID { get; set; }
        public int InOutTypeID { get; set; }
        public int AdminID { get; set; }
    
        public virtual tblBook tblBook { get; set; }
        public virtual tblOrder tblOrder { get; set; }
        public virtual tblPerson tblPerson { get; set; }
        public virtual tblPerson tblPerson1 { get; set; }
        public virtual tblPerson tblPerson2 { get; set; }
        public virtual tblInOutType tblInOutType { get; set; }
    }
}
