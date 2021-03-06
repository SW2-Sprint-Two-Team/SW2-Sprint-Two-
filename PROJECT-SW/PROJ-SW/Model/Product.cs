//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PROJ_SW.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Cart_Product = new HashSet<Cart_Product>();
        }
    
        public int prod_id { get; set; }
        public string prod_name { get; set; }
        public Nullable<double> Price { get; set; }
        public string Prod_Image { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> MGF_Date { get; set; }
        public Nullable<System.DateTime> Expiry_Date { get; set; }
        public Nullable<int> Batch_No { get; set; }
        public Nullable<int> Cate_Id { get; set; }
        public Nullable<int> inventory_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart_Product> Cart_Product { get; set; }
        public virtual Category Category { get; set; }
        public virtual Inventory Inventory { get; set; }
    }
}
