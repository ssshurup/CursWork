//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CursWork
{
    using System;
    using System.Collections.Generic;
    
    public partial class ticketUser
    {
        public int id { get; set; }
        public Nullable<int> idTicket { get; set; }
        public Nullable<int> idUser { get; set; }
    
        public virtual tickets tickets { get; set; }
        public virtual users users { get; set; }
    }
}
