using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DropDownCascata.Models
{
    public class Cidade
    {
        public int CidadeId { get; set; }
        public string Descricao { get; set; }
        public int EstadoId { get; set; }
        public virtual Estado Estado { get; set; }

    }
}