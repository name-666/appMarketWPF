//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace shop
{
    using System;
    using System.Collections.Generic;
    
    public partial class zakaz
    {
        public int ID { get; set; }
        public int ID_Tovara { get; set; }
        public bool pay { get; set; }
        public System.DateTime date { get; set; }
        public int ID_customer { get; set; }
        public int summa { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual tovar tovar { get; set; }
    }
}
