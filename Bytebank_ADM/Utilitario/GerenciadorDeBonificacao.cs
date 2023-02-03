using Bytebank_ADM.Funcionários;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonificacoes { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            this.TotalDeBonificacoes += funcionario.GetBonificacao();
        }
        
        //public void Registrar(Diretor diretor)  
        //{
        //    this.TotalDeBonificacoes += diretor.GetBonificacao();
        //}
         
    }
}
