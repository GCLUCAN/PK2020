using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Clinica
{
    public class LaboratorioExameFaixaEtaria: Retorno.TabelaGeral
    {
        public string Sexo { get; set; }
        public int IdadeInicial { get; set; }
        public int IdadeFinal { get; set; }
        public string UnidadeFaixa { get; set; }
    }
}
