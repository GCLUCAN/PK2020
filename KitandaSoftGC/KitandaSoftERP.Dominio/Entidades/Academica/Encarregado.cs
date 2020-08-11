using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class Encarregado: Retorno.Retorno
    {
        public Aluno EncAluno { get; set; }
        public string EncNome { get; set; }
        public string EncTelefone { get; set; }
        public string EncTelemovel { get; set; }
        public string EncParentesco { get; set; }
        public string EncEmail { get; set; }



        public class ListaEncarregadosDTO : List<Encarregado>
    {

    }
  }
}
