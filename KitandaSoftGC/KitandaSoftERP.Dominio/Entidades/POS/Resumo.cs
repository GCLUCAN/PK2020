using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.POS
{
    public class Resumo: Retorno.Retorno
    {
        public string ReceiptNumber { get; set; }
        public List<MetodoPagamentoDTO> MetodosPagamentos = new List<MetodoPagamentoDTO>();
    }
}
