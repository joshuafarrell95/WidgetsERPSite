using System;
using System.ComponentModel.DataAnnotations;

namespace WidgetsERPSite.Models
{
    public class ItemMetadata
    {
        [DisplayFormat(DataFormatString = "{0:C}")]
        public string Price;
    }

    public class InvoiceMetadata
    {
        [DisplayFormat(DataFormatString = "{0:C}")]
        public string InvoiceTotal;
    }

    public class Line_itemMetadata
    {
        [DisplayFormat(DataFormatString = "{0:C}")]
        public string ItemTotal;
    }
}