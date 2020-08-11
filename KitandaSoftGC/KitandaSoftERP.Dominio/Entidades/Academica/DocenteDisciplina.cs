using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class DocenteDisciplina : Retorno.Retorno
    {
        public string DocenteName { get; set; }
        public string DisciplinaDesgination { get; set; }
        public Docente Docente { get; set; }
        public UnidadeCurricular Disciplina { get; set; }
    }
}
