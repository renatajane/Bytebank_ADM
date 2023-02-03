using Bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionários
{
    public class GerenteDeCompras: FuncionarioAutenticavel
    {
        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }

        public GerenteDeCompras(string cpf) : base(cpf, 4000)
        {
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }
    }
}
