using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class Filiacao : Retorno.Retorno
    {
        public int FilCodigo { get; set; }
        public string FilNome { get; set; }
        public string FilIdentificacao { get; set; }
        public DateTime FilDtNascimento { get; set; }
        public int FilHabilitacoesID { get; set; }
        public string FilHabilitacoesDS { get; set; }
        public int FilProfissaoID { get; set; }
        public string FilProfissaoDS { get; set; }
        public int FilInstituicaoID { get; set; }
        public string FilInstituicao { get; set; }
        public string FilTelefone { get; set; }
        public string FiLTelAlternativo { get; set; }
        public string FilEmail { get; set; }
        public AlunoFiliacao FilAlunoFiliacao { get; set; }
        public ListaAlunoFiliacao Pais { get; set; }



    }

    public class ListaFiliacaoDTO : List<Filiacao>
    {

    }
}

