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
    
    public partial class OV
    {
        public int IdOV { get; set; }
        public string NumOV { get; set; }
        public string SousOrdonnateur { get; set; }
        public string TresorierPayeur { get; set; }
    
        public virtual OP InfoOP { get; set; }
    }
}