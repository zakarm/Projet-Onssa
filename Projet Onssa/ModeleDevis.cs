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
    
    public partial class ModeleDevis
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ModeleDevis()
        {
            this.ListProduit = new HashSet<Produit>();
        }
    
        public int IdModeleDevis { get; set; }
        public string NumDevis { get; set; }
        public System.DateTime Date { get; set; }
        public double Total { get; set; }
        public double Tva { get; set; }
        public double Ttc { get; set; }
    
        public virtual Fournisseur InfoFournisseur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Produit> ListProduit { get; set; }
        public virtual Consultation InfoConsultation { get; set; }
    }
}
