//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FishingElite
{
    using System;
    using System.Collections.Generic;
    
    public partial class Client
    {
        public int id { get; set; }
        public string email { get; set; }
        public Nullable<bool> active { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public Nullable<int> active_id { get; set; }
    
        public virtual Active Active1 { get; set; }
    }
}
