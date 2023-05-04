using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPratico.Entidades
{
    internal class FContratado : Funcionario
    {
        public FContratado() { }

        public double CalcInss()
        {
            SalarioLiquido = SalarioBase - ((SalarioBase * 0.18) + PlanoSaude);
            return SalarioLiquido;
        }
    }

}
