//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WidgetsERPSite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Line_item
    {
        public int PKFK_ItemID { get; set; }
        public int PKFK_InvoiceNo { get; set; }
        public Nullable<int> Qty { get; set; }
        public Nullable<double> ItemTotal { get; set; }
    
        public virtual Invoice Invoice { get; set; }
        public virtual Item Item { get; set; }
    }
}
