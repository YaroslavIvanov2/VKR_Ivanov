//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Diplom_Ivanov_Admin.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dishes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dishes()
        {
            this.Dishes_in_Order = new HashSet<Dishes_in_Order>();
        }
    
        public int id_Dish { get; set; }
        public string Name_dish { get; set; }
        public int Price { get; set; }
        public int Wheight { get; set; }
        public string The_nutritional_value { get; set; }
        public int id_category { get; set; }
        public string Compound { get; set; }
        public string Image { get; set; }
    
        public virtual Category_of_dishes Category_of_dishes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dishes_in_Order> Dishes_in_Order { get; set; }
    }
}
