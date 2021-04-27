using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webapi.Domains
{
    public partial class Habilidade
    {
        public int IdHabilidade { get; set; }
        public int? IdTipo { get; set; }
        public string NomeHabilidade { get; set; }

        public virtual TipoHabilidade IdTipoNavigation { get; set; }
    }
}
