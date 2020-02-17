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
    
    public partial class tblOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblOrder()
        {
            this.tblInOut = new HashSet<tblInOut>();
            this.tblOrderDetail = new HashSet<tblOrderDetail>();
        }
    
        public int OrderID { get; set; }
        public int OrderNumber { get; set; }
        public double OrderCost { get; set; }
        public System.DateTime OrderPayDate { get; set; }
        public System.DateTime OrderDeliveryDate { get; set; }
        public System.DateTime OrderInsertDate { get; set; }
        public int PersonID { get; set; }
        public int DiscountID { get; set; }
        public int StatusID { get; set; }
    
        public virtual tblDiscount tblDiscount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblInOut> tblInOut { get; set; }
        public virtual tblPerson tblPerson { get; set; }
        public virtual tblStatus tblStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderDetail> tblOrderDetail { get; set; }
    }
}
