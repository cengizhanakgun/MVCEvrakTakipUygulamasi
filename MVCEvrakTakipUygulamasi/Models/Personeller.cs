//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCEvrakTakipUygulamasi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Personeller
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personeller()
        {
            this.Evraklar = new HashSet<Evraklar>();
            this.Raporlar = new HashSet<Raporlar>();
        }
    
        public int perID { get; set; }
        public string perAD { get; set; }
        public string perKULLANICI { get; set; }
        public string perPAROLA { get; set; }
        public Nullable<int> perYEKILIID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evraklar> Evraklar { get; set; }
        public virtual Yetkiler Yetkiler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Raporlar> Raporlar { get; set; }
    }
}