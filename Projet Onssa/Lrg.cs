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
    
    public partial class Lrg
    {
        public int CodeLrg { get; set; }
        public string DescriptionLrg { get; set; }
        public string NumLrg { get; set; }
    
        public virtual Paragraphe InfoParagraphe { get; set; }
        public virtual Ligne Ligne { get; set; }
    }
}
