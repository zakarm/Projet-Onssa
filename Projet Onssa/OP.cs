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
    
    public partial class OP
    {
        public int IdOP { get; set; }
        public string NumOP { get; set; }
        public System.DateTime DateOP { get; set; }
    
        public virtual OI InfoOI { get; set; }
        public virtual OV InfoOV { get; set; }
    }
}