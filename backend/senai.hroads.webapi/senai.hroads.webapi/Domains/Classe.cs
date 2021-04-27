using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webapi.Domains
{
    public partial class Classe
    {
        public Classe()
        {
            Personagens = new HashSet<Personagen>();
        }

        public int IdClasse { get; set; }
        public string NomeClasse { get; set; }

        public virtual ICollection<Personagen> Personagens { get; set; }
    }
}
