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
    
    public partial class Reservatie
    {
        public int ReservatieNr { get; set; }
        public int KlantNr { get; set; }
        public int VoorstellingsNr { get; set; }
        public short Plaatsen { get; set; }
    
        public virtual Klant Klanten { get; set; }
        public virtual Voorstelling Voorstellingen { get; set; }
    }
}
