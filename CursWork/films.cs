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
    
    public partial class films
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public films()
        {
            this.schedule = new HashSet<schedule>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<int> idCountry { get; set; }
        public Nullable<System.DateTime> releaseDate { get; set; }
        public Nullable<int> idGenre { get; set; }
        public string duration { get; set; }
        public Nullable<int> idDirector { get; set; }
        public string description { get; set; }
        public Nullable<int> rating { get; set; }
        public Nullable<int> cost { get; set; }
    
        public virtual country country { get; set; }
        public virtual director director { get; set; }
        public virtual genre genre { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<schedule> schedule { get; set; }
    }
}
