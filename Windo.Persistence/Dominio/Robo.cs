using System;
using System.Collections.Generic;

namespace Windo.Persistence.Dominio
{
    public partial class Robo
    {
        public Robo()
        {
            Plataformas = new HashSet<Plataforma>();
        }

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricacao { get; set; }
        public int QtdLote { get; set; }

        public virtual ICollection<Plataforma> Plataformas { get; set; }
    }
}
