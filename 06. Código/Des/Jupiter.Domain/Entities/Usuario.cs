using System;

namespace Jupiter.Domain.Entities
{
    public class Usuario
    {
        public Usuario()
        {
            DataDeCadastro = DateTime.Now;
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataDeCadastro { get; private set; }

        #region ' Perfil '
        public Perfil Perfil { get; set; }
        public Guid IdPerfil { get; set; }
        #endregion
    }
}
