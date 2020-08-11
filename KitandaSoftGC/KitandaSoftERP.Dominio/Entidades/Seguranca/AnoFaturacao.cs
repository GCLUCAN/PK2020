using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Seguranca
{
    public class AnoFaturacao : Retorno.Retorno
    {
        public int Ano { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        public bool Actived { get; set; }

        public AnoFaturacao()
        {
        }
        public AnoFaturacao(int pAno, string pDescricao, DateTime pFrom, DateTime pUntil, bool pStatus)
        {
            Ano = pAno;
            Descricao = pDescricao;
            Inicio = pFrom;
            Termino = pUntil;
            Actived = pStatus;
        }
    }
}
