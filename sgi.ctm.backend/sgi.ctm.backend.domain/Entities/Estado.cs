using System;
using System.Collections.Generic;


namespace sgi.ctm.backend.domain.Entities
{
    public class Estado
    {
        public Int64 Id { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
        public Int64 PaisId { get; set; }
    }
}

