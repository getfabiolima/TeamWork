using System;
using System.Collections.Generic;
using System.Text;

namespace Jupiter.Models
{
    public class UsuarioProjeto
    {
        #region + Atributos e Propriedades +

        private int _idUsuario;
        private int _idProjeto;
        private string _nomeUsuario;
        private string _login;
        private string _email;
        private FuncaoEnum _funcao;
        private NivelProfissionalEnum _nivelProfissional;

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

        public int IdProjeto
        {
            get
            {
                return _idProjeto;
            }
            set
            {
                _idProjeto = value;
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

        public FuncaoEnum Funcao
        {
            get
            {
                return _funcao;
            }
            set
            {
                _funcao = value;
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

        public UsuarioProjeto(string nomeUsuario, string login, string email, FuncaoEnum funcao, NivelProfissionalEnum nivelProfissional)
        {
            _nomeUsuario = nomeUsuario;
            _login = login;
            _email = email;
            _funcao = funcao;
            _nivelProfissional = nivelProfissional;
        }

        #endregion - Construtores -
    }
}