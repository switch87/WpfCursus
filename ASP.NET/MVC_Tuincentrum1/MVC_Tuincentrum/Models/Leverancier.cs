//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_Tuincentrum.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Leverancier
    {
        public Leverancier()
        {
            this.Planten = new HashSet<Plant>();
        }
    
        public int LevNr { get; set; }
        public string Naam { get; set; }
        public string Adres { get; set; }
        public string PostNr { get; set; }
        public string Woonplaats { get; set; }
    
        public virtual ICollection<Plant> Planten { get; set; }
    }
}
