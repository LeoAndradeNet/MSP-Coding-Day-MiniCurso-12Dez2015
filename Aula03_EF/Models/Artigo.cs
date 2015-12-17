using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_EF.Models
{
    public class Artigo
    {        
        public int Id { get; set; }
                
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Autor { get; set; }        
    }
}
