using System;
using System.Collections.Generic;
using System.Text;

namespace Jupiter.Models
{
    public class Tarefa
    {
        #region + Atributos e Propriedades +

        private string _nomeTarefa;
        private string _criador;
        private string _responsavel;
        private string _momento;
        private string _descricaoTarefa;
        private DateTime _dataPrevInicio;
        private DateTime _dataPrevTermino;
        private List<Tarefa> _predecessoras;
        private TipoTarefaEnum _tipoTarefa;
        private EstadoEnum _estado;
        private MotivoEnum _motivo;


        public string NomeTarefa
        {
            get
            {
                return _nomeTarefa;
            }
            set
            {
                _nomeTarefa = value;
            }
        }

        public string Criador
        {
            get
            {
                return _criador;
            }
            set
            {
                _criador = value;
            }
        }

        public string Responsavel
        {
            get
            {
                return _responsavel;
            }
            set
            {
                _responsavel = value;
            }
        }

        public string Momento
        {
            get
            {
                return _momento;
            }
            set
            {
                _momento = value;
            }
        }

        public string DescricaoTarefa
        {
            get
            {
                return _descricaoTarefa;
            }
            set
            {
                _descricaoTarefa = value;
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

        public List<Tarefa> Predecessoras
        {
            get
            {
                return _predecessoras;
            }
            set
            {
                _predecessoras = value;
            }
        }

        public TipoTarefaEnum TipoTarefa
        {
            get
            {
                return _tipoTarefa;
            }
            set
            {
                _tipoTarefa = value;
            }
        }

        public EstadoEnum Estado
        {
            get
            {
                return _estado;
            }
            set
            {
                _estado = value;
            }
        }

        public MotivoEnum Motivo
        {
            get
            {
                return _motivo;
            }
            set
            {
                _motivo = value;
            }
        }

        #endregion - Atributos e Propriedades -
        
        #region + Construtores +

        public Tarefa(string nomeTarefa, string criador, string descricaoTarefa)
        {
            _nomeTarefa = nomeTarefa;
            _criador = criador;
            _descricaoTarefa = descricaoTarefa;
            _estado = EstadoEnum.Nova;
        }

        public Tarefa(string criador, string nomeTarefa, DateTime dataPrevInicio, DateTime dataPrevTermino)
        {
            _criador = criador;
            _nomeTarefa = nomeTarefa;
            _dataPrevInicio = dataPrevInicio;
            _dataPrevTermino = dataPrevTermino;
            _estado = EstadoEnum.Nova;
            _motivo = MotivoEnum.Definida;
        }

        public Tarefa(string criador, string nomeTarefa, string descricaoTarefa, DateTime dataPrevInicio, DateTime dataPrevTermino)
        {
            _criador = criador;
            _nomeTarefa = nomeTarefa;
            _descricaoTarefa = descricaoTarefa;
            _dataPrevInicio = dataPrevInicio;
            _dataPrevTermino = dataPrevTermino;
            _estado = EstadoEnum.Nova;
            _motivo = MotivoEnum.Definida;
        }
        
        public Tarefa(string nomeTarefa, string criador, string responsavel, string momento, string descricaoTarefa, DateTime dataPrevInicio,
                  DateTime dataPrevTermino, List<Tarefa> predecessoras, TipoTarefaEnum tipoTarefa)
        {
            _nomeTarefa = nomeTarefa;
            _criador = criador;
            _responsavel = responsavel;
            _momento = momento;
            _descricaoTarefa = descricaoTarefa;
            _dataPrevInicio = dataPrevInicio;
            _dataPrevTermino = dataPrevTermino;
            _predecessoras = predecessoras;
            _tipoTarefa = tipoTarefa;
            _estado = EstadoEnum.Nova;
            _motivo = MotivoEnum.Definida;
        }

    #endregion - Construtores -

    }
}
