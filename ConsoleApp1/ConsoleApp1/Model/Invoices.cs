//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoices
    {
        public int InvoiceID { get; set; }
        public int OrderID { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public string Status { get; set; }
    
        public virtual Orders Orders { get; set; }
    }
}
