//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Autori
    {
        public Autori()
        {
            this.Cartis = new HashSet<Carti>();
        }
    
        public int AutorID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
    
        public virtual ICollection<Carti> Cartis { get; set; }
    }
}
