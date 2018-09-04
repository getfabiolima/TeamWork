using Jupiter.Domain.Entities.Enum;
using System;
using System.Collections.Generic;

namespace Jupiter.Domain.Entities
{
    public class Perfil
    {
        public Perfil(Guid idPerfil, TipoPerfil tipoPerfil)
        {
            Id = idPerfil;
            Tipo = tipoPerfil;
        }
        public Guid Id { get; private set; }
        public TipoPerfil Tipo { get; private set; }        
    }
}
