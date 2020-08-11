using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class AlunoDividaDTO
    {
      
        public MensalidadeAluno DivPlanoAluno { get; set; }
        public String DivPlanoDescricao { get; set; }
        public String DivPlanoPeriodo { get; set; }
        public Decimal DivPlanoPreco { get; set; }
        public String DivPlanoSituacao { get; set; }
        public String DivInscricao { get; set; }
        public String DivNomeAluno { get; set; }
        public Decimal Total { get; set; }
        public DateTime DivData { get; set; }

        public int MultaID { get; set; }
    }
}
