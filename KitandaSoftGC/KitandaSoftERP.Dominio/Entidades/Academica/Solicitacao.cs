using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class Solicitacao : Retorno.Retorno
    {
        public int Codigo { get; set; }
        public string Documento { get; set; }
        public Aluno Solicitante { get; set; }
        public DateTime Data { get; set; }
        public string Emissor { get; set; }
        public string Recibo { get; set; }

        public Solicitacao()
        {

        }

        public Solicitacao(string pCodigo)
        {
            // TODO: Complete member initialization
            this.Codigo = Convert.ToInt32(pCodigo);
        }


        public string De { get; set; }

        public string Ate { get; set; }

        public string Numero { get; set; }


        public string Tipo { get; set; }

        public string Motivo { get; set; }

        public string Disciplina { get; set; }

        public List<Nota> Notas { get; set; }

        public string Instituicao { get; set; }

        public string CursoDestino { get; set; }

        public DateTime DataDeferimento { get; set; }

        public string Observacoes { get; set; }

        public string ParecerPedagogia { get; set; }

        public int IsUrgente { get; set; }

        public string ResponsavelDeferimento { get; set; }

        public string MotivoDeferimento { get; set; }

        public decimal Nota { get; set; }

        public string DocFile { get; set; }
    }
}
