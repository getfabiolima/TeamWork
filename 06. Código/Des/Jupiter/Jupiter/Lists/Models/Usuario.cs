using System;
using System.Collections.Generic;
using System.Text;

namespace Jupiter.Models
{
    public class Usuario
    {
        #region + Atributos e Propriedades +

        private int _idUsuario;
        private string _nomeUsuario;
        private string _login;
        private string _senha;
        private string _email;
        private NivelProfissionalEnum _nivelProfissional;

        // Obs: Remover o método set de Id após implementar o autoincrement no banco
        public int IdUsuario
        {
            get
            {
                return _idUsuario;
            }
            set
            {
                _idUsuario = value;
            }
        }

        public string NomeUsuario
        {
            get
            {
                return _nomeUsuario;
            }
            set
            {
                _nomeUsuario = value;
            }
        }

        public string Login
        {
            get
            {
                return _login;
            }
            set
            {
                _login = value;
            }
        }

        public string Senha
        {
            get
            {
                return _senha;
            }
            set
            {
                _senha = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        public NivelProfissionalEnum NivelProfissional
        {
            get
            {
                return _nivelProfissional;
            }
            set
            {
                _nivelProfissional = value;
            }
        }

        #endregion - Atributos e Propriedades -

        #region + Construtores +

        public Usuario(string nomeUsuario, string login, string senha, string email)
        {
            _nomeUsuario = nomeUsuario;
            _login = login;
            _senha = senha;
            _email = email;
        }
        public Usuario(string nomeUsuario, string login, string senha, string email, NivelProfissionalEnum nivelProfissional)
        {
            _nomeUsuario = nomeUsuario;
            _login = login;
            _senha = senha;
            _email = email;
            _nivelProfissional = nivelProfissional;
        }

        #endregion - Construtores -
    }
}
