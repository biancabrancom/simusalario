using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPratico.Entidades
{
    internal class FPublico : Funcionario
    {
        public FPublico() { }

        public double CalcSalarioLiquido()
        {
            SalarioLiquido = SalarioBase - PlanoSaude;
            return SalarioLiquido;
        }

    }
}

