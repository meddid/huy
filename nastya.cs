//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace huy
{
    using System;
    using System.Collections.Generic;
    
    public partial class nastya
    {
        public int id { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string mname { get; set; }
        public string email { get; set; }
        public string pass { get; set; }
        public int rolee { get; set; }
    
        public virtual roles roles { get; set; }
    }
}
