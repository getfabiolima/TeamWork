using System;
using System.Collections.Generic;
using System.Text;

namespace Jupiter.Models
{
    public class Projeto
    {
        #region + Atributos e Propriedades +

        private int _idProjeto;
        private string _nomeProjeto;
        private string _objetivoProjeto;
        private string _descricaoProjeto;
        private string _gerenteProjeto;
        private string _contratada;
        private string _contratante;
        private DateTime _dataPrevInicio;
        private DateTime _dataPrevTermino;

        // Obs: Remover o método set de Id após implementar o autoincrement no banco
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

        public string NomeProjeto
        {
            get
            {
                return _nomeProjeto;
            }
            set
            {
                _nomeProjeto = value;
            }
        }

        public string ObjetivoProjeto
        {
            get
            {
                return _objetivoProjeto;
            }
            set
            {
                _objetivoProjeto = value;
            }
        }

        public string DescricaoProjeto
        {
            get
            {
                return _descricaoProjeto;
            }
            set
            {
                _descricaoProjeto = value;
            }
        }

        public string GerenteProjeto
        {
            get
            {
                return _gerenteProjeto;
            }
            set
            {
                _gerenteProjeto = value;
            }
        }

        public string Contratada
        {
            get
            {
                return _contratada;
            }
            set
            {
                _contratada = value;
            }
        }
        
        public string Contratante
        {
            get
            {
                return _contratante;
            }
            set
            {
                _contratante = value;
            }
        }

        public DateTime DataPrevInicio
        {
            get
            {
                return _dataPrevInicio;
            }
            set
            {
                _dataPrevInicio = value;
            }
        }

        public DateTime DataPrevTermino
        {
            get
            {
                return _dataPrevTermino;
            }
            set
            {
                _dataPrevTermino = value;
            }
        }

        #endregion - Atributos e Propriedades -

        #region + Construtores +

        public Projeto(string nomeProjeto, string gerenteProjeto, string contratante)
        {
            _nomeProjeto = nomeProjeto;
            _gerenteProjeto = gerenteProjeto;
            _contratante = contratante;
        }

        public Projeto(string nomeProjeto, string descricaoProjeto, string gerenteProjeto, string contratante)
        {
            _nomeProjeto = nomeProjeto;
            _descricaoProjeto = descricaoProjeto;
            _gerenteProjeto = gerenteProjeto;
            _contratante = contratante;
        }

        public Projeto(string nomeProjeto, string objetivoProjeto, string descricaoProjeto, string gerenteProjeto,
               string contratada, string contratante, DateTime dataPrevInicio, DateTime dataPrevTermino)
        {
            _nomeProjeto = nomeProjeto;
            _objetivoProjeto = objetivoProjeto;
            _descricaoProjeto = descricaoProjeto;
            _gerenteProjeto = gerenteProjeto;
            _contratada = contratada;
            _contratante = contratante;
            _dataPrevInicio = dataPrevInicio;
            _dataPrevTermino = dataPrevTermino;
        }

        #endregion - Construtores -
    }
}
