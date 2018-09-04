using System;
using System.Collections.Generic;
using System.Text;

namespace Jupiter
{
    public enum NivelProfissionalEnum
    {
        Estagiario,
        Trainee,
        Junior,
        Pleno,
        Senior,
        Especialista
    }

    public enum FuncaoEnum
    {
        GerenteDeProjetos,
        AnalistaDeRequisitos,
        AnalistaDeNegocios,
        ArquitetoDeSoftware,
        Desenvolvedor,
        TestadorDeSoftware,
        AnalistaDeSuporte,
        UsuarioFinal,
        ParteInteressadaChave
    }

    public enum TipoTarefaEnum
    {
        Tarefa,
        Reuniao,
        Revisao,
        Duvida,
        Teste,
        Bug
    }

    public enum EstadoEnum
    {
        Nova,
        Ativa,
        Iniciada,
        Concluida,
        Fechada
    }

    public enum MotivoEnum
    {
        Definida,
        Aceita,
        Feita,
        Verificada,
        Pendente,
        NaoConcluida
    }
}
