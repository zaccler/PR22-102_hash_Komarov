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
    
    public partial class MaterialDeliveries
    {
        public int DeliveryID { get; set; }
        public int OrderID { get; set; }
        public int MaterialID { get; set; }
        public decimal Quantity { get; set; }
        public System.DateTime DeliveryDate { get; set; }
    
        public virtual Materials Materials { get; set; }
        public virtual Orders Orders { get; set; }
    }
}
