using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Empresa.Models
{
    public class Funcionario
    {
        public int FuncionarioID {get; set;}
        public string Nome {get; set;}
        public string Funcao {get; set;}
        public int Idade {get; set;}
        public double Salario {get; set;}
    }
}