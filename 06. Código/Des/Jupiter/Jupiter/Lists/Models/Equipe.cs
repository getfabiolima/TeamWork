using System;
using System.Collections.Generic;
using System.Text;

namespace Jupiter.Models
{
    public class Equipe
    {
        #region + Atributos e Propriedades +

        private string _nomeEquipe;
        private string _objetivoEquipe;
        private List<Usuario> _usuarios;

        public string NomeEquipe
        {
            get
            {
                return _nomeEquipe;
            }
            set
            {
                _nomeEquipe = value;
            }
        }

        public string ObjetivoEquipe
        {
            get
            {
                return _objetivoEquipe;
            }
            set
            {
                _objetivoEquipe = value;
            }
        }

        public List<Usuario> Usuarios
        {
            get
            {
                return _usuarios;
            }
            set
            {
                _usuarios = value;
            }
        }

        #endregion - Atributos e Propriedades -

        #region + Construtores +

        public Equipe(string nomeEquipe)
        {
            _nomeEquipe = nomeEquipe;
        }

        public Equipe(string nomeEquipe, string objetivoEquipe, List<Usuario> usuarios)
        {
            _nomeEquipe = nomeEquipe;
            _objetivoEquipe = objetivoEquipe;
            _usuarios = usuarios;
        }

        #endregion - Construtores -
    }
}
