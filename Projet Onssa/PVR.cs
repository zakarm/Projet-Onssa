//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projet_Onssa
{
    using System;
    using System.Collections.Generic;
    
    public partial class PVR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PVR()
        {
            this.ListCommission = new HashSet<Commission>();
        }
    
        public int IdPVR { get; set; }
        public string DateString { get; set; }
        public System.DateTime DatePVR { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Commission> ListCommission { get; set; }
        public virtual OI InfoOI { get; set; }
    }
}