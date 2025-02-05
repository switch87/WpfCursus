//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cultuurhuis.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Voorstelling
    {
        public Voorstelling()
        {
            this.Reservaties = new HashSet<Reservatie>();
        }
    
        public int VoorstellingsNr { get; set; }
        public string Titel { get; set; }
        public string Uitvoerders { get; set; }
        public System.DateTime Datum { get; set; }
        public int GenreNr { get; set; }
        public decimal Prijs { get; set; }
        public short VrijePlaatsen { get; set; }
    
        public virtual Genre Genres { get; set; }
        public virtual ICollection<Reservatie> Reservaties { get; set; }
    }
}
