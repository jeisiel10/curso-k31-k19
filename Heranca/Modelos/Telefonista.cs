using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Modelos
{
    class Telefonista : Funcionario
    {
        public int EstacaoDeTrabalho { get; set; }

        public override double CalculaBonificacao()
        {
            return base.CalculaBonificacao() + 1000;
        }
    }
}
