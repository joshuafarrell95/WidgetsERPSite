using System;
using System.ComponentModel.DataAnnotations;

namespace WidgetsERPSite.Models
{
   [MetadataType(typeof(ItemMetadata))]
   public partial class Item
   {
   }

   [MetadataType(typeof(InvoiceMetadata))]
   public partial class Invoice
   {
   }

   [MetadataType(typeof(Line_itemMetadata))]
   public partial class Line_item
   {
   }
}