using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Comercial
{
    public class Avenca
    {
        public int Codigo { get; set; }
        public string Designacao { get; set; }
        public int ModeloID { get; set; }
        public bool IsPropinaEscolar { get; set; }
        public bool OnlyForWeekDays { get; set; }
        public bool IsTemplate { get; set; }
        public bool IncludeMonthReference { get; set; }
        public int FinalDocumentID { get; set; }
        public int SerieID { get; set; }
        public int PaymentTermsID { get; set; }
    }
}
