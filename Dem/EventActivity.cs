//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dem
{
    using System;
    using System.Collections.Generic;
    
    public partial class EventActivity
    {
        public int Id { get; set; }
        public Nullable<int> IdActivity { get; set; }
        public Nullable<int> IdEvent { get; set; }
    
        public virtual Activity Activity { get; set; }
        public virtual Event Event { get; set; }
    }
}