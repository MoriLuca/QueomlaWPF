//------------------------------------------------------------------------------
// <auto-generated>
//     Codice generato da un modello.
//
//     Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//     Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuemolaWPF.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class MolaTipo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdMarca { get; set; }
    
        public virtual MolaMarca MolaMarca { get; set; }
    }
}
