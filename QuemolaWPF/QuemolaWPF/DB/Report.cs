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
    
    public partial class Report
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> DataFineLavoro { get; set; }
        public string Marca { get; set; }
        public string TipoSfrido { get; set; }
        public string NumeroColata { get; set; }
        public string Destinazione { get; set; }
        public Nullable<int> PezziLavorati { get; set; }
        public Nullable<float> PesoInizioLavoro { get; set; }
        public Nullable<float> PesoFineLavoro { get; set; }
        public Nullable<float> PesoSfrido { get; set; }
        public Nullable<bool> CambioMola { get; set; }
        public Nullable<int> NumeroMoleCambiate { get; set; }
        public Nullable<bool> UtilizzoMolaConsigliata { get; set; }
        public Nullable<bool> UtilizzoGranaConsigliata { get; set; }
        public string TipoMolaUtilizzata { get; set; }
        public string TipoMolaturaUtilizzato { get; set; }
        public string MarcaMolaUtilizzato { get; set; }
        public string NoteLavoro { get; set; }
    }
}
