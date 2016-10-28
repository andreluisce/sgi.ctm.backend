using sgi.ctm.backend.domain.Entities.Enum;
using System;

namespace sgi.ctm.backend.domain.Entities
{
    public class PerfilAluno
    {
        public Int64 Id { get; set; }
        public Sexo Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Skype { get; set; }
        public string Facebook { get; set; }
        public string Fone1 { get; set; }
        public string Fone2 { get; set; }
        public string Celular1 { get; set; }
        public string Celular2 { get; set; }
        public string Avatar { get; set; }
        public Int64? IgrejaId { get; set; }
        public Int64 EnderecoId { get; set; }
        
        public void Validar()
        {
        
        }
    }
}
