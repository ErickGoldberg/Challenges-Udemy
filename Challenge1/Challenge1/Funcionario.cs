using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

        public double SalarioLiquido(double salarioBruto, double imposto)
        {
            return salarioBruto - imposto;
        }

        public double AumentarSalario(double porcentagem, double salarioLiquido)
        {
            return salarioLiquido += (porcentagem/100) * salarioLiquido;
        }
    }
}
