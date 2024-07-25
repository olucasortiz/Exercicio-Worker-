using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Worker.Entities
{
    class Department
    {
        public string Nome {  get; set; }   

        public Department() { }
        public Department(string nome)
        {
            Nome = nome;
        }
    }
}
