using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DropDownCascata.Models
{
    public class Estado
    {
        public int EstadoId { get; set; }
        public string Sigla { get; set; }
        public virtual ICollection<Cidade> Cidades { get; set; }

    }
}