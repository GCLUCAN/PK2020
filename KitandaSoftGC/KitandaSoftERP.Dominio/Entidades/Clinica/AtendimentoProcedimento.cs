using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Clinica
{
    public class AtendimentoProcedimento : Retorno.Retorno
    {
        public int Codigo { get; set; }
        public int Atendimento { get; set; }
        public int Procedimento { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorLiquidado { get; set; }
        public decimal ValorTotal { get; set; }
        public string ItemDesignation { get; set; }

        public AtendimentoProcedimento()
        {

        }

        public AtendimentoProcedimento(int pAtendimento)
        {

        }

        public AtendimentoProcedimento(int pCodigo, int pAtendimento, int pProcedimento, decimal pPrecoUnitario, decimal pQuantidade, decimal pValorLiquidado, decimal pValorTotal, int pStatus)
        {
            Codigo = pCodigo;
            Atendimento = pAtendimento;
            Procedimento = pProcedimento;
            PrecoUnitario = pPrecoUnitario;
            Quantidade = pQuantidade;
            ValorTotal = pValorTotal;
            ValorLiquidado = pValorLiquidado;
            Status = pStatus;
        }
    }
}
