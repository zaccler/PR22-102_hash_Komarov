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
    
    public partial class Reports
    {
        public int ReportID { get; set; }
        public int OrderID { get; set; }
        public string ReportType { get; set; }
        public System.DateTime SubmissionDate { get; set; }
        public decimal Amount { get; set; }
    
        public virtual Orders Orders { get; set; }
    }
}
