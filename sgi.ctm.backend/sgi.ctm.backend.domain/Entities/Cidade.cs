using System;
using System.Collections.Generic;


namespace sgi.ctm.backend.domain.Entities
{
    public class Cidade
    {
        public Int64 Id { get; set; }
        public string Nome { get; set; }
        public Int64 EstadoId { get; set; }
    }
}
