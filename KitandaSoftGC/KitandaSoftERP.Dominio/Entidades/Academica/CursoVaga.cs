using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class CursoVaga
    {
        public CursoVaga(Curso curso, AnoLectivo anoLectivo, int vaga)
        {
            this.VagAnoLectivo = anoLectivo;
            this.VagCurso = curso;
            this.VagVaga = vaga;
        }
        public Curso VagCurso { get; set; }
        public AnoLectivo VagAnoLectivo { get; set; }
        public int VagVaga { get; set; }

    }

    public class ListaCursosVagasDTO : List<CursoVaga>
    {

    }
}

