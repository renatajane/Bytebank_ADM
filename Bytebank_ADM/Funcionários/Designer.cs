using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionários
{
    internal class Designer: Funcionario
    {
        public override double GetBonificacao()
        {
            return this.Salario * 0.17;
        }

        public Designer(string cpf) : base(cpf, 3000)
        {

        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }
    }
}
