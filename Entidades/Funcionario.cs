 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPratico.Entidades
{
    internal class Funcionario
    {
        public string Nome { get; private set; }
        public int Registro { get; private set; }
        public double SalarioBase { get; private set; }
        public double SalarioLiquido { get; protected set; }
        public double PlanoSaude { get; private set; }

        public Funcionario()
        {
        }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }

        public void setRegistro(int registro)
        {
            this.Registro = registro;
        }

        public void setSalarioBase(double salarioBase)
        {
            this.SalarioBase = salarioBase;
        }

        public void setSalarioLiquido(double salarioLiquido)
        {
            this.SalarioLiquido = salarioLiquido;
        }

        public void setPlanoSaude(double planoSaude)
        {
            this.PlanoSaude = planoSaude;
        }

        public string getNome()
        {
            return this.Nome;
        }

        public int getRegistro()
        {
            return this.Registro;
        }

        public double getSalarioBase()
        {
            return this.SalarioBase;
        }

        public double getSalarioLiquido()
        {
            return this.SalarioLiquido;
        }

        public double getPlanoSaude ()
        {
            return this.PlanoSaude;
        }

        public Funcionario(string nome, int registro, double salarioBase, double salarioLiquido, double planoSaude)
        {
            Nome = nome;
            Registro = registro;
            SalarioBase = salarioBase;
            SalarioLiquido = salarioLiquido;
            PlanoSaude = planoSaude;
        }
    }
}
