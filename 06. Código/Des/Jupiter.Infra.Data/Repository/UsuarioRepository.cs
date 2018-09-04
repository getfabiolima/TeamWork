using Jupiter.Domain.Entities;
using Jupiter.Infra.Data.Context;
using System;
using System.Linq;

namespace Jupiter.Infra.Data.Repository
{
    public class UsuarioRepository
    {
        private readonly JupiterContext _context;
        public UsuarioRepository()
        {
            _context = new JupiterContext();
        }

        public bool Autenticado(string userName, string senha)
        {
            return _context.Usuario.Any(x => x.UserName.Equals(userName) && x.Senha.Equals(senha));
        }

        public void Salvar(Usuario usuario)
        {
            _context.Usuario.Add(usuario);
            _context.SaveChanges();
        }

        public void Alterar(Usuario usuario)
        {
            _context.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public Usuario ObterPorId(Guid id)
        {
            return _context.Usuario.Find(id);
        }

        public void Deletar(Guid id)
        {
            var usuario = ObterPorId(id);
            Deletar(usuario);
        }

        public void Deletar(Usuario usuario)
        {
            _context.Usuario.Remove(usuario);
            _context.SaveChanges();
        }
    }
}
