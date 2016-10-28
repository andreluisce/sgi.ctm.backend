using System;

namespace sgi.ctm.backend.domain.Entities
{
    public class Aluno
    {

        public Int64 Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string ConfirmarSenha { get; set; }
        public DateTime CriadoEm { get; set; }
        public bool Ativo { get; set; }


        public void SetarSenha(string senha, string confirmarSenha)
        {
            //AssertionConcern.AssertArgumentNotNull(senha, Errors.InvalidPassword);
           // AssertionConcern.AssertArgumentNotNull(confirmarSenha, Errors.InvalidPasswordConfirmation);
           // AssertionConcern.AssertArgumentEquals(senha, confirmarSenha, Errors.InvalidPasswordMatch);
            //AssertionConcern.AssertArgumentLength(senha, 6, 20, Errors.InvalidPassword);

           // this.Senha = PasswordAssertionConcern.Encrypt(senha);
        }
        public string ResetarSenha()
        {
           string password = Guid.NewGuid().ToString().Substring(0, 8);
          //  this.Senha = PasswordAssertionConcern.Encrypt(password);

            return password;
        }
        public void MudarSenha(string nome)
        {
            this.Nome = nome;
        }
        public void Validar()
        {
           // AssertionConcern.AssertArgumentLength(this.Nome, 3, 250, Errors.InvalidUserName);
           // EmailAssertionConcern.AssertIsValid(this.Email);
            //PasswordAssertionConcern.AssertIsValid(this.Senha);
        }
        public override string ToString()
        {
            return "Nome: " + this.Nome + "\nSenha: " + this.Senha + "\nCriado em: " + this.CriadoEm.ToUniversalTime();
        }

    }
}
