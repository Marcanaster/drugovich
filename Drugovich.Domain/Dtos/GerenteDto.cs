using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drugovich.Domain.Enums;

namespace Drugovich.Domain.Dtos
{
    public class GerenteDto   
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public string Email { get; set; }
        public NivelGerenteEnum Nivel { get; set; }
    }
}
