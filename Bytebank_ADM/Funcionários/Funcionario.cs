using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionários
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }

        public abstract double GetBonificacao();


        public virtual double PremioSemestral()
        {
            return this.Salario * 0.20;
        }

        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario();
    }
}
